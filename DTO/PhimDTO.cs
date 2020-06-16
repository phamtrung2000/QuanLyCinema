using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
     public class PhimDTO
    {
        private string maphim;
        private string tenphim;
        private string daodien;
        private string dienvien;
        private string malp;
        private string noidung;
        private string namsx;
        private string nuocsx;
        private string thoiluong;

        public string Maphim { get => maphim; set => maphim = value; }
        public string Tenphim { get => tenphim; set => tenphim = value; }
        public string Daodien { get => daodien; set => daodien = value; }
        public string Dienvien { get => dienvien; set => dienvien = value; }
        public string Malp { get => malp; set => malp = value; }
        public string Noidung { get => noidung; set => noidung = value; }
        public string Namsx { get => namsx; set => namsx = value; }
        public string Nuocsx { get => nuocsx; set => nuocsx = value; }
        public string Thoiluong { get => thoiluong; set => thoiluong = value; }

        public PhimDTO(string maphim,string tenphim,string daodien,string dienvien,string malp,string noidung,string namsx,string nuocsx,string thoiluong)
        {
            Maphim = maphim;
            Tenphim = tenphim;
            Daodien = daodien;
            Dienvien = dienvien;
            Malp = malp;
            Noidung = noidung;
            Namsx = namsx;
            Nuocsx = nuocsx;
            Thoiluong = thoiluong;
        }
    }
}
