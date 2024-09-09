using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Variabelen1_Rekenmachine
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void multiplyButton_Click(object sender, RoutedEventArgs e)
        {
            float getal1 = Convert.ToSingle(number1TextBox.Text);
            float getal2 = Convert.ToSingle(number2TextBox.Text);
            float resultaat = getal1 * getal2;

            resultTextBox.Text = Convert.ToString(resultaat);
        }

        private void divideButton_Click(object sender, RoutedEventArgs e)
        {
            float getal1 = Convert.ToSingle(number1TextBox.Text);
            float getal2 = Convert.ToSingle(number2TextBox.Text);
            float resultaat = getal1 / getal2;

            resultTextBox.Text = Convert.ToString(resultaat);
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            float getal1 = Convert.ToSingle(number1TextBox.Text);
            float getal2 = Convert.ToSingle(number2TextBox.Text);
            float resultaat = getal1 + getal2;

            resultTextBox.Text = Convert.ToString(resultaat);
        }
        private void minusButton_Click(object sender, RoutedEventArgs e)
        {
            float getal1 = Convert.ToSingle(number1TextBox.Text);
            float getal2 = Convert.ToSingle(number2TextBox.Text);
            float resultaat = getal1 - getal2;

            resultTextBox.Text = Convert.ToString(resultaat);
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            number1TextBox.Text = "0";
            number2TextBox.Text = "0";
            resultTextBox.Text = string.Empty;

            number1TextBox.Focus();
        }
    }
}
