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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace practice_08_10
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void openTranslator(object sender, RoutedEventArgs e)
        {
            Window1 a = new Window1();
            a.Show();
            this.Close();
        }

        private void openCalculator(object sender, RoutedEventArgs e)
        {
            Window2 a = new Window2();
            a.Show();
            this.Close();
        }

        private void openExam(object sender, RoutedEventArgs e)
        {
            Window3 a = new Window3();
            a.Show();
            this.Close();
        }

        private void openPasword(object sender, RoutedEventArgs e)
        {
            Window4 a = new Window4();
            a.Show();
            this.Close();
        }
    }
}
