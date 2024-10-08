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
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }

        const string password = "admin";
        string text;

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
                text = ResultTextBox.Text;
                TextBlokError.Text = "";
            }
            catch
            {
                TextBlokError.Text = "error, invalid value";
            }
        }

        private void Enter(object sender, RoutedEventArgs e)
        {
            switch (text)
            {
                case password:
                    TextBlokError.Text = "secret message";
                    break;
                default:
                    TextBlokError.Text = "error, incalid value";
                    break;
            }
        }
    }
}
