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

namespace QuanLyCinema
{
    /// <summary>
    /// Interaction logic for RefactoringTest.xaml
    /// </summary>
    public partial class RefactoringTest : Window
    {
        private NhanVienBUS nhanVienBUS;
        public RefactoringTest()
        {
            InitializeComponent();
            nhanVienBUS = new NhanVienBUS();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NhanVienDTO nv = new NhanVienDTO();
            nv = nhanVienBUS.TimTheoMaNhanVien(txtMaNv.Text);
            if (nv == null)
            {
                MessageBox.Show("No Match Found", "No Match Found", MessageBoxButton.OK);
            }
            else
            {
                MessageBox.Show($"{nv.MaNV} {nv.HoTen} Found!", "Found", MessageBoxButton.OK);
            }
        }
    }
}
