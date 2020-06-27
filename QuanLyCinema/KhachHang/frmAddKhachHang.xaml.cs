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

namespace QuanLyCinema.KhachHang
{
    /// <summary>
    /// Interaction logic for frmAddKhachHang.xaml
    /// </summary>
    public partial class frmAddKhachHang : Window
    {
        public frmAddKhachHang()
        {
            InitializeComponent();
        }
        
        private void btnLamMoi_Click(object sender, RoutedEventArgs e)
        {
            txtMaKH.Clear();
            txtHoTenKH.Clear();
            txtDiaChi.Clear();
            dtpNgaySinh.Text = "";
            rdbNam.IsChecked = rdbNu.IsChecked = false;
            txtSDT.Clear();  
            dtpNgayDK.Text = "";

        }

        private void btnHuy_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, RoutedEventArgs e)
        {
            bool TrungMaKH = false;
        Nhaplai:
            string makh = null;
            if (txtMaKH.Text.Length != 0)
            {
                makh = txtMaKH.Text;
                
            }
            string hoten = null;
            if (txtHoTenKH.Text.Length != 0)
            {
                hoten = txtHoTenKH.Text;
            }

            //string loaikh = null;
            //if (txtLoaikh.Text.Length != 0)

            //{
            //    loaikh = txtLoaikh.Text;
            //}

            string loaikh = null;
            if (cbbLoaiKH.Text.Length != 0)

            {
                loaikh = cbbLoaiKH.Text;
            }

            string gioitinh = null;
            if (rdbNam.IsChecked == true)
                gioitinh = "Nam";
            else if (rdbNu.IsChecked == true)
                gioitinh = "Nữ";

            DateTime ngaysinh = dtpNgaySinh.DisplayDate;

            string sdt = null;
            if (txtSDT.Text.Length != 0)
            {
                sdt = txtSDT.Text;
            }
            string diachi = null;
            if (txtDiaChi.Text.Length != 0)
            {
                diachi = txtDiaChi.Text;
            }
            
            DateTime ngaydk = dtpNgayDK.DisplayDate;

            KhachHangDTO kh = new KhachHangDTO(makh, hoten, diachi, ngaysinh, gioitinh, sdt, loaikh, ngaydk);
            

            // báo lỗi nếu chưa nhập theo thứ tự trừ trên xuống , trái sang phải

            if (makh == null)
            {
                if (TrungMaKH == false)
                {
                    MessageBox.Show("Chưa nhập mã khách hàng");
                    txtMaKH.Focus();
                }
                else
                {
                    MessageBox.Show("Mã khách hàng trùng");
                    txtMaKH.Focus();
                }

            }
            else if (hoten == null)
            {
                MessageBox.Show("Chưa nhập họ tên");
                txtHoTenKH.Focus();
            }
            else if (diachi == null)
            {
                MessageBox.Show("Chưa nhập địa chỉ");
                txtDiaChi.Focus();
            }
            else if (gioitinh == null)
            {
                MessageBox.Show("Chưa chọn giới tính");
                rdbNam.Focus();
                rdbNam.IsChecked = false;
            }

            else if (sdt == null)
            {
                MessageBox.Show("Chưa nhập số điện thoại");
                txtSDT.Focus();
            }
            else if (loaikh == null)
            {
                MessageBox.Show("Chưa nhập lớp");
                cbbLoaiKH.Focus();
            }
            else
            {
                try
                {
                    KhachHangBUS.Them(kh);
                }
                catch
                {
                    txtMaKH.Clear();
                    TrungMaKH = true;
                    goto Nhaplai;
                }

                MessageBox.Show("Thêm nhân viên mới thành công", "Thông báo");
                this.Close();
            }
        }

        //private void txtLuong_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    int n = txtLuong.Text.Length;
        //    if (n > 0)
        //    {
        //        if ('a' <= txtLuong.Text[n - 1] && txtLuong.Text[n - 1] <= 'z' || ('A' <= txtLuong.Text[n - 1] && txtLuong.Text[n - 1] <= 'Z'))
        //        {
        //            MessageBox.Show("Lương chỉ có thế là số, vui lòng nhập lại", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Warning);
        //            txtLuong.Text = txtLuong.Text.Remove(n - 1, 1);
        //            txtLuong.SelectionStart = n - 1;
        //        }
        //    }

        //}
    }
}