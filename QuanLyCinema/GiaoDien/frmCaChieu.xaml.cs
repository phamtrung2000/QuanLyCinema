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
namespace QuanLyCinema.GiaoDien
{
    /// <summary>
    /// Interaction logic for frmCaChieu.xaml
    /// </summary>
    public partial class frmCaChieu : UserControl
    {
        public frmCaChieu()
        {
            InitializeComponent();
        }
        bool Selected = false;

        void ChoPhepNhap()
        {
            txtMaCC.IsReadOnly = txtTenCC.IsReadOnly = txtBatdau.IsReadOnly = txtKetthuc.IsReadOnly = false;
            txtMaCC.Focus();
        }

        void KhongChoNhap()
        {
            txtTenCC.Clear();
            txtMaCC.Clear();
            txtBatdau.Clear();
            txtKetthuc.Clear();


            txtTenCC.IsReadOnly = txtMaCC.IsReadOnly = txtBatdau.IsReadOnly = txtKetthuc.IsReadOnly = true;
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

        private void BtnThem_Click(object sender, RoutedEventArgs e)
        {
            CaChieu.frmAddCaChieu addCaChieu = new CaChieu.frmAddCaChieu();
            addCaChieu.ShowDialog();
            dtgDSCC.ItemsSource = CaChieuBUS.LoadDSCC().DefaultView;
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

        private void BtnLamMoi_Click(object sender, RoutedEventArgs e)
        {
            KhongChoNhap();
            dtgDSCC.ItemsSource = CaChieuBUS.LoadDSCC().DefaultView;
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
                dtgDSCC.ItemsSource = CaChieuBUS.LoadDSCC().DefaultView;
                KhongChoNhap();
                btnLuu_Sua.Visibility = Visibility.Hidden;
                btnSua.Visibility = Visibility.Visible;
                btnThem.IsEnabled = btnXoa.IsEnabled = true;
                dtgDSCC.IsEnabled = true;
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
            dtgDSCC.ItemsSource = CaChieuBUS.LoadDSCC().DefaultView;
        }

        private void BtnHuy_Sua_Click(object sender, RoutedEventArgs e)
        {
            KhongChoNhap();
            btnLuu_Sua.Visibility = btnHuy_Sua.Visibility = Visibility.Hidden;
            btnSua.Visibility = Visibility.Visible;
            btnThem.IsEnabled = btnXoa.IsEnabled = true;
        }

        private void DtgDSCC_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Selected = true;
            DataGrid dg = sender as DataGrid;
            DataRowView dr = dg.SelectedItem as DataRowView;
            if (dr != null)
            {
                txtMaCC.Text = dr["MACC"].ToString();
                txtTenCC.Text = dr["TENCC"].ToString();
                txtBatdau.Text = dr["BATDAU"].ToString();
                txtKetthuc.Text = dr["KETHUC"].ToString();

            }
        }

        private void TxtTimKiem_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtTimKiem.Text.Length > 1)
            {
                switch (type_timkiem)
                {
                    case 0:
                        {
                            dtgDSCC.ItemsSource = CaChieuBUS.TimTheoMaCC(txtTimKiem.Text.ToString()).DefaultView;
                        }
                        break;
                    case 1:
                        {
                            dtgDSCC.ItemsSource = CaChieuBUS.TimTheoTenCC(txtTimKiem.Text.ToString()).DefaultView;
                        }
                        break;

                }
            }
            else if (txtTimKiem.Text.Length == 0)
            {
                dtgDSCC.ItemsSource = CaChieuBUS.LoadDSCC().DefaultView;
            }
        }

        private void TxtTimKiem_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                txtTimKiem.Text = "Tìm Kiếm...";
                dtgDSCC.ItemsSource = CaChieuBUS.LoadDSCC().DefaultView;
            }
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

        private void GridCaChieu_Loaded(object sender, RoutedEventArgs e)
        {
            KhongChoNhap();
            dtgDSCC.ItemsSource = CaChieuBUS.LoadDSCC().DefaultView;
            panelTimKiem.Visibility = btnHuy_Sua.Visibility = Visibility.Hidden;
        }

        int type_timkiem = -1;
        private void CbbTimKiem_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            String a = cbbTimKiem.SelectedItem.ToString();
            if (cbbTimKiem.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: Mã ca chiếu")
            {
                type_timkiem = 0;
            }
            else if (cbbTimKiem.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: Tên ca chiếu")
            {
                type_timkiem = 1;
            }
        }
    }
}
