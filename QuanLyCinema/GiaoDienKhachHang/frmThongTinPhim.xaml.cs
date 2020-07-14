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

using System.Windows.Threading;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using BUS;
using QuanLyCinema.NhanVien;
using DTO;

namespace QuanLyCinema.GiaoDienKhachHang
{
    /// <summary>
    /// Interaction logic for frmThongTinPhim.xaml
    /// </summary>
  
    public partial class frmThongTinPhim : UserControl
    {
        List<PhimDTO> listPhim = new List<PhimDTO>();
        BitmapImage carBitmap = new BitmapImage();
        Image carImg = new Image();

        public delegate void GuiDiaChiAnh(string diachi); // gửi địa chỉ ảnh

        public GuiDiaChiAnh Sender;

        public static string DiaChi = null;

        private void Get_DiaChiAnh(string diachi)
        {
            DiaChi = diachi;
        }

        public delegate void GuiMaPhim(string diachi); // gửi địa chỉ ảnh

        public GuiMaPhim Sender_MaPhim;

        public static string MaPhim = null;

        private void Get_MaPhim(string maphim)
        {
            MaPhim = maphim;
        }

        public frmThongTinPhim()
        {
            InitializeComponent();
            Sender = new GuiDiaChiAnh(Get_DiaChiAnh);
            Sender_MaPhim = new GuiMaPhim(Get_MaPhim);
        }

        void Load_Data(DataTable dataTable)
        {
            object[] a = new object[9];
            a = dataTable.Rows[0].ItemArray;
            string maphim = a[1].ToString();
            lblTenPhim.Content = a[2].ToString();
            txtDaoDien.Text  = a[3].ToString();
            txtDienVien.Text  = a[4].ToString();
            txtND.Text = a[5].ToString();
            txtNamSX.Text = a[6].ToString();
            txtNuocSX.Text  = a[7].ToString();
            txtThoiLuong.Text  = a[8].ToString();

            DataTable dataTable_theloai = PhimBUS.LoadTheLoaiPhim(maphim);
            object[] b = new object[2];
            b = dataTable_theloai.Rows[0].ItemArray;
            txtTheLoai.Text += b[1].ToString();
            for (int j = 0; j <= dataTable_theloai.Rows.Count - 1; j++)
            {
                b = new object[2];
                b = dataTable_theloai.Rows[j].ItemArray;
                txtTheLoai.Text += ", " + b[1].ToString();
            }
        }

        private void GridfrmThongTinPhim_Loaded(object sender, RoutedEventArgs e)
        {
            // carBitmap = new BitmapImage(new Uri("pack://application:,,,/Resources/cuong-phong.jpg", UriKind.Absolute));
            carBitmap = new BitmapImage(new Uri(DiaChi, UriKind.Absolute));

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
            if (txtND.Text == "")
            {
                carImg.Width = 165;
                carImg.Height = 230;

                carImg.Source = carBitmap;
                canvas1.Children.Add(carImg);
            }

            DataTable dataTable = new DataTable();
            dataTable = PhimBUS.TimTheoMaP(MaPhim);
            Load_Data(dataTable);

        }

        void timer_Tick(object sender, EventArgs e)
        {
            if (check == true)
            {
                if (Player.Source != null)
                {
                    if (Player.NaturalDuration.HasTimeSpan)
                    {
                        lblStatus.Content = String.Format("{0} / {1}", Player.Position.ToString(@"mm\:ss"), Player.NaturalDuration.TimeSpan.ToString(@"mm\:ss"));
                        timelineSlider.SmallChange = 1;
                    }
                }
                else
                    lblStatus.Content = "No file selected...";
            }
            else
            {
                if (Player1.Source != null)
                {
                    if (Player1.NaturalDuration.HasTimeSpan)
                    {
                        lblStatus.Content = String.Format("{0} / {1}", Player1.Position.ToString(@"mm\:ss"), Player1.NaturalDuration.TimeSpan.ToString(@"mm\:ss"));
                        timelineSlider.SmallChange = 1;
                    }
                }
                else
                    lblStatus.Content = "No file selected...";
            }
        }

        private void Playbt_Click(object sender, RoutedEventArgs e)
        {
            if (check == true)
            {
                Player.Play();
                btPause.Visibility = Visibility.Visible;
                Playbt.Visibility = Visibility.Hidden;
                lblStatus.Visibility = Visibility.Visible;
            }
            else
            {
                Player1.Play();
                btPause.Visibility = Visibility.Visible;
                Playbt.Visibility = Visibility.Hidden;
                lblStatus.Visibility = Visibility.Visible;
            }
        }

        private void btStop_Click(object sender, RoutedEventArgs e)
        {
            if (check == true)
            {
                Player.Stop();
                Playbt.Visibility = Visibility.Visible;
                btPause.Visibility = Visibility.Hidden;
            }
            else
            {
                Player1.Stop();
                Playbt.Visibility = Visibility.Visible;
                btPause.Visibility = Visibility.Hidden;
            }

        }

        private void btPause_Click(object sender, RoutedEventArgs e)
        {
            if (check == true)
            {
                Player.Pause();
                Playbt.Visibility = Visibility.Visible;
                btPause.Visibility = Visibility.Hidden;
            }
            else
            {
                Player1.Pause();
                Playbt.Visibility = Visibility.Visible;
                btPause.Visibility = Visibility.Hidden;
            }
        }
        bool check = true;
        private void btNext_Click(object sender, RoutedEventArgs e)
        {
            if (check == true)
            {
                Player.Visibility = Visibility.Hidden;
                Player1.Visibility = Visibility.Visible;
                Playbt.Visibility = Visibility.Visible;
                btPause.Visibility = Visibility.Hidden;
                lblStatus.Visibility = Visibility.Hidden;
                Player.Stop();
                check = false;

            }
            else
            {
                Player1.Visibility = Visibility.Hidden;
                Player.Visibility = Visibility.Visible;
                Playbt.Visibility = Visibility.Visible;
                btPause.Visibility = Visibility.Hidden;
                lblStatus.Visibility = Visibility.Hidden;
                Player1.Stop();
                check = true;

            }
        }
        bool checkV = true;
        private void btVolume_Click(object sender, RoutedEventArgs e)
        {
            if (checkV == true)
            {
                SliderVolume.Visibility = Visibility.Visible;
                checkV = false;
                TextB.Visibility = Visibility.Visible;
            }
            else
            {
                SliderVolume.Visibility = Visibility.Hidden;
                checkV = true;
                TextB.Visibility = Visibility.Hidden;
            }
        }

        private void SliderVolume_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (check == true)
            {
                Player.Volume = (double)SliderVolume.Value;
            }
            else
            {
                Player1.Volume = (double)SliderVolume.Value;
            }
        }

        private void btBack_Click(object sender, RoutedEventArgs e)
        {
            GridfrmThongTinPhim.Children.Clear();
            GridfrmThongTinPhim.Children.Add(new frmXemThongTinPhim());
        }

        private void SeekToMediaPosition(object sender, RoutedPropertyChangedEventArgs<double> args)
        {
            int SliderValue = (int)timelineSlider.Value;

            // Overloaded constructor takes the arguments days, hours, minutes, seconds, milliseconds.
            // Create a TimeSpan with miliseconds equal to the slider value.
            if (check == true)
            {
                TimeSpan ts = new TimeSpan(0, 0, 0, 0, SliderValue);
                Player.Position = ts;
            }
            else
            {
                TimeSpan ts = new TimeSpan(0, 0, 0, 0, SliderValue);
                Player1.Position = ts;
            }
        }

        private void Player1_MediaOpened(object sender, RoutedEventArgs e)
        {

            timelineSlider.Maximum = Player1.NaturalDuration.TimeSpan.TotalMilliseconds;
            timelineSlider.SmallChange = 1;


        }

        private void btXemtrrailer_Click(object sender, RoutedEventArgs e)
        {
            Player.Visibility = Visibility.Visible;
            Player.Play();
            Playbt.Visibility = Visibility.Hidden;
            btPause.Visibility = Visibility.Visible;
            Player1.Stop();
            Player1.Visibility = Visibility.Hidden;
            check = true;
        }

        private void btXemPhim_Click(object sender, RoutedEventArgs e)
        {
            Player1.Visibility = Visibility.Visible;
            Player.Stop();
            Player.Visibility = Visibility.Hidden;
            Player1.Play();
            Playbt.Visibility = Visibility.Hidden;
            btPause.Visibility = Visibility.Visible;
            check = false;
        }

       
    }
}
