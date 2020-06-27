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
using QuanLyCinema.NguoiDung;

namespace QuanLyCinema.GiaoDien
{
    /// <summary>
    /// Interaction logic for frmNguoiDung.xaml
    /// </summary>
    public partial class frmNguoiDung : UserControl
    {
        public frmNguoiDung()
        {
            InitializeComponent();
        }

        void ChoPhepNhap()
        {
            txtHoTen.IsReadOnly = txtMaND.IsReadOnly = txtChucVu.IsReadOnly = txtPhanQuyen.IsReadOnly = false;
            txtHoTen.Focus();
            grpThongTinNguoiDung.IsEnabled = true;
        }

        void KhongChoNhap()
        {
            txtHoTen.Clear();
            txtMaND.Clear();
            txtChucVu.Clear();
            txtPhanQuyen.Clear();

            txtHoTen.IsReadOnly = txtMaND.IsReadOnly = txtChucVu.IsReadOnly = txtPhanQuyen.IsReadOnly = true;
        }

        List<NguoiDungDTO> listNguoiDung = new List<NguoiDungDTO>();

        void Load_Data(DataTable dataTable)
        {
            dtgDSND.Items.Clear(); // có dòng này đề sau khi thêm nó k thêm đè lên 5 dòng thành 10 dòng
            dtgDSND.ItemsSource = null; // như trên
            listNguoiDung = new List<NguoiDungDTO>();
            for (int i = 0; i <= dataTable.Rows.Count - 1; i++)
            {
                object[] a = new object[5];
                a = dataTable.Rows[i].ItemArray;
                string stt = a[0].ToString();
                string manv = a[1].ToString();
                string hoten = a[2].ToString();
                string chucvu = a[3].ToString();
                string phanquyen = a[4].ToString();

                listNguoiDung.Add(new NguoiDungDTO(stt, manv, hoten, chucvu,phanquyen));
                dtgDSND.Items.Add(listNguoiDung[i]);
            //    dtgDSND.ItemsSource = listNguoiDung; // có dòng này là hư chương trình
            }
           // dtgDSND.ItemsSource = listNguoiDung;
            //rowcount = dataTable.Rows.Count;
        }

        private void GridNguoiDung_Loaded(object sender, RoutedEventArgs e)
        {
            KhongChoNhap();
            DataTable dataTable = new DataTable();
            dataTable = NguoiDungBUS.LoadDSND();
            Load_Data(dataTable);

            panelTimKiem.Visibility = btnHuy_Sua.Visibility = Visibility.Hidden;
        }

        bool Selected = false;
        
        private void dtgDSND_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //DataGrid dg = sender as DataGrid;
            //DataRowView dr = dg.SelectedItem as DataRowView;
            //if (dr != null)
            //{
            //    txtMaND.Text = dr["MAND"].ToString();
            //    txtHoTen.Text = dr["HOTEN"].ToString();
            //    txtChucVu.Text = dr["CHUCVU"].ToString();
            //    txtPhanQuyen.Text = dr["PHANQUYEN"].ToString();

            //}
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            frmAddNguoiDung frmAddNguoiDung = new frmAddNguoiDung();
            frmAddNguoiDung.ShowDialog();

            DataTable dataTable = new DataTable();
            dataTable = NguoiDungBUS.LoadDSND();
            Load_Data(dataTable);

            KhongChoNhap();
            btnThem.Visibility = Visibility.Visible;
            btnSua.IsEnabled = btnXoa.IsEnabled = true;
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa người dùng này không?", "Thông Báo", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                NguoiDungBUS.Xoa(txtMaND.Text);
                MessageBox.Show("Xóa người dùng thành công", "Thông Báo");
            }
            DataTable dataTable = new DataTable();
            dataTable = NguoiDungBUS.LoadDSND();
            Load_Data(dataTable);
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
            }
        }

        private void btnLuu_Sua_Click(object sender, RoutedEventArgs e)
        {
            bool TrungMaND = false;
        SuaLai:
            string mand = null;
            if (txtMaND.Text.Length != 0)
            {
                mand = txtMaND.Text;
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
            string phanquyen = null;
            if (txtPhanQuyen.Text.Length != 0)
            {
                phanquyen = txtPhanQuyen.Text;
            }

            NguoiDungDTO nv = new NguoiDungDTO(mand, hoten, chucvu, phanquyen);

            if (mand == null)
            {
                if (TrungMaND == false)
                {
                    MessageBox.Show("Mã số người dùng không được để trống");
                }
                else
                {
                    MessageBox.Show("Mã số người dùng bị trùng");
                }
                txtMaND.Focus();
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
            else if (phanquyen == null)
            {
                MessageBox.Show("Phân quyền không được để trống");
                txtPhanQuyen.Focus();
            }
            else
            {
                try
                {
                    NguoiDungBUS.Sua(nv);
                }
                catch
                {
                    txtMaND.Clear();
                    TrungMaND = true;
                    goto SuaLai;
                }
                MessageBox.Show("Sửa thông tin người dùng  thành công", "Thông báo");

                DataTable dataTable = new DataTable();
                dataTable = NguoiDungBUS.LoadDSND();
                Load_Data(dataTable);

                KhongChoNhap();
                btnLuu_Sua.Visibility = Visibility.Hidden;
                btnSua.Visibility = Visibility.Visible;
                btnThem.IsEnabled = btnXoa.IsEnabled = true;
                dtgDSND.IsEnabled = true;
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
            if (cbbTimKiem.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: Mã Người Dùng")
            {
                type_timkiem = 0;
            }
            else if (cbbTimKiem.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: Họ Tên")
            {
                type_timkiem = 1;
            }
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
                            dataTable = NguoiDungBUS.TimTheoMaND(txtTimKiem.Text.ToString());
                        }
                        break;
                    case 1:
                        {
                            dataTable = NguoiDungBUS.TimTheoHoTenNguoiDung(txtTimKiem.Text.ToString());
                        }
                        break;
                }
            }
            else if (txtTimKiem.Text.Length == 0)
            {
                dataTable = NguoiDungBUS.LoadDSND();
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
                dataTable = NguoiDungBUS.LoadDSND();
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

        private void btnLamMoi_Click(object sender, RoutedEventArgs e)
        {
            KhongChoNhap();
            DataTable dataTable = new DataTable();
            dataTable = NguoiDungBUS.LoadDSND();
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

        private void dtgDSND_MouseUp(object sender, MouseButtonEventArgs e)
        {
            int index = dtgDSND.SelectedIndex;
            if (index >= 0) // tránh lỗi click vẫn trong datagrid nhưng mà click chỗ k có dòng nào
            {
                Selected = true;
                NguoiDungDTO nv = dtgDSND.SelectedItem as NguoiDungDTO;
                txtMaND.Text = nv.MaND;
                txtHoTen.Text = nv.HoTen;
                txtChucVu.Text = nv.ChucVu;
                txtPhanQuyen.Text = nv.PhanQuyen;
            }    
                
        }
    }
}
