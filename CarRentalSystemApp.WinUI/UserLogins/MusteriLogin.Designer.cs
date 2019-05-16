namespace CarRentalSystemApp.WinUI.UserLogins
{
    partial class MusteriLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriLogin));
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.btnAdminGiris = new DevExpress.XtraEditors.SimpleButton();
            this.txtSifre = new DevExpress.XtraEditors.TextEdit();
            this.txtKullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            this.lblASifre = new DevExpress.XtraEditors.LabelControl();
            this.lblAKullaniciAdi = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureEdit2.BackgroundImage")));
            this.pictureEdit2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(103, 33);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pictureEdit2.Size = new System.Drawing.Size(192, 93);
            this.pictureEdit2.TabIndex = 6;
            // 
            // btnAdminGiris
            // 
            this.btnAdminGiris.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdminGiris.Appearance.Options.UseFont = true;
            this.btnAdminGiris.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnAdminGiris.Location = new System.Drawing.Point(164, 259);
            this.btnAdminGiris.Name = "btnAdminGiris";
            this.btnAdminGiris.Size = new System.Drawing.Size(183, 48);
            this.btnAdminGiris.TabIndex = 11;
            this.btnAdminGiris.Text = "GİRİŞ YAP";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(164, 206);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Properties.MaxLength = 8;
            this.txtSifre.Properties.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(183, 20);
            this.txtSifre.TabIndex = 10;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(164, 169);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Properties.MaxLength = 8;
            this.txtKullaniciAdi.Size = new System.Drawing.Size(183, 20);
            this.txtKullaniciAdi.TabIndex = 9;
            // 
            // lblASifre
            // 
            this.lblASifre.Location = new System.Drawing.Point(44, 213);
            this.lblASifre.Name = "lblASifre";
            this.lblASifre.Size = new System.Drawing.Size(22, 13);
            this.lblASifre.TabIndex = 8;
            this.lblASifre.Text = "Sifre";
            // 
            // lblAKullaniciAdi
            // 
            this.lblAKullaniciAdi.Location = new System.Drawing.Point(44, 169);
            this.lblAKullaniciAdi.Name = "lblAKullaniciAdi";
            this.lblAKullaniciAdi.Size = new System.Drawing.Size(55, 13);
            this.lblAKullaniciAdi.TabIndex = 7;
            this.lblAKullaniciAdi.Text = "Kullanıcı Adi";
            // 
            // MusteriLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(406, 342);
            this.Controls.Add(this.btnAdminGiris);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.lblASifre);
            this.Controls.Add(this.lblAKullaniciAdi);
            this.Controls.Add(this.pictureEdit2);
            this.Name = "MusteriLogin";
            this.Text = "MusteriLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.SimpleButton btnAdminGiris;
        private DevExpress.XtraEditors.TextEdit txtSifre;
        private DevExpress.XtraEditors.TextEdit txtKullaniciAdi;
        private DevExpress.XtraEditors.LabelControl lblASifre;
        private DevExpress.XtraEditors.LabelControl lblAKullaniciAdi;
    }
}