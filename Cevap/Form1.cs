using Cevap.Siniflar;

namespace Cevap
{
    public partial class Form1 : Form
    {
        Universite universite = new Universite();
        List<Ders> dersler = new List<Ders>()
            {
                new Ders(){DersAdi = "Matematik", DersKodu = "A1", Kredisi = 5, ZorunluMu = true},
                new Ders(){DersAdi = "Fizik", DersKodu = "B1", Kredisi = 5, ZorunluMu = true },
                new Ders(){DersAdi = "Tarih", DersKodu = "C1", Kredisi = 3, ZorunluMu = true},
                new Ders(){DersAdi = "Mühendislik Giriþ", DersKodu = "D1", Kredisi = 5, ZorunluMu = true },
                new Ders(){DersAdi = "Resim", DersKodu = "E1", Kredisi = 2, ZorunluMu = false },
                new Ders(){DersAdi = "Bilimsel Etik", DersKodu = "F1", Kredisi = 2, ZorunluMu = false }
            };

        List<Ogrenci> ogrenciler = new List<Ogrenci>()
        {
            new Ogrenci(){Adi = "Abuzer", Soyadi = "Kömürcü", Danismani = "Prof. Ahmet Yüksel", Bolumu = "Harita Mühendisi" },
            new Ogrenci(){Adi = "Erdal", Soyadi = "Kömürcü", Danismani = "Prof. Selim Yasin", Bolumu = "Maden Mühendisi"}
        };
      

        public Form1()
        {
            InitializeComponent();
            universite.UniDersler = dersler;
            universite.Ogrenciler = ogrenciler;
         
           
        }

        private void btnOgrenciListesi_Click(object sender, EventArgs e)
        {
            new OgrenciListesi(universite).ShowDialog();
            
        }

        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
           new OgrenciyiEkle(universite).ShowDialog();
        }

        private void btnDersler_Click(object sender, EventArgs e)
        {
            new DersListesi(universite).ShowDialog();
        }

        private void btnDersEkle_Click(object sender, EventArgs e)
        {
            new DersEkle(universite).ShowDialog();
        }

        private void btnOgrenciyeDersEkle_Click(object sender, EventArgs e)
        {
            new OgrenciyeDersEkle(universite).ShowDialog();
        }
    }
}