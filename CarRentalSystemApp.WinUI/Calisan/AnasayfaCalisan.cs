using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalSystemApp.WinUI.Calisan
{
    using AracServiceReference;
    public partial class AnasayfaCalisan : Form
    {
        public AnasayfaCalisan()
        {
            InitializeComponent();
        }

        private void btnAracEkle_Click(object sender, EventArgs e)
        {
            AracEkle ae = new AracEkle();
            ae.Show();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            
            AracListe al = new AracListe();
            al.Show();
        }
    }
}
