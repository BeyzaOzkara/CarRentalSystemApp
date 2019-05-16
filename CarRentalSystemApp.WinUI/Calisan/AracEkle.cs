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
    public partial class AracEkle : Form
    {
        public AracEkle()
        {
            InitializeComponent();
        }

        private void btnAracEkle_Click(object sender, EventArgs e)
        {
            int sirketId = 1;
            string marka = "Audi";
            string model = "e-tron";
            int ehliyetYas = 20;
            int minYasSinir = 20;
            float gunlukKm = 200;
            float anlikKm = 150;
            byte airbag = 1;
            int bagajHacmi = 2000;
            int koltukSayisi = 8;
            Decimal gunlukKiralik = 100;
            Boolean durum = true;

            AraclarDTO arac = new AraclarDTO();
            arac.SirketID = sirketId;
            arac.Marka = marka;
            arac.Model = model;
            arac.EhliyetYasi = ehliyetYas;
            arac.MinYasSiniri = minYasSinir;
            arac.GunukKm = gunlukKm;
            arac.AnlikKm = anlikKm;
            arac.Airbag = airbag;
            arac.BagajHacmi = bagajHacmi;
            arac.KoltukSayisi = koltukSayisi;
            arac.GunlukKiralikFiyati = gunlukKiralik;
            arac.Durum = durum;
            /*AraclarDTO arac = new AraclarDTO();
            arac.SirketID = Convert.ToInt16(txtSirketID.Text);
            arac.Marka = txtMarka.Text;
            arac.Model = txtModel.Text;
            arac.EhliyetYasi = Convert.ToInt16(txtEhliyetYas.Text);
            arac.MinYasSiniri = Convert.ToInt16(txtMinYas.Text);
            arac.GunukKm = Convert.ToInt64(txtGunlukKm.Text);
            arac.AnlikKm = Convert.ToInt64(txtAnlıkKm.Text);
            arac.Airbag = Convert.ToByte(txtAirbag.Text);
            arac.BagajHacmi = Convert.ToInt16(txtHacim.Text);
            arac.KoltukSayisi = Convert.ToInt16(txtKoltukSayisi.Text);
            arac.GunlukKiralikFiyati = Convert.ToDecimal(txtGunlukKira.Text);
            if(txtDurum.Text == "1")
            {
                arac.Durum = true;
            }*/

            AracServiceClient client = new AracServiceClient();
            client.Ekle(arac);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AracServiceClient client = new AracServiceClient();
            dataGridView1.DataSource = client.Listele();
        }
    }
}
