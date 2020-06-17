using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHangDTO
    {
        public string MaKH { get; set; }
        public string Hoten { get; set; }
        public string Diachi { get; set; }
        public DateTime Ngaysinh { get; set; }
        public string Gioitinh { get; set; }
        public string Sdt { get; set; }
        public string Loaikh { get; set; }
        public DateTime Ngaydk { get; set; }

        public KhachHangDTO(string maKH, string hoten, string diachi, DateTime ngaysinh, string gioitinh, string sdt, string loaikh, DateTime ngaydk)
        {
            MaKH = maKH;
            Hoten = hoten;
            Diachi = diachi;
            Ngaysinh = ngaysinh;
            Gioitinh = gioitinh;
            Sdt = sdt;
            Loaikh = loaikh;
            Ngaydk = ngaydk;
        }
    }
}

