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
    public partial class OgrenciyeDersEkle : Form
    {
        private readonly Universite _uni;

        public OgrenciyeDersEkle(Universite uni)
        {
            _uni = uni;
            InitializeComponent();
           
            foreach (Ogrenci item in _uni.Ogrenciler)
                lboxOgrenciler.Items.Add(item);

            foreach (Ders item in _uni.UniDersler)
                lboxDersler.Items.Add(item);
        }

        private void btnDersiEkle_Click(object sender, EventArgs e)
        {
            Ders ders = (Ders)lboxDersler.SelectedItem;
            
            ((Ogrenci)lboxOgrenciler.SelectedItem).Dersleri.Add(ders);

            lboxDersler.Items.Remove(ders);

            lboxDersler.SelectedItem = null;
        }
    }
}
