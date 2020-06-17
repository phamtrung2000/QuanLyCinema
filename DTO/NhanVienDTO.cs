using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public string ChucVu { get; set; }
        public string SDT { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string Luong { get; set; }
        public DateTime NgayBatDauLamViec { get; set; }

        public NhanVienDTO()
        {

        }

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
            NgayBatDauLamViec = ngayvl;
        }
    }
}
