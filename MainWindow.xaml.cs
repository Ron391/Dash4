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

namespace Dash4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            rectHover.Margin=new Thickness(20,85,0,0);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            rectHover.Margin = new Thickness(20, 85, 0, 0);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            rectHover.Margin = new Thickness(20, 135, 0, 0);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            rectHover.Margin = new Thickness(20, 185, 0, 0);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            rectHover.Margin = new Thickness(20, 236, 0, 0);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            rectHover.Margin = new Thickness(20, 286, 0, 0);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            rectHover.Margin = new Thickness(20, 336, 0, 0);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            rectHover.Margin = new Thickness(20, 466, 0, 0);
        }
    }
}
