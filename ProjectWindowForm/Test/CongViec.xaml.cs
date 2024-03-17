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
    /// Interaction logic for CongViec.xaml
    /// </summary>
    public partial class CongViec : UserControl
    {
        public CongViec()
        {
            InitializeComponent();
            this.DataContext = this;
        }
        public string Title { get; set; }
        public string URL { get; set; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FCongViec fCongViec = new FCongViec();
            fCongViec.Show();
            
        }
    }
}
