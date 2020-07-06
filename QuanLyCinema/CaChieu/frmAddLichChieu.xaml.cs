using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Shapes;

namespace QuanLyCinema.CaChieu
{
    /// <summary>
    /// Interaction logic for frmAddLichChieu.xaml
    /// </summary>
    public partial class frmAddLichChieu : Window
    {
        public frmAddLichChieu()
        {
            InitializeComponent();
        }

        List<string> listMaPhim = new List<string>();
        List<string> listMaPC = new List<string>();
        List<string> listMaCC = new List<string>();
        string ngaychieu = null;

        private void Load_DataCombobox()
        {
            DataTable dataTable = new DataTable();
            dataTable = PhimBUS.LoadDSPhim();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                object[] a = new object[9];
                a = dataTable.Rows[i].ItemArray;

                string tenphim = a[2].ToString();
                cbbTenPhim.Items.Add(tenphim);

                string maphim = a[1].ToString();
                listMaPhim.Add(maphim);
            }
            dataTable = PhongChieuBUS.LoadDSPC();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                object[] a = new object[9];
                a = dataTable.Rows[i].ItemArray;

                string tenpc = a[2].ToString();
                cbbTenPC.Items.Add(tenpc);

                string mapc = a[1].ToString();
                listMaPC.Add(mapc);

            }
            dataTable = CaChieuBUS.LoadDSCaChieu();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                object[] a = new object[5];
                a = dataTable.Rows[i].ItemArray;

                string tencc = a[2].ToString();
                cbbTenCC.Items.Add(tencc);

                string macc = a[1].ToString();
                listMaCC.Add(macc);
            }
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

        private void BtnLuu_Click(object sender, RoutedEventArgs e)
        {
            bool TrungMaLC = false;
        SuaLai:
            string maphim = null;
            if (cbbTenPhim.Text.Length != 0)
            {
                int index = cbbTenPhim.SelectedIndex;
                maphim = listMaPhim[index];
            }
            string macc = null;
            if (cbbTenCC.Text.Length != 0)
            {
                int index = cbbTenCC.SelectedIndex;
                macc = listMaCC[index];
            }
            string mapc = null;
            if (cbbTenPC.Text.Length != 0)
            {
                int index = cbbTenPC.SelectedIndex;
                mapc = listMaPC[index];
            }

            DateTime ngaychieu = DateTime.Parse(ThangTruocNgaySau(txtNgayChieu.Text));

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
                cbbTenPhim.Focus();
            }
            else if (macc == null)
            {
                MessageBox.Show("Mã ca chiếu không được để trống");
                cbbTenCC.Focus();
            }
            else if (mapc == null)
            {
                MessageBox.Show("Mã phòng chiếu không được để trống");
                cbbTenPC.Focus();
            }
            else
            {
                try
                {
                    LichChieuBUS.Them(lc);
                }
                catch
                {
                    TrungMaLC = true;
                    goto SuaLai;
                }
                MessageBox.Show("Thêm thông tin lịch chiếu  thành công", "Thông báo");
                this.Close();
            }
        }

        private void BtnLamMoi_Click(object sender, RoutedEventArgs e)
        {
          
        }

        private void BtnHuy_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void GridLichChieu_Loaded(object sender, RoutedEventArgs e)
        {
            Load_DataCombobox();
        }

        
        private void txtNgayChieu_LostFocus(object sender, RoutedEventArgs e)
        {
            ngaychieu = txtNgayChieu.Text;
        }

        private void dpNgayChieu_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dpNgayChieu.Text.Length > 0)
            {
                ngaychieu = txtNgayChieu.Text = ThangTruocNgaySau(dpNgayChieu.Text);

            }
            dpNgayChieu.Text = "";
        }
    }
}
