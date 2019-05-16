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
    public partial class AracListe : Form
    {
        public AracListe()
        {
            InitializeComponent();
        }

        private void AracListe_Load(object sender, EventArgs e)
        {
            AracServiceClient client = new AracServiceClient();
            dataGridView1.DataSource = client.Listele();
        }
    }
}
