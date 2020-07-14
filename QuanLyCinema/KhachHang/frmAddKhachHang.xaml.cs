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
        public delegate void GuiSoLuongMaKH(int soluong);
        // ví dụ: Mã loại vé đang là LV9 thì soluong sẽ là 9
        // mục đích của cái này là hệ thống tự động tăng mã loại vé lên, người dùng k cần nhập 
        // để tránh trường hợp nhập trùng mã lv
        public GuiSoLuongMaKH Sender;

        public static int SoLuongMaKH = 0;

        private void GetSoLuongMaKH(int soluong)
        {
            SoLuongMaKH = soluong;
        }

        public frmAddKhachHang()
        {
            InitializeComponent();
            Sender = new GuiSoLuongMaKH(GetSoLuongMaKH);
        }
        
        private void btnLamMoi_Click(object sender, RoutedEventArgs e)
        {
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
            string makh = "KH" + (SoLuongMaKH + 1).ToString();
        Nhaplai:
            string hoten = null;
            if (txtHoTenKH.Text.Length != 0)
            {
                hoten = txtHoTenKH.Text;
            }

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

           if (hoten == null)
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
                    goto Nhaplai;
                }

                MessageBox.Show("Thêm nhân viên mới thành công", "Thông báo");
                this.Close();
            }
        }

        private string ThangTruocNgaySau(string a) // 4 thang 5 -> 5/4
        {
            string kq = null;
            string ngay = null, thang = null, nam = null;
            string[] chuoi_duoc_tach = a.Split(new Char[] { '/' });

            ngay = chuoi_duoc_tach[0];
            thang = chuoi_duoc_tach[1];
            nam = chuoi_duoc_tach[2];
            kq = thang + "/" + ngay + "/" + nam;
            return kq;
        }

        private void dtpNgaySinh_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dtpNgaySinh.Text.Length > 0)
            {
                txtNgaySinh.Text = ThangTruocNgaySau(dtpNgaySinh.Text);
            }
            dtpNgaySinh.Text = "";
            txtNgaySinh.Focus();
        }

        private void dtpNgayDK_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dtpNgayDK.Text.Length > 0)
            {
                txtNgayDK.Text = ThangTruocNgaySau(dtpNgayDK.Text);
            }
            dtpNgayDK.Text = "";
            txtNgayDK.Focus();
        }
    }
}