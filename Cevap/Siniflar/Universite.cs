using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cevap.Siniflar
{
    public class Universite
    {
        public string UniAdi { get; set; }

        public List<Ogrenci> Ogrenciler { get; set; }

        public List<Ders> UniDersler { get; set; }
    }

    
}
