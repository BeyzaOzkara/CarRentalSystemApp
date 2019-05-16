namespace CarRentalSystemApp.WinUI.Calisan
{
    partial class AnasayfaCalisan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnasayfaCalisan));
            this.btnAracEkle = new System.Windows.Forms.Button();
            this.btnAracSil = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnKirala = new System.Windows.Forms.Button();
            this.btnDurumGuncelle = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAracEkle
            // 
            this.btnAracEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAracEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAracEkle.Location = new System.Drawing.Point(56, 51);
            this.btnAracEkle.Name = "btnAracEkle";
            this.btnAracEkle.Size = new System.Drawing.Size(162, 48);
            this.btnAracEkle.TabIndex = 0;
            this.btnAracEkle.Text = "ARAC EKLE";
            this.btnAracEkle.UseVisualStyleBackColor = false;
            this.btnAracEkle.Click += new System.EventHandler(this.btnAracEkle_Click);
            // 
            // btnAracSil
            // 
            this.btnAracSil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAracSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAracSil.Location = new System.Drawing.Point(56, 105);
            this.btnAracSil.Name = "btnAracSil";
            this.btnAracSil.Size = new System.Drawing.Size(162, 48);
            this.btnAracSil.TabIndex = 1;
            this.btnAracSil.Text = "ARAC SİL";
            this.btnAracSil.UseVisualStyleBackColor = false;
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.Location = new System.Drawing.Point(56, 159);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(162, 48);
            this.btnListele.TabIndex = 2;
            this.btnListele.Text = "ARACLARI LİSTELE";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnKirala
            // 
            this.btnKirala.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnKirala.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKirala.Location = new System.Drawing.Point(262, 51);
            this.btnKirala.Name = "btnKirala";
            this.btnKirala.Size = new System.Drawing.Size(162, 48);
            this.btnKirala.TabIndex = 3;
            this.btnKirala.Text = "ARAC KİRALA";
            this.btnKirala.UseVisualStyleBackColor = false;
            // 
            // btnDurumGuncelle
            // 
            this.btnDurumGuncelle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDurumGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDurumGuncelle.Location = new System.Drawing.Point(262, 106);
            this.btnDurumGuncelle.Name = "btnDurumGuncelle";
            this.btnDurumGuncelle.Size = new System.Drawing.Size(162, 48);
            this.btnDurumGuncelle.TabIndex = 4;
            this.btnDurumGuncelle.Text = "KİRALIK DURUMU GÜNCELLE";
            this.btnDurumGuncelle.UseVisualStyleBackColor = false;
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Location = new System.Drawing.Point(262, 160);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(162, 48);
            this.btnCikis.TabIndex = 5;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.UseVisualStyleBackColor = false;
            // 
            // AnasayfaCalisan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(485, 247);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnDurumGuncelle);
            this.Controls.Add(this.btnKirala);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnAracSil);
            this.Controls.Add(this.btnAracEkle);
            this.Name = "AnasayfaCalisan";
            this.Text = "AnasayfaCalisan";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAracEkle;
        private System.Windows.Forms.Button btnAracSil;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnKirala;
        private System.Windows.Forms.Button btnDurumGuncelle;
        private System.Windows.Forms.Button btnCikis;
    }
}