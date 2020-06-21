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

using BUS;
using DTO;

namespace QuanLyCinema.NguoiDung
{
    /// <summary>
    /// Interaction logic for frmAddNguoiDung.xaml
    /// </summary>
   
    public partial class frmAddNguoiDung : Window
{
        public frmAddNguoiDung()
    {
            InitializeComponent();
        }

        private void btnLamMoi_Click(object sender, RoutedEventArgs e)
        {
            txtMaND.Clear();
            txtHoTen.Clear();
            txtChucVu.Clear();
            txtPhanQuyen.Clear();
        }

        private void btnHuy_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, RoutedEventArgs e)
        {
            bool TrungMaND = false;
        Nhaplai:
            string mand = null;
            if (txtMaND.Text.Length != 0)
            {
                mand = txtMaND.Text;
            }
            string hoten = null;
            if (txtHoTen.Text.Length != 0)
            {
                hoten = txtHoTen.Text;
            }
            string chucvu = null;
            if (txtChucVu.Text.Length != 0)
            {
                chucvu = txtChucVu.Text;
            }
            string phanquyen = null;
            if (txtPhanQuyen.Text.Length != 0)
            {
                phanquyen = txtPhanQuyen.Text;
            }

            NguoiDungDTO nv = new NguoiDungDTO(mand, hoten, chucvu, phanquyen);

            if (mand == null)
            {
                if (TrungMaND == false)
                {
                    MessageBox.Show("Mã số người dùng không được để trống");
                }
                else
                {
                    MessageBox.Show("Mã số người dùng bị trùng");
                }
                txtMaND.Focus();
            }
            else if (hoten == null)
            {
                MessageBox.Show("Họ tên không được để trống");
                txtHoTen.Focus();
            }
            else if (chucvu == null)
            {
                MessageBox.Show("Chức vụ không được để trống");
                txtChucVu.Focus();
            }
            else if (phanquyen == null)
            {
                MessageBox.Show("Phân quyền không được để trống");
                txtPhanQuyen.Focus();
            }
            else
            {
                try
                {
                    NguoiDungBUS.Sua(nv);
                }
                catch
                {
                    txtMaND.Clear();
                    TrungMaND = true;
                    goto Nhaplai;
                }
                MessageBox.Show("Thêm người dùng  thành công", "Thông báo");
                this.Close();
            }
        }

    }
}
