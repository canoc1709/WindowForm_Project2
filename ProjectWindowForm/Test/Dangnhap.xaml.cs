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
    /// Interaction logic for Dangnhap.xaml
    /// </summary>
    public partial class Dangnhap : Window
    {
        public Dangnhap()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            this.Close();
            main.Show();
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
        private void Grid_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }



        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Dangki dangki = new Dangki();
            dangki.Show();
            this.Close();
        }
        private void Dangnhap_click(object sender, RoutedEventArgs e)
        {
            if (Checkbox_Ungvien.IsChecked == true)
            {
                Trangchu trangchu = new Trangchu();
                trangchu.Show();
                this.Close();
            }
            else if (Checkbox_Nhanvien.IsChecked == true)
            {
                HoSoNhanVien hsnhanvien = new HoSoNhanVien();
                hsnhanvien.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn chức vụ!");
            }


        }
    }
}
