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

namespace QuanLyCinema.GiaoDien
{
    /// <summary>
    /// Interaction logic for frmNguoiDung.xaml
    /// </summary>
    public partial class frmNguoiDung : UserControl
    {
        public frmNguoiDung()
        {
            InitializeComponent();
        }

        //void ChoPhepNhap()
        //{
        //    txtHoTen.IsReadOnly = txtMaND.IsReadOnly = txtChucVu.IsReadOnly = txtPhanQuyen.IsReadOnly = false;
        //    txtHoTen.Focus();
        //}

        //void KhongChoNhap()
        //{
        //    txtHoTen.Clear();
        //    txtMaND.Clear();
        //    txtChucVu.Clear();
        //    txtPhanQuyen.Clear();
         
        //    txtHoTen.IsReadOnly = txtMaND.IsReadOnly = txtChucVu.IsReadOnly = txtPhanQuyen.IsReadOnly = true;
        //}

        //private void GridNhanVien_Loaded(object sender, RoutedEventArgs e)
        //{
        //    KhongChoNhap();
        //    dtgDSND.ItemsSource = NguoiDungBUS.LoadDSND().DefaultView;
        //    panelTimKiem.Visibility = btnHuy_Sua.Visibility = Visibility.Hidden;
        //}

        //private void dtgDSND_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    DataGrid dg = sender as DataGrid;
        //    DataRowView dr = dg.SelectedItem as DataRowView;
        //    if (dr != null)
        //    {
        //        txtMaND.Text = dr["MANV"].ToString();
        //        txtHoTen.Text = dr["HOTEN"].ToString();
        //        txtChucVu.Text = dr["CHUCVU"].ToString();
        //        txtPhanQuyen.Text = dr["SDT"].ToString();

        //        string gioitinh = dr["GIOITINH"].ToString();
        //        if (gioitinh == "Nam")
        //            rdbNam.IsChecked = true;
        //        else if (gioitinh == "Nữ")
        //            rdbNu.IsChecked = true;

        //        dtpNgaySinh.SelectedDate = DateTime.Parse(dr["NGAYSINH"].ToString());
        //        txtDiaChi.Text = dr["DIACHI"].ToString();
        //        txtLuong.Text = dr["LUONG"].ToString();
        //        dtpNgayVL.SelectedDate = DateTime.Parse(dr["NGAYVL"].ToString());
        //    }
        //}

        //private void btnThem_Click(object sender, RoutedEventArgs e)
        //{
        //    frmAddNhanVien addNhanVien = new frmAddNhanVien();
        //    addNhanVien.ShowDialog();
        //    dtgDSND.ItemsSource = NguoiDungBUS.LoadDSND().DefaultView;
        //    KhongChoNhap();
        //    btnThem.Visibility = Visibility.Visible;
        //    btnSua.IsEnabled = btnXoa.IsEnabled = true;
        //}

        //private void btnXoa_Click(object sender, RoutedEventArgs e)
        //{
        //    MessageBoxResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không?", "Thông Báo", MessageBoxButton.YesNo, MessageBoxImage.Question);
        //    if (result == MessageBoxResult.Yes)
        //    {
        //        NguoiDungBUS.Xoa(txtMaND.Text);
        //        MessageBox.Show("Xóa nhân viên thành công", "Thông Báo");
        //    }
        //    dtgDSND.ItemsSource = NguoiDungBUS.LoadDSND().DefaultView;
        //}

        //private void btnSua_Click(object sender, RoutedEventArgs e)
        //{
        //    ChoPhepNhap();
        //    btnLuu_Sua.Visibility = Visibility.Visible;
        //    btnHuy_Sua.Visibility = Visibility.Visible;
        //    btnSua.Visibility = Visibility.Hidden;
        //    btnThem.IsEnabled = btnXoa.IsEnabled = false;
        //}

        //private void btnLuu_Sua_Click(object sender, RoutedEventArgs e)

        //{
        //    bool TrungMaNV = false;
        //SuaLai:
        //    string manv = null;
        //    if (txtMaND.Text.Length != 0)
        //    {
        //        manv = txtMaND.Text;
        //    }
        //    string hoten = null;
        //    if (txtHoTen.Text.Length != 0)
        //    {
        //        hoten = txtHoTen.Text;
        //    }
        //    string chucvu = null;
        //    if (txtChucVu.Text.Length != 0)
        //    {
        //        chucvu = txtChucVu.Text;
        //    }
        //    string sdt = null;
        //    if (txtPhanQuyen.Text.Length != 0)
        //    {
        //        sdt = txtPhanQuyen.Text;
        //    }
        //    string gioitinh = null;
        //    if (rdbNam.IsChecked == true)
        //        gioitinh = "Nam";
        //    else if (rdbNu.IsChecked == true)
        //        gioitinh = "Nữ";

        //    DateTime ngaysinh = dtpNgaySinh.DisplayDate;

        //    string diachi = null;
        //    if (txtDiaChi.Text.Length != 0)
        //    {
        //        diachi = txtDiaChi.Text;
        //    }
        //    string luong = null;
        //    if (txtLuong.Text.Length != 0)
        //    {
        //        luong = txtLuong.Text;
        //    }
        //    DateTime ngayvl = dtpNgayVL.DisplayDate;

        //    NhanVienDTO nv = new NhanVienDTO(manv, hoten, chucvu, sdt, gioitinh, ngaysinh, diachi, luong, ngayvl);


        //    if (manv == null)
        //    {
        //        if (TrungMaNV == false)
        //        {
        //            MessageBox.Show("Mã số nhân viên không được để trống");
        //        }
        //        else
        //        {
        //            MessageBox.Show("Mã số nhân viên bị trùng");
        //        }
        //        txtMaND.Focus();
        //    }
        //    else if (hoten == null)
        //    {
        //        MessageBox.Show("Họ tên không được để trống");
        //        txtHoTen.Focus();
        //    }
        //    else if (chucvu == null)
        //    {
        //        MessageBox.Show("Chức vụ không được để trống");
        //        txtChucVu.Focus();
        //    }
        //    else if (sdt == null)
        //    {
        //        MessageBox.Show("Số điện thoại không được để trống");
        //        txtPhanQuyen.Focus();
        //    }
        //    else if (gioitinh == null)
        //    {
        //        MessageBox.Show("Giới tính không được để trống");
        //        rdbNam.Focus();
        //        rdbNam.IsChecked = false;
        //    }
        //    else if (diachi == null)
        //    {
        //        MessageBox.Show("Địa chỉ không được để trống");
        //        txtDiaChi.Focus();
        //    }

        //    else if (luong == null)
        //    {
        //        MessageBox.Show("Lương không được để trống");
        //        txtLuong.Focus();
        //    }
        //    else
        //    {
        //        try
        //        {
        //            NguoiDungBUS.Sua(nv);
        //        }
        //        catch
        //        {
        //            txtMaND.Clear();
        //            TrungMaNV = true;
        //            goto SuaLai;
        //        }
        //        MessageBox.Show("Sửa thông tin nhân viên  thành công", "Thông báo");
        //        dtgDSND.ItemsSource = NguoiDungBUS.LoadDSND().DefaultView;
        //        KhongChoNhap();
        //        btnLuu_Sua.Visibility = Visibility.Hidden;
        //        btnSua.Visibility = Visibility.Visible;
        //        btnThem.IsEnabled = btnXoa.IsEnabled = true;
        //        dtgDSND.IsEnabled = true;
        //    }
        //}

        //private void btnTimKiem_Click(object sender, RoutedEventArgs e)
        //{
        //    if (panelTimKiem.Visibility == Visibility.Visible)
        //    {
        //        panelTimKiem.Visibility = Visibility.Hidden;
        //    }
        //    else
        //    {
        //        panelTimKiem.Visibility = Visibility.Visible;
        //    }
        //}

        //int type_timkiem = -1;
        //private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    String a = cbbTimKiem.SelectedItem.ToString();
        //    if (cbbTimKiem.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: Mã Nhân Viên")
        //    {
        //        type_timkiem = 0;
        //    }
        //    else if (cbbTimKiem.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: Họ Tên")
        //    {
        //        type_timkiem = 1;
        //    }
        //    else if (cbbTimKiem.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: Số Điện Thoại")
        //    {
        //        type_timkiem = 2;
        //    }
        //}


        //private void txtTimKiem_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    if (txtTimKiem.Text.Length > 1)
        //    {
        //        switch (type_timkiem)
        //        {
        //            case 0:
        //                {
        //                    dtgDSND.ItemsSource = NguoiDungBUS.TimTheoMaNV(txtTimKiem.Text.ToString()).DefaultView;
        //                }
        //                break;
        //            case 1:
        //                {
        //                    dtgDSND.ItemsSource = NguoiDungBUS.TimTheoHoTen(txtTimKiem.Text.ToString()).DefaultView;
        //                }
        //                break;
        //            case 2:
        //                {
        //                    dtgDSND.ItemsSource = NguoiDungBUS.TimTheoSDT(txtTimKiem.Text.ToString()).DefaultView;
        //                }
        //                break;
        //        }
        //    }
        //    else if (txtTimKiem.Text.Length == 0)
        //    {
        //        dtgDSND.ItemsSource = NguoiDungBUS.LoadDSND().DefaultView;
        //    }
        //}

        //private void txtTimKiem_GotFocus(object sender, RoutedEventArgs e)
        //{
        //    if (type_timkiem == -1)
        //    {
        //        MessageBox.Show("Chưa chọn mục tìm kiếm");
        //        cbbTimKiem.Focus();
        //    }
        //    else if (txtTimKiem.Text == "Tìm Kiếm...")
        //        txtTimKiem.Text = "";
        //}

        //private void txtTimKiem_LostFocus(object sender, RoutedEventArgs e)
        //{
        //    if (txtTimKiem.Text == "")
        //    {
        //        txtTimKiem.Text = "Tìm Kiếm...";
        //        dtgDSND.ItemsSource = NguoiDungBUS.LoadDSND().DefaultView;
        //    }
        //}

        //private void btnHuy_Sua_Click(object sender, RoutedEventArgs e)
        //{
        //    KhongChoNhap();
        //    btnLuu_Sua.Visibility = btnHuy_Sua.Visibility = Visibility.Hidden;
        //    btnSua.Visibility = Visibility.Visible;
        //    btnThem.IsEnabled = btnXoa.IsEnabled = true;
        //}

        //private void btnLamMoi_Click(object sender, RoutedEventArgs e)
        //{
        //    KhongChoNhap();
        //    dtgDSND.ItemsSource = NguoiDungBUS.LoadDSND().DefaultView;
        //    panelTimKiem.Visibility = btnHuy_Sua.Visibility = Visibility.Hidden;
        //}
    }
}
