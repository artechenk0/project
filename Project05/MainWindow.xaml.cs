using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Project05
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() => InitializeComponent();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double a = double.Parse(textBox_ValueA.Text);
                double b = double.Parse(textBox_ValueB.Text);

                if (a > b) textBlock.Text = $"Прямоугольник со сторонами {a} и {b} можно разделить на {(int)(a / b)} квадрат(а, ов)";
                if (a < b) textBlock.Text = $"Прямоугольник со сторонами {a} и {b} можно разделить на {(int)(b / a)} квадрат(а, ов)";
                if (a == b) textBlock.Text = $"Прямоугольник со сторонами {a} и {b} по умолчанию является квадратом";
            }
            catch
            {
                MessageBox.Show($"Ошибка при вводе значений!\n" +
                    $"Принимаются только вещественные и целочисленные числа");
            }
            
        }
        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, 0) || (sender as TextBox).Text.Length >= 9) e.Handled = true;
        }
    }
}
