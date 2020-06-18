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
using QuanLyCinema.GiaoDien;
using DTO;

namespace QuanLyCinema.GiaoDien
{
    /// <summary>
    /// Interaction logic for frmLoaiVe.xaml
    /// </summary>
    public partial class frmLoaiVe : UserControl
    {
        public frmLoaiVe()
        {
            InitializeComponent();
        }

        bool Selected = false;

        void ChoPhepNhap()
        {
            txtTenLV.IsReadOnly = txtMaLV.IsReadOnly = txtLoaiChoNgoi.IsReadOnly = txtGia.IsReadOnly  = false;
            txtMaLV.Focus();
        }

        void KhongChoNhap()
        {
            txtTenLV.Clear();
            txtMaLV.Clear();
            txtLoaiChoNgoi.Clear();
            txtGia.Clear();

            txtTenLV.IsReadOnly = txtMaLV.IsReadOnly = txtLoaiChoNgoi.IsReadOnly = txtGia.IsReadOnly = true;
        }

        string Money(string money)
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

        private void GridLoaiVe_Loaded(object sender, RoutedEventArgs e)
        {
            KhongChoNhap();
            dtgDSLoaiVe.ItemsSource = LoaiVeBUS.LoadDSLoaiVe().DefaultView;
            panelTimKiem.Visibility = btnHuy_Sua.Visibility = Visibility.Hidden;
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            //frmAddNhanVien addNhanVien = new frmAddNhanVien();
            //addNhanVien.ShowDialog();
            //dtgDSLoaiVe.ItemsSource = LoaiVeBUS.LoadDSLoaiVe().DefaultView;
            //KhongChoNhap();
            //btnThem.Visibility = Visibility.Visible;
            //btnSua.IsEnabled = btnXoa.IsEnabled = true;
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa loại vé này không?", "Thông Báo", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                LoaiVeBUS.Xoa(txtMaLV.Text);
                MessageBox.Show("Xóa loại vé thành công", "Thông Báo");
            }
            dtgDSLoaiVe.ItemsSource = LoaiVeBUS.LoadDSLoaiVe().DefaultView;
        }

        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            if (Selected == false)
                MessageBox.Show("Bạn chưa chọn loại vé để sửa thông tin");
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
            bool TrungMaLV = false;
        SuaLai:
            string malv = null;
            if (txtMaLV.Text.Length != 0)
            {
                malv = txtMaLV.Text;
            }
            string tenlv = null;
            if (txtTenLV.Text.Length != 0)
            {
                tenlv = txtTenLV.Text;
            }
            string loaichongoi = null;
            if (txtLoaiChoNgoi.Text.Length != 0)
            {
                loaichongoi = txtLoaiChoNgoi.Text;
            }
            float gia = -1;
            if (txtGia.Text.Length != 0)
            {
                gia = float.Parse(txtGia.Text);
            }

            LoaiVeDTO nv = new LoaiVeDTO(malv, tenlv, loaichongoi, gia);


            if (malv == null)
            {
                if (TrungMaLV == false)
                {
                    MessageBox.Show("Mã loại vé không được để trống");
                }
                else
                {
                    MessageBox.Show("Mã loại vé bị trùng");
                }
                txtMaLV.Focus();
            }
            else if (tenlv == null)
            {
                MessageBox.Show("Tên loại vé không được để trống");
                txtTenLV.Focus();
            }
            else if (loaichongoi == null)
            {
                MessageBox.Show("Loại chỗ ngồi không được để trống");
                txtLoaiChoNgoi.Focus();
            }
            else if (gia == -1)
            {
                MessageBox.Show("Giá không được để trống");
                txtGia.Focus();
            }
            else
            {
                try
                {
                    LoaiVeBUS.Sua(nv);
                }
                catch
                {
                    txtMaLV.Clear();
                    TrungMaLV = true;
                    goto SuaLai;
                }
                MessageBox.Show("Sửa thông tin loại vé thành công", "Thông báo");
                dtgDSLoaiVe.ItemsSource = LoaiVeBUS.LoadDSLoaiVe().DefaultView;
                KhongChoNhap();
                btnLuu_Sua.Visibility = Visibility.Hidden;
                btnSua.Visibility = Visibility.Visible;
                btnThem.IsEnabled = btnXoa.IsEnabled = true;
                dtgDSLoaiVe.IsEnabled = true;
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
            String a = cbbTimKiem.SelectedItem.ToString();
            if (cbbTimKiem.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: Mã loại vé")
            {
                type_timkiem = 0;
            }
            else if (cbbTimKiem.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: Tên loại vé")
            {
                type_timkiem = 1;
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
                            dtgDSLoaiVe.ItemsSource = LoaiVeBUS.TimTheoMaLV(txtTimKiem.Text.ToString()).DefaultView;
                        }
                        break;
                    case 1:
                        {
                            dtgDSLoaiVe.ItemsSource = LoaiVeBUS.TimTheoTenLoaiVe(txtTimKiem.Text.ToString()).DefaultView;
                        }
                        break;
                }
            }
            else if (txtTimKiem.Text.Length == 0)
            {
                dtgDSLoaiVe.ItemsSource = LoaiVeBUS.LoadDSLoaiVe().DefaultView;
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
                dtgDSLoaiVe.ItemsSource = LoaiVeBUS.LoadDSLoaiVe().DefaultView;
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
            dtgDSLoaiVe.ItemsSource = LoaiVeBUS.LoadDSLoaiVe().DefaultView;
            panelTimKiem.Visibility = btnLuu_Sua.Visibility = btnHuy_Sua.Visibility = Visibility.Hidden;
            if (btnSua.Visibility == Visibility.Hidden)
                btnSua.Visibility = Visibility.Visible;
            if (btnThem.IsEnabled == btnXoa.IsEnabled == false)
                btnThem.IsEnabled = btnXoa.IsEnabled = true;
        }

        private void dtgDSLoaiVe_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Selected = true;
            DataGrid dg = sender as DataGrid;
            DataRowView dr = dg.SelectedItem as DataRowView;
            if (dr != null)
            {
                txtMaLV.Text = dr["MALV"].ToString();
                txtTenLV.Text = dr["TENLV"].ToString();
                txtLoaiChoNgoi.Text = dr["LOAICHONGOI"].ToString();
                txtGia.Text = dr["GIA"].ToString();
            }
        }
    }
}
