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
using QuanLyCinema.NhanVien;
using DTO;
namespace QuanLyCinema
{
    /// <summary>
    /// Interaction logic for Test.xaml
    /// </summary>
    public partial class Test : UserControl
    {
        public Test()
        {
            InitializeComponent();
        }
        
        string Money(string money)
        {
            int n = money.Length;
            string kq = "";
            for (int i = n - 1; i >= 3; i -= 3)
            {
                kq = kq.Insert(0, money.Substring(i - 2, 3));
                // kq = 000
                kq = kq.Insert(0, ".");
                // .000
                money = money.Remove(i - 2, 3);
            }
            kq = kq.Insert(0, money);
            return kq;
        }
        //int rowcount = 0;
        List<NhanVienDTO> listnhanVien = new List<NhanVienDTO>();

        void Load_Data(DataTable dataTable)
        {
           
            for (int i = 0; i <= dataTable.Rows.Count - 1; i++)
            {
                object[] a = new object[10];
                a = dataTable.Rows[i].ItemArray;
                string stt = a[0].ToString();
                string manv = a[1].ToString();
                string hoten = a[2].ToString();
                string chucvu = a[3].ToString();
                string sdt = a[4].ToString();
                string gioitinh = a[5].ToString();

                DateTime ngaysinh_temp =DateTime.Parse(a[6].ToString());
                string ngaysinh = ngaysinh_temp.Day.ToString() +"/"+ ngaysinh_temp.Month.ToString() +"/"+ ngaysinh_temp.Year.ToString();

                string diachi = a[7].ToString();

                string luong = a[8].ToString();
                double luong1 = double.Parse(luong);
                luong = Money(luong1.ToString());

                DateTime ngayvl_temp = DateTime.Parse(a[9].ToString());
                string ngayvl = ngayvl_temp.Day.ToString() + "/" + ngayvl_temp.Month.ToString() + "/" + ngayvl_temp.Year.ToString();

                listnhanVien.Add(new NhanVienDTO(stt,manv,hoten,chucvu,sdt,gioitinh,"1/1/2000",diachi,luong,"1/2/2000"));
                dtgDSNV.Items.Add(listnhanVien[i]);
            }
            //dtgDSNV.ItemsSource = listnhanVien;
            //rowcount = dataTable.Rows.Count;
        }

     

        private void GridNhanVien_Loaded(object sender, RoutedEventArgs e)
        {

            DataTable dataTable = new DataTable();
            dataTable = NhanVienBUS.LoadDSNV();
            Load_Data(dataTable);
            //dtgDSNV.ItemsSource = NhanVienBUS.LoadDSNV().DefaultView;
            //NhanVienDTO nhanVien = new NhanVienDTO();
            //nhanVien.MaNV = "NV1";


            //dtgDSNV.Items.Add(nhanVien);
        }
      
    }

}
