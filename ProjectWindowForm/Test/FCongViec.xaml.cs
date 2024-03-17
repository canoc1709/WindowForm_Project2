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
    /// Interaction logic for FCongViec.xaml
    /// </summary>
    public partial class FCongViec : Window
    {
        public FCongViec()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Nhận việc thành công");
            TimKiemCongViec timKiemCongViec = new TimKiemCongViec();
            this.Close();           
        }
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            TimKiemCongViec timKiemCongViec = new TimKiemCongViec();
            this.Close();
            
        }
    }
}
