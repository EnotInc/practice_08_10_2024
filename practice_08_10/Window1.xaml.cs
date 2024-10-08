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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        string word = "";

        private void GoBack(object sender, RoutedEventArgs e)
        {
            MainWindow a = new MainWindow();
            a.Show();
            this.Close();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            word = TextBoxOne.Text; 
        }

        private void translate(object sender, RoutedEventArgs e)
        {
            string trWord = word.ToLower();
            switch (trWord)
            {
                case "погода":
                    TrBox.Text = "weather";
                    break;

                case "шторм":
                    TrBox.Text = "shtorm";
                    break;

                case "солнечно":
                    TrBox.Text = "sunny";
                    break;

                case "пасмурно":
                    TrBox.Text = "cloudy";
                    break;

                case "ветер":
                    TrBox.Text = "wind";
                    break;

                case "штиль":
                    TrBox.Text = "calm";
                    break;

                case "дождь":
                    TrBox.Text = "rain";
                    break;

                case "гроза":
                    TrBox.Text = "tunder";
                    break;

                case "радуга":
                    TrBox.Text = "rainbow";
                    break;

                case "туман":
                    TrBox.Text = "fog";
                    break;

                default:
                    TrBox.Text = "error: invalid value";
                    break;
            }
        }
    }
}
