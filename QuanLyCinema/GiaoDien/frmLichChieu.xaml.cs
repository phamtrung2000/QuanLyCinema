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
    /// Interaction logic for frmLichChieu.xaml
    /// </summary>
    public partial class frmLichChieu : UserControl
    {
        public frmLichChieu()
        {
            InitializeComponent();
        }
        bool Selected = false;
        void ChoPhepNhap()
        {
            txtMacc.IsReadOnly = txtMaphim.IsReadOnly = txtMapc.IsReadOnly = false;
            dtpNgaychieu.IsEnabled = true;
            dtpNgaychieu.Focus();
        }
        void KhongChoNhap()
        {
            txtMaphim.Clear();
            txtMacc.Clear();
            txtMapc.Clear();

            txtMacc.IsReadOnly = txtMaphim.IsReadOnly = txtMapc.IsReadOnly = true;
            dtpNgaychieu.IsEnabled = false;
        }
        private void GridLichChieu_Loaded(object sender, RoutedEventArgs e)
        {
            KhongChoNhap();
            dtgDSLC.ItemsSource = LichChieuBUS.LoadDSLC().DefaultView;
            panelTimKiem.Visibility = btnHuy_Sua.Visibility = Visibility.Hidden;
        }

        private void DtgDSLC_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Selected = true;
            DataGrid dg = sender as DataGrid;
            DataRowView dr = dg.SelectedItem as DataRowView;
            if (dr != null)
            {
                txtMaphim.Text = dr["MAPHIM"].ToString();
                txtMacc.Text = dr["MACC"].ToString();
                txtMapc.Text = dr["MAPC"].ToString();
                dtpNgaychieu.SelectedDate = DateTime.Parse(dr["NGAYCHIEU"].ToString());
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
                            dtgDSLC.ItemsSource = LichChieuBUS.Timtheomapc(txtTimKiem.Text.ToString()).DefaultView;
                        }
                        break;
                    case 1:
                        {
                            dtgDSLC.ItemsSource = LichChieuBUS.TimTheomacclc(txtTimKiem.Text.ToString()).DefaultView;
                        }
                        break;

                }
            }
            else if (txtTimKiem.Text.Length == 0)
            {
                dtgDSLC.ItemsSource = LichChieuBUS.LoadDSLC().DefaultView;
            }
        }

        private void TxtTimKiem_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                txtTimKiem.Text = "Tìm Kiếm...";
                dtgDSLC.ItemsSource = LichChieuBUS.LoadDSLC().DefaultView;
            }
        }
        int type_timkiem = -1;
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

        private void CbbTimKiem_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (txtTimKiem.Text != "" || txtTimKiem.Text != "Tìm Kiếm...")
                txtTimKiem.Text = "";
            if (cbbTimKiem.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: Mã phòng chiếu")
            {
                type_timkiem = 0;
            }
            else if (cbbTimKiem.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: Mã ca chiếu")
            {
                type_timkiem = 1;
            }

            txtTimKiem.Focus();
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
            CaChieu.frmAddLichChieu addLichChieu = new CaChieu.frmAddLichChieu();
            addLichChieu.ShowDialog();
            dtgDSLC.ItemsSource = LichChieuBUS.LoadDSLC().DefaultView;
            KhongChoNhap();
            btnThem.Visibility = Visibility.Visible;
            btnSua.IsEnabled = btnXoa.IsEnabled = true;
        }

        private void BtnSua_Click(object sender, RoutedEventArgs e)
        {
            if (Selected == false)
                MessageBox.Show("Bạn chưa chọn lịch chiếu để sửa thông tin");
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
            dtgDSLC.ItemsSource = LichChieuBUS.LoadDSLC().DefaultView;
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
            bool TrungMaLC = false;
        SuaLai:
            string maphim = null;
            if (txtMaphim.Text.Length != 0)
            {
                maphim = txtMaphim.Text;
            }
            string macc = null;
            if (txtMacc.Text.Length != 0)
            {
                macc = txtMacc.Text;
            }
            string mapc = null;
            if (txtMapc.Text.Length != 0)
            {
                mapc = txtMapc.Text;
            }

            DateTime ngaychieu = DateTime.Parse(dtpNgaychieu.ToString());
            LichChieuDTO lc = new LichChieuDTO(ngaychieu, maphim, macc, mapc);
            if (maphim == null)
            {
                if (TrungMaLC == false)
                {
                    MessageBox.Show("Mã phim không được để trống");
                }
                else
                {
                    MessageBox.Show("Mã phim bị trùng");
                }
                txtMacc.Focus();
            }
            else if (macc == null)
            {
                MessageBox.Show("Mã ca chiếu không được để trống");
                txtMacc.Focus();
            }
            else if (mapc == null)
            {
                MessageBox.Show("Mã phòng chiếu không được để trống");
                txtMapc.Focus();
            }
            else
            {
                try
                {
                    LichChieuBUS.Sua(lc);
                }
                catch
                {
                    txtMaphim.Clear();
                    TrungMaLC = true;
                    goto SuaLai;
                }
                MessageBox.Show("Sửa thông tin lịch chiếu  thành công", "Thông báo");
                dtgDSLC.ItemsSource = LichChieuBUS.LoadDSLC().DefaultView;
                KhongChoNhap();
                btnLuu_Sua.Visibility = Visibility.Hidden;
                btnSua.Visibility = Visibility.Visible;
                btnThem.IsEnabled = btnXoa.IsEnabled = true;
                dtgDSLC.IsEnabled = true;
            }
        }

        private void BtnXoa_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa lịch chiếu này không?", "Thông Báo", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                LichChieuBUS.Xoa(DateTime.Parse(dtpNgaychieu.Text), txtMaphim.Text);
                MessageBox.Show("Xóa lịch chiếu thành công", "Thông Báo");
            }
            dtgDSLC.ItemsSource = LichChieuBUS.LoadDSLC().DefaultView;
        }

        private void BtnHuy_Sua_Click(object sender, RoutedEventArgs e)
        {
            KhongChoNhap();
            btnLuu_Sua.Visibility = btnHuy_Sua.Visibility = Visibility.Hidden;
            btnSua.Visibility = Visibility.Visible;
            btnThem.IsEnabled = btnXoa.IsEnabled = true;
        }
    }
}
