using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cevap.Siniflar
{
    public class Ogrenci
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Danismani { get; set; }
        public string Bolumu { get; set; }
        public List<Ders> Dersleri { get; set; } = new List<Ders>(); // null olarak başlamaması için başlangıçta bir liste newledik

        public override string ToString()
        {
            return $"{Adi} {Soyadi}, Okuduğu Bölümü: {Bolumu},Danışman Hocası: {Danismani}";
        }
    }
}
