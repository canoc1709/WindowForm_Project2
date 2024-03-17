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

namespace Test
{
    /// <summary>
    /// Interaction logic for Trangchu.xaml
    /// </summary>
    public partial class Trangchu : Window
    {
        public Trangchu()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Dangnhap dangnhap = new Dangnhap();
            dangnhap.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Trangchu trangchu = new Trangchu();
            trangchu.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            TimKiemCongViec timKiemCongViec = new TimKiemCongViec();
            timKiemCongViec.Show();
            this.Close();

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }
    }
}
