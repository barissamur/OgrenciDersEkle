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
    public partial class DersListesi : Form
    {
        private readonly Universite _uni;
        public DersListesi(Universite uni)
        {
            _uni = uni;
            InitializeComponent();
            dgvDersler.DataSource = _uni.UniDersler;
        }
    }
}
