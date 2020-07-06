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
    /// <summary>
    /// Interaction logic for frmLichChieu.xaml
    /// </summary>
    public partial class frmLichChieu : UserControl
    {
        public frmLichChieu()
        {
            InitializeComponent();
        }

        List<LichChieuDTO> listLichChieu = new List<LichChieuDTO>();
        List<string> listMaPhim = new List<string>();
        List<string> listMaPC = new List<string>();
        List<string> listMaCC = new List<string>();
       
        int index = -1;
        bool Sua = false;

        void Load_Data(DataTable dataTable)
        {
            dtgDSLichChieu.Items.Clear();
            dtgDSLichChieu.ItemsSource = null;
            listLichChieu = new List<LichChieuDTO>();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                object[] a = new object[8];
                a = dataTable.Rows[i].ItemArray;
                string stt = (i + 1).ToString();

                DateTime ngaychieu_temp = DateTime.Parse(a[1].ToString());
                string ngaychieu = ngaychieu_temp.Day.ToString() + "/" + ngaychieu_temp.Month.ToString() + "/" + ngaychieu_temp.Year.ToString();

                string tenphim = a[2].ToString();
                string tenpc = a[3].ToString();
                string tencc = a[4].ToString();

                listLichChieu.Add(new LichChieuDTO(stt, ngaychieu, tenphim, tencc, tenpc));
                dtgDSLichChieu.Items.Add(listLichChieu[i]);

                string maphim = a[5].ToString();
                listMaPhim.Add(maphim);
                string macc = a[6].ToString();
                listMaCC.Add(macc);
                string mapc = a[7].ToString();
                listMaPC.Add(mapc);
            }
        }

        bool Selected = false;

        void ChoPhepNhap()
        {
            txtMacc.IsReadOnly = txtMaphim.IsReadOnly = txtMapc.IsReadOnly = false;
            dtpNgayChieu.IsEnabled = true;
            dtpNgayChieu.Focus();
            grpThongTinLichChieu.IsEnabled = true;
        }

        void KhongChoNhap()
        {
            txtMaphim.Clear();
            txtMacc.Clear();
            txtMapc.Clear();
            txtNgayChieu.Clear();

            txtMacc.IsReadOnly = txtMaphim.IsReadOnly = txtMapc.IsReadOnly = true;

            dtpNgayChieu.Visibility  = Visibility.Hidden;
            txtNgayChieu.Visibility = Visibility.Visible;
            dtpNgayChieu.IsEnabled = false;

        }

        private void GridLichChieu_Loaded(object sender, RoutedEventArgs e)
        {
            dtpNgayChieu.Visibility = Visibility.Hidden;
            KhongChoNhap();

            DataTable dataTable = new DataTable();
            dataTable = LichChieuBUS.LoadDSLC();
            Load_Data(dataTable);

            panelTimKiem.Visibility = btnHuy_Sua.Visibility = Visibility.Hidden;
        }

        private void BtnThem_Click(object sender, RoutedEventArgs e)
        {
            frmAddLichChieu addLichChieu = new frmAddLichChieu();
            addLichChieu.ShowDialog();

            DataTable dataTable = new DataTable();
            dataTable = LichChieuBUS.LoadDSLC();
            Load_Data(dataTable);

            KhongChoNhap();
            btnThem.Visibility = Visibility.Visible;
            btnSua.IsEnabled = btnXoa.IsEnabled = true;
        }

        private void BtnXoa_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa lịch chiếu này không?", "Thông Báo", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                LichChieuBUS.Xoa(DateTime.Parse(ThangTruocNgaySau(txtNgayChieu.Text) + " 12:00:00 AM"), listMaPhim[index], listMaCC[index], listMaPC[index]);
                MessageBox.Show("Xóa lịch chiếu thành công", "Thông Báo");
            }
            DataTable dataTable = new DataTable();
            dataTable = LichChieuBUS.LoadDSLC();
            Load_Data(dataTable);
            BtnLamMoi_Click(sender, e);
        }

        private string ThangTruocNgaySau(string a) // 4 thang 5 -> 5/4
        {
            string kq = null;
            string ngay = null, thang = null, nam = null;
            string[] chuoi_duoc_tach = a.Split(new Char[] { '/' });

            ngay = chuoi_duoc_tach[0];
            thang = chuoi_duoc_tach[1];
            nam = chuoi_duoc_tach[2];
            kq = thang + "/" + ngay + "/" + nam;
            return kq;
        }

        private void BtnSua_Click(object sender, RoutedEventArgs e)
        {
            if (Selected == false)
                MessageBox.Show("Bạn chưa chọn lịch chiếu để sửa thông tin");
            else
            {
                ChoPhepNhap();

                txtNgayChieu.Visibility = Visibility.Hidden;
                dtpNgayChieu.Visibility = Visibility.Visible;
                dtpNgayChieu.SelectedDate = DateTime.Parse(ThangTruocNgaySau(txtNgayChieu.Text) + " 12:00:00 AM");

                btnLuu_Sua.Visibility = Visibility.Visible;
                btnHuy_Sua.Visibility = Visibility.Visible;
                btnSua.Visibility = Visibility.Hidden;
                btnThem.IsEnabled = btnXoa.IsEnabled = false;
                Sua = true;
            }
        }

        private void BtnLamMoi_Click(object sender, RoutedEventArgs e)
        {
            KhongChoNhap();

            DataTable dataTable = new DataTable();
            dataTable = LichChieuBUS.LoadDSLC();
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

        private void BtnLuu_Sua_Click(object sender, RoutedEventArgs e)
        {
            bool TrungMaLC = false;
        SuaLai:
            string maphim = null;
            if (txtMaphim.Text.Length != 0)
            {
                maphim = listMaPhim[index];
            }
            string macc = null;
            if (txtMacc.Text.Length != 0)
            {
                macc = listMaCC[index];
            }
            string mapc = null;
            if (txtMapc.Text.Length != 0)
            {
                mapc = listMaPC[index];
            }

            DateTime ngaychieu = DateTime.Parse(dtpNgayChieu.ToString());

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

                DataTable dataTable = new DataTable();
                dataTable = LichChieuBUS.LoadDSLC();
                Load_Data(dataTable);

                KhongChoNhap();
                txtNgayChieu.Clear();
                btnLuu_Sua.Visibility = Visibility.Hidden;
                btnSua.Visibility = Visibility.Visible;
                btnThem.IsEnabled = btnXoa.IsEnabled = true;
                dtgDSLichChieu.IsEnabled = true;
            }
        }

        private void BtnHuy_Sua_Click(object sender, RoutedEventArgs e)
        {
            KhongChoNhap();
            btnLuu_Sua.Visibility = btnHuy_Sua.Visibility = Visibility.Hidden;
            btnSua.Visibility = Visibility.Visible;
            btnThem.IsEnabled = btnXoa.IsEnabled = true;
            Sua = false;
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

        private void TxtTimKiem_TextChanged(object sender, TextChangedEventArgs e)
        {
            DataTable dataTable = new DataTable();
            if (txtTimKiem.Text.Length >= 1 && txtTimKiem.Text != "Tìm Kiếm...")
            {
                switch (type_timkiem)
                {
                    case 0:
                        {
                            dataTable = LichChieuBUS.Timtheomapc(txtTimKiem.Text.ToString());
                        }
                        break;
                    case 1:
                        {
                            dataTable = LichChieuBUS.TimTheomacclc(txtTimKiem.Text.ToString());
                        }
                        break;

                }
            }
            else if (txtTimKiem.Text.Length == 0)
            {
                dataTable = LichChieuBUS.LoadDSLC();
            }
            Load_Data(dataTable);
        }

        private void TxtTimKiem_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                txtTimKiem.Text = "Tìm Kiếm...";
                DataTable dataTable = new DataTable();
                dataTable = LichChieuBUS.LoadDSLC();
                Load_Data(dataTable);
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

        private void dtgDSLichChieu_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
             index = dtgDSLichChieu.SelectedIndex;
            if (index >= 0) // tránh lỗi click vẫn trong datagrid nhưng mà click chỗ k có dòng nào
            {
                Selected = true;
                LichChieuDTO nv = dtgDSLichChieu.SelectedItem as LichChieuDTO;
                txtNgayChieu.Text = nv.NgayChieu_String;
                txtMaphim.Text = nv.MaPhim;
                txtMapc.Text = nv.MaPC;
                txtMacc.Text = nv.MaCC;
            }
        }
    }
}
