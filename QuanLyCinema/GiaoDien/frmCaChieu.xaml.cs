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
using QuanLyCinema.CaChieu;
using DTO;

namespace QuanLyCinema.GiaoDien
{
    public partial class frmCaChieu : UserControl
    {
        public frmCaChieu()
        {
            InitializeComponent();
        }

        List<CaChieuDTO> listnhanVien = new List<CaChieuDTO>();

        void Load_Data(DataTable dataTable)
        {
            dtgDSCaChieu.Items.Clear();
            dtgDSCaChieu.ItemsSource = null;
            listnhanVien = new List<CaChieuDTO>();
            for (int i = 0; i <= dataTable.Rows.Count - 1; i++)
            {
                object[] a = new object[5];
                a = dataTable.Rows[i].ItemArray;
                string stt = (i + 1).ToString();
                string macc = a[1].ToString();
                string tencc = a[2].ToString();

                DateTime batdau_temp = DateTime.Parse(a[3].ToString());
               // string batdau = batdau_temp.Hour.ToString() + ":" + batdau_temp.Minute.ToString() + ":" + batdau_temp.Second.ToString();
                string batdau = batdau_temp.TimeOfDay.ToString();

                DateTime kethuc_temp = DateTime.Parse(a[4].ToString());
              //  string ketthuc = kethuc_temp.Hour.ToString() + ":" + kethuc_temp.Minute.ToString() + ":" + kethuc_temp.Second.ToString();
                string ketthuc = kethuc_temp.TimeOfDay.ToString();

                listnhanVien.Add(new CaChieuDTO(stt, macc, tencc, batdau, ketthuc));
                dtgDSCaChieu.Items.Add(listnhanVien[i]);
            }
        }

        bool Selected = false;

        void ChoPhepNhap()
        {
            txtMaCC.IsReadOnly = txtTenCC.IsReadOnly = txtBatdau.IsReadOnly = txtKetthuc.IsReadOnly = false;
            txtMaCC.Focus();
            grpThongTinCaChieu.IsEnabled = true;
        }

        void KhongChoNhap()
        {
            txtTenCC.Clear();
            txtMaCC.Clear();
            txtBatdau.Clear();
            txtKetthuc.Clear();

            txtTenCC.IsReadOnly = txtMaCC.IsReadOnly = txtBatdau.IsReadOnly = txtKetthuc.IsReadOnly = true;
        }

        private void GridCaChieu_Loaded(object sender, RoutedEventArgs e)
        {
            KhongChoNhap();

            DataTable dataTable = new DataTable();
            dataTable = CaChieuBUS.LoadDSCaChieu();
            Load_Data(dataTable);

            panelTimKiem.Visibility = btnHuy_Sua.Visibility = Visibility.Hidden;
        }

        private void BtnThem_Click(object sender, RoutedEventArgs e)
        {
            frmAddCaChieu addCaChieu = new frmAddCaChieu();
            addCaChieu.ShowDialog();

            DataTable dataTable = new DataTable();
            dataTable = CaChieuBUS.LoadDSCaChieu();
            Load_Data(dataTable);

            KhongChoNhap();
            btnThem.Visibility = Visibility.Visible;
            btnSua.IsEnabled = btnXoa.IsEnabled = true;
        }

        private void BtnSua_Click(object sender, RoutedEventArgs e)
        {
            if (Selected == false)
                MessageBox.Show("Bạn chưa chọn ca chiếu để sửa thông tin");
            else
            {
                ChoPhepNhap();
                btnLuu_Sua.Visibility = Visibility.Visible;
                btnHuy_Sua.Visibility = Visibility.Visible;
                btnSua.Visibility = Visibility.Hidden;
                btnThem.IsEnabled = btnXoa.IsEnabled = false;
            }
        }

        private void BtnXoa_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa ca chiếu này không?", "Thông Báo", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                CaChieuBUS.Xoa(txtMaCC.Text);
                MessageBox.Show("Xóa ca chiếu thành công", "Thông Báo");
            }
            DataTable dataTable = new DataTable();
            dataTable = CaChieuBUS.LoadDSCaChieu();
            Load_Data(dataTable);
        }

        private void BtnLuu_Sua_Click(object sender, RoutedEventArgs e)
        {
            bool TrungMaCC = false;
        SuaLai:
            string macc = null;
            if (txtMaCC.Text.Length != 0)
            {
                macc = txtMaCC.Text;
            }
            string tencc = null;
            if (txtTenCC.Text.Length != 0)
            {
                tencc = txtTenCC.Text;
            }

            string batdau = null;
            if (txtBatdau.Text.Length != 0)
            {
                batdau = txtBatdau.Text;
            }
            string ketthuc = null;
            if (txtKetthuc.Text.Length != 0)
            {
                ketthuc = txtKetthuc.Text;
            }

            CaChieuDTO cc = new CaChieuDTO(macc, tencc, DateTime.Parse(batdau.ToString()), DateTime.Parse(ketthuc.ToString()));

            if (macc == null)
            {
                if (TrungMaCC == false)
                {
                    MessageBox.Show("Mã ca chiếu không được để trống");
                }
                else
                {
                    MessageBox.Show("Mã ca chiếu bị trùng");
                }
                txtMaCC.Focus();
            }
            else if (tencc == null)
            {
                MessageBox.Show("Tên ca chiếu không được để trống");
                txtTenCC.Focus();
            }
            else if (batdau == null)
            {
                MessageBox.Show("Thời gian bắt đầu không được để trống");
                txtBatdau.Focus();
            }
            else
            {
                try
                {
                    CaChieuBUS.Sua(cc);
                }
                catch
                {
                    txtMaCC.Clear();
                    TrungMaCC = true;
                    goto SuaLai;
                }
                MessageBox.Show("Sửa thông tin ca chiếu  thành công", "Thông báo");

                DataTable dataTable = new DataTable();
                dataTable = CaChieuBUS.LoadDSCaChieu();
                Load_Data(dataTable);

                KhongChoNhap();
                btnHuy_Sua.Visibility = btnLuu_Sua.Visibility = Visibility.Hidden;
                btnSua.Visibility = Visibility.Visible;
                btnThem.IsEnabled = btnXoa.IsEnabled = true;
                dtgDSCaChieu.IsEnabled = true;
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
            dataTable = CaChieuBUS.LoadDSCaChieu();
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
            if (cbbTimKiem.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: Mã ca chiếu")
            {
                type_timkiem = 0;
            }
            else if (cbbTimKiem.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: Tên ca chiếu")
            {
                type_timkiem = 1;
            }
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
                            dataTable = CaChieuBUS.TimTheoMaCC(txtTimKiem.Text.ToString());
                        }
                        break;
                    case 1:
                        {
                            dataTable = CaChieuBUS.TimTheoTenCC(txtTimKiem.Text.ToString());
                        }
                        break;

                }
            }
            else if (txtTimKiem.Text.Length == 0)
            {
                dataTable = CaChieuBUS.LoadDSCaChieu();
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
                txtTimKiem.Text = "";
        }

        private void TxtTimKiem_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                txtTimKiem.Text = "Tìm Kiếm...";
                DataTable dataTable = new DataTable();
                dataTable = CaChieuBUS.LoadDSCaChieu();
                Load_Data(dataTable);
            }
        }

        private void dtgDSCaChieu_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            int index = dtgDSCaChieu.SelectedIndex;
            if (index >= 0) // tránh lỗi click vẫn trong datagrid nhưng mà click chỗ k có dòng nào
            {
                Selected = true;
                CaChieuDTO nv = dtgDSCaChieu.SelectedItem as CaChieuDTO;
                txtMaCC.Text = nv.MaCC;
                txtTenCC.Text = nv.TenCC;
                txtBatdau.Text = nv.BatDau_String;
                txtKetthuc.Text = nv.KetThuc_String;
            }
        }
    }
}
