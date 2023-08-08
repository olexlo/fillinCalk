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

namespace fillinCalk
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
        int kass, rezz, num_b = 0;
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            num_b = 1;
            labb.Content = 1;
        }

        private void k2_Click(object sender, RoutedEventArgs e)
        {
            num_b = 2;
            labb.Content = 2;
        }

        private void k3_Click(object sender, RoutedEventArgs e)
        {
            num_b = 3;
            labb.Content = 3;
        }

        private void k4_Click(object sender, RoutedEventArgs e)
        {
            num_b = 4;
            labb.Content = 4;
        }

        private void k5_Click(object sender, RoutedEventArgs e)
        {
            num_b = 5;
            labb.Content = 5;
        }

        private void k6_Click(object sender, RoutedEventArgs e)
        {
            num_b = 6;
            labb.Content = 6;
        }

        private void k7_Click(object sender, RoutedEventArgs e)
        {
            num_b = 7;
            labb.Content = 7;
        }

        private void k8_Click(object sender, RoutedEventArgs e)
        {
            num_b = 8;
            labb.Content = 8;
        }

        private void k9_Click(object sender, RoutedEventArgs e)
        {
            num_b = 9;
            labb.Content = 9;
        }

        private void k0_Click(object sender, RoutedEventArgs e)
        {
            num_b = 0;
            labb.Content = 0;
        }

        private void kplus_Click(object sender, RoutedEventArgs e)
        {
            kass = num_b + kass;
            labb.Content = kass;
        }

        private void kminus_Click(object sender, RoutedEventArgs e)
        {
            kass = num_b - kass;
            labb.Content = kass;

        }

       
    }
}
