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
        private NhanVienDAO nhanVienDAO;
        public NhanVienBUS()
        {
            nhanVienDAO = new NhanVienDAO();
        }

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

        public NhanVienDTO TimTheoMaNhanVien(string manv)
        {
            NhanVienDTO nv = new NhanVienDTO();
            DataTable dataTable = new DataTable();

            dataTable = nhanVienDAO.TimTheoMaNhanVien(manv);

            foreach (DataRow dr in dataTable.Rows)
            {
                nv.HoTen = dr["HoTen"].ToString();
                nv.ChucVu = dr["ChucVu"].ToString();
                nv.SDT = dr["SDT"].ToString();
                nv.GioiTinh = dr["GioiTinh"].ToString();
                nv.NgaySinh = DateTime.Parse(dr["NgaySinh"].ToString());
                nv.DiaChi = dr["DiaChi"].ToString();
                nv.Luong = dr["Luong"].ToString();
                nv.NgayBatDauLamViec = DateTime.Parse(dr["NgayVL"].ToString());
            }

            return nv;
        }

        public List<NhanVienDTO> getAll()
        {
            List<NhanVienDTO> list_nv = new List<NhanVienDTO>();
            DataTable dataTable = new DataTable();

            dataTable = nhanVienDAO.getAll();

            foreach (DataRow dr in dataTable.Rows)
            {
                list_nv.Add(new NhanVienDTO
                {
                    MaNV = dr["MaNV"].ToString(),
                    HoTen = dr["HoTen"].ToString(),
                    ChucVu = dr["ChucVu"].ToString(),
                    SDT = dr["SDT"].ToString(),
                    GioiTinh = dr["GioiTinh"].ToString(),
                    NgaySinh = DateTime.Parse(dr["NgaySinh"].ToString()),
                    DiaChi = dr["DiaChi"].ToString(),
                    Luong = dr["Luong"].ToString(),
                    NgayBatDauLamViec = DateTime.Parse(dr["NgayVL"].ToString()),
                }
                );
            }
            return list_nv;
        }
    }
}
