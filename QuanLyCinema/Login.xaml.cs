using BUS;
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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        MessageBoxResult res = MessageBox.Show("Bạn có phải là nhân viên hay không", "XIN CHÀO", MessageBoxButton.YesNo);
        public Login()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, RoutedEventArgs e)
        {
            txtTaiKhoan.Focus();

            string tk = txtTaiKhoan.Text;
            string mk = txtMatKhau.Password;
            if (string.IsNullOrWhiteSpace(tk)) MessageBox.Show("Vui lòng nhập Tài khoản");
            if (string.IsNullOrWhiteSpace(mk)) MessageBox.Show("Vui lòng nhập Mật khẩu");

            try
            {
                var DANGNHAP = true;
                if (res == MessageBoxResult.Yes)
                {
                    DANGNHAP = DangNhapNhanVienBUS.Login(tk, mk);
                    if (DANGNHAP == true)
                    {
                        var mainWindow = new GiaoDienChinh();
                        var pq = DangNhapNhanVienBUS.LaNhanVien(tk, mk);

                        // Hiển thị các chức năng mỗi chức vụ có thể thực hiện được.
                        switch (pq)
                        {
                            case 1:
                                mainWindow.Show();
                                break;
                            case 2:
                            case 3:
                                mainWindow.btnNhanvien.IsEnabled = false;
                                mainWindow.btnKhachhang.IsEnabled = false;
                                mainWindow.btnNguoidung.IsEnabled = false;
                                mainWindow.btnPhongchieu.IsEnabled = false;
                                mainWindow.Show();
                                break;
                            case 4:
                                mainWindow.btnNguoidung.IsEnabled = false;
                                mainWindow.btnNhanvien.IsEnabled = false;
                                mainWindow.btnKhachhang.IsEnabled = false;
                                mainWindow.Show();
                                break;
                            case 5:
                                var result = MessageBox.Show("Bạn không có quyền truy cập vào hệ thống này!", "Thông báo", MessageBoxButton.YesNo);
                                if (result == MessageBoxResult.Yes)
                                    Application.Current.Shutdown();
                                break;
                        }
                    }
                    else if (DANGNHAP == false)
                    {
                        MessageBox.Show("Tài khoản/Mật khẩu bạn đã nhập không chính xác! Vui lòng kiểm tra lại.",
                            "Lỗi đăng nhập");
                        txtTaiKhoan.Focus();
                        txtMatKhau.Clear();
                    }
                }
                else if (res == MessageBoxResult.No)
                {
                    DANGNHAP = DangNhapKhachHangBUS.Login(tk, mk);
                    if (DANGNHAP == true)
                    {
                        GiaoDienChinh mainWindow = new GiaoDienChinh();
                        var pq = DangNhapKhachHangBUS.isstaff(tk, mk);
                        if (pq == 1)
                        {
                            mainWindow.Show();
                        }
                        if (pq == 2)
                        {
                            mainWindow.btnPhongchieu.IsEnabled = false;
                            mainWindow.Show();
                        }
                        if (pq == 3)
                        {
                            mainWindow.Show();
                        }

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản/Mật khẩu bạn đã nhập không chính xác! Vui lòng kiểm tra lại.",
                            "Lỗi đăng nhập");
                        txtTaiKhoan.Focus();
                        txtMatKhau.Password = "";
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }

        // ?
        private void btnThoat_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void guest_bt_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            GiaoDienChinh giaoDien = new GiaoDienChinh();
            giaoDien.Show();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}

