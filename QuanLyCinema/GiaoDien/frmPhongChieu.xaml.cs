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
using QuanLyCinema.PhongChieu;

namespace QuanLyCinema.GiaoDien
{
    /// <summary>
    /// Interaction logic for frmPhongChieu.xaml
    /// </summary>
    public partial class frmPhongChieu : UserControl
    {
        public frmPhongChieu()
        {
            InitializeComponent();
        }

        bool Selected = false;

        void ChoPhepNhap()
        {
            txtTenPC.IsReadOnly = txtMaPC.IsReadOnly = txtSoCho.IsReadOnly = txtMayChieu.IsReadOnly = txtLoa.IsReadOnly = txtDienTich.IsReadOnly = txtTinhTrang.IsReadOnly = txtTrangThietBiKhac.IsReadOnly = false;
            txtMaPC.Focus();
            grpThongTinPhongChieu.IsEnabled = true;
        }

        void KhongChoNhap()
        {
            txtTenPC.Clear();
            txtMaPC.Clear();
            txtSoCho.Clear();
            txtMayChieu.Clear();
            txtLoa.Clear();
            txtDienTich.Clear();
            txtTinhTrang.Clear();
            txtTrangThietBiKhac.Clear();

            txtTenPC.IsReadOnly = txtMaPC.IsReadOnly = txtSoCho.IsReadOnly = txtMayChieu.IsReadOnly
            = txtLoa.IsReadOnly = txtDienTich.IsReadOnly = txtTrangThietBiKhac.IsReadOnly = txtTinhTrang.IsReadOnly = true;
        }

        List<PhongChieuDTO> listPhongChieu = new List<PhongChieuDTO>();

        void Load_Data(DataTable dataTable)
        {
            dtgDSPC.Items.Clear();
            dtgDSPC.ItemsSource = null;
            listPhongChieu = new List<PhongChieuDTO>();
            for (int i = 0; i <= dataTable.Rows.Count - 1; i++)
            {
                object[] a = new object[9];
                a = dataTable.Rows[i].ItemArray;
                string stt = (i+1).ToString();
                string mapc = a[1].ToString();
                string tenpc = a[2].ToString();
                string socho = a[3].ToString();
                string maychieu = a[4].ToString();

                string loa = a[5].ToString();
                string dientich = a[6].ToString();
                string tinhtrang = a[7].ToString();
                string trangthietbikhac = a[8].ToString();

                listPhongChieu.Add(new PhongChieuDTO(stt, mapc, tenpc,Int32.Parse(socho), maychieu,loa,Int32.Parse( dientich),tinhtrang,trangthietbikhac));
                dtgDSPC.Items.Add(listPhongChieu[i]);
            }
          //  dtgDSPC.ItemsSource = listPhongChieu;
        }

        private void GridPhongChieu_Loaded(object sender, RoutedEventArgs e)
        {
            KhongChoNhap();
            DataTable dataTable = new DataTable();
            dataTable = PhongChieuBUS.LoadDSPC();
            Load_Data(dataTable);

            panelTimKiem.Visibility = btnHuy_Sua.Visibility = Visibility.Hidden;
        }

        private void dtgDSPC_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Selected = true;
            //DataGrid dg = sender as DataGrid;
            //DataRowView dr = dg.SelectedItem as DataRowView;
            //if (dr != null)
            //{
            //    txtMaPC.Text = dr["MAPC"].ToString();
            //    txtTenPC.Text = dr["TENPC"].ToString();
            //    txtSoCho.Text = dr["SOCHO"].ToString();
            //    txtMayChieu.Text = dr["MAYCHIEU"].ToString();
            //    txtLoa.Text = dr["LOA"].ToString();
            //    txtDienTich.Text = dr["DIENTICH"].ToString();
            //    txtTinhTrang.Text = dr["TINHTRANG"].ToString();
            //    txtTrangThietBiKhac.Text = dr["TRANGTHIETBIKHAC"].ToString();

            //}
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            frmAddPhongChieu frmAddPhongChieu = new frmAddPhongChieu();
            frmAddPhongChieu.ShowDialog();

            DataTable dataTable = new DataTable();
            dataTable = PhongChieuBUS.LoadDSPC();
            Load_Data(dataTable);
            //dtgDSPC.ItemsSource = PhongChieuBUS.LoadDSPC().DefaultView;

            KhongChoNhap();
            btnThem.Visibility = Visibility.Visible;
            btnSua.IsEnabled = btnXoa.IsEnabled = true;
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa phòng chiếu này không?", "Thông Báo", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                PhongChieuBUS.Xoa(txtMaPC.Text);
                MessageBox.Show("Xóa phòng chiếu thành công", "Thông Báo");
            }
            DataTable dataTable = new DataTable();
            dataTable = PhongChieuBUS.LoadDSPC();
            Load_Data(dataTable);
            btnLamMoi_Click(sender,e);
        }

        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            if (Selected == false)
                MessageBox.Show("Bạn chưa chọn phòng chiếu để sửa thông tin");
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
            bool TrungMaPC = false;
        SuaLai:
            string mapc = null;
            if (txtMaPC.Text.Length != 0)
            {
                mapc = txtMaPC.Text;
            }
            string tenpc = null;
            if (txtTenPC.Text.Length != 0)
            {
                tenpc = txtTenPC.Text;
            }
            string socho = null;
            if (txtSoCho.Text.Length != 0)
            {
                socho = txtSoCho.Text;
            }
            string maychieu = null;
            if (txtMayChieu.Text.Length != 0)
            {
                maychieu = txtMayChieu.Text;
            }
            string loa = null;
            if (txtLoa.Text.Length != 0)
            {
                loa = txtLoa.Text;
            }
            string dientich = null;
            if (txtDienTich.Text.Length != 0)
            {
                dientich = txtDienTich.Text;
            }
            string tinhtrang = null;
            if (txtTinhTrang.Text.Length != 0)
            {
                tinhtrang = txtTinhTrang.Text;
            }
            string trangthietbikhac = null;
            if (txtTrangThietBiKhac.Text.Length != 0)
            {
                trangthietbikhac = txtTrangThietBiKhac.Text;
            }
           

            PhongChieuDTO nv = new PhongChieuDTO(mapc, tenpc,Int32.Parse(socho), maychieu, loa,Int32.Parse( dientich), tinhtrang, trangthietbikhac);


            if (mapc == null)
            {
                if (TrungMaPC == false)
                {
                    MessageBox.Show("Mã số phòng chiếu không được để trống");
                }
                else
                {
                    MessageBox.Show("Mã số phòng chiếu bị trùng");
                }
                txtMaPC.Focus();
            }
            else if (tenpc == null)
            {
                MessageBox.Show("Họ tên không được để trống");
                txtTenPC.Focus();
            }
            else if (socho == null)
            {
                MessageBox.Show("Số chỗ không được để trống");
                txtSoCho.Focus();
            }
            else if (maychieu == null)
            {
                MessageBox.Show("Máy chiếu không được để trống");
                txtMayChieu.Focus();
            }
            else if (loa == null)
            {
                MessageBox.Show("Loa không được để trống");
                txtLoa.Focus();
            }
            else if (dientich == null)
            {
                MessageBox.Show("Diện tích không được để trống");
                txtDienTich.Focus();
            }

            else if (tinhtrang == null)
            {
                MessageBox.Show("Tình trạng không được để trống");
                txtTinhTrang.Focus();
            }
            else if (trangthietbikhac == null)
            {
                MessageBox.Show("Trang thiết bị khác không được để trống");
                txtTrangThietBiKhac.Focus();
            }
            else
            {
                try
                {
                    PhongChieuBUS.Sua(nv);
                }
                catch
                {
                    txtMaPC.Clear();
                    TrungMaPC = true;
                    goto SuaLai;
                }
                MessageBox.Show("Sửa thông tin phòng chiếu  thành công", "Thông báo");

                DataTable dataTable = new DataTable();
                dataTable = PhongChieuBUS.LoadDSPC();
                Load_Data(dataTable);

                KhongChoNhap();
                btnLuu_Sua.Visibility = Visibility.Hidden;
                btnSua.Visibility = Visibility.Visible;
                btnThem.IsEnabled = btnXoa.IsEnabled = true;
                dtgDSPC.IsEnabled = true;
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
            if (cbbTimKiem.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: Mã phòng chiếu")
            {
                type_timkiem = 0;
            }
            else if (cbbTimKiem.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: Tên phòng chiếu")
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
                            dataTable = PhongChieuBUS.TimTheoMaPC(txtTimKiem.Text.ToString());
                        }
                        break;
                    case 1:
                        {
                            dataTable = PhongChieuBUS.TimTheoTenPhongChieu(txtTimKiem.Text.ToString());
                        }
                        break;
                }
            }
            else if (txtTimKiem.Text.Length == 0)
            {
                dataTable = PhongChieuBUS.LoadDSPC();
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
                dataTable = PhongChieuBUS.LoadDSPC();
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
            dataTable = PhongChieuBUS.LoadDSPC();
            Load_Data(dataTable);

            panelTimKiem.Visibility = btnLuu_Sua.Visibility = btnHuy_Sua.Visibility = Visibility.Hidden;
            if (btnSua.Visibility == Visibility.Hidden)
                btnSua.Visibility = Visibility.Visible;
            if (btnThem.IsEnabled == btnXoa.IsEnabled == false)
                btnThem.IsEnabled = btnXoa.IsEnabled = true;
        }

        private void dtgDSPC_MouseUp(object sender, MouseButtonEventArgs e)
        {
            int index = dtgDSPC.SelectedIndex;
            if (index >= 0) // tránh lỗi click vẫn trong datagrid nhưng mà click chỗ k có dòng nào
            {
                Selected = true;
                PhongChieuDTO nv = dtgDSPC.SelectedItem as PhongChieuDTO;
                txtMaPC.Text = nv.MaPC;
                txtTenPC.Text = nv.TenPC;
                txtSoCho.Text = nv.SoCho.ToString();
                txtMayChieu.Text = nv.MayChieu;

                txtLoa.Text = nv.Loa;
                txtDienTich.Text = nv.DienTich.ToString();
                txtTinhTrang.Text = nv.TinhTrang;
                txtTrangThietBiKhac.Text = nv.TrangThietBiKhac;
            }    
                
        }
    }
}
