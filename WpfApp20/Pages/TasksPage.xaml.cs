using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp20.Pages
{
    public partial class TasksPage : Page
    {
        private int _number;
        private Dictionary<string, TextBox> _inputFields = new Dictionary<string, TextBox>();
        private Action<Dictionary<string, object>> _calculate;

        public TasksPage(int number, List<string> variables, Action<Dictionary<string, object>> calculate)
        {
            InitializeComponent();
            _calculate = calculate;
            _number = number;
            TaskNumberTextBlock.Text = $"Задача №{_number}";

            foreach (var variable in variables)
            {
                var stackPanel = new StackPanel { Orientation = Orientation.Horizontal, Margin = new Thickness(0, 20, 0, 5) };

                stackPanel.Children.Add(new TextBlock
                {
                    Text = variable + ":",
                    Width = 50,
                    FontSize = 16,
                    Margin = new Thickness(0, 10, 0, 0),
                    VerticalAlignment = VerticalAlignment.Center
                });

                var inputField = new TextBox
                {
                    Width = 150,
                    FontSize = 14,
                    Margin = new Thickness(0, 5, 0, 0)
                };
                stackPanel.Children.Add(inputField);

                _inputFields[variable] = inputField;
                InputFieldsContainer.Children.Add(stackPanel);
            }
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var values = new Dictionary<string, object>();
                foreach (var kvp in _inputFields)
                {
                    var inputValue = kvp.Value.Text;

                    // Преобразуем введённые данные в числовой тип или строку
                    if (double.TryParse(inputValue, out double number))
                    {
                        values[kvp.Key] = number;
                    }
                    else
                    {
                        values[kvp.Key] = inputValue; // Для строковых значений
                    }
                }

                _calculate(values);
                ResultTextBlock.Text = "Решение выполнено. Проверьте массив.";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }


}