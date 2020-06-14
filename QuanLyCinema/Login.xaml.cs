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
            string tk = txtTaiKhoan.Text;
            string mk = txtMatKhau.Password;
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
                        //var validLogin2 = DangNhapKhachHangBUS.Login(tk, mk);
                        //var validLogin = DangNhapNhanVienBUS.Login(tk, mk);
                        //var a = DangNhapNhanVienBUS.isstaff(tk, mk);
                        if (res == MessageBoxResult.Yes)
                        {
                            DANGNHAP = DangNhapNhanVienBUS.Login(tk, mk);
                            if (DANGNHAP == true)
                            {
                                GiaoDienChinh mainWindow = new GiaoDienChinh();
                                var pq = DangNhapNhanVienBUS.isstaff(tk, mk);
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
                            /// file gốc .
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
                                    //mainWindow.btnNhanvien.IsEnabled = false;
                                    mainWindow.btnPhongchieu.IsEnabled = false;
                                    //mainWindow.btnLichChieu.IsEnabled = false;
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



                        //if (validLogin2 == true)
                        //{
                        //    MainWindow mainw = new MainWindow();
                        //    mainw.Show();
                        //    this.Close();
                        //}


                        //}
                        //else if(validLogin2==true)
                        //{
                        //    MainWindow mainWindow1 = new MainWindow();

                        //     mainWindow1.Show();
                        //    this.Close();
                        //}
                        //frmWait_for_GiaoDienChinh welcome = new frmWait_for_GiaoDienChinh();
                        //welcome.ShowDialog();



                        // thêm sự kiện logout khi bấm nút logout bên frmGiaoDienChinh,
                        // nếu không có thì khi bấm nút LogOut , frmLogin sẽ k xuất hiện
                        //frmGiaoDienChinh.FormClosed += LogOut;
                        // Ẩn frmLogin khi đăng nhập thành công
                        // hàm Close sẽ đóng luôn frm -> đóng luôn chương trình


                        else
                        {
                            MessageBox.Show("Tài khoản/Mật khẩu bạn đã nhập không chính xác! Vui lòng kiểm tra lại.",
                                "Lỗi đăng nhập");
                            txtTaiKhoan.Focus();
                            txtMatKhau.Password = "";
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Lỗi kết nối");
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void guest_bt_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            GiaoDienChinh giaoDien = new GiaoDienChinh();
            giaoDien.Show();
        }

        private void btExit_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}

