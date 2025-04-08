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
    public partial class Task2Page : Page
    {
        public Task2Page()
        {
            InitializeComponent();
        }


        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == true)
            {
                string inputFile = dialog.FileName;
                string outputFile = System.IO.Path.Combine(
                    System.IO.Path.GetDirectoryName(inputFile),
                    "g.txt"
                );

                try
                {
                    string[] lines = File.ReadAllLines(inputFile);
                    InputContentTextBox.Text = string.Join(Environment.NewLine, lines);

                    List<int> positives = new List<int>();
                    List<int> negatives = new List<int>();

                    foreach (string line in lines)
                    {
                        int num;
                        if (int.TryParse(line, out num))
                        {
                            if (num > 0)
                                positives.Add(num);
                            else if (num < 0)
                                negatives.Add(num);
                        }
                    }

                    if (positives.Count != negatives.Count)
                    {
                        MessageBox.Show("Ошибка: количество положительных и отрицательных чисел не совпадает.");
                        return;
                    }

                    List<int> result = new List<int>();
                    result.AddRange(positives);
                    result.AddRange(negatives);

                    File.WriteAllLines(outputFile, result.ConvertAll(n => n.ToString()));

                    OutputContentTextBox.Text = string.Join(Environment.NewLine, result);
                    ResultTextBlock.Text = "Файл g.txt успешно создан:\n" + outputFile;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
