using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

namespace QuanLyCinema
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class GiaoDien : Window
    {
       
        public GiaoDien()
        {
            InitializeComponent();
        }

       

        private void ButtonFechar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

      

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = ListViewMenu.SelectedIndex;
            MoveCursorMenu(index);

            switch (index)
            {
                case 0:
                   GridHienThi.Children.Clear();
                   GridHienThi.Children.Add(new TongQuan());
                    break;
                case 1:
                   GridHienThi.Children.Clear();
                   GridHienThi.Children.Add(new NhanVien());
                    break;
                default:
                    break;
            }
        }

        private void MoveCursorMenu(int index)
        {
            //TrainsitionigContentSlide.OnApplyTemplate();
            //GridMenu.Margin = new Thickness(0, (100 + (60 * index)), 0, 0);
        }
    }
}
