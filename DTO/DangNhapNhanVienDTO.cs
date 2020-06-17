using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public partial class DangNhapNhanVienDTO
    {
        public string MaNV { get; set; }
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }

        public DangNhapNhanVienDTO(string manv, string taiKhoan, string matKhau)
        {
            MaNV = manv;
            TaiKhoan = taiKhoan;
            MatKhau = matKhau;
        }
    }
}
