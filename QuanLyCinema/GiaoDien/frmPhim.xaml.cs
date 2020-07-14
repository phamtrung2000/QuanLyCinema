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

namespace QuanLyCinema.LoaiPhim
{
    /// <summary>
    /// Interaction logic for frmPhim.xaml
    /// </summary>
    public partial class frmPhim : UserControl
    {
        public frmPhim()  
        {
            InitializeComponent();
        }

        List<PhimDTO> listPhim = new List<PhimDTO>();



        void Load_Data(DataTable dataTable)
        {
            dtgDSPhim.Items.Clear();
            dtgDSPhim.ItemsSource = null;
            listPhim = new List<PhimDTO>();
            for (int i = 0; i <= dataTable.Rows.Count - 1; i++)
            {
                object[] a = new object[9];
                a = dataTable.Rows[i].ItemArray;
                string stt = (i + 1).ToString();
                string maphim = a[1].ToString();
                string tenphim = a[2].ToString();
                string daodien = a[3].ToString();
                string dienvien = a[4].ToString();

                string theloai = null;
                DataTable dataTable_theloai = PhimBUS.LoadTheLoaiPhim(maphim);
                object[] b = new object[2];
                b = dataTable_theloai.Rows[0].ItemArray;
                theloai += b[1].ToString();
                for (int j = 0; j <= dataTable_theloai.Rows.Count - 1; j++)
                {
                    b = new object[2];
                    b = dataTable_theloai.Rows[j].ItemArray;
                    theloai += ", " + b[1].ToString();
                }

                string noidung = a[5].ToString();
                string namsx = a[6].ToString();
                string nuocsx = a[7].ToString();
                string thoiluong = a[8].ToString();


                listPhim.Add(new PhimDTO(stt, maphim, tenphim, daodien, dienvien,theloai, noidung, namsx,nuocsx, thoiluong));
                dtgDSPhim.Items.Add(listPhim[i]);
            }
        }

       
        bool Selected = false;

        void ChoPhepNhap()
        {
            txtMaPhim.IsReadOnly =txtTenPhim.IsReadOnly=txtDaoDien.IsReadOnly=txtDienVien.IsReadOnly=txtNoiDung.IsReadOnly
                =txtNuocSX.IsReadOnly=txtNamSX.IsReadOnly=txtThoiLuong.IsReadOnly= false;
            
            txtMaPhim.Focus();
            grpThongTinPhim.IsEnabled = true;
        }

        void KhongChoNhap()
        {
            txtMaPhim.Clear();
            txtTenPhim.Clear();
            txtDaoDien.Clear();
            txtDienVien.Clear();
            txtNoiDung.Clear();
            txtNamSX.Clear();
            txtNuocSX.Clear();
            txtThoiLuong.Clear();
          

            txtMaPhim.IsReadOnly = txtTenPhim.IsReadOnly = txtDaoDien.IsReadOnly = txtDienVien.IsReadOnly = txtNoiDung.IsReadOnly
            = txtNuocSX.IsReadOnly = txtNamSX.IsReadOnly = txtThoiLuong.IsReadOnly = true;
        }

        private void GridPhim_Loaded(object sender, RoutedEventArgs e)
        {
            KhongChoNhap();

            DataTable dataTable = new DataTable();
            dataTable = PhimBUS.LoadDSPhim();
            Load_Data(dataTable);

            panelTimKiem.Visibility = btnHuy_Sua.Visibility = Visibility.Hidden;
        }

        private void BtnThem_Click(object sender, RoutedEventArgs e)
        {
            frmAddPhim addPhim = new frmAddPhim();
            addPhim.ShowDialog();

            DataTable dataTable = new DataTable();
            dataTable = PhimBUS.LoadDSPhim();
            Load_Data(dataTable);
           
            KhongChoNhap();
            btnThem.Visibility = Visibility.Visible;
            btnSua.IsEnabled = btnXoa.IsEnabled = true;
        }

        private void BtnXoa_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa phim này không?", "Thông Báo", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                PhimBUS.Xoa(txtMaPhim.Text);
                MessageBox.Show("Xóa phim thành công", "Thông Báo");
            }
            DataTable dataTable = new DataTable();
            dataTable = PhimBUS.LoadDSPhim();
            Load_Data(dataTable);
        }

        private void BtnSua_Click(object sender, RoutedEventArgs e)
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
            }
        }

        private void BtnLuu_Sua_Click(object sender, RoutedEventArgs e)
        {
            bool TrungMaP = false;
        SuaLai:
            string maphim = null;
            if (txtMaPhim.Text.Length != 0)
            {
                maphim = txtMaPhim.Text;
            }
            string tenphim = null;
            if (txtTenPhim.Text.Length != 0)
            {
                tenphim = txtTenPhim.Text;
            }
            string daodien = null;
            if (txtDaoDien.Text.Length != 0)
            {
                daodien = txtDaoDien.Text;
            }
            string dienvien = null;
            if (txtDienVien.Text.Length != 0)
            {
                dienvien = txtDienVien.Text;
            }
            string noidung = null;
            if (txtNoiDung.Text.Length != 0)
            {
                noidung = txtNoiDung.Text;
            }
            string namsx = null;
            if (txtNamSX.Text.Length != 0)
            {
                namsx = txtNamSX.Text;
            }
            string nuocsx = null;
            if (txtNuocSX.Text.Length != 0)
            {
                nuocsx = txtNuocSX.Text;
            }
            string thoiluong = null;
            if (txtThoiLuong.Text.Length != 0)
            {
                thoiluong = txtThoiLuong.Text;
            }


            PhimDTO phim = new PhimDTO(maphim, tenphim, daodien, dienvien, noidung, namsx, nuocsx, thoiluong);


            if (maphim == null)
            {
                if (TrungMaP == false)
                {
                    MessageBox.Show("Mã phim không được để trống");
                }
                else
                {
                    MessageBox.Show("Mã phim bị trùng");
                }
                txtMaPhim.Focus();
            }
            else if (tenphim == null)
            {
                MessageBox.Show("Tên phim không được để trống");
            }
            else if (daodien == null)
            {
                MessageBox.Show("Đạo diễn không được để trống");
                txtDaoDien.Focus();
            }
            else if (dienvien == null)
            {
                MessageBox.Show("Diễn viên không được để trống");
                txtDienVien.Focus();
            }
            else if (noidung == null)
            {
                MessageBox.Show("Nội dung không được để trống");
                txtNoiDung.Focus();
            }
            else if (namsx == null)
            {
                MessageBox.Show("Địa chỉ không được để trống");
                txtNamSX.Focus();
            }

            else if (nuocsx == null)
            {
                MessageBox.Show("Lương không được để trống");
                txtNuocSX.Focus();
            }
            else if (thoiluong == null)
            {
                MessageBox.Show("Thời lượng phim không được để trống");
                txtThoiLuong.Focus();
            }
            else
            {
                try
                {
                    PhimBUS.Sua(phim);
                }
                catch
                {
                    txtMaPhim.Clear();
                    TrungMaP = true;
                    goto SuaLai;
                }
                MessageBox.Show("Sửa thông tin phim  thành công", "Thông báo");

                DataTable dataTable = new DataTable();
                dataTable = PhimBUS.LoadDSPhim();
                Load_Data(dataTable);

                KhongChoNhap();
                btnHuy_Sua.Visibility = btnLuu_Sua.Visibility = Visibility.Hidden;
                btnSua.Visibility = Visibility.Visible;
                btnThem.IsEnabled = btnXoa.IsEnabled = true;
                dtgDSPhim.IsEnabled = true;
                Selected = false;
            }
        }

        private void BtnHuy_Sua_Click(object sender, RoutedEventArgs e)
        {
            KhongChoNhap();
            btnLuu_Sua.Visibility = btnHuy_Sua.Visibility = Visibility.Hidden;
            btnSua.Visibility = Visibility.Visible;
            btnThem.IsEnabled = btnXoa.IsEnabled = true;
        }

        private void BtnLamMoi_Click(object sender, RoutedEventArgs e)
        {
            KhongChoNhap();

            DataTable dataTable = new DataTable();
            dataTable = PhimBUS.LoadDSPhim();
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
        
        private void BtnTimKiem_Click(object sender, RoutedEventArgs e)
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
        private void CbbTimKiem_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (txtTimKiem.Text != "" || txtTimKiem.Text != "Tìm Kiếm...")
                txtTimKiem.Text = "";
            if (cbbTimKiem.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: Mã Phim")
            {
                type_timkiem = 0;
            }
            else if (cbbTimKiem.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: Tên Phim")
            {
                type_timkiem = 1;
            }
            txtTimKiem.Focus();
        }

        private void TxtTimKiem_TextChanged(object sender, TextChangedEventArgs e)
        {
            DataTable dataTable = new DataTable();
            if (txtTimKiem.Text.Length >= 1 && txtTimKiem.Text != "Tìm Kiếm...")
            {
                switch (type_timkiem)
                {
                    case 0:
                        {
                            dataTable = PhimBUS.TimTheoMaP(txtTimKiem.Text.ToString());
                        }
                        break;
                    case 1:
                        {
                            dataTable = PhimBUS.TimTheoTenPhim(txtTimKiem.Text.ToString());
                        }
                        break;

                }
            }
            else if (txtTimKiem.Text.Length == 0)
            {
                dataTable = PhimBUS.LoadDSPhim();
            }
            Load_Data(dataTable);
        }

        private void TxtTimKiem_GotFocus(object sender, RoutedEventArgs e)
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

        private void TxtTimKiem_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                txtTimKiem.Text = "Tìm Kiếm...";
                DataTable dataTable = new DataTable();
                dataTable = PhimBUS.LoadDSPhim();
                Load_Data(dataTable);
            }
        }

        private void dtgDSPhim_MouseUp(object sender, MouseButtonEventArgs e)
        {
            int index = dtgDSPhim.SelectedIndex;
            if (index >= 0) // tránh lỗi click vẫn trong datagrid nhưng mà click chỗ k có dòng nào
            {
                Selected = true;
                PhimDTO nv = dtgDSPhim.SelectedItem as PhimDTO;
                txtMaPhim.Text = nv.MaPhim;
                txtTenPhim.Text = nv.TenPhim;
                txtDaoDien.Text = nv.DaoDien;
                txtDienVien.Text = nv.DienVien;
                txtNoiDung.Text = nv.NoiDung;
                txtNamSX.Text = nv.NamSX;
                txtNuocSX.Text = nv.NuocSX;
                txtThoiLuong.Text = nv.ThoiLuong;
            }
        }
    }
}
