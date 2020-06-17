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
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using BUS;
using QuanLyCinema.NhanVien;
using DTO;

namespace QuanLyCinema
{
    /// <summary>
    /// Interaction logic for NhanVien.xaml
    /// </summary>
    public partial class frmNhanVien : UserControl
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        void ChoPhepNhap()
        {
            txtHoTen.IsReadOnly = txtMaNV.IsReadOnly = txtChucVu.IsReadOnly = txtSDT.IsReadOnly = txtDiaChi.IsReadOnly = txtLuong.IsReadOnly = false;
            dtpNgaySinh.IsEnabled = dtpNgayVL.IsEnabled = true;
            rdbNam.IsEnabled = rdbNu.IsEnabled = true;
            txtHoTen.Focus();
        }

        void KhongChoNhap()
        {
            txtHoTen.Clear();
            txtMaNV.Clear();
            txtChucVu.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            txtLuong.Clear();

            rdbNam.IsChecked = rdbNu.IsChecked = false;

            txtHoTen.IsReadOnly = txtMaNV.IsReadOnly = txtChucVu.IsReadOnly = txtSDT.IsReadOnly
            = txtDiaChi.IsReadOnly = txtLuong.IsReadOnly = true;
            dtpNgaySinh.IsEnabled = dtpNgayVL.IsEnabled = false;
            rdbNam.IsEnabled = rdbNu.IsEnabled = false;
        }

        private void GridNhanVien_Loaded(object sender, RoutedEventArgs e)
        {
            KhongChoNhap();
            dtgDSNV.ItemsSource = NhanVienBUS.LoadDSNV().DefaultView;
            panelTimKiem.Visibility = btnHuy_Sua.Visibility = Visibility.Hidden;
        }

        private void dtgDSNV_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = sender as DataGrid;
            DataRowView dr = dg.SelectedItem as DataRowView;
            if (dr != null)
            {
                txtMaNV.Text = dr["MANV"].ToString();
                txtHoTen.Text = dr["HOTEN"].ToString();
                txtChucVu.Text = dr["CHUCVU"].ToString();
                txtSDT.Text = dr["SDT"].ToString();

                string gioitinh = dr["GIOITINH"].ToString();
                if (gioitinh == "Nam")
                    rdbNam.IsChecked = true;
                else if (gioitinh == "Nữ")
                    rdbNu.IsChecked = true;

                dtpNgaySinh.SelectedDate = DateTime.Parse(dr["NGAYSINH"].ToString());
                txtDiaChi.Text = dr["DIACHI"].ToString();
                txtLuong.Text = dr["LUONG"].ToString();
                dtpNgayVL.SelectedDate = DateTime.Parse(dr["NGAYVL"].ToString());
            }
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            frmAddNhanVien addNhanVien = new frmAddNhanVien();
            addNhanVien.ShowDialog();
            dtgDSNV.ItemsSource = NhanVienBUS.LoadDSNV().DefaultView;
            KhongChoNhap();
            btnThem.Visibility = Visibility.Visible;
            btnSua.IsEnabled = btnXoa.IsEnabled = true;
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không?", "Thông Báo", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                NhanVienBUS.Xoa(txtMaNV.Text);
                MessageBox.Show("Xóa nhân viên thành công", "Thông Báo");
            }
            dtgDSNV.ItemsSource = NhanVienBUS.LoadDSNV().DefaultView;
        }

        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            ChoPhepNhap();
            btnLuu_Sua.Visibility = Visibility.Visible;
            btnHuy_Sua.Visibility = Visibility.Visible;
            btnSua.Visibility = Visibility.Hidden;
            btnThem.IsEnabled = btnXoa.IsEnabled = false;
        }

        private void btnLuu_Sua_Click(object sender, RoutedEventArgs e)

        {
            bool TrungMaNV = false;
        SuaLai:
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
            string sdt = null;
            if (txtSDT.Text.Length != 0)
            {
                sdt = txtSDT.Text;
            }
            string gioitinh = null;
            if (rdbNam.IsChecked == true)
                gioitinh = "Nam";
            else if (rdbNu.IsChecked == true)
                gioitinh = "Nữ";

            DateTime ngaysinh = dtpNgaySinh.DisplayDate;

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


            if (manv == null)
            {
                if (TrungMaNV == false)
                {
                    MessageBox.Show("Mã số nhân viên không được để trống");
                }
                else
                {
                    MessageBox.Show("Mã số nhân viên bị trùng");
                }
                txtMaNV.Focus();
            }
            else if (hoten == null)
            {
                MessageBox.Show("Họ tên không được để trống");
                txtHoTen.Focus();
            }
            else if (chucvu == null)
            {
                MessageBox.Show("Chức vụ không được để trống");
                txtChucVu.Focus();
            }
            else if (sdt == null)
            {
                MessageBox.Show("Số điện thoại không được để trống");
                txtSDT.Focus();
            }
            else if (gioitinh == null)
            {
                MessageBox.Show("Giới tính không được để trống");
                rdbNam.Focus();
                rdbNam.IsChecked = false;
            }
            else if (diachi == null)
            {
                MessageBox.Show("Địa chỉ không được để trống");
                txtDiaChi.Focus();
            }

            else if (luong == null)
            {
                MessageBox.Show("Lương không được để trống");
                txtLuong.Focus();
            }
            else
            {
                try
                {
                    NhanVienBUS.Sua(nv);
                }
                catch
                {
                    txtMaNV.Clear();
                    TrungMaNV = true;
                    goto SuaLai;
                }
                MessageBox.Show("Sửa thông tin nhân viên  thành công", "Thông báo");
                dtgDSNV.ItemsSource = NhanVienBUS.LoadDSNV().DefaultView;
                KhongChoNhap();
                btnLuu_Sua.Visibility = Visibility.Hidden;
                btnSua.Visibility = Visibility.Visible;
                btnThem.IsEnabled = btnXoa.IsEnabled = true;
                dtgDSNV.IsEnabled = true;
            }
        }

        private void btnTimKiem_Click(object sender, RoutedEventArgs e)
        {
            if (panelTimKiem.Visibility == Visibility.Visible)
            {
                panelTimKiem.Visibility = Visibility.Hidden;
            }
            else
            {
                panelTimKiem.Visibility = Visibility.Visible;
            }
        }

        int type_timkiem = -1;
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            String a = cbbTimKiem.SelectedItem.ToString();
            if (cbbTimKiem.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: Mã Nhân Viên")
            {
                type_timkiem = 0;
            }
            else if (cbbTimKiem.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: Họ Tên")
            {
                type_timkiem = 1;
            }
            else if (cbbTimKiem.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: Số Điện Thoại")
            {
                type_timkiem = 2;
            }
        }


        private void txtTimKiem_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtTimKiem.Text.Length > 1)
            {
                switch (type_timkiem)
                {
                    case 0:
                        {
                            dtgDSNV.ItemsSource = NhanVienBUS.TimTheoMaNV(txtTimKiem.Text.ToString()).DefaultView;
                        }
                        break;
                    case 1:
                        {
                            dtgDSNV.ItemsSource = NhanVienBUS.TimTheoHoTen(txtTimKiem.Text.ToString()).DefaultView;
                        }
                        break;
                    case 2:
                        {
                            dtgDSNV.ItemsSource = NhanVienBUS.TimTheoSDT(txtTimKiem.Text.ToString()).DefaultView;
                        }
                        break;
                }
            }
            else if (txtTimKiem.Text.Length == 0)
            {
                dtgDSNV.ItemsSource = NhanVienBUS.LoadDSNV().DefaultView;
            }
        }

        private void txtTimKiem_GotFocus(object sender, RoutedEventArgs e)
        {
            if (type_timkiem == -1)
            {
                MessageBox.Show("Chưa chọn mục tìm kiếm");
                cbbTimKiem.Focus();
            }
            else if (txtTimKiem.Text == "Tìm Kiếm...")
                txtTimKiem.Text = "";
        }

        private void txtTimKiem_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                txtTimKiem.Text = "Tìm Kiếm...";
                dtgDSNV.ItemsSource = NhanVienBUS.LoadDSNV().DefaultView;
            }
        }

        private void btnHuy_Sua_Click(object sender, RoutedEventArgs e)
        {
            KhongChoNhap();
            btnLuu_Sua.Visibility = btnHuy_Sua.Visibility = Visibility.Hidden;
            btnSua.Visibility = Visibility.Visible;
            btnThem.IsEnabled = btnXoa.IsEnabled = true;
        }

        private void btnLamMoi_Click(object sender, RoutedEventArgs e)
        {
            KhongChoNhap();
            dtgDSNV.ItemsSource = NhanVienBUS.LoadDSNV().DefaultView;
            panelTimKiem.Visibility = btnHuy_Sua.Visibility = Visibility.Hidden;
        }
    }
}
