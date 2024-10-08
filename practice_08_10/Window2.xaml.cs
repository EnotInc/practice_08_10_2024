using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace practice_08_10
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        Random rnd = new Random();

        string action;

        float operand1;
        float operand2;

        private void GoBack(object sender, RoutedEventArgs e)
        {
            MainWindow a = new MainWindow();
            a.Show();
            this.Close();
        }



        private void ActionChanged(object sender, TextChangedEventArgs e)
        {
            action = TextBoxAct.Text;
        }

        private void equal(object sender, RoutedEventArgs e)
        {
            float result = 0;
            switch (action)
            {
                case "+":
                    result = operand1 + operand2;
                    resultTextBox.Text = Convert.ToString(result);
                    break;

                case "-":
                    result = operand1 - operand2;
                    resultTextBox.Text = Convert.ToString(result);
                    break;

                case "/":
                    result = operand1 / operand2;
                    resultTextBox.Text = Convert.ToString(result);
                    break;

                case "*":
                    result = operand1 * operand2;
                    resultTextBox.Text = Convert.ToString(result);
                    break;

                default:
                    resultTextBox.Text = "error, invalid value";
                    break;
            }
        }

        private void newRandom(object sender, RoutedEventArgs e)
        {
            operand1 = rnd.Next(-9999,9999);
            operand2 = rnd.Next(-9999, 9999);

            FirstNumber.Text = Convert.ToString(operand1);
            SecondNumber.Text = Convert.ToString(operand2);
        }
    }
}
