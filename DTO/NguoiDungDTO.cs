using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NguoiDungDTO
    {
        public string MaND { get; set; }
        public string HoTen { get; set; }
        public string ChucVu { get; set; }
        public string PhanQuyen { get; set; }

        public NguoiDungDTO(string mand, string hoten, string chucvu, string phanquyen)
        {
            MaND = mand;
            HoTen = hoten;
            ChucVu = chucvu;
            PhanQuyen = phanquyen;
        }
    }
}
