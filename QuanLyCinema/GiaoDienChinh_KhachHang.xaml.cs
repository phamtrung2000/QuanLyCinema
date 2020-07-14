using QuanLyCinema.GiaoDienKhachHang;
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

namespace QuanLyCinema
{
    /// <summary>
    /// Interaction logic for GiaoDienChinh_KhachHang.xaml
    /// </summary>
  
    public partial class GiaoDienChinh_KhachHang : Window
    {
        public GiaoDienChinh_KhachHang()
        {
            InitializeComponent();
        }

        private void ListViewItem_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            int index = ListViewMenu.SelectedIndex;
            MoveCursorMenu(index);

            switch (index)
            {
                case 0:
                    GridHienThi.Children.Clear();
                    GridHienThi.Children.Add(new TongQuan());
                    break;
                case 1:
                    GridHienThi.Children.Clear();
                    GridHienThi.Children.Add(new frmXemThongTinPhim());
                    break;
                case 2:
                    GridHienThi.Children.Clear();
                    GridHienThi.Children.Add(new frmXemLichChieu());
                    break;
                case 3:
                    GridHienThi.Children.Clear();
                    GridHienThi.Children.Add(new frmDatVe());
                    break;

            }
        }

        private void MoveCursorMenu(int index)
        {
            //TrainsitionigContentSlide.OnApplyTemplate();
            //GridMenu.Margin = new Thickness(0, (100 + (60 * index)), 0, 0);
        }

        private void bt_shutdown_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void bt_logout_Click(object sender, RoutedEventArgs e)
        {
            Login lg = new Login();
            this.Close();
            lg.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GridHienThi.Children.Clear();
            GridHienThi.Children.Add(new TongQuan());
        }

    }
}
