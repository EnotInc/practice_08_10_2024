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

        Dictionary<string, string> TransWords = new Dictionary<string, string>()
        {
            { "погода", "weather"},
            { "шторм", "shtorm"},
            { "солнечно", "sunny"},
            { "пасмурно", "cloudy"},
            { "верет", "wind" },
            { "штиль", "calm" },
            { "дождь","rain" },
            { "гроза","tunder" },
            { "радуга","rainbow" },
            { "туман","fog" },
        };
        


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

            TrBox.Text = TransWords[trWord];
        }
    }
}
