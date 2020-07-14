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

namespace QuanLyCinema.GiaoDienKhachHang
{
    /// <summary>
    /// Interaction logic for frmDatVe.xaml
    /// </summary>
    public partial class frmDatVe : UserControl
    {
        public frmDatVe()
        {
            InitializeComponent();
        }

        private void btMuave_Click(object sender, RoutedEventArgs e)
        {
            Grid_hienthi.Children.Clear();
            Grid_hienthi.Children.Add(new frmThongTinDatVe());
        }
    }
}
