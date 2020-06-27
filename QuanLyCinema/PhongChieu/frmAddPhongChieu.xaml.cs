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

using BUS;
using DTO;

namespace QuanLyCinema.PhongChieu
{
    /// <summary>
    /// Interaction logic for frmAddPhongChieu.xaml
    /// </summary>

    public partial class frmAddPhongChieu : Window
    {
        public frmAddPhongChieu()
        {
            InitializeComponent();
        }

        private void btnLamMoi_Click(object sender, RoutedEventArgs e)
        {
            txtMaPC.Clear();
            txtTenPC.Clear();
            txtSoCho.Clear();
            txtDienTich.Clear();
            txtTinhTrang.Clear();
            txtTrangThietBiKhac.Clear();

            cbbMayChieu.SelectedIndex = cbbLoa.SelectedIndex = -1;
        }

        private void btnHuy_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, RoutedEventArgs e)
        {
            bool TrungMaPC = false;
        Nhaplai:
            string mapc = null;
            if (txtMaPC.Text.Length != 0)
            {
                mapc = txtMaPC.Text;
            }
            string tenpc = null;
            if (txtTenPC.Text.Length != 0)
            {
                tenpc = txtTenPC.Text;
            }

            string socho = null;
            if (txtSoCho.Text.Length != 0)

            {
                socho = txtSoCho.Text;
            }

            string maychieu = null;
            if (cbbMayChieu.Text.Length != 0)
            {
                maychieu = cbbMayChieu.Text;
            }
            string loa = null;
            if (cbbLoa.Text.Length != 0)
            {
                loa = cbbLoa.Text;
            }
            string dientich = null;
            if (txtDienTich.Text.Length != 0)
            {
                dientich = txtDienTich.Text;
            }
            string tinhtrang = null;
            if (txtTinhTrang.Text.Length != 0)
            {
                tinhtrang = txtTinhTrang.Text;
            }
            string trangthietbikhac = null;
            if (txtTrangThietBiKhac.Text.Length != 0)
            {
                trangthietbikhac = txtTrangThietBiKhac.Text;
            }


            PhongChieuDTO pc = new PhongChieuDTO(mapc, tenpc, Int32.Parse(socho), maychieu, loa,Int32.Parse(dientich), tinhtrang, trangthietbikhac);

            // báo lỗi nếu chưa nhập theo thứ tự trừ trên xuống , trái sang phải

            if (mapc == null)
            {
                if (TrungMaPC == false)
                {
                    MessageBox.Show("Chưa nhập mã phòng chiếu");
                    txtMaPC.Focus();
                }
                else
                {
                    MessageBox.Show("Mã phòng chiếu trùng");
                    txtMaPC.Focus();
                }

            }
            else if (tenpc == null)
            {
                MessageBox.Show("Chưa nhập tên phòng chiếu");
                txtTenPC.Focus();
            }
            else if (socho == null)
            {
                MessageBox.Show("Chưa nhập số chỗ");
                txtSoCho.Focus();
            }
            else if (maychieu == null)
            {
                MessageBox.Show("Chưa nhập máy chiếu");
                cbbMayChieu.Focus();
            }
            else if (loa == null)
            {
                MessageBox.Show("Chưa chọn loa");
                cbbLoa.Focus();
            }
            else if (dientich == null)
            {
                MessageBox.Show("Chưa nhập diện tích");
                txtDienTich.Focus();
            }

            else if (tinhtrang == null)
            {
                MessageBox.Show("Chưa nhập tình trạng");
                txtTinhTrang.Focus();
            }
            else if (trangthietbikhac == null)
            {
                MessageBox.Show("Chưa nhập trang thiết bị khác");
                txtTrangThietBiKhac.Focus();
            }
            else
            {
                try
                {
                    PhongChieuBUS.Them(pc);
                }
                catch
                {
                    txtMaPC.Clear();
                    TrungMaPC = true;
                    goto Nhaplai;
                }

                MessageBox.Show("Thêm phòng chiếu mới thành công", "Thông báo");
                this.Close();
            }
        }
    }

}
