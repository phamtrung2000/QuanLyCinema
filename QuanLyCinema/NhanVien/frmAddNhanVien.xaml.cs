using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
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

namespace QuanLyCinema.NhanVien
{
    /// <summary>
    /// Interaction logic for frmAddNhanVien.xaml
    /// </summary>
    public partial class frmAddNhanVien : Window
    {
        public frmAddNhanVien()
        {
            InitializeComponent();
        }

        private void btnLamMoi_Click(object sender, RoutedEventArgs e)
        {
            txtMaNV.Clear();
            txtHoTen.Clear();
            txtChucVu.Clear();
            txtSDT.Clear();
            rdbNam.IsChecked = rdbNu.IsChecked = false;
            dtpNgaySinh.Text = "";
            txtDiaChi.Clear();
            txtLuong.Clear();
            dtpNgayVL.Text = "";
        }

        private void btnHuy_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, RoutedEventArgs e)
        {
            bool TrungMaNV = false;
        Nhaplai:
            string manv = null;
            if (txtMaNV.Text.Length != 0)
            {
                manv = txtMaNV.Text;
            }
            string hoten = null;
            if (txtHoTen.Text.Length != 0)
            {
                hoten = txtHoTen.Text;
            }

            string chucvu = null;
            if (txtChucVu.Text.Length != 0)

            {
                chucvu = txtChucVu.Text;
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
            string luong = null;
            if (txtLuong.Text.Length != 0)
            {
                luong = txtLuong.Text;
            }
            DateTime ngayvl = dtpNgayVL.DisplayDate;

            NhanVienDTO nv = new NhanVienDTO(manv, hoten, chucvu, sdt, gioitinh, ngaysinh, diachi, luong, ngayvl);

            // báo lỗi nếu chưa nhập theo thứ tự trừ trên xuống , trái sang phải

            if (manv == null)
            {
                if (TrungMaNV == false)
                {
                    MessageBox.Show("Chưa nhập mã nhân viên");
                    txtMaNV.Focus();
                }
                else
                {
                    MessageBox.Show("Mã nhân viên trùng");
                    txtMaNV.Focus();
                }

            }
            else if (hoten == null)
            {
                MessageBox.Show("Chưa nhập họ tên");
                txtHoTen.Focus();
            }
            else if (chucvu == null)
            {
                MessageBox.Show("Chưa nhập lớp");
                txtChucVu.Focus();
            }
            else if (sdt == null)
            {
                MessageBox.Show("Chưa nhập số điện thoại");
                txtSDT.Focus();
            }
            else if (gioitinh == null)
            {
                MessageBox.Show("Chưa chọn giới tính");
                rdbNam.Focus();
                rdbNam.IsChecked = false;
            }
            else if (diachi == null)
            {
                MessageBox.Show("Chưa nhập địa chỉ");
                txtDiaChi.Focus();
            }

            else if (luong == null)
            {
                MessageBox.Show("Chưa nhập lương");
                txtLuong.Focus();
            }
            else
            {
                try
                {
                    using (var client = new HttpClient())
                    {
                        client.BaseAddress = new Uri("https://localhost:44373/");
                        client.DefaultRequestHeaders.Accept.Clear();
                        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                        HttpResponseMessage response = client.PostAsJsonAsync($"api/nhanvien", nv).Result;
                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show($"Thêm nhân viên {nv.MaNV} thành công");
                        }
                    }    
                }
                catch
                {
                    txtMaNV.Clear();
                    TrungMaNV = true;
                    goto Nhaplai;
                }

                MessageBox.Show("Thêm nhân viên mới thành công", "Thông báo");
                this.Close();
            }
        }

        private void txtLuong_TextChanged(object sender, TextChangedEventArgs e)
        {
            int n = txtLuong.Text.Length;
            if(n>0)
            {
                if ('a' <= txtLuong.Text[n - 1] && txtLuong.Text[n - 1] <= 'z' || ('A' <= txtLuong.Text[n - 1] && txtLuong.Text[n - 1] <= 'Z'))
                {
                    MessageBox.Show("Lương chỉ có thế là số, vui lòng nhập lại", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                    txtLuong.Text = txtLuong.Text.Remove(n - 1, 1);
                    txtLuong.SelectionStart = n-1;
                }
            }    
            
        }

        private void txtSDT_TextChanged(object sender, TextChangedEventArgs e)
        {
            int n = txtSDT.Text.Length;
            if (n > 0)
            {
                if ('a' <= txtSDT.Text[n - 1] && txtSDT.Text[n - 1] <= 'z' || ('A' <= txtSDT.Text[n - 1] && txtSDT.Text[n - 1] <= 'Z'))
                {
                    MessageBox.Show("Số điện thoại chỉ có thế là số, vui lòng nhập lại", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                    txtSDT.Text = txtSDT.Text.Remove(n - 1, 1);
                    txtSDT.SelectionStart = n - 1;
                }
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

        private void dtpNgayVL_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dtpNgayVL.Text.Length > 0)
            {
                txtNgayVL.Text = ThangTruocNgaySau(dtpNgayVL.Text);

            }
            dtpNgayVL.Text = "";
        }

        private void dtpNgaySinh_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dtpNgaySinh.Text.Length > 0)
            {
                txtNgaySinh.Text = ThangTruocNgaySau(dtpNgaySinh.Text);

            }
            dtpNgaySinh.Text = "";
        }
    }
}
