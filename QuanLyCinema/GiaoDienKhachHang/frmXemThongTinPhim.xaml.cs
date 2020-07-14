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
    /// Interaction logic for frmXemThongTinPhim.xaml
    /// </summary>
   
    public partial class frmXemThongTinPhim : UserControl
    {

        public frmXemThongTinPhim()
        {
            InitializeComponent();
        }

        string DiaChiPoster = null;
      
        void OpenFormThongTinPhim(object sender, RoutedEventArgs e)
        {
            Button temp = (Button) sender;

            frmThongTinPhim frmThongTinPhim = new frmThongTinPhim();
            frmThongTinPhim.Sender(DiaChiPoster);
            frmThongTinPhim.Sender_MaPhim(temp.Name);
            Grid_hienthi.Children.Clear();
            Grid_hienthi.Children.Add(frmThongTinPhim);
        }

        private void PHIM1_Click(object sender, RoutedEventArgs e)
        {
            DiaChiPoster = "pack://application:,,,/Resources/Venom.png";
            OpenFormThongTinPhim(sender,e);
        }

        private void PHIM2_Click(object sender, RoutedEventArgs e)
        {
            DiaChiPoster = "pack://application:,,,/Resources/SwordArtOnline.jpg";
            OpenFormThongTinPhim(sender,e);
        }
    }
}
