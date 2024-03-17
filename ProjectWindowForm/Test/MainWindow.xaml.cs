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

namespace Test
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
        private void Grid_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Dangnhap dangnhap = new Dangnhap();
            this.Close();
            dangnhap.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Dangki dangki = new Dangki();
            this.Close();
            dangki.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Dangnhap dangnhap = new Dangnhap();
            this.Close();
            dangnhap.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Dangki dangki = new Dangki();
            this.Close();
            dangki.Show();
        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
