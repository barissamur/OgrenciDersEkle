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
    public partial class DersEkle : Form
    {
        private readonly Universite _uni;

        public DersEkle(Universite uni)
        {
            InitializeComponent();
            _uni=uni;
        }

        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            Ders ders = new Ders() { DersAdi = txtDersAdi.Text, DersKodu = txtDersKodu.Text, Kredisi = Convert.ToInt32(txtDersKredisi.Text), ZorunluMu = chcZorunlu.Checked };

            _uni.UniDersler.Add(ders);

            Temizle();
        }

        private void Temizle()
        {
            txtDersAdi.Text = txtDersAdi.Text = txtDersKredisi.Text = txtDersKodu.Text = "";
            chcZorunlu.Checked = false;
        }
    }
}
