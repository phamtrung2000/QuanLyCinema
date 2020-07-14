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

namespace QuanLyCinema.GiaoDienKhachHang
{
    /// <summary>
    /// Interaction logic for frmThongTinGhe.xaml
    /// </summary>
    public partial class frmThongTinGhe : UserControl
    {
        public frmThongTinGhe()
        {
            InitializeComponent();
            txtManhinh.IsReadOnly = true;
            txtHienThiGheDaChon.IsReadOnly = true;
        }
        int count = 0;
        // Ghế A1


        bool check = false;
        // Check hàng A
        bool checkA1 = false;
        bool checkA2 = false;
        bool checkA3 = false;
        bool checkA4 = false;
        bool checkA5 = false;
        bool checkA6 = false;
        bool checkA7 = false;
        bool checkA8 = false;
        bool checkA9 = false;
        bool checkA10 = false;
        bool checkA11 = false;
        // sao k code hnagf A B CD mà code hnafg 1 2 chi mệt v // 
        // Check hàng B
        bool checkB1 = false;
        bool checkB2 = false;
        bool checkB3 = false;
        bool checkB4 = false;
        bool checkB5 = false;
        bool checkB6 = false;
        bool checkB7 = false;
        bool checkB8 = false;
        bool checkB9 = false;
        bool checkB10 = false;
        bool checkB11 = false;
        // Check hàng C
        bool checkC1 = false;
        bool checkC2 = false;
        bool checkC3 = false;
        bool checkC4 = false;
        bool checkC5 = false;
        bool checkC6 = false;
        bool checkC7 = false;
        bool checkC8 = false;
        bool checkC9 = false;
        bool checkC10 = false;
        bool checkC11 = false;
        // Check hàng D
        bool checkD1 = false;
        bool checkD2 = false;
        bool checkD3 = false;
        bool checkD4 = false;
        bool checkD5 = false;
        bool checkD6 = false;
        bool checkD7 = false;
        bool checkD8 = false;
        bool checkD9 = false;
        bool checkD10 = false;
        bool checkD11 = false;
        // Check hàng E
        bool checkE1 = false;
        bool checkE2 = false;
        bool checkE3 = false;
        bool checkE4 = false;
        bool checkE5 = false;
        bool checkE6 = false;
        bool checkE7 = false;
        bool checkE8 = false;
        bool checkE9 = false;
        bool checkE10 = false;
        bool checkE11 = false;
        // Check hàng F
        bool checkF1 = false;
        bool checkF2 = false;
        bool checkF3 = false;
        bool checkF4 = false;
        bool checkF5 = false;
        bool checkF6 = false;
        bool checkF7 = false;
        bool checkF8 = false;
        bool checkF9 = false;
        bool checkF10 = false;
        bool checkF11 = false;
        // Check hàng G
        bool checkG1 = false;
        bool checkG2 = false;
        bool checkG3 = false;
        bool checkG4 = false;
        bool checkG5 = false;
        bool checkG6 = false;
        bool checkG7 = false;
        bool checkG8 = false;
        bool checkG9 = false;
        bool checkG10 = false;
        bool checkG11 = false;

        // Check hàng H
        bool checkH1 = false;
        bool checkH2 = false;
        bool checkH3 = false;
        bool checkH4 = false;
        bool checkH5 = false;
        bool checkH6 = false;
        bool checkH7 = false;
        bool checkH8 = false;
        bool checkH9 = false;
        bool checkH10 = false;
        bool checkH11 = false;

        // string hienthi_ghedachon;

        void ChuotEnterGhe(object sender, RoutedEventArgs e)
        {
            Button temp = (Button)sender;
            temp.Foreground = Brushes.Black;

        }

        void ChuotLeaveGhe(object sender, RoutedEventArgs e)
        {
            Button temp = (Button)sender;
            temp.Foreground = Brushes.White;
        }

        void CheckHangGheA(object sender, RoutedEventArgs e, bool check_temp)
        {
            Button temp = (Button)sender;
            if (check_temp == true)
            {
                temp.Background = Brushes.Green;
                temp.Foreground = Brushes.White;
                count++;
                if (txtHienThiGheDaChon.Text.Length == 0)
                {
                    txtHienThiGheDaChon.Text += temp.Name;
                }
                else
                    txtHienThiGheDaChon.Text += ", " + temp.Name;

                if (count > 10)
                {
                    MessageBox.Show("CC");
                }
            }
            else
            {
                temp.Background = Brushes.White;
                temp.Foreground = Brushes.Black;
                count--;
                int vitrixoa = txtHienThiGheDaChon.Text.IndexOf(temp.Name);
                if (vitrixoa <= 2)
                {
                    if (txtHienThiGheDaChon.Text.Length == 2)

                    {
                        txtHienThiGheDaChon.Text = txtHienThiGheDaChon.Text.Remove(vitrixoa, temp.Name.Length);
                    }
                    else
                        txtHienThiGheDaChon.Text = txtHienThiGheDaChon.Text.Remove(vitrixoa, temp.Name.Length + 2);
                }
                else
                    txtHienThiGheDaChon.Text = txtHienThiGheDaChon.Text.Remove(vitrixoa - 2, temp.Name.Length + 2);
            }
        }



        private void A1_Click(object sender, RoutedEventArgs e)
        {
            if (checkA1 == false)
                checkA1 = true;
            else
                checkA1 = false;
            CheckHangGheA(sender, e, checkA1);

        }
        private void A1_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void A1_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }


        private void A2_Click(object sender, RoutedEventArgs e)
        {
            if (checkA2 == false)
                checkA2 = true;
            else
                checkA2 = false;
            CheckHangGheA(sender, e, checkA2);
        }
        private void A2_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void A2_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }

        // ghế C3 
        private void A3_Click(object sender, RoutedEventArgs e)
        {
            if (checkA3 == false)
                checkA3 = true;
            else
                checkA3 = false;
            CheckHangGheA(sender, e, checkA3);
        }
        private void A3_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void A3_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }
        // ghế A4
        private void A4_Click(object sender, RoutedEventArgs e)
        {
            if (checkA4 == false)
                checkA4 = true;
            else
                checkA4 = false;
            CheckHangGheA(sender, e, checkA4);
        }
        private void A4_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void A4_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }
        //Ghế A5
        private void A5_Click(object sender, RoutedEventArgs e)
        {
            if (checkA5 == false)
                checkA5 = true;
            else
                checkA5 = false;
            CheckHangGheA(sender, e, checkA5);
        }
        private void A5_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void A5_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }
        //Ghế A6
        private void A6_Click(object sender, RoutedEventArgs e)
        {
            if (checkA6 == false)
                checkA6 = true;
            else
                checkA6 = false;
            CheckHangGheA(sender, e, checkA6);
        }
        private void A6_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void A6_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }
        //Ghế A7
        private void A7_Click(object sender, RoutedEventArgs e)
        {
            if (checkA7 == false)
                checkA7 = true;
            else
                checkA7 = false;
            CheckHangGheA(sender, e, checkA7);
        }
        private void A7_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void A7_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }
        //Ghế A8
        private void A8_Click(object sender, RoutedEventArgs e)
        {
            if (checkA8 == false)
                checkA8 = true;
            else
                checkA8 = false;
            CheckHangGheA(sender, e, checkA8);
        }
        private void A8_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void A8_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }
        // Ghế A9
        private void A9_Click(object sender, RoutedEventArgs e)
        {
            if (checkA9 == false)
                checkA9 = true;
            else
                checkA9 = false;
            CheckHangGheA(sender, e, checkA9);
        }
        private void A9_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void A9_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }
        // Ghế A10
        private void A10_Click(object sender, RoutedEventArgs e)
        {
            if (checkA10 == false)
                checkA10 = true;
            else
                checkA10 = false;
            CheckHangGheA(sender, e, checkA10);
        }
        private void A10_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void A10_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }
        // Ghế A11
        private void A11_Click(object sender, RoutedEventArgs e)
        {
            if (checkA11 == false)
                checkA11 = true;
            else
                checkA11 = false;
            CheckHangGheA(sender, e, checkA11);
        }
        private void A11_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void A11_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }
        // Ghế B1
        private void B1_Click(object sender, RoutedEventArgs e)
        {
            if (checkB1 == false)
                checkB1 = true;
            else
                checkB1 = false;
            CheckHangGheA(sender, e, checkB1);

        }
        private void B1_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void B1_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }


        private void B2_Click(object sender, RoutedEventArgs e)
        {
            if (checkB2 == false)
                checkB2 = true;
            else
                checkB2 = false;
            CheckHangGheA(sender, e, checkB2);
        }
        private void B2_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void B2_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }

        // ghế B3 
        private void B3_Click(object sender, RoutedEventArgs e)
        {
            if (checkB3 == false)
                checkB3 = true;
            else
                checkB3 = false;
            CheckHangGheA(sender, e, checkB3);
        }
        private void B3_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void B3_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }
        // ghế B4
        private void B4_Click(object sender, RoutedEventArgs e)
        {
            if (checkB4 == false)
                checkB4 = true;
            else
                checkB4 = false;
            CheckHangGheA(sender, e, checkB4);
        }
        private void B4_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void B4_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }
        //Ghế B5
        private void B5_Click(object sender, RoutedEventArgs e)
        {
            if (checkB5 == false)
                checkB5 = true;
            else
                checkB5 = false;
            CheckHangGheA(sender, e, checkB5);
        }
        private void B5_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void B5_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }
        //Ghế B6
        private void B6_Click(object sender, RoutedEventArgs e)
        {
            if (checkB6 == false)
                checkB6 = true;
            else
                checkB6 = false;
            CheckHangGheA(sender, e, checkB6);
        }
        private void B6_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void B6_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }
        //Ghế B7
        private void B7_Click(object sender, RoutedEventArgs e)
        {
            if (checkB7 == false)
                checkB7 = true;
            else
                checkB7 = false;
            CheckHangGheA(sender, e, checkB7);
        }
        private void B7_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void B7_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }
        //Ghế B8
        private void B8_Click(object sender, RoutedEventArgs e)
        {
            if (checkB8 == false)
                checkB8 = true;
            else
                checkB8 = false;
            CheckHangGheA(sender, e, checkB8);
        }
        private void B8_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void B8_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }
        // Ghế B9
        private void B9_Click(object sender, RoutedEventArgs e)
        {
            if (checkB9 == false)
                checkB9 = true;
            else
                checkB9 = false;
            CheckHangGheA(sender, e, checkB9);
        }
        private void B9_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void B9_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }
        // Ghế B10
        private void B10_Click(object sender, RoutedEventArgs e)
        {
            if (checkB10 == false)
                checkB10 = true;
            else
                checkB10 = false;
            CheckHangGheA(sender, e, checkB10);
        }
        private void B10_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void B10_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }
        // Ghế B11
        private void B11_Click(object sender, RoutedEventArgs e)
        {
            if (checkB11 == false)
                checkB11 = true;
            else
                checkB11 = false;
            CheckHangGheA(sender, e, checkB11);
        }
        private void B11_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void B11_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }
        // Ghế C1
        private void C1_Click(object sender, RoutedEventArgs e)
        {
            if (checkC1 == false)
                checkC1 = true;
            else
                checkC1 = false;
            CheckHangGheA(sender, e, checkC1);

        }
        private void C1_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void C1_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }


        private void C2_Click(object sender, RoutedEventArgs e)
        {
            if (checkC2 == false)
                checkC2 = true;
            else
                checkC2 = false;
            CheckHangGheA(sender, e, checkC2);
        }
        private void C2_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void C2_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }

        // ghế C3 
        private void C3_Click(object sender, RoutedEventArgs e)
        {
            if (checkC3 == false)
                checkC3 = true;
            else
                checkC3 = false;
            CheckHangGheA(sender, e, checkC3);
        }
        private void C3_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void C3_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }
        // ghế C4
        private void C4_Click(object sender, RoutedEventArgs e)
        {
            if (checkC4 == false)
                checkC4 = true;
            else
                checkC4 = false;
            CheckHangGheA(sender, e, checkC4);
        }
        private void C4_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void C4_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }
        //Ghế C5
        private void C5_Click(object sender, RoutedEventArgs e)
        {
            if (checkC5 == false)
                checkC5 = true;
            else
                checkC5 = false;
            CheckHangGheA(sender, e, checkC5);
        }
        private void C5_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void C5_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }
        //Ghế C6
        private void C6_Click(object sender, RoutedEventArgs e)
        {
            if (checkC6 == false)
                checkC6 = true;
            else
                checkC6 = false;
            CheckHangGheA(sender, e, checkC6);
        }
        private void C6_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void C6_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }
        //Ghế C7
        private void C7_Click(object sender, RoutedEventArgs e)
        {
            if (checkC7 == false)
                checkC7 = true;
            else
                checkC7 = false;
            CheckHangGheA(sender, e, checkC7);
        }
        private void C7_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void C7_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }
        //Ghế C8
        private void C8_Click(object sender, RoutedEventArgs e)
        {
            if (checkC8 == false)
                checkC8 = true;
            else
                checkC8 = false;
            CheckHangGheA(sender, e, checkC8);
        }
        private void C8_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void C8_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }
        // Ghế C9
        private void C9_Click(object sender, RoutedEventArgs e)
        {
            if (checkC9 == false)
                checkC9 = true;
            else
                checkC9 = false;
            CheckHangGheA(sender, e, checkC9);
        }
        private void C9_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void C9_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }
        // Ghế C10
        private void C10_Click(object sender, RoutedEventArgs e)
        {
            if (checkC10 == false)
                checkC10 = true;
            else
                checkC10 = false;
            CheckHangGheA(sender, e, checkC10);
        }
        private void C10_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void C10_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }
        // Ghế C11
        private void C11_Click(object sender, RoutedEventArgs e)
        {
            if (checkC11 == false)
                checkC11 = true;
            else
                checkC11 = false;
            CheckHangGheA(sender, e, checkC11);
        }
        private void C11_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void C11_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }

        //Ghế D1
        private void D1_Click(object sender, RoutedEventArgs e)
        {
            if (checkD1 == false)
                checkD1 = true;
            else
                checkD1 = false;
            CheckHangGheA(sender, e, checkD1);

        }
        private void D1_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void D1_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }


        private void D2_Click(object sender, RoutedEventArgs e)
        {
            if (checkD2 == false)
                checkD2 = true;
            else
                checkD2 = false;
            CheckHangGheA(sender, e, checkD2);
        }
        private void D2_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void D2_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }

        // ghế D3 
        private void D3_Click(object sender, RoutedEventArgs e)
        {
            if (checkD3 == false)
                checkD3 = true;
            else
                checkD3 = false;
            CheckHangGheA(sender, e, checkD3);
        }
        private void D3_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void D3_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }
        // ghế D4
        private void D4_Click(object sender, RoutedEventArgs e)
        {
            if (checkD4 == false)
                checkD4 = true;
            else
                checkD4 = false;
            CheckHangGheA(sender, e, checkD4);
        }
        private void D4_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void D4_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }
        //Ghế D5
        private void D5_Click(object sender, RoutedEventArgs e)
        {
            if (checkD5 == false)
                checkD5 = true;
            else
                checkD5 = false;
            CheckHangGheA(sender, e, checkD5);
        }
        private void D5_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void D5_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }
        //Ghế D6
        private void D6_Click(object sender, RoutedEventArgs e)
        {
            if (checkD6 == false)
                checkD6 = true;
            else
                checkD6 = false;
            CheckHangGheA(sender, e, checkD6);
        }
        private void D6_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void D6_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }
        //Ghế D7
        private void D7_Click(object sender, RoutedEventArgs e)
        {
            if (checkD7 == false)
                checkD7 = true;
            else
                checkD7 = false;
            CheckHangGheA(sender, e, checkD7);
        }
        private void D7_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void D7_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }
        //Ghế D8
        private void D8_Click(object sender, RoutedEventArgs e)
        {
            if (checkD8 == false)
                checkD8 = true;
            else
                checkD8 = false;
            CheckHangGheA(sender, e, checkD8);
        }
        private void D8_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void D8_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }
        // Ghế D9
        private void D9_Click(object sender, RoutedEventArgs e)
        {
            if (checkD9 == false)
                checkD9 = true;
            else
                checkD9 = false;
            CheckHangGheA(sender, e, checkD9);
        }
        private void D9_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void D9_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }
        // Ghế D10
        private void D10_Click(object sender, RoutedEventArgs e)
        {
            if (checkD10 == false)
                checkD10 = true;
            else
                checkD10 = false;
            CheckHangGheA(sender, e, checkD10);
        }
        private void D10_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void D10_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }
        // Ghế D11
        private void D11_Click(object sender, RoutedEventArgs e)
        {
            if (checkD11 == false)
                checkD11 = true;
            else
                checkD11 = false;
            CheckHangGheA(sender, e, checkD11);
        }
        private void D11_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void D11_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }

        // Ghế E1
        private void E1_Click(object sender, RoutedEventArgs e)
        {
            if (checkE1 == false)
                checkE1 = true;
            else
                checkE1 = false;
            CheckHangGheA(sender, e, checkE1);

        }
        private void E1_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void E1_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }


        private void E2_Click(object sender, RoutedEventArgs e)
        {
            if (checkE2 == false)
                checkE2 = true;
            else
                checkE2 = false;
            CheckHangGheA(sender, e, checkE2);
        }
        private void E2_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void E2_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }

        // ghế E3 
        private void E3_Click(object sender, RoutedEventArgs e)
        {
            if (checkE3 == false)
                checkE3 = true;
            else
                checkE3 = false;
            CheckHangGheA(sender, e, checkE3);
        }
        private void E3_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void E3_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }
        // ghế E4
        private void E4_Click(object sender, RoutedEventArgs e)
        {
            if (checkE4 == false)
                checkE4 = true;
            else
                checkE4 = false;
            CheckHangGheA(sender, e, checkE4);
        }
        private void E4_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void E4_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }
        //Ghế E5
        private void E5_Click(object sender, RoutedEventArgs e)
        {
            if (checkE5 == false)
                checkE5 = true;
            else
                checkE5 = false;
            CheckHangGheA(sender, e, checkE5);
        }
        private void E5_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void E5_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }
        //Ghế E6
        private void E6_Click(object sender, RoutedEventArgs e)
        {
            if (checkE6 == false)
                checkE6 = true;
            else
                checkE6 = false;
            CheckHangGheA(sender, e, checkE6);
        }
        private void E6_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void E6_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }
        //Ghế E7
        private void E7_Click(object sender, RoutedEventArgs e)
        {
            if (checkE7 == false)
                checkE7 = true;
            else
                checkE7 = false;
            CheckHangGheA(sender, e, checkE7);
        }
        private void E7_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void E7_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }
        //Ghế E8
        private void E8_Click(object sender, RoutedEventArgs e)
        {
            if (checkE8 == false)
                checkE8 = true;
            else
                checkE8 = false;
            CheckHangGheA(sender, e, checkE8);
        }
        private void E8_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void E8_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }
        // Ghế E9
        private void E9_Click(object sender, RoutedEventArgs e)
        {
            if (checkE9 == false)
                checkE9 = true;
            else
                checkE9 = false;
            CheckHangGheA(sender, e, checkE9);
        }
        private void E9_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void E9_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }
        // Ghế E10
        private void E10_Click(object sender, RoutedEventArgs e)
        {
            if (checkE10 == false)
                checkE10 = true;
            else
                checkE10 = false;
            CheckHangGheA(sender, e, checkE10);
        }
        private void E10_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void E10_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }
        // Ghế E11
        private void E11_Click(object sender, RoutedEventArgs e)
        {
            if (checkE11 == false)
                checkE11 = true;
            else
                checkE11 = false;
            CheckHangGheA(sender, e, checkE11);
        }
        private void E11_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void E11_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }

        //Ghế F1
        private void F1_Click(object sender, RoutedEventArgs e)
        {
            if (checkF1 == false)
                checkF1 = true;
            else
                checkF1 = false;
            CheckHangGheA(sender, e, checkF1);

        }
        private void F1_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void F1_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }


        private void F2_Click(object sender, RoutedEventArgs e)
        {
            if (checkF2 == false)
                checkF2 = true;
            else
                checkF2 = false;
            CheckHangGheA(sender, e, checkF2);
        }
        private void F2_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void F2_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }

        // ghế F3 
        private void F3_Click(object sender, RoutedEventArgs e)
        {
            if (checkF3 == false)
                checkF3 = true;
            else
                checkF3 = false;
            CheckHangGheA(sender, e, checkF3);
        }
        private void F3_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void F3_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }
        // ghế F4
        private void F4_Click(object sender, RoutedEventArgs e)
        {
            if (checkF4 == false)
                checkF4 = true;
            else
                checkF4 = false;
            CheckHangGheA(sender, e, checkF4);
        }
        private void F4_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void F4_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }
        //Ghế F5
        private void F5_Click(object sender, RoutedEventArgs e)
        {
            if (checkF5 == false)
                checkF5 = true;
            else
                checkF5 = false;
            CheckHangGheA(sender, e, checkF5);
        }
        private void F5_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void F5_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }
        //Ghế F6
        private void F6_Click(object sender, RoutedEventArgs e)
        {
            if (checkF6 == false)
                checkF6 = true;
            else
                checkF6 = false;
            CheckHangGheA(sender, e, checkF6);
        }
        private void F6_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void F6_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }
        //Ghế F7
        private void F7_Click(object sender, RoutedEventArgs e)
        {
            if (checkF7 == false)
                checkF7 = true;
            else
                checkF7 = false;
            CheckHangGheA(sender, e, checkF7);
        }
        private void F7_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void F7_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }
        //Ghế F8
        private void F8_Click(object sender, RoutedEventArgs e)
        {
            if (checkF8 == false)
                checkF8 = true;
            else
                checkF8 = false;
            CheckHangGheA(sender, e, checkF8);
        }
        private void F8_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void F8_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }
        // Ghế F9
        private void F9_Click(object sender, RoutedEventArgs e)
        {
            if (checkF9 == false)
                checkF9 = true;
            else
                checkF9 = false;
            CheckHangGheA(sender, e, checkF9);
        }
        private void F9_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void F9_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }
        // Ghế F10
        private void F10_Click(object sender, RoutedEventArgs e)
        {
            if (checkF10 == false)
                checkF10 = true;
            else
                checkF10 = false;
            CheckHangGheA(sender, e, checkF10);
        }
        private void F10_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void F10_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }
        // Ghế F11
        private void F11_Click(object sender, RoutedEventArgs e)
        {
            if (checkF11 == false)
                checkF11 = true;
            else
                checkF11 = false;
            CheckHangGheA(sender, e, checkF11);
        }
        private void F11_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void F11_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }

        //Ghế G1
        private void G1_Click(object sender, RoutedEventArgs e)
        {
            if (checkG1 == false)
                checkG1 = true;
            else
                checkG1 = false;
            CheckHangGheA(sender, e, checkG1);

        }
        private void G1_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void G1_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }


        private void G2_Click(object sender, RoutedEventArgs e)
        {
            if (checkG2 == false)
                checkG2 = true;
            else
                checkG2 = false;
            CheckHangGheA(sender, e, checkG2);
        }
        private void G2_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void G2_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }

        // ghế G3 
        private void G3_Click(object sender, RoutedEventArgs e)
        {
            if (checkG3 == false)
                checkG3 = true;
            else
                checkG3 = false;
            CheckHangGheA(sender, e, checkG3);
        }
        private void G3_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void G3_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }
        // ghế G4
        private void G4_Click(object sender, RoutedEventArgs e)
        {
            if (checkG4 == false)
                checkG4 = true;
            else
                checkG4 = false;
            CheckHangGheA(sender, e, checkG4);
        }
        private void G4_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void G4_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }
        //Ghế G5
        private void G5_Click(object sender, RoutedEventArgs e)
        {
            if (checkG5 == false)
                checkG5 = true;
            else
                checkG5 = false;
            CheckHangGheA(sender, e, checkG5);
        }
        private void G5_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void G5_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }
        //Ghế G6
        private void G6_Click(object sender, RoutedEventArgs e)
        {
            if (checkG6 == false)
                checkG6 = true;
            else
                checkG6 = false;
            CheckHangGheA(sender, e, checkG6);
        }
        private void G6_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void G6_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }
        //Ghế G7
        private void G7_Click(object sender, RoutedEventArgs e)
        {
            if (checkG7 == false)
                checkG7 = true;
            else
                checkG7 = false;
            CheckHangGheA(sender, e, checkG7);
        }
        private void G7_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void G7_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }
        //Ghế G8
        private void G8_Click(object sender, RoutedEventArgs e)
        {
            if (checkG8 == false)
                checkG8 = true;
            else
                checkG8 = false;
            CheckHangGheA(sender, e, checkG8);
        }
        private void G8_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void G8_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }
        // Ghế G9
        private void G9_Click(object sender, RoutedEventArgs e)
        {
            if (checkG9 == false)
                checkG9 = true;
            else
                checkG9 = false;
            CheckHangGheA(sender, e, checkG9);
        }
        private void G9_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void G9_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }
        // Ghế G10
        private void G10_Click(object sender, RoutedEventArgs e)
        {
            if (checkG10 == false)
                checkG10 = true;
            else
                checkG10 = false;
            CheckHangGheA(sender, e, checkG10);
        }
        private void G10_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void G10_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }
        // Ghế G11
        private void G11_Click(object sender, RoutedEventArgs e)
        {
            if (checkG11 == false)
                checkG11 = true;
            else
                checkG11 = false;
            CheckHangGheA(sender, e, checkG11);
        }
        private void G11_MouseEnter(object sender, MouseEventArgs e)
        {
            ChuotEnterGhe(sender, e);
        }
        private void G11_MouseLeave(object sender, MouseEventArgs e)
        {
            ChuotLeaveGhe(sender, e);
        }

        //Ghế H1




        private void txtHienThiGheDaChon_TextChanged(object sender, TextChangedEventArgs e)
        {
            //int n = txtHienThiGheDaChon.Text.Length;
            //if(n>0)
            //{
            //    if (txtHienThiGheDaChon.Text[n - 1] != ',')
            //    {
            //        txtHienThiGheDaChon.Text += ",";
            //    }
            //    if (n > 1)
            //    {

            //        if (txtHienThiGheDaChon.Text[n - 1] == ',' && txtHienThiGheDaChon.Text[n - 2] == ',')
            //        {
            //            txtHienThiGheDaChon.Text = txtHienThiGheDaChon.Text.Remove(n - 1, 1);
            //            // đụ má string đéo trừ dc
            //            // big city boi pơ phẹc big city big city boi yeah big city big city boi cặc gì v ? éo bt
            //            // từ từ còn 1 TH
            //        }
            //    }
            //    if (n == 1)
            //    {
            //        if (txtHienThiGheDaChon.Text[n - 1] == ',')
            //            txtHienThiGheDaChon.Text = txtHienThiGheDaChon.Text.Remove(n - 1, 1);
            //        // để yên bố debug //lô cc
            //    }
            //} 
        }
        private void bt_back_Click(object sender, RoutedEventArgs e)
        {
            grid_hienthi.Children.Clear();
            grid_hienthi.Children.Add(new frmThongTinDatVe());
        }




        // r xóa dấu phẩy đi bạn
        // t nghĩ cái hàm lồn này sẽ đéo baoh xóa đc 
        // s ko thêm lên chỗ kia
    }
}
