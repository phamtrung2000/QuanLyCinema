using BUS;
using DTO;
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
using System.Windows.Shapes;

namespace QuanLyCinema.CaChieu
{
    /// <summary>
    /// Interaction logic for frmAddCaChieu.xaml
    /// </summary>
    public partial class frmAddCaChieu : Window
    {
        public frmAddCaChieu()
        {
            InitializeComponent();
        }

        private void BtnHuy_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnLamMoi_Click(object sender, RoutedEventArgs e)
        {
            txtMaCC.Clear();
            txtTencc.Clear();
            txtBatdau.Clear();
            txtketthuc.Clear();
        }

        private void BtnLuu_Click(object sender, RoutedEventArgs e)
        {
            bool TrungMaCC = false;
        SuaLai:
            string macc = null;
            if (txtMaCC.Text.Length != 0)
            {
                macc = txtMaCC.Text;
            }
            string tencc = null;
            if (txtTencc.Text.Length != 0)
            {
                tencc = txtTencc.Text;
            }

            string batdau = null;
            if (txtBatdau.Text.Length != 0)
            {
                batdau = txtBatdau.Text;
            }
            string ketthuc = null;
            if (txtketthuc.Text.Length != 0)
            {
                ketthuc = txtketthuc.Text;
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
                txtTencc.Focus();
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
                    CaChieuBUS.Them(cc);
                }
                catch
                {
                    txtMaCC.Clear();
                    TrungMaCC = true;
                    goto SuaLai;
                }
                MessageBox.Show("Thêm thông tin ca chiếu  thành công", "Thông báo");
                this.Close();
            }
        }
    }
}
