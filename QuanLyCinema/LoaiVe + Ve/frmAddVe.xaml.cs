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


using BUS;
using DTO;

namespace QuanLyCinema.LoaiVe___Ve
{
    /// <summary>
    /// Interaction logic for frmAddVe.xaml
    /// </summary>
   
    public partial class frmAddVe : Window
    {
        
        public frmAddVe()
        {
            InitializeComponent();
        }

        List<string> listMaPhim = new List<string>();
        List<string> listMaPC = new List<string>();
        List<string> listMaLV = new List<string>();

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
            dataTable = LoaiVeBUS.LoadDSLoaiVe();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                object[] a = new object[5];
                a = dataTable.Rows[i].ItemArray;

                string tenlv = a[2].ToString();
                cbbTenLV.Items.Add(tenlv);

                string malv = a[1].ToString();
                listMaLV.Add(malv);
            }
        }

        private void btnLamMoi_Click(object sender, RoutedEventArgs e)
        {
            cbbTenLV.SelectedIndex = -1;
        }

        private void btnHuy_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, RoutedEventArgs e)
        {
        Nhaplai:
            string maphim = null;
            if (cbbTenPhim.Text.Length != 0)
            {
                int index = cbbTenPhim.SelectedIndex;
                maphim = listMaPhim[index];
            }

            string mapc = null;
            if (cbbTenPC.Text.Length != 0)
            {
                int index = cbbTenPC.SelectedIndex;
                mapc = listMaPC[index];
            }

            string malv = null;
            if (cbbTenLV.Text.Length != 0)
            {
                int index = cbbTenLV.SelectedIndex;
                malv = listMaLV[index];
            }
            string soluong = null;
            if (txtSoLuong.Text.Length != 0)
            {
                soluong = txtSoLuong.Text;
            }

            VeDTO ve = new VeDTO( maphim, mapc, malv, soluong);

            // báo lỗi nếu chưa nhập theo thứ tự trừ trên xuống , trái sang phải

            if (maphim == null)
            {
                MessageBox.Show("Chưa nhập tên vé");
                cbbTenPhim.Focus();
            }
            else if (mapc == null)
            {
                MessageBox.Show("Chưa nhập loại chỗ ngồi");
                cbbTenPC.Focus();
            }
            else if (soluong == null)
            {
                MessageBox.Show("Chưa nhập giá");
                txtSoLuong.Focus();
            }
            else
            {
                try
                {
                    VeBUS.Them(ve);
                }
                catch
                {
                    goto Nhaplai;
                }
                MessageBox.Show("Thêm vé mới thành công", "Thông báo");
                this.Close();
            }
        }

        private void GridThemVe_Loaded(object sender, RoutedEventArgs e)
        {
            Load_DataCombobox();
        }
    }
}
