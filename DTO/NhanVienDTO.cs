using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {
        private string stt;
        public string STT { get => stt; set => stt = value; }

        private string manv;
        public string MaNV { get => manv; set => manv = value; }

        private string hoten;
        public string HoTen { get => hoten; set => hoten = value; }

        private string chucvu;
        public string ChucVu { get => chucvu; set => chucvu = value; }

        private string sdt;
        public string SDT { get => sdt; set => sdt = value; }

        private string gioitinh;
        public string GioiTinh { get => gioitinh; set => gioitinh = value; }

        private DateTime ngaysinh;
        public DateTime NgaySinh { get => ngaysinh; set => ngaysinh = value; }

        private string ngaysinh_string;
        public string NgaySinh_String { get => ngaysinh_string; set => ngaysinh_string = value; }


        private string diachi;
        public string DiaChi { get => diachi; set => diachi = value; }

        private string luong;
        public string Luong { get => luong; set => luong = value; }

        private DateTime ngayvl;
        public DateTime NgayVL { get => ngayvl; set => ngayvl = value; }

        private string ngayvl_string;
        public string NgayVL_String { get => ngayvl_string; set => ngayvl_string = value; }

        public NhanVienDTO(string manv, string hoten, string chucvu, string sdt, string gioitinh, DateTime ngaysinh, string diachi, string luong, DateTime ngayvl)
        {
            MaNV = manv;
            HoTen = hoten;
            ChucVu = chucvu;
            SDT = sdt;
            GioiTinh = gioitinh;
            NgaySinh = ngaysinh;
            DiaChi = diachi;
            Luong = luong;
            NgayVL = ngayvl;
        }
        public NhanVienDTO(string stt,string manv, string hoten, string chucvu, string sdt, string gioitinh, DateTime ngaysinh, string diachi, string luong, DateTime ngayvl)
        {
            STT=stt;
            MaNV = manv;
            HoTen = hoten;
            ChucVu = chucvu;
            SDT = sdt;
            GioiTinh = gioitinh;
            NgaySinh = ngaysinh;
            DiaChi = diachi;
            Luong = luong;
            NgayVL = ngayvl;
        }

        public NhanVienDTO(string manv, string hoten, string chucvu, string sdt, string gioitinh, string ngaysinh_string, string diachi, string luong, string ngayvl_string)
        {
            MaNV = manv;
            HoTen = hoten;
            ChucVu = chucvu;
            SDT = sdt;
            GioiTinh = gioitinh;
            NgaySinh_String = ngaysinh_string;
            DiaChi = diachi;
            Luong = luong;
            NgayVL_String = ngayvl_string;
        }
        public NhanVienDTO(string stt, string manv, string hoten, string chucvu, string sdt, string gioitinh, string ngaysinh_string, string diachi, string luong, string ngayvl_string)
        {
            STT = stt;
            MaNV = manv;
            HoTen = hoten;
            ChucVu = chucvu;
            SDT = sdt;
            GioiTinh = gioitinh;
            NgaySinh_String = ngaysinh_string;
            DiaChi = diachi;
            Luong = luong;
            NgayVL_String = ngayvl_string;
        }
    }
}
