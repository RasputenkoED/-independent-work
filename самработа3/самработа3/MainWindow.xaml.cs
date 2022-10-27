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

namespace самработа3
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
            l1.Content = "First value";
            l2.Content = "Second value";
            l3.Content = "Third value";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            l1.Content = "Index: 0";
            l2.Content = "Index: 1";
            l3.Content = "Index: 2";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            l1.Content = "Like";
            l2.Content = "it,";
            l3.Content = "please!";
        }
    }
}
