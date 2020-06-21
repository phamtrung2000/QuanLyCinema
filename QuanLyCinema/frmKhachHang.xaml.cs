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

        List<KhachHangDTO> listkhachhang = new List<KhachHangDTO>();

        void Load_Data(DataTable dataTable)
        {
            dtgDSKH.ItemsSource = null;
            listkhachhang = new List<KhachHangDTO>();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                object[] a = new object[9];
                a = dataTable.Rows[i].ItemArray;
               // string stt = a[0].ToString();
                string stt = (i+1).ToString();
                string makh = a[1].ToString();
                string hoten = a[2].ToString();
                string diachi = a[3].ToString();

                DateTime ngaysinh_temp = DateTime.Parse(a[4].ToString());
                string ngaysinh = ngaysinh_temp.Day.ToString() + "/" + ngaysinh_temp.Month.ToString() + "/" + ngaysinh_temp.Year.ToString();

                string gioitinh = a[5].ToString();
                
                string sdt = a[6].ToString();
                string loaikh = a[7].ToString();
               
                DateTime ngaydk_temp = DateTime.Parse(a[8].ToString());
                string ngaydk = ngaydk_temp.Day.ToString() + "/" + ngaydk_temp.Month.ToString() + "/" + ngaydk_temp.Year.ToString();

                listkhachhang.Add(new KhachHangDTO(stt, makh, hoten, diachi, ngaysinh, gioitinh, sdt ,loaikh, ngaydk));
            }
            dtgDSKH.ItemsSource = listkhachhang;
        }

        bool Selected = false;

        void ChoPhepNhap()
        {
            txtHoTen.IsReadOnly = txtMaKH.IsReadOnly = txtSDTKH.IsReadOnly = txtDiachiKH.IsReadOnly = txtLoaiKH.IsReadOnly = false;
            dtpNgaySinh.IsEnabled = dtpNgayDK.IsEnabled = true;
            rdbNam.IsEnabled = rdbNu.IsEnabled = true;
            txtHoTen.Focus();
            grpThongTinKH.IsEnabled = true;
        }

        void KhongChoNhap()
        {
            txtMaKH.Clear();
            txtHoTen.Clear();         
            txtSDTKH.Clear();
            txtDiachiKH.Clear();
            txtLoaiKH.Clear();
            txtNgayDK.Clear();
            txtNgaySinh.Clear();

            rdbNam.IsChecked = rdbNu.IsChecked = false;

            txtHoTen.IsReadOnly = txtMaKH.IsReadOnly = txtSDTKH.IsReadOnly = txtNgayDK.IsReadOnly = txtNgaySinh.IsReadOnly 
            = txtDiachiKH.IsReadOnly = txtLoaiKH.IsReadOnly = true;

            dtpNgayDK.Visibility = dtpNgaySinh.Visibility = Visibility.Hidden;
            txtNgayDK.Visibility = txtNgaySinh.Visibility = Visibility.Visible;
            dtpNgaySinh.IsEnabled = dtpNgayDK.IsEnabled = false;
            rdbNam.IsEnabled = rdbNu.IsEnabled = false;
            rdbNam.Opacity = 100;
            rdbNu.Opacity = 100;
        }

        private void GridKhachHang_Loaded(object sender, RoutedEventArgs e)
        {
            dtpNgaySinh.Visibility = dtpNgayDK.Visibility = Visibility.Hidden;


            KhongChoNhap();

            DataTable dataTable = new DataTable();
            dataTable = KhachHangBUS.LoadDSKH();
            Load_Data(dataTable);

            panelTimKiem.Visibility = btnHuy_Sua.Visibility = Visibility.Hidden;
        }

        string ngaythangnamsinh = null, ngaythangnamdangky = null;

        private void DtgDSKH_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        //    DataGrid dg = sender as DataGrid;
        //    DataRowView dr = dg.SelectedItem as DataRowView;
        //    if (dr != null)
        //    {

        //        txtMaKH.Text = dr["MAKH"].ToString();
        //        txtHoTen.Text = dr["HOTEN"].ToString();
        //        txtDiachiKH.Text = dr["DIACHI"].ToString();
        //        string gioitinh = dr["GIOITINH"].ToString();
        //        if (gioitinh == "Nam")
        //            rdbNam.IsChecked = true;
        //        else if (gioitinh == "Nữ")
        //            rdbNu.IsChecked = true;
        //        dtpNgaySinh.SelectedDate = DateTime.Parse(dr["NGAYSINH"].ToString());

        //        //ngay sinh
        //        //dtpNgaySinh.SelectedDate = DateTime.Parse(dr["NGAYSINH"].ToString());

        //        txtSDTKH.Text = dr["SDT"].ToString();
        //        txtLoaiKH.Text = dr["LOAIKH"].ToString();
        //        dtpNgayDK.SelectedDate = DateTime.Parse(dr["NGAYDK"].ToString());
        //    }
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            frmAddKhachHang addKhachHang = new frmAddKhachHang();
            addKhachHang.ShowDialog();

            DataTable dataTable = new DataTable();
            dataTable = KhachHangBUS.LoadDSKH();
            Load_Data(dataTable);

            KhongChoNhap();
            btnThem.Visibility = Visibility.Visible;
            btnSua.IsEnabled = btnXoa.IsEnabled = true;
        }

        private string ThangTruocNgaySau(string a)
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
        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            if (Selected == false)
                MessageBox.Show("Bạn chưa chọn khách hàng để sửa thông tin");
            else
            {
                ChoPhepNhap();
                btnLuu_Sua.Visibility = Visibility.Visible;
                btnHuy_Sua.Visibility = Visibility.Visible;
                btnSua.Visibility = Visibility.Hidden;
                btnThem.IsEnabled = btnXoa.IsEnabled = false;

                txtNgaySinh.Visibility = Visibility.Hidden;
                dtpNgaySinh.Visibility = Visibility.Visible;
                dtpNgaySinh.SelectedDate = DateTime.Parse(ThangTruocNgaySau(ngaythangnamsinh) + " 12:00:00 AM");

                txtNgayDK.Visibility = Visibility.Hidden;
                dtpNgayDK.Visibility = Visibility.Visible;
                dtpNgayDK.SelectedDate = DateTime.Parse(ThangTruocNgaySau(ngaythangnamdangky) + " 12:00:00 AM");
            }
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này không?", "Thông Báo", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                KhachHangBUS.Xoa(txtMaKH.Text);
                MessageBox.Show("Xóa khách hàng thành công", "Thông Báo");
            }
            DataTable dataTable = new DataTable();
            dataTable = KhachHangBUS.LoadDSKH();
            Load_Data(dataTable);
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
            if (txtHoTen.Text.Length != 0)
            {
                hoten = txtHoTen.Text;
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
                txtHoTen.Focus();
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
                MessageBox.Show("Sửa thông tin khách hàng thành công", "Thông báo");

                DataTable dataTable = new DataTable();
                dataTable = KhachHangBUS.LoadDSKH();
                Load_Data(dataTable);

                KhongChoNhap();
                btnHuy_Sua.Visibility = btnLuu_Sua.Visibility = Visibility.Hidden;
                btnSua.Visibility = Visibility.Visible;
                btnThem.IsEnabled = btnXoa.IsEnabled = true;
                dtgDSKH.IsEnabled = true;
                Selected = false;
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
            if (txtTimKiem.Text != "" || txtTimKiem.Text != "Tìm Kiếm...")
                txtTimKiem.Text = "";
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
            txtTimKiem.Focus();
        }

      

        private void txtTimKiem_TextChanged(object sender, TextChangedEventArgs e)
        {
            DataTable dataTable = new DataTable();
            if (txtTimKiem.Text.Length > 1 && txtTimKiem.Text != "Tìm Kiếm...")
            {
                switch (type_timkiem)
                {
                    case 0:
                        {
                            dataTable = KhachHangBUS.TimTheoMaKH(txtTimKiem.Text.ToString());
                        }
                        break;
                    case 1:
                        {
                            dataTable = KhachHangBUS.TimTheoHoTen(txtTimKiem.Text.ToString());
                        }
                        break;
                    case 2:
                        {
                            dataTable = KhachHangBUS.TimTheoSDT(txtTimKiem.Text.ToString());
                        }
                        break;
                }
            }
            else if (txtTimKiem.Text.Length == 0)
            {
                dataTable = KhachHangBUS.LoadDSKH();
            }
            Load_Data(dataTable);
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
                DataTable dataTable = new DataTable();
                dataTable = KhachHangBUS.LoadDSKH();
                Load_Data(dataTable);
            }
        }

        private void btnLamMoi_Click(object sender, RoutedEventArgs e)
        {
            KhongChoNhap();

            DataTable dataTable = new DataTable();
            dataTable = KhachHangBUS.LoadDSKH();
            Load_Data(dataTable);

            panelTimKiem.Visibility = btnHuy_Sua.Visibility = btnLuu_Sua.Visibility = Visibility.Hidden;
            if (btnSua.Visibility == Visibility.Hidden)
            {
                btnSua.Visibility = Visibility.Visible;
            }
            if (btnThem.IsEnabled == btnXoa.IsEnabled == false)
            {
                btnThem.IsEnabled = btnXoa.IsEnabled = true;
            }
        }

        private void dtgDSKH_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Selected = true;
            KhachHangDTO nv = dtgDSKH.SelectedItem as KhachHangDTO;
            txtMaKH.Text = nv.MaKH;
            txtHoTen.Text = nv.HoTen;
            txtDiachiKH.Text = nv.DiaChi;
            ngaythangnamsinh = txtNgaySinh.Text = nv.NgaySinh_String;
            string gioitinh = nv.GioiTinh;
            if (gioitinh == "Nam")
                rdbNam.IsChecked = true;
            else if (gioitinh == "Nữ")
                rdbNu.IsChecked = true;
            txtSDTKH.Text = nv.SDT;
            txtLoaiKH.Text = nv.LoaiKH;
            ngaythangnamdangky = txtNgayDK.Text = nv.NgayDK_String;
        }
    }
}
