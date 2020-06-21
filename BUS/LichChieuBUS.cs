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
    public class LichChieuBUS
    {
        public static DataTable LoadDSLC()
        {
            return LichChieuDAO.LoadDSLC();
        }
        public static void Them(LichChieuDTO lc)
        {
            LichChieuDAO.Them(lc);
        }

        public static void Sua(LichChieuDTO lc)
        {
            LichChieuDAO.Sua(lc);
        }

        public static void Xoa(DateTime ngaychieu, string maphim)
        {
            LichChieuDAO.Xoa(ngaychieu, maphim);
        }
        public static DataTable TimTheongaychieu(DateTime ngaychieu)
        {
            return LichChieuDAO.Timtheongaychieu(ngaychieu);
        }
        public static DataTable TimTheomacclc(string macc)
        {
            return LichChieuDAO.Timtheomacc(macc);
        }
        public static DataTable Timtheomapc(string mapc)
        {
            return LichChieuDAO.Timtheomapc(mapc);
        }
    }
}
