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
    /// Interaction logic for frmThongTinDatVe.xaml
    /// </summary>
  
    public partial class frmThongTinDatVe : UserControl
    {
        public frmThongTinDatVe()
        {
            InitializeComponent();
            txt.IsReadOnly = true;

        }

        private void bt_back_Click(object sender, RoutedEventArgs e)
        {
            grid_hienthi.Children.Clear();
            grid_hienthi.Children.Add(new frmDatVe());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            grid_hienthi.Children.Clear();
            grid_hienthi.Children.Add(new frmThongTinGhe());
        }

        private void btDatLich_Click(object sender, RoutedEventArgs e)
        {
            txt.Visibility = Visibility.Visible;
            pnThongTin.Visibility = Visibility.Visible;
            dtpLichChieuPhim.Visibility = Visibility.Visible;
            icon.Visibility = Visibility.Visible;
        }

        private void cbTP_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }
    }
}
