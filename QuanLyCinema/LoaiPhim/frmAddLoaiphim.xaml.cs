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

namespace QuanLyCinema.LoaiPhim
{
    /// <summary>
    /// Interaction logic for frmAddLoaiphim.xaml
    /// </summary>
    public partial class frmAddLoaiphim : Window
    {
        public frmAddLoaiphim()
        {
            InitializeComponent();
        }

        private void BtnLuu_Click(object sender, RoutedEventArgs e)
        {
            bool TrungMaLP = false;
        Nhaplai:
            string malp = null;
            if (txtMaLP.Text.Length != 0)
            {
                malp = txtMaLP.Text;

            }
            string tenlp = null;
            if (txtTenlp.Text.Length != 0)
            {
                tenlp = txtTenlp.Text;
            }

            string mota = null;
            if (txtMota.Text.Length != 0)

            {
                mota = txtMota.Text;
            }



            

            LoaiPhimDTO lp = new LoaiPhimDTO(malp,tenlp,mota);


            // báo lỗi nếu chưa nhập theo thứ tự trừ trên xuống , trái sang phải

            if (malp == null)
            {
                if (TrungMaLP == false)
                {
                    MessageBox.Show("Chưa nhập mã loại phim");
                    txtMaLP.Focus();
                }
                else
                {
                    MessageBox.Show("Mã loại phim trùng");
                    txtMaLP.Focus();
                }

            }
            else if (tenlp == null)
            {
                MessageBox.Show("Chưa nhập họ tên");
                txtTenlp.Focus();
            }
            else if (mota == null)
            {
                MessageBox.Show("Chưa nhập địa chỉ");
                txtMota.Focus();
            }
            
            else
            {
                try
                {
                    LoaiPhimBUS.Them(lp);
                }
                catch
                {
                    txtMaLP.Clear();
                    TrungMaLP = true;
                    goto Nhaplai;
                }

                MessageBox.Show("Thêm loại phim mới thành công", "Thông báo");
                this.Close();
            }
        }

        private void BtnHuy_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnLamMoi_Click(object sender, RoutedEventArgs e)
        {           
            txtMaLP.Clear();
            txtMota.Clear();
            txtTenlp.Clear();
        }
    }
}
