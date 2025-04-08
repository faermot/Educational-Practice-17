using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ConsoleApp23.Utils
{
    public class Task6
    {
        public static void Calculate(Dictionary<string, object> vars)
        {
            // Получаем массив
            var arrayText = vars["array"] as string;
            if (arrayText == null) return;

            // Преобразуем строку в массив (например, через разделитель)
            var rows = arrayText.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            var matrix = new List<List<double>>();

            foreach (var row in rows)
            {
                var values = row.Split(',').Select(val => double.Parse(val.Trim())).ToList();
                matrix.Add(values);
            }

            // Поменять местами наибольшие элементы первого и третьего столбцов
            int maxIndexCol1 = matrix.Select(row => row[0]).ToList().IndexOf(matrix.Select(row => row[0]).Max());
            int maxIndexCol3 = matrix.Select(row => row[2]).ToList().IndexOf(matrix.Select(row => row[2]).Max());

            double temp = matrix[maxIndexCol1][0];
            matrix[maxIndexCol1][0] = matrix[maxIndexCol3][2];
            matrix[maxIndexCol3][2] = temp;

            // Отобразим результат
            var result = "Новый массив:\n";
            foreach (var row in matrix)
            {
                result += string.Join(", ", row) + "\n";
            }

            // Выводим результат
            MessageBox.Show(result, "Решение задачи", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }

}
