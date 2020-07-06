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
using QuanLyCinema.LoaiVe___Ve;

namespace QuanLyCinema.GiaoDien
{
    /// <summary>
    /// Interaction logic for frmVe.xaml
    public partial class frmVe : UserControl
    {
        public frmVe()
        {
            InitializeComponent();
        }

        List<VeDTO> listVe = new List<VeDTO>();
        List<string> listMaPhim = new List<string>();
        List<string> listMaPC = new List<string>();
        List<string> listMaLV = new List<string>();
      
        int index = -1;
        bool Sua = false;

        void Load_Data(DataTable dataTable)
        {
            dtgDSVe.Items.Clear();
            dtgDSVe.ItemsSource = null;
            listVe = new List<VeDTO>();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                object[] a = new object[8];
                a = dataTable.Rows[i].ItemArray;
                string stt = (i + 1).ToString();
                string tenphim = a[1].ToString();
                string tenpc = a[2].ToString();
                string tenlv = a[3].ToString();
                string soluong = a[4].ToString();

                listVe.Add(new VeDTO(stt, tenphim, tenpc, tenlv, soluong));
                dtgDSVe.Items.Add(listVe[i]);

                string maphim = a[5].ToString();
                listMaPhim.Add(maphim);
                string mapc = a[6].ToString();
                listMaPC.Add(mapc);
                string malv = a[7].ToString();
                listMaLV.Add(malv);
            }
        }

        bool Selected = false;

        void ChoPhepNhap()
        {
            txtSoLuong.IsReadOnly = false;
            txtSoLuong.Focus();
            grpThongTinLoaiVe.IsEnabled = true;
        }

        void KhongChoNhap()
        {
            txtTenLV.Clear();
            txtTenPhim.Clear();
            txtTenPC.Clear();
            txtSoLuong.Clear();

            txtTenLV.IsReadOnly = txtTenPhim.IsReadOnly = txtTenPC.IsReadOnly = txtSoLuong.IsReadOnly = true;
        }


        private void GridLoaiVe_Loaded(object sender, RoutedEventArgs e)
        {
            KhongChoNhap();

            DataTable dataTable = new DataTable();
            dataTable = VeBUS.LoadDSVe();
            Load_Data(dataTable);

            panelTimKiem.Visibility = btnHuy_Sua.Visibility = Visibility.Hidden;
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            frmAddVe frmAddVe = new frmAddVe();
            frmAddVe.ShowDialog();

            DataTable dataTable = new DataTable();
            dataTable = VeBUS.LoadDSVe();
            Load_Data(dataTable);

            KhongChoNhap();
            btnThem.Visibility = Visibility.Visible;
            btnSua.IsEnabled = btnXoa.IsEnabled = true;
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa loại vé này không?", "Thông Báo", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                VeBUS.Xoa(listMaPhim[index], listMaPC[index], listMaLV[index]);
                MessageBox.Show("Xóa loại vé thành công", "Thông Báo");
            }
            DataTable dataTable = new DataTable();
            dataTable = VeBUS.LoadDSVe();
            Load_Data(dataTable);
            btnLamMoi_Click(sender, e);
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
                Sua = true;
            }
        }

        private void btnLuu_Sua_Click(object sender, RoutedEventArgs e)
        {
            SuaLai:
            string maphim = null;
            if (txtTenPhim.Text.Length != 0)
            {
                maphim = listMaPhim[index];
            }

            string mapc = null;
            if (txtTenPC.Text.Length != 0)
            {
                mapc = listMaPC[index];
            }

            string malv = null;
            if (txtTenLV.Text.Length != 0)
            {
                malv = listMaLV[index];
            }
            string soluong = null;
            if (txtSoLuong.Text.Length != 0)
            {
                soluong = txtSoLuong.Text;
            }

            VeDTO ve = new VeDTO(maphim, mapc, malv, soluong);

            // báo lỗi nếu chưa nhập theo thứ tự trừ trên xuống , trái sang phải

            if (soluong == null)
            {
                MessageBox.Show("Số lượng không được để trống");
                txtSoLuong.Focus();
            }
            else
            {
                try
                {
                    VeBUS.Sua(ve);
                }
                catch
                {
                    goto SuaLai;
                }
                MessageBox.Show("Sửa thông tin vé thành công", "Thông báo");

                DataTable dataTable = new DataTable();
                dataTable = VeBUS.LoadDSVe();
                Load_Data(dataTable);

                KhongChoNhap();
                btnHuy_Sua.Visibility = btnLuu_Sua.Visibility = Visibility.Hidden;
                btnSua.Visibility = Visibility.Visible;
                btnThem.IsEnabled = btnXoa.IsEnabled = true;
                dtgDSVe.IsEnabled = true;
                Selected = false;
            }
        }

        private void btnHuy_Sua_Click(object sender, RoutedEventArgs e)
        {
            KhongChoNhap();
            btnLuu_Sua.Visibility = btnHuy_Sua.Visibility = Visibility.Hidden;
            btnSua.Visibility = Visibility.Visible;
            btnThem.IsEnabled = btnXoa.IsEnabled = true;
            Sua = false;
        }

        private void btnLamMoi_Click(object sender, RoutedEventArgs e)
        {
            KhongChoNhap();

            DataTable dataTable = new DataTable();
            dataTable = VeBUS.LoadDSVe();
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
            if (cbbTimKiem.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: Phim")
            {
                type_timkiem = 0;
            }
            else if (cbbTimKiem.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: Phòng chiếu")
            {
                type_timkiem = 1;
            }
            else if (cbbTimKiem.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: Loại vé")
            {
                type_timkiem = 2;
            }
            else if (cbbTimKiem.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: Số lượng")
            {
                type_timkiem = 3;
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
                            dataTable = VeBUS.TimTheoTenPhim(txtTimKiem.Text.ToString());
                        }
                        break;
                    case 1:
                        {
                            dataTable = VeBUS.TimTheoTenPC(txtTimKiem.Text.ToString());
                        }
                        break;
                    case 2:
                        {
                            dataTable = VeBUS.TimTheoTenLV(txtTimKiem.Text.ToString());
                        }
                        break;
                    case 3:
                        {
                            dataTable = VeBUS.TimTheoSoLuong(txtTimKiem.Text.ToString());
                        }
                        break;
                }
            }
            else if (txtTimKiem.Text.Length == 0)
            {
                dataTable = VeBUS.LoadDSVe();
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
                dataTable = VeBUS.LoadDSVe();
                Load_Data(dataTable);
            }
        }

        private void txtTenPhim_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if(Sua==true)
            {
                MessageBox.Show("Bạn không thể sửa tên phim. Vui lòng sửa bên giao diện PHIM");
                txtSoLuong.Focus();
            }    
        }

        private void dtgDSVe_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            index = dtgDSVe.SelectedIndex;
            if (index >= 0) // tránh lỗi click vẫn trong datagrid nhưng mà click chỗ k có dòng nào
            {
                Selected = true;
                VeDTO nv = dtgDSVe.SelectedItem as VeDTO;
                txtTenPhim.Text = nv.MaPhim;
                txtTenLV.Text = nv.MaLV;
                txtTenPC.Text = nv.MaPC;
                txtSoLuong.Text = nv.SoLuong;
            }
        }
    }
}
