using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace OurFirstApp
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

        private void Window_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //MessageBox.Show($"Salam Yeni Pencere");
        }

        private void innerBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Inner Button Clicked");
        }

        private void outerBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Outer Button Clicked");
        }

        private void btn_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void mystackpanel_MouseMove(object sender, MouseEventArgs e)
        {
            var x = Mouse.GetPosition(Application.Current.MainWindow).X;
            var y = Mouse.GetPosition(Application.Current.MainWindow).Y;
            //btn.Content = $" X : {x}  Y : {y}";
        }

        private void Label_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            foreach (var item in mystackpanel.Children)
            {
                if(item is Label lb)
                {
                    lb.Content += " Great";
                   //// mystackpanel.Children.Remove(lb);
                   //// break;
                }
            }
        }
    }
}
