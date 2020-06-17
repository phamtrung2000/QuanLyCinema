using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DangNhapKhachHangBUS
    {
        public static bool Login(string taikhoan, string matkhau)
        {
            return DangNhapKhachHangDAO.Login(taikhoan, matkhau);
        }
        public static int isstaff(string taikhoan, string matkhau)
        {
            return DangNhapKhachHangDAO.PhanQuyen(taikhoan, matkhau);
        }

    }
}
