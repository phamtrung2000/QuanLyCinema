using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiPhimDTO
    {
        private string malp;
        private string tenlp;
        private string mota;

        public string Malp { get => malp; set => malp = value; }
        public string Mota { get => mota; set => mota = value; }
        public string Tenlp { get => tenlp; set => tenlp = value; }
        public LoaiPhimDTO(string malp,string tenlp,string mota)
        {
            Malp = malp;
            Tenlp = tenlp;
            Mota = mota;
        }
    }
}
