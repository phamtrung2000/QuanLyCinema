using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public partial class DangNhapKhachHangDTO
    {
        public string MaKH { get; set; }
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }

        public DangNhapKhachHangDTO(string makh, string taiKhoan, string matKhau)
        {
            MaKH = makh;
            TaiKhoan = taiKhoan;
            MatKhau = matKhau;
        }
    }
}


