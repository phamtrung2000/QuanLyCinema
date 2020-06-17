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

        void ChoPhepNhap()
        {
            txtMaphim.IsReadOnly =txtTenphim.IsReadOnly=txtDaodien.IsReadOnly=txtDienvien.IsReadOnly=txtMalp.IsReadOnly=txtNoidung.IsReadOnly
                =txtNuocsx.IsReadOnly=txtNamsx.IsReadOnly=txtThoiluong.IsReadOnly= false;
            txtMaphim.Focus();
        }

        void KhongChoNhap()
        {
            txtMaphim.Clear();
            txtTenphim.Clear();
            txtDaodien.Clear();
            txtDienvien.Clear();
            txtNoidung.Clear();
            txtNamsx.Clear();
            txtNuocsx.Clear();
            txtThoiluong.Clear();
            txtMalp.Clear();


            txtMaphim.IsReadOnly = txtTenphim.IsReadOnly = txtDaodien.IsReadOnly = txtDienvien.IsReadOnly = txtMalp.IsReadOnly = txtNoidung.IsReadOnly
                = txtNuocsx.IsReadOnly = txtNamsx.IsReadOnly = txtThoiluong.IsReadOnly = true;
        }

        private void DtgDSP_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = sender as DataGrid;
            DataRowView dr = dg.SelectedItem as DataRowView;
            if (dr != null)
            {
                txtMalp.Text = dr["MALP"].ToString();
                txtMaphim.Text = dr["MAPHIM"].ToString();
                txtTenphim.Text = dr["TENPHIM"].ToString();
                txtDaodien.Text= dr["DAODIEN"].ToString();
                txtDienvien.Text= dr["DIENVIEN"].ToString();
                txtNoidung.Text= dr["DIENVIEN"].ToString();
                txtNuocsx.Text= dr["NUOCSX"].ToString();
                txtNamsx.Text= dr["NAMSX"].ToString();
                txtThoiluong.Text= dr["THOILUONG"].ToString();
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
                            dtgDSP.ItemsSource = PhimBUS.TimTheoMaP(txtTimKiem.Text.ToString()).DefaultView;
                        }
                        break;
                    case 1:
                        {
                            dtgDSP.ItemsSource = PhimBUS.TimTheoTenPhim(txtTimKiem.Text.ToString()).DefaultView;
                        }
                        break;

                }
            }
            else if (txtTimKiem.Text.Length == 0)
            {
                dtgDSP.ItemsSource = PhimBUS.LoadDSP().DefaultView;
            }
        }

        private void TxtTimKiem_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                txtTimKiem.Text = "Tìm Kiếm...";
                dtgDSP.ItemsSource = PhimBUS.LoadDSP().DefaultView;
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

        int type_timkiem = -1;
        private void CbbTimKiem_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            String a = cbbTimKiem.SelectedItem.ToString();
            if (cbbTimKiem.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: Mã Phim")
            {
                type_timkiem = 0;
            }
            else if (cbbTimKiem.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: Tên Phim")
            {
                type_timkiem = 1;
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

        private void BtnThem_Click(object sender, RoutedEventArgs e)
        {
            frmAddPhim addPhim = new frmAddPhim();
            addPhim.ShowDialog();
            dtgDSP.ItemsSource = PhimBUS.LoadDSP().DefaultView;
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
            //btnLamMoi.IsEnabled = false;
            btnThem.IsEnabled = btnXoa.IsEnabled = false;
        }

        private void BtnLamMoi_Click(object sender, RoutedEventArgs e)
        {
            KhongChoNhap();
            dtgDSP.ItemsSource = PhimBUS.LoadDSP().DefaultView;
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
            bool TrungMaP = false;
        SuaLai:
            string maphim = null;
            if (txtMaphim.Text.Length != 0)
            {
                maphim = txtMaphim.Text;
            }
            string tenphim = null;
            if (txtTenphim.Text.Length != 0)
            {
                tenphim = txtTenphim.Text;
            }
            string daodien = null;
            if (txtDaodien.Text.Length != 0)
            {
                daodien = txtDaodien.Text;
            }
            string dienvien = null;
            if (txtDienvien.Text.Length != 0)
            {
                dienvien = txtDienvien.Text;
            }
            string malp = null;
            if(txtMalp.Text.Length!=0)
            {
                malp = txtMalp.Text;
            }

            string noidung = null;
            if(txtNoidung.Text.Length!=0)
            {
                noidung = txtNoidung.Text;
            }
            string namsx = null;
            if (txtNamsx.Text.Length != 0)
            {
                namsx = txtNamsx.Text;
            }
            string nuocsx = null;
            if (txtNuocsx.Text.Length != 0)
            {
                nuocsx = txtNuocsx.Text;
            }
            string thoiluong = null;
            if (txtThoiluong.Text.Length != 0)
            {
                thoiluong = txtThoiluong.Text;
            }


            PhimDTO phim = new PhimDTO(maphim, tenphim, daodien, dienvien, malp, noidung, namsx, nuocsx,thoiluong);


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
                txtMaphim.Focus();
            }
            else if (tenphim == null)
            {
                MessageBox.Show("Tên phim không được để trống");
            }
            else if (daodien == null)
            {
                MessageBox.Show("Đạo diễn không được để trống");
                txtDaodien.Focus();
            }
            else if (dienvien == null)
            {
                MessageBox.Show("Diễn viên không được để trống");
                txtDienvien.Focus();
            }
            else if (noidung == null)
            {
                MessageBox.Show("Nội dung không được để trống");
                txtNoidung.Focus();
            }
            else if (namsx == null)
            {
                MessageBox.Show("Địa chỉ không được để trống");
                txtNamsx.Focus();
            }

            else if (nuocsx == null)
            {
                MessageBox.Show("Lương không được để trống");
                txtNuocsx.Focus();
            }
            else if(malp==null)
            {
                MessageBox.Show("Mã loại phim không được để trống");
                txtMalp.Focus();
            }
            else if(thoiluong==null)
            {
                MessageBox.Show("Thời lượng phim không được để trống");
                txtThoiluong.Focus();
            }
            else
            {
                try
                {
                    PhimBUS.Sua(phim);
                }
                catch
                {
                    txtMaphim.Clear();
                    TrungMaP = true;
                    goto SuaLai;
                }
                MessageBox.Show("Sửa thông tin phim  thành công", "Thông báo");
                dtgDSP.ItemsSource = PhimBUS.LoadDSP().DefaultView;
                KhongChoNhap();
                btnLuu_Sua.Visibility = Visibility.Hidden;
                btnSua.Visibility = Visibility.Visible;
                btnThem.IsEnabled = btnXoa.IsEnabled = true;
                dtgDSP.IsEnabled = true;
            }
        }

        private void BtnHuy_Sua_Click(object sender, RoutedEventArgs e)
        {
            KhongChoNhap();
            btnLuu_Sua.Visibility = btnHuy_Sua.Visibility = Visibility.Hidden;
            btnSua.Visibility = Visibility.Visible;
            btnThem.IsEnabled = btnXoa.IsEnabled = true;
        }

        private void GroupBox_Loaded(object sender, RoutedEventArgs e)
        {
            KhongChoNhap();
            dtgDSP.ItemsSource = PhimBUS.LoadDSP().DefaultView;
            panelTimKiem.Visibility = btnHuy_Sua.Visibility = Visibility.Hidden;
        }

        private void BtnXoa_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa phim này không?", "Thông Báo", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                PhimBUS.Xoa(txtMaphim.Text);
                MessageBox.Show("Xóa phim thành công", "Thông Báo");
            }
            dtgDSP.ItemsSource = PhimBUS.LoadDSP().DefaultView;
        }
    }
}
