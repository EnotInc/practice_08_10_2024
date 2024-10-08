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
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void GoBack(object sender, RoutedEventArgs e)
        {
            MainWindow a = new MainWindow();
            a.Show();
            this.Close();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                int number = Convert.ToInt32(TBnumber.Text);
                if ( 0 <= number && number <= 14)
                {
                    TBanswer.Text = "number in range 0-14";
                }
                else if (15 <= number && number <= 35)
                {
                    TBanswer.Text = "number in range 15-36";
                }
                else if (36 <= number && number <= 50)
                {
                    TBanswer.Text = "number in range 36-50";
                }
                else if (50 <= number && number <= 100)
                {
                    TBanswer.Text = "number in range 50-100";
                }
                else
                {
                    TBanswer.Text = "number out of range";
                }
            }
            catch
            {
                TBanswer.Text = "error, invalid value";
            }

        }
    }
}
