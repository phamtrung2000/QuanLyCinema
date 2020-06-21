using BUS;
using DTO;
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

namespace QuanLyCinema.CaChieu
{
    /// <summary>
    /// Interaction logic for frmAddLichChieu.xaml
    /// </summary>
    public partial class frmAddLichChieu : Window
    {
        public frmAddLichChieu()
        {
            InitializeComponent();
        }

        private void BtnLuu_Click(object sender, RoutedEventArgs e)
        {
            bool TrungMaLC = false;
        SuaLai:
            string maphim = null;
            if (txtMaphim.Text.Length != 0)
            {
                maphim = txtMaphim.Text;
            }
            string macc = null;
            if (txtMacc.Text.Length != 0)
            {
                macc = txtMacc.Text;
            }
            string mapc = null;
            if (txtMapc.Text.Length != 0)
            {
                mapc = txtMapc.Text;
            }

            DateTime ngaychieu = dtpNgaychieu.DisplayDate;
            LichChieuDTO lc = new LichChieuDTO(ngaychieu, maphim, macc, mapc);
            if (maphim == null)
            {
                if (TrungMaLC == false)
                {
                    MessageBox.Show("Mã phim không được để trống");
                }
                else
                {
                    MessageBox.Show("Mã phim bị trùng");
                }
                txtMacc.Focus();
            }
            else if (macc == null)
            {
                MessageBox.Show("Mã ca chiếu không được để trống");
                txtMacc.Focus();
            }
            else if (mapc == null)
            {
                MessageBox.Show("Mã phòng chiếu không được để trống");
                txtMapc.Focus();
            }
            else
            {
                try
                {
                    LichChieuBUS.Them(lc);
                }
                catch
                {
                    txtMaphim.Clear();
                    TrungMaLC = true;
                    goto SuaLai;
                }
                MessageBox.Show("Thêm thông tin lịch chiếu  thành công", "Thông báo");
                this.Close();
            }
        }

        private void BtnLamMoi_Click(object sender, RoutedEventArgs e)
        {
            txtMacc.Clear();
            txtMapc.Clear();
            txtMaphim.Clear();
            dtpNgaychieu.Text = "";
        }

        private void BtnHuy_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
