using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data;

namespace BUS
{
    // lớp kết nối giữa lớp Presentation và DAO
    public class NhanVienBUS
    {

        public static DataTable LoadDSNV()
        {
            return NhanVienDAO.LoadDSNV();
        }

        public static void Them(NhanVienDTO nv)
        {
            NhanVienDAO.Them(nv);
        }

        public static void Sua(NhanVienDTO nv)
        {
            NhanVienDAO.Sua(nv);
        }

        public static void Xoa(string manv)
        {
            NhanVienDAO.Xoa(manv);
        }
        public static DataTable TimTheoMaNV(string manv)
        {
            return NhanVienDAO.TimTheoMaNV(manv);
        }
        public static DataTable TimTheoHoTen(string hoten)
        {
            return NhanVienDAO.TimTheoHoTen(hoten);
        }

        public static DataTable TimTheoSDT(string sdt)
        {
            return NhanVienDAO.TimTheoSDT(sdt);
        }
    }
}
