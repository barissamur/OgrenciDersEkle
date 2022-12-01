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
    public partial class OgrenciListesi : Form
    {
        private readonly Universite _uni;

        public OgrenciListesi(Universite uni)
        {
            _uni=uni;
            InitializeComponent();

            foreach (Ogrenci item in _uni.Ogrenciler)
                cmbOgrenciler.Items.Add(item);

        }

        private void cmbOgrenciler_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblOgrenciBilgi.Text = cmbOgrenciler.SelectedItem.ToString();
            dgvOgrenciDersleri.DataSource = ((Ogrenci)cmbOgrenciler.SelectedItem).Dersleri;
        }
    }
}
