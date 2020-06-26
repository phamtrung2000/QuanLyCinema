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
using System.Globalization;
using System.Threading;
using System.Net.Http;
using System.Net.Http.Headers;

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

        string Money(string money) // chuyển từ 100000.00 hay thành 100.000 ( nhìn cho đẹp )
        {
            int n = money.Length;
            string kq = "";
            for (int i = n - 1; i >= 3; i -= 3)
            {
                kq = kq.Insert(0, money.Substring(i - 2, 3));
                // kq = 000
                kq = kq.Insert(0, ".");
                // .000
                money = money.Remove(i - 2, 3);
            }
            kq = kq.Insert(0, money);
            return kq;
        }

        string ReMoney(string money)
        {
            string kq = money;
            for (int i = 0; i < kq.Length; i++)
            {
                if (kq[i] == '.')
                    kq = kq.Remove(i, 1);
            }
            return kq;
        }
      
        List<NhanVienDTO> listnhanVien = new List<NhanVienDTO>();

        void Load_Data(DataTable dataTable)
        {
           // dtgDSNV.Items.Clear();
            dtgDSNV.ItemsSource = null;
            listnhanVien = new List<NhanVienDTO>();
            for (int i = 0; i <= dataTable.Rows.Count - 1; i++)
            {
                object[] a = new object[10];
                a = dataTable.Rows[i].ItemArray;
                string stt = a[0].ToString();
                string manv = a[1].ToString();
                string hoten = a[2].ToString();
                string chucvu = a[3].ToString();
                string sdt = a[4].ToString();
                string gioitinh = a[5].ToString();

                DateTime ngaysinh_temp = DateTime.Parse(a[6].ToString());
                string ngaysinh = ngaysinh_temp.Day.ToString() + "/" + ngaysinh_temp.Month.ToString() + "/" + ngaysinh_temp.Year.ToString();

                string diachi = a[7].ToString();

                string luong = a[8].ToString();
                double luong1 = double.Parse(luong);
                luong = Money(luong1.ToString());

                DateTime ngayvl_temp = DateTime.Parse(a[9].ToString());
                string ngayvl = ngayvl_temp.Day.ToString() + "/" + ngayvl_temp.Month.ToString() + "/" + ngayvl_temp.Year.ToString();

                listnhanVien.Add(new NhanVienDTO(stt, manv, hoten, chucvu, sdt, gioitinh, ngaysinh, diachi, luong, ngayvl));
               // dtgDSNV.Items.Add(listnhanVien[i]);
            }
            dtgDSNV.ItemsSource = listnhanVien;
            //rowcount = dataTable.Rows.Count;
        }

        bool Selected = false;

        void ChoPhepNhap()
        {
            txtHoTen.IsReadOnly = txtMaNV.IsReadOnly = txtChucVu.IsReadOnly = txtSDT.IsReadOnly = txtDiaChi.IsReadOnly = txtLuong.IsReadOnly = false;
            dtpNgaySinh.IsEnabled = dtpNgayVL.IsEnabled = true;
            rdbNam.IsEnabled = rdbNu.IsEnabled = true;
            txtHoTen.Focus();
            grpThongTinNV.IsEnabled = true;
        }

        void KhongChoNhap()
        {
            txtHoTen.Clear();
            txtMaNV.Clear();
            txtChucVu.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            txtLuong.Clear();
            txtNgaySinh.Clear();
            txtNgayVL.Clear();

            rdbNam.IsChecked = rdbNu.IsChecked = false;

            txtHoTen.IsReadOnly = txtMaNV.IsReadOnly = txtChucVu.IsReadOnly = txtSDT.IsReadOnly
            = txtDiaChi.IsReadOnly = txtLuong.IsReadOnly = txtNgaySinh.IsReadOnly = txtNgayVL.IsReadOnly = true;

            dtpNgayVL.Visibility = dtpNgaySinh.Visibility = Visibility.Hidden;
            txtNgayVL.Visibility = txtNgaySinh.Visibility = Visibility.Visible;
            dtpNgaySinh.IsEnabled = dtpNgayVL.IsEnabled = false;
            rdbNam.IsEnabled = rdbNu.IsEnabled = false;
            rdbNam.Opacity = 100;
            rdbNu.Opacity = 100;

          
        }

        private void GridNhanVien_Loaded(object sender, RoutedEventArgs e)
        {
            dtpNgaySinh.Visibility = dtpNgayVL.Visibility = Visibility.Hidden;
            KhongChoNhap();

            // Gọi Get => trả về IEnumerable<NhanVienDTO> hiển thị lên DataGridView
            Refresh();

            panelTimKiem.Visibility = btnHuy_Sua.Visibility = Visibility.Hidden;
        }

        string ngaythangnamsinh = null, ngaythangnamvaolam = null;

        private void dtgDSNV_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // khúc này dr null vì nó ko phải datarowview mà là 1 nhân viên dto

            //DataGrid dg = sender as DataGrid;
            //DataRowView dr = dg.SelectedItem as DataRowView;
            //if (dr != null) 
            //{
            //    txtMaNV.Text = dr["Mã nhân viên"].ToString();
            //    txtHoTen.Text = dr["Họ tên"].ToString();
            //    txtChucVu.Text = dr["Chức vụ"].ToString();
            //    txtSDT.Text = dr["SĐT"].ToString();

            //    string gioitinh = dr["Giới tính"].ToString();
            //    if (gioitinh == "Nam")
            //        rdbNam.IsChecked = true;
            //    else if (gioitinh == "Nữ")
            //        rdbNu.IsChecked = true;

            //    dtpNgaySinh.SelectedDate = DateTime.Parse(dr["Ngày sinh"].ToString());
            //    txtDiaChi.Text = dr["Địa chỉ"].ToString();
            //    txtLuong.Text = dr["Lương (VND)"].ToString();
            //    dtpNgayVL.SelectedDate = DateTime.Parse(dr["Ngày vào làm"].ToString());
            //}

            //Selected = true;
            //NhanVienDTO nv = dtgDSNV.SelectedItem as NhanVienDTO;
            //txtMaNV.Text = nv.MaNV;
            //txtHoTen.Text = nv.HoTen;
            //txtChucVu.Text = nv.ChucVu;
            //txtSDT.Text = nv.SDT;
            //string gioitinh = nv.GioiTinh;
            //if (gioitinh == "Nam")
            //    rdbNam.IsChecked = true;
            //else if (gioitinh == "Nữ")
            //    rdbNu.IsChecked = true;

            //ngaythangnamsinh = txtNgaySinh.Text = nv.NgaySinh_String;
            //ngaythangnamvaolam = txtNgayVL.Text = nv.NgayVL_String;

            //txtDiaChi.Text = nv.DiaChi;
            //txtLuong.Text = nv.Luong;
           
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            frmAddNhanVien addNhanVien = new frmAddNhanVien();
            addNhanVien.ShowDialog();

            Refresh();

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
            DataTable dataTable = new DataTable();
            dataTable = NhanVienBUS.LoadDSNV();
            Load_Data(dataTable);
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
                MessageBox.Show("Bạn chưa chọn nhân viên để sửa thông tin");
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

                txtNgayVL.Visibility = Visibility.Hidden;
                dtpNgayVL.Visibility = Visibility.Visible;
                dtpNgayVL.SelectedDate = DateTime.Parse(ThangTruocNgaySau(ngaythangnamvaolam) + " 12:00:00 AM");
            }
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
                luong = ReMoney(luong);
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

                DataTable dataTable = new DataTable();
                dataTable = NhanVienBUS.LoadDSNV();
                Load_Data(dataTable);

                KhongChoNhap();
                btnHuy_Sua.Visibility = btnLuu_Sua.Visibility = Visibility.Hidden;
                btnSua.Visibility = Visibility.Visible;
                btnThem.IsEnabled = btnXoa.IsEnabled = true;
                dtgDSNV.IsEnabled = true;
                Selected = false;
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
            if (txtTimKiem.Text != "" || txtTimKiem.Text != "Tìm Kiếm...")
                txtTimKiem.Text = "";
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
            txtTimKiem.Focus();
        }

        private void txtTimKiem_TextChanged(object sender, TextChangedEventArgs e)
        {
            DataTable dataTable = new DataTable();
            if (txtTimKiem.Text.Length > 1 && txtTimKiem.Text!= "Tìm Kiếm...")
            {
                switch (type_timkiem)
                {
                    case 0:
                        {
                            dataTable = NhanVienBUS.TimTheoMaNV(txtTimKiem.Text.ToString());
                        }
                        break;
                    case 1:
                        {
                            dataTable = NhanVienBUS.TimTheoHoTen(txtTimKiem.Text.ToString());
                        }
                        break;
                    case 2:
                        {
                            dataTable = NhanVienBUS.TimTheoSDT(txtTimKiem.Text.ToString());
                        }
                        break;
                }
            }
            else if (txtTimKiem.Text.Length == 0)
            {
                dataTable = NhanVienBUS.LoadDSNV();
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
            {
                txtTimKiem.Text = "";
            }
                
        }

        private void txtTimKiem_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                txtTimKiem.Text = "Tìm Kiếm...";
                DataTable dataTable = new DataTable();
                dataTable = NhanVienBUS.LoadDSNV();
                Load_Data(dataTable);
            }
        }

        private void btnHuy_Sua_Click(object sender, RoutedEventArgs e)
        {
            KhongChoNhap();
            btnLuu_Sua.Visibility = btnHuy_Sua.Visibility = Visibility.Hidden;
            btnSua.Visibility = Visibility.Visible;
            btnThem.IsEnabled = btnXoa.IsEnabled = true;
        }

        private void dtgDSNV_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Selected = true;
            NhanVienDTO nv = dtgDSNV.SelectedItem as NhanVienDTO;
            txtMaNV.Text = nv.MaNV;
            txtHoTen.Text = nv.HoTen;
            txtChucVu.Text = nv.ChucVu;
            txtSDT.Text = nv.SDT;
            string gioitinh = nv.GioiTinh;
            if (gioitinh == "Nam")
                rdbNam.IsChecked = true;
            else if (gioitinh == "Nữ")
                rdbNu.IsChecked = true;

            ngaythangnamsinh = txtNgaySinh.Text = nv.NgaySinh_String;
            ngaythangnamvaolam = txtNgayVL.Text = nv.NgayVL_String;

            txtDiaChi.Text = nv.DiaChi;
            txtLuong.Text = nv.Luong;
        }

        private void btnLamMoi_Click(object sender, RoutedEventArgs e)
        {
            KhongChoNhap();

            DataTable dataTable = new DataTable();
            dataTable = NhanVienBUS.LoadDSNV();
            Load_Data(dataTable);

            panelTimKiem.Visibility = btnHuy_Sua.Visibility =btnLuu_Sua.Visibility= Visibility.Hidden;
            if(btnSua.Visibility==Visibility.Hidden)
            {
                btnSua.Visibility = Visibility.Visible;
            }
            if(btnThem.IsEnabled==btnXoa.IsEnabled==false)
            {
                btnThem.IsEnabled = btnXoa.IsEnabled = true;
            }
        }

        //---------------------------Helper-----------------------------//
        private void Refresh()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44373/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.GetAsync("api/nhanvien").Result;
                if (response.IsSuccessStatusCode)
                {
                    var list_nv = response.Content.ReadAsAsync<IEnumerable<NhanVienDTO>>().Result;
                    dtgDSNV.ItemsSource = list_nv;
                }
            }
        }
    }
}
