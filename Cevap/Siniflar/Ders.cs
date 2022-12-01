using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cevap.Siniflar
{
    public class Ders
    {
        public string DersAdi { get; set; }
        public string DersKodu { get; set; }
        public int Kredisi { get; set; }
        public bool ZorunluMu { get; set; }

        public override string ToString()
        {
            return $"{DersAdi} - {Kredisi} kredi ";
        }
    }
}
