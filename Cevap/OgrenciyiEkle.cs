using Cevap.Siniflar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cevap
{
    public partial class OgrenciyiEkle : Form
    {
        private readonly Universite _uni;

        public OgrenciyiEkle(Universite uni)
        {
            InitializeComponent();
            _uni=uni;
        }

        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            Ogrenci ogr = new Ogrenci() { Adi = txtAd.Text, Soyadi = txtSoyad.Text, Bolumu = txtBolum.Text, Danismani = txtDanisman.Text };
            _uni.Ogrenciler.Add(ogr);

            Temizle();
        }

        private void Temizle()
        {
            txtAd.Text = txtSoyad.Text = txtBolum.Text = txtDanisman.Text = "";
        }
    }
}
