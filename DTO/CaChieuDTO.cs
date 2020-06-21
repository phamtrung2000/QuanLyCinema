using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace DTO
{
    public class CaChieuDTO
    {
        private string macc;
        private string tencc;
        private DateTime batdau;
        private DateTime ketthuc;





        public string Macc { get => macc; set => macc = value; }
        public string Tencc { get => tencc; set => tencc = value; }
        public DateTime Batdau { get => batdau; set => batdau = value; }
        public DateTime Ketthuc { get => ketthuc; set => ketthuc = value; }
        public CaChieuDTO(string macc, string tencc, DateTime batdau, DateTime ketthuc)
        {

            Macc = macc;
            Tencc = tencc;
            Batdau = batdau;
            Ketthuc = ketthuc;
        }
    }
}

