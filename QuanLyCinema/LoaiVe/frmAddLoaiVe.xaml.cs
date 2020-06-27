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

namespace QuanLyCinema.LoaiVe
{
    /// <summary>
    /// Interaction logic for frmAddLoaiVe.xaml
    /// </summary>
    public partial class frmAddLoaiVe : Window
    {
        public delegate void GuiSoLuongMaLV(int soluong);
        // ví dụ: Mã loại vé đang là LV9 thì soluong sẽ là 9
        // mục đích của cái này là hệ thống tự động tăng mã loại vé lên, người dùng k cần nhập 
        // để tránh trường hợp nhập trùng mã lv
        public GuiSoLuongMaLV Sender;

        public static int SoLuongMaLV = 0;

        private void GetSoLuongMaLV(int soluong)
        {
            SoLuongMaLV = soluong;
        }

        public frmAddLoaiVe()
        {
            InitializeComponent();
            Sender = new GuiSoLuongMaLV(GetSoLuongMaLV);
        }

        private void btnLamMoi_Click(object sender, RoutedEventArgs e)
        {
            txtMaLV.Clear();
            txtTenLV.Clear();
            txtLoaiChoNgoi.Clear();
            txtGia.Clear();
        }

        private void btnHuy_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, RoutedEventArgs e)
        {
            bool TrungMaLV = false;
        Nhaplai:
            string malv = null;
            if (txtMaLV.Text.Length != 0)
            {
                malv = txtMaLV.Text;
            }
            string tenlv = null;
            if (txtTenLV.Text.Length != 0)
            {
                tenlv = txtTenLV.Text;
            }

            string loaichongoi = null;
            if (txtLoaiChoNgoi.Text.Length != 0)

            {
                loaichongoi = txtLoaiChoNgoi.Text;
            }

            string gia = null;
            if (txtGia.Text.Length != 0)
            {
                gia = txtGia.Text;
            }


            LoaiVeDTO loaive = new LoaiVeDTO(malv, tenlv, loaichongoi, gia);

            // báo lỗi nếu chưa nhập theo thứ tự trừ trên xuống , trái sang phải

            if (malv == null)
            {
                if (TrungMaLV == false)
                {
                    MessageBox.Show("Chưa nhập mã loại vé");
                    txtMaLV.Focus();
                }
                else
                {
                    MessageBox.Show("Mã loại vé trùng");
                    txtMaLV.Focus();
                }

            }
            else if (tenlv == null)
            {
                MessageBox.Show("Chưa nhập tên loại vé");
                txtTenLV.Focus();
            }
            else if (loaichongoi == null)
            {
                MessageBox.Show("Chưa nhập loại chỗ ngồi");
                txtLoaiChoNgoi.Focus();
            }
            else if (gia == null)
            {
                MessageBox.Show("Chưa nhập giá");
                txtGia.Focus();
            }
            else
            {
                try
                {
                    LoaiVeBUS.Them(loaive);
                }
                catch
                {
                    txtMaLV.Clear();
                    TrungMaLV = true;
                    goto Nhaplai;
                }
                MessageBox.Show("Thêm loại vé mới thành công", "Thông báo");
                this.Close();
            }
        }
    }
}
