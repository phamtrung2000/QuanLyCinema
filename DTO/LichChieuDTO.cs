using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DTO
{
    public class LichChieuDTO
    {
        private DateTime ngaychieu;
        private string maphim;
        private string macc;
        private string mapc;


        public DateTime Ngaychieu { get => ngaychieu; set => ngaychieu = value; }
        public string Maphim { get => maphim; set => maphim = value; }
        public string Macc { get => macc; set => macc = value; }
        public string Mapc { get => mapc; set => mapc = value; }


        public LichChieuDTO(DateTime ngaychieu, string maphim, string macc, string mapc)
        {
            Ngaychieu = ngaychieu;
            Maphim = maphim;
            Macc = macc;
            Mapc = mapc;
        }
    }
}
