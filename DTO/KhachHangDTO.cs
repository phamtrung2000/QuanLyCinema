using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHangDTO
    {
        private string maKH;
        private string hoten;
        private string diachi;
        private DateTime ngaysinh;
        private string gioitinh;
        private string sdt;
        private string loaikh;
        private DateTime ngaydk;
        public string MaKH { get => maKH; set => maKH = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Loaikh { get => loaikh; set => loaikh = value; }
        public DateTime Ngaydk { get => ngaydk; set => ngaydk = value; }

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

