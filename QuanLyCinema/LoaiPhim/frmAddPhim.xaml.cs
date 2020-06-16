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

namespace QuanLyCinema.LoaiPhim
{
    /// <summary>
    /// Interaction logic for frmAddPhim.xaml
    /// </summary>
    public partial class frmAddPhim : Window
    {
        public frmAddPhim()
        {
            InitializeComponent();
        }

        private void BtnLuu_Click(object sender, RoutedEventArgs e)
        {
            bool TrungMaP = false;
        SuaLai:
            string maphim = null;
            if (txtMaP.Text.Length != 0)
            {
                maphim = txtMaP.Text;
            }
            string tenphim = null;
            if (txtTenphim.Text.Length != 0)
            {
                tenphim = txtTenphim.Text;
            }
            string daodien = null;
            if (txtDaodien.Text.Length != 0)
            {
                daodien = txtDaodien.Text;
            }
            string dienvien = null;
            if (txtDienvien.Text.Length != 0)
            {
                dienvien = txtDienvien.Text;
            }
            string malp = null;
            if (txtMalp.Text.Length != 0)
            {
                malp = txtMalp.Text;
            }

            string noidung = null;
            if (txtNoidung.Text.Length != 0)
            {
                noidung = txtNoidung.Text;
            }
            string namsx = null;
            if (txtNamsx.Text.Length != 0)
            {
                namsx = txtNamsx.Text;
            }
            string nuocsx = null;
            if (txtNuocsx.Text.Length != 0)
            {
                nuocsx = txtNuocsx.Text;
            }
            string thoiluong = null;
            if (txtThoiluong.Text.Length != 0)
            {
                thoiluong = txtThoiluong.Text;
            }


            PhimDTO phim = new PhimDTO(maphim, tenphim, daodien, dienvien, malp, noidung, namsx, nuocsx, thoiluong);


            if (maphim == null)
            {
                if (TrungMaP == false)
                {
                    MessageBox.Show("Mã phim không được để trống");
                }
                else
                {
                    MessageBox.Show("Mã phim bị trùng");
                }
                txtMaP.Focus();
            }
            else if (tenphim == null)
            {
                MessageBox.Show("Tên phim không được để trống");
            }
            else if (daodien == null)
            {
                MessageBox.Show("Đạo diễn không được để trống");
                txtDaodien.Focus();
            }
            else if (dienvien == null)
            {
                MessageBox.Show("Diễn viên không được để trống");
                txtDienvien.Focus();
            }
            else if (noidung == null)
            {
                MessageBox.Show("Nội dung không được để trống");
                txtNoidung.Focus();
            }
            else if (namsx == null)
            {
                MessageBox.Show("Địa chỉ không được để trống");
                txtNamsx.Focus();
            }

            else if (nuocsx == null)
            {
                MessageBox.Show("Lương không được để trống");
                txtNuocsx.Focus();
            }
            else if (malp == null)
            {
                MessageBox.Show("Mã loại phim không được để trống");
                txtMalp.Focus();
            }
            else if (thoiluong == null)
            {
                MessageBox.Show("Thời lượng phim không được để trống");
                txtThoiluong.Focus();
            }
            else
            {
                try
                {
                    PhimBUS.Them(phim);
                }
                catch
                {
                    txtMaP.Clear();
                    TrungMaP = true;
                    goto SuaLai;
                }
                MessageBox.Show("Thêm thông tin phim  thành công", "Thông báo");
                this.Close();
            }
        }

        private void BtnLamMoi_Click(object sender, RoutedEventArgs e)
        {
            txtMaP.Clear();
            txtTenphim.Clear();
            txtDaodien.Clear();
            txtDienvien.Clear();
            txtNoidung.Clear();
            txtNamsx.Clear();
            txtNuocsx.Clear();
            txtMalp.Clear();
            txtThoiluong.Clear();
        }

        private void BtnHuy_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
