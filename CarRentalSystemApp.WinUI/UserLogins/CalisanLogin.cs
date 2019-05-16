using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRentalSystemApp.Models;
using CarRentalSystemApp.BLL;
using System.ComponentModel.DataAnnotations;
using CarRentalSystemApp.WinUI.Calisan;

namespace CarRentalSystemApp.WinUI.UserLogins
{
    public partial class CalisanLogin : Form
    {
        public CalisanLogin()
        {
            InitializeComponent();
        }

        private void btnAdminGiris_Click(object sender, EventArgs e)
        {
            try
            {
                Calisanlar user = new Calisanlar();
                //user.Sifre = txtSifre.Text;
                //string md5 = SifreDonusumu.CreateMD5(user.Sifre);
                if (string.IsNullOrEmpty(txtKullaniciAdi.Text) || string.IsNullOrEmpty(txtSifre.Text))
                {
                    throw new ValidationException("Kullanıcı Adı veya Şifre Boş Geçilemez !");
                }
                else
                {
                    user.KullaniciAdi = txtKullaniciAdi.Text;
                    user.Sifre = txtSifre.Text;
                }
                //user.Sifre = md5;
                var result = CalisanlarBusiness.UserAdminLogin(user);

                AnasayfaCalisan ac = new AnasayfaCalisan();
                ac.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Meydana Geldi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
