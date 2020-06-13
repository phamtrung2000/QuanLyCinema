﻿using System;
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
    public class KhachHangBUS
    {

        public static DataTable LoadDSKH()
        {
            return KhachHangDAO.LoadDSKH();
        }
        public static void Them(KhachHangDTO kh)
        {
            KhachHangDAO.Them(kh);
        }

        public static void Sua(KhachHangDTO kh)
        {
            KhachHangDAO.Sua(kh);
        }

        public static void Xoa(string makh)
        {
            KhachHangDAO.Xoa(makh);
        }

        public static DataTable TimTheoMaKH(string makh)
        {
            return KhachHangDAO.TimTheoMaKH(makh);
        }
        public static DataTable TimTheoHoTen(string hoten)
        {
            return KhachHangDAO.TimTheoHoTen(hoten);
        }

        public static DataTable TimTheoSDT(string sdt)
        {
            return KhachHangDAO.TimTheoSDT(sdt);
        }

    }
}

