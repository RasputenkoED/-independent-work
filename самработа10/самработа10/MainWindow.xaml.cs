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

namespace самработа10
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>  
    public partial class MainWindow : Window
    {
        private Random _random = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Random_Click(object sender, RoutedEventArgs e)
        {
            Data data = new Data() { RandomValue = _random.Next(100000) };
            DataContext = data;
        }

        class Data
        {
            public int RandomValue { get; set; }
        }
    }
}
