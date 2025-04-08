using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp20.Pages
{
    /// <summary>
    /// Логика взаимодействия для Task1Page.xaml
    /// </summary>
    public partial class Task1Page : Page
    {

        private string filePath1;
        private string filePath2;

        public Task1Page()
        {
            InitializeComponent();
        }


        private void SelectFirstFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                filePath1 = openFileDialog.FileName;
                FirstFileContent.Text = File.ReadAllText(filePath1);
            }
        }

        private void SelectSecondFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                filePath2 = openFileDialog.FileName;
                SecondFileContent.Text = File.ReadAllText(filePath2);
            }
        }


        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (filePath1 == null || filePath2 == null)
                {
                    MessageBox.Show("Сначала выберите оба файла!");
                    return;
                }

                List<int[,]> matrices1 = ReadMatricesFromFile(filePath1);
                List<int[,]> matrices2 = ReadMatricesFromFile(filePath2);

                List<int[,]> moved = matrices1.Where(m => m[0, 0] == 0).ToList();
                List<int[,]> remaining = matrices1.Where(m => m[0, 0] != 0).ToList();

                matrices2.AddRange(moved);

                // перезаписываем файлы
                WriteMatricesToFile(filePath1, remaining);
                WriteMatricesToFile(filePath2, matrices2);

                // обновляем вывод
                FirstFileContent.Text = File.ReadAllText(filePath1);
                SecondFileContent.Text = File.ReadAllText(filePath2);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private List<int[,]> ReadMatricesFromFile(string path)
        {
            List<int[,]> matrices = new List<int[,]>();
            var blocks = File.ReadAllText(path).Trim().Split(new string[] { "\r\n\r\n", "\n\n" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var block in blocks)
            {
                var rows = block.Trim().Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                int m = rows.Length;
                int n = rows[0].Split(' ').Length;
                int[,] matrix = new int[m, n];

                for (int i = 0; i < m; i++)
                {
                    var values = rows[i].Split(' ');
                    for (int j = 0; j < n; j++)
                        matrix[i, j] = int.Parse(values[j]);
                }

                matrices.Add(matrix);
            }

            return matrices;
        }

        private void WriteMatricesToFile(string path, List<int[,]> matrices)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var matrix in matrices)
            {
                int m = matrix.GetLength(0);
                int n = matrix.GetLength(1);

                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                        sb.Append(matrix[i, j] + " ");
                    sb.AppendLine();
                }
                sb.AppendLine();
            }

            File.WriteAllText(path, sb.ToString().Trim());
        }
    }
}
