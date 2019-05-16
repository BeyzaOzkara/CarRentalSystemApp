using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRentalSystemApp.WinUI.UserLogins;

namespace CarRentalSystemApp.WinUI
{
    public partial class GirisForm : Form
    {
        public GirisForm()
        {
            InitializeComponent();
        }

        private void tlCntrlMusteriGiris_Click(object sender, EventArgs e)
        {
            MusteriLogin MLF = new MusteriLogin();
            MLF.Show();
            this.Hide();
        }

        private void tlCnttlCalisanGiris_Click(object sender, EventArgs e)
        {
            CalisanLogin CLF = new CalisanLogin();
            CLF.Show();
            this.Hide();
        }
    }
}
