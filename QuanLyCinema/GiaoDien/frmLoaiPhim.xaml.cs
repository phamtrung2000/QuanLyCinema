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
    /// Interaction logic for LoaiPhim.xaml
    /// </summary>
    public partial class frmLoaiPhim : UserControl
    {
        public frmLoaiPhim()
        {
            InitializeComponent();
        }

        void ChoPhepNhap()
        {
            txtMalp.IsReadOnly = txtMota.IsReadOnly = txtTenloaiphim.IsReadOnly = false;
            txtTenloaiphim.Focus();
        }

        void KhongChoNhap()
        {
            txtTenloaiphim.Clear();
            txtMalp.Clear();
            txtMota.Clear();


            txtTenloaiphim.IsReadOnly = txtMalp.IsReadOnly = txtMota.IsReadOnly = true;
        }

        private void DtgDSLP_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = sender as DataGrid;
            DataRowView dr = dg.SelectedItem as DataRowView;
            if (dr != null)
            { 
                txtMalp.Text = dr["MALP"].ToString();
                txtTenloaiphim.Text = dr["TENLP"].ToString();
                txtMota.Text = dr["MOTA"].ToString();
            }
        }

        

        private void BtnThem_Click(object sender, RoutedEventArgs e)
        {
            frmAddLoaiphim addLoaiPhim = new frmAddLoaiphim();
            addLoaiPhim.ShowDialog();
            dtgDSLP.ItemsSource = LoaiPhimBUS.LoadDSLP().DefaultView;
            KhongChoNhap();
            btnThem.Visibility = Visibility.Visible;
            btnSua.IsEnabled = btnXoa.IsEnabled = true;
        }

        private void BtnSua_Click(object sender, RoutedEventArgs e)
        {
            ChoPhepNhap();
            btnLuu_Sua.Visibility = Visibility.Visible;
            btnHuy_Sua.Visibility = Visibility.Visible;
            btnSua.Visibility = Visibility.Hidden;
            btnLamMoi.IsEnabled = false;
            btnThem.IsEnabled = btnXoa.IsEnabled = false;
        }

        private void BtnLamMoi_Click(object sender, RoutedEventArgs e)
        {
            KhongChoNhap();
            dtgDSLP.ItemsSource = LoaiPhimBUS.LoadDSLP().DefaultView;
            panelTimKiem.Visibility = btnHuy_Sua.Visibility = Visibility.Hidden;
        }

        private void BtnLuu_Sua_Click(object sender, RoutedEventArgs e)
        {
            bool TrungMaLP = false;
        SuaLai:
            string malp = null;
            if (txtMalp.Text.Length != 0)
            {
                malp = txtMalp.Text;
            }
            string tenlp = null;
            if (txtTenloaiphim.Text.Length != 0)
            {
                tenlp = txtTenloaiphim.Text;
            }
            string mota = null;
            if (txtMota.Text.Length != 0)
            {
                mota = txtMota.Text;
            }



            LoaiPhimDTO lp = new LoaiPhimDTO(malp, tenlp, mota);


            if (malp == null)
            {
                if (TrungMaLP == false)
                {
                    MessageBox.Show("Mã số loại phim không được để trống");
                }
                else
                {
                    MessageBox.Show("Mã số loại phim bị trùng");
                }
                txtMalp.Focus();
            }
            else if (tenlp == null)
            {
                MessageBox.Show("Tên loại phim không được để trống");
                txtTenloaiphim.Focus();
            }
            else if (mota == null)
            {
                MessageBox.Show("Mô tả không được để trống");
                txtMota.Focus();
            }
            
            else
            {
                try
                {
                    LoaiPhimBUS.Sua(lp);
                }
                catch
                {
                    txtMalp.Clear();
                    TrungMaLP = true;
                    goto SuaLai;
                }
                MessageBox.Show("Sửa thông tin loại phim  thành công", "Thông báo");
                dtgDSLP.ItemsSource = LoaiPhimBUS.LoadDSLP().DefaultView;
                KhongChoNhap();
                btnLuu_Sua.Visibility = Visibility.Hidden;
                btnSua.Visibility = Visibility.Visible;
                btnThem.IsEnabled = btnXoa.IsEnabled = true;
                dtgDSLP.IsEnabled = true;
            }
        }

        private void BtnXoa_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa loại phim này không?", "Thông Báo", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                LoaiPhimBUS.Xoa(txtMalp.Text);
                MessageBox.Show("Xóa phim thành công", "Thông Báo");
            }
            dtgDSLP.ItemsSource = LoaiPhimBUS.LoadDSLP().DefaultView;
        }

        private void BtnHuy_Sua_Click(object sender, RoutedEventArgs e)
        {
            KhongChoNhap();
            btnLuu_Sua.Visibility = btnHuy_Sua.Visibility = Visibility.Hidden;
            btnSua.Visibility = Visibility.Visible;
            btnThem.IsEnabled = btnXoa.IsEnabled = true;
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
            String a = cbbTimKiem.SelectedItem.ToString();
            if (cbbTimKiem.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: Mã Loại Phim")
            {
                type_timkiem = 0;
            }
            else if (cbbTimKiem.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: Tên Loại Phim")
            {
                type_timkiem = 1;
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
                            dtgDSLP.ItemsSource = LoaiPhimBUS.TimTheoMaLP(txtTimKiem.Text.ToString()).DefaultView;
                        }
                        break;
                    case 1:
                        {
                            dtgDSLP.ItemsSource = LoaiPhimBUS.TimTheoTenLoaiPhim(txtTimKiem.Text.ToString()).DefaultView;
                        }
                        break;

                }
            }
            else if (txtTimKiem.Text.Length == 0)
            {
                dtgDSLP.ItemsSource = LoaiPhimBUS.LoadDSLP().DefaultView;
            }
        }

        private void TxtTimKiem_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                txtTimKiem.Text = "Tìm Kiếm...";
                dtgDSLP.ItemsSource = LoaiPhimBUS.LoadDSLP().DefaultView;
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

        private void GridLoaiPhim_Loaded(object sender, RoutedEventArgs e)
        {
            KhongChoNhap();
            dtgDSLP.ItemsSource = LoaiPhimBUS.LoadDSLP().DefaultView;
            panelTimKiem.Visibility = btnHuy_Sua.Visibility = Visibility.Hidden;
        }
    }
}
