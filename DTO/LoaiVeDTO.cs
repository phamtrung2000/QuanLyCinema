using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    
    public class LoaiVeDTO
    {
        private string malv;
        public string MaLV { get => malv; set => malv = value; }

        private string tenlv;
        public string TenLV { get => tenlv; set => tenlv = value; }

        private string loaichongoi;
        public string LoaiChoNgoi { get => loaichongoi; set => loaichongoi = value; }

        private double gia;
        public double Gia { get => gia; set => gia = value; }

    
        public LoaiVeDTO(string malv, string tenlv, string loaichongoi, double gia) 
        {
            MaLV = malv;
            TenLV = tenlv;
            LoaiChoNgoi = loaichongoi;
            Gia = gia;
        }
    }
}
