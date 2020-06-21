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
        string tk = null;
        string mk = null;
        public Login()
        {
            InitializeComponent();
        }
     

        private void btnDangNhap_Click(object sender, RoutedEventArgs e)
        {
            tk = txtTaiKhoan.Text;
            mk = txtMatKhau.Password;
            if (tk == "")
            {
                MessageBox.Show("Vui lòng nhập Tài khoản");
            }
            else
            {
                if (mk == "")
                {
                    MessageBox.Show("Vui lòng nhập Mật khẩu");
                }
                else
                {
                    try
                    {
                        var DANGNHAP = true;
                        DANGNHAP = DangNhapNhanVienBUS.Login(tk, mk);
                        if (DANGNHAP == true)
                        {
                            GiaoDienChinh mainWindow = new GiaoDienChinh();
                            var pq = DangNhapNhanVienBUS.PhanQuyen(tk, mk);
                            if (pq == 1)
                            {
                                mainWindow.Show();

                            }
                            else if (pq == 2)
                            {
                                mainWindow.btnNhanvien.IsEnabled = false;
                                mainWindow.btnKhachhang.IsEnabled = false;
                                mainWindow.btnNguoidung.IsEnabled = false;
                                mainWindow.btnPhongchieu.IsEnabled = false;
                                mainWindow.Show();
                            }
                            else if (pq == 3)
                            {
                                mainWindow.btnNhanvien.IsEnabled = false;
                                mainWindow.btnKhachhang.IsEnabled = false;
                                mainWindow.btnNguoidung.IsEnabled = false;
                                mainWindow.btnLoaiphim.IsEnabled = false;
                                mainWindow.Show();

                            }
                            else if (pq == 4)
                            {
                                mainWindow.btnNguoidung.IsEnabled = false;
                                //mainWindow.btnPhim.IsEnabled = false;
                                //mainWindow.btnLoaiphim.IsEnabled = false;
                                mainWindow.btnNhanvien.IsEnabled = false;
                                mainWindow.btnKhachhang.IsEnabled = false;
                                mainWindow.Show();
                            }
                            else if (pq == 5)
                            {
                                MessageBoxResult a;
                                a = MessageBox.Show("Bạn không có quyền truy cập vào hệ thống này!", "Thông báo", MessageBoxButton.OK);
                                if (a == MessageBoxResult.OK)
                                {
                                    Application.Current.Shutdown();
                                }
                            }

                            //mainWindow.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Tài khoản/Mật khẩu bạn đã nhập không chính xác! Vui lòng kiểm tra lại.",
                                "Lỗi đăng nhập");
                            txtTaiKhoan.Focus();
                            txtMatKhau.Password = "";
                        }
                        // file gốc .
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Lỗi kết nối");
                    }
                }
            }
        }

        private void btExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnDangNhapKhachHang_Click(object sender, RoutedEventArgs e)
        {
            tk = txtTaiKhoan.Text;
            mk = txtMatKhau.Password;
            if(tk=="" && mk=="")
            {
                // khách hàng đăng nhập không tài khoản
                this.Hide();
                GiaoDienChinh giaoDien = new GiaoDienChinh();
                giaoDien.Show();
            }    
            else
            {
                var DANGNHAP = true;
                DANGNHAP = DangNhapKhachHangBUS.Login(tk, mk);
                if (DANGNHAP == true)
                {
                    GiaoDienChinh_KhachHang mainWindow = new GiaoDienChinh_KhachHang();
                    mainWindow.Show();
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
    }
}

