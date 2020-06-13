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
using BUS;
using DTO;
using QuanLyCinema.KhachHang;
namespace QuanLyCinema
{
    /// <summary>
    /// Interaction logic for frmKhachHang.xaml
    /// </summary>
    public partial class frmKhachHang : UserControl
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }
        void ChoPhepNhap()
        {
            txtHoTenKH.IsReadOnly = txtMaKH.IsReadOnly = txtSDTKH.IsReadOnly = txtDiachiKH.IsReadOnly = txtLoaiKH.IsReadOnly = false;
            dtpNgaySinh.IsEnabled = dtpNgayDK.IsEnabled = true;
            rdbNam.IsEnabled = rdbNu.IsEnabled = true;
            txtHoTenKH.Focus();
        }

        void KhongChoNhap()
        {
            txtMaKH.Clear();
            txtHoTenKH.Clear();         
            txtSDTKH.Clear();
            txtDiachiKH.Clear();

            txtLoaiKH.Clear();
            rdbNam.IsChecked = rdbNu.IsChecked = false;

            txtHoTenKH.IsReadOnly = txtMaKH.IsReadOnly = txtSDTKH.IsReadOnly
            = txtDiachiKH.IsReadOnly = txtLoaiKH.IsReadOnly = true;
            dtpNgaySinh.IsEnabled = dtpNgayDK.IsEnabled = false;
            rdbNam.IsEnabled = rdbNu.IsEnabled = false;
        }

        private void GridKhachHang_Loaded(object sender, RoutedEventArgs e)
        {
            
            KhongChoNhap();
            dtgDSKH.ItemsSource = KhachHangBUS.LoadDSKH().DefaultView;
            panelTimKiem.Visibility = btnHuy_Sua.Visibility = Visibility.Hidden;

        }

        private void DtgDSKH_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = sender as DataGrid;
            DataRowView dr = dg.SelectedItem as DataRowView;
            if (dr != null)
            {

                txtMaKH.Text = dr["MAKH"].ToString();
                txtHoTenKH.Text = dr["HOTEN"].ToString();
                txtDiachiKH.Text = dr["DIACHI"].ToString();
                string gioitinh = dr["GIOITINH"].ToString();
                if (gioitinh == "Nam")
                    rdbNam.IsChecked = true;
                else if (gioitinh == "Nữ")
                    rdbNu.IsChecked = true;
                dtpNgaySinh.SelectedDate = DateTime.Parse(dr["NGAYSINH"].ToString());

                //ngay sinh
                //dtpNgaySinh.SelectedDate = DateTime.Parse(dr["NGAYSINH"].ToString());

                txtSDTKH.Text = dr["SDT"].ToString();
                txtLoaiKH.Text = dr["LOAIKH"].ToString();
                dtpNgayDK.SelectedDate = DateTime.Parse(dr["NGAYDK"].ToString());
            }
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            frmAddKhachHang addKhachHang = new frmAddKhachHang();
            addKhachHang.ShowDialog();
            dtgDSKH.ItemsSource = KhachHangBUS.LoadDSKH().DefaultView;
            KhongChoNhap();
            btnThem.Visibility = Visibility.Visible;
            btnSua.IsEnabled = btnXoa.IsEnabled = true;
        }

        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            ChoPhepNhap();
            btnLuu_Sua.Visibility = Visibility.Visible;
            btnHuy_Sua.Visibility = Visibility.Visible;
            btnSua.Visibility = Visibility.Hidden;
            btnThem.IsEnabled = btnXoa.IsEnabled = false;
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không?", "Thông Báo", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                KhachHangBUS.Xoa(txtMaKH.Text);
                MessageBox.Show("Xóa nhân viên thành công", "Thông Báo");
            }
            dtgDSKH.ItemsSource = KhachHangBUS.LoadDSKH().DefaultView;
        }

        private void btnLuu_Sua_Click(object sender, RoutedEventArgs e)
        {
            bool TrungMaKH = false;
        SuaLai:
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
            string diachi = null;
            if (txtDiachiKH.Text.Length != 0)
            {
                diachi = txtDiachiKH.Text;
            }
            DateTime ngaysinh = dtpNgaySinh.DisplayDate;

            string gioitinh = null;
            if (rdbNam.IsChecked == true)
                gioitinh = "Nam";
            else if (rdbNu.IsChecked == true)
                gioitinh = "Nữ";

            string sdt = null;
            if (txtSDTKH.Text.Length != 0)
            {
                sdt = txtSDTKH.Text;
            }

            string loaikh = null;
            if (txtLoaiKH.Text.Length != 0)
            {
                loaikh = txtLoaiKH.Text;
            }
            DateTime ngaydk = dtpNgayDK.DisplayDate;

            KhachHangDTO kh = new KhachHangDTO(makh, hoten, diachi, ngaysinh, gioitinh, sdt, loaikh, ngaydk);


            if (makh == null)
            {
                if (TrungMaKH == false)
                {
                    MessageBox.Show("Mã số khách hàng không được để trống");
                }
                else
                {
                    MessageBox.Show("Mã số khách hàng bị trùng");
                }
                txtMaKH.Focus();
            }
            else if (hoten == null)
            {
                MessageBox.Show("Họ tên không được để trống");
                txtHoTenKH.Focus();
            }
            else if (diachi == null)
            {
                MessageBox.Show("Địa chỉ không được để trống");
                txtDiachiKH.Focus();
            }
            else if (gioitinh == null)
            {
                MessageBox.Show("Giới tính không được để trống");
                rdbNam.Focus();
                rdbNam.IsChecked = false;
            }
            else if (sdt == null)
            {
                MessageBox.Show("Số điện thoại không được để trống");
                txtSDTKH.Focus();
            }
            else if (loaikh == null)
            {
                MessageBox.Show("Loại khách hàng không được để trống");
                txtLoaiKH.Focus();
            }
            else
            {
                try
                {
                    KhachHangBUS.Sua(kh);
                }
                catch
                {
                    txtMaKH.Clear();
                    TrungMaKH = true;
                    goto SuaLai;
                }
                MessageBox.Show("Sửa thông tin nhân viên  thành công", "Thông báo");
                dtgDSKH.ItemsSource = KhachHangBUS.LoadDSKH().DefaultView;
                KhongChoNhap();
                btnLuu_Sua.Visibility = Visibility.Hidden;
                btnSua.Visibility = Visibility.Visible;
                btnThem.IsEnabled = btnXoa.IsEnabled = true;
                dtgDSKH.IsEnabled = true;
            }

        }

        private void btnHuy_Sua_Click(object sender, RoutedEventArgs e)
        {
            KhongChoNhap();
            btnLuu_Sua.Visibility = btnHuy_Sua.Visibility = Visibility.Hidden;
            btnSua.Visibility = Visibility.Visible;
            btnThem.IsEnabled = btnXoa.IsEnabled = true;
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
            if (cbbTimKiem.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: Mã Khách Hàng")
            {
                type_timkiem = 0;
            }
            else if (cbbTimKiem.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: Họ Tên Khách Hàng")
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
                             dtgDSKH.ItemsSource = KhachHangBUS.TimTheoMaKH(txtTimKiem.Text.ToString()).DefaultView;
                        }
                        break;
                    case 1:
                        {
                             dtgDSKH.ItemsSource = KhachHangBUS.TimTheoHoTen(txtTimKiem.Text.ToString()).DefaultView;
                        }
                        break;
                    case 2:
                        {
                             dtgDSKH.ItemsSource = KhachHangBUS.TimTheoSDT(txtTimKiem.Text.ToString()).DefaultView;
                        }
                        break;
                }
            }
            else if (txtTimKiem.Text.Length == 0)
            {
                 dtgDSKH.ItemsSource = KhachHangBUS.LoadDSKH().DefaultView;
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
                 dtgDSKH.ItemsSource = KhachHangBUS.LoadDSKH().DefaultView;
            }
        }

        private void btnLamMoi_Click(object sender, RoutedEventArgs e)
        {
            KhongChoNhap();
            dtgDSKH.ItemsSource = KhachHangBUS.LoadDSKH().DefaultView;
            panelTimKiem.Visibility = btnHuy_Sua.Visibility = Visibility.Hidden;
        }
    }
}
