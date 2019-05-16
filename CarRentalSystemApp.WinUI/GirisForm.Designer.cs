namespace CarRentalSystemApp.WinUI
{
    partial class GirisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisForm));
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            this.tileAdmin = new DevExpress.XtraEditors.TileItem();
            this.tlCntrlMusteriGiris = new DevExpress.XtraEditors.TileControl();
            this.tlCnttlCalisanGiris = new DevExpress.XtraEditors.TileControl();
            this.SuspendLayout();
            // 
            // tileControl1
            // 
            this.tileControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tileControl1.BackgroundImage")));
            this.tileControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileControl1.Location = new System.Drawing.Point(0, 0);
            this.tileControl1.Name = "tileControl1";
            this.tileControl1.Size = new System.Drawing.Size(623, 249);
            this.tileControl1.TabIndex = 0;
            this.tileControl1.Text = "tileControl1";
            // 
            // tileAdmin
            // 
            this.tileAdmin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tileAdmin.BackgroundImage")));
            tileItemElement1.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement1.Image")));
            tileItemElement1.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement1.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement1.Text = "ADMIN";
            tileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileAdmin.Elements.Add(tileItemElement1);
            this.tileAdmin.Id = 3;
            this.tileAdmin.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileAdmin.Name = "tileAdmin";
            // 
            // tlCntrlMusteriGiris
            // 
            this.tlCntrlMusteriGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tlCntrlMusteriGiris.BackgroundImage")));
            this.tlCntrlMusteriGiris.Location = new System.Drawing.Point(63, 88);
            this.tlCntrlMusteriGiris.MaxId = 1;
            this.tlCntrlMusteriGiris.Name = "tlCntrlMusteriGiris";
            this.tlCntrlMusteriGiris.ShowText = true;
            this.tlCntrlMusteriGiris.Size = new System.Drawing.Size(233, 78);
            this.tlCntrlMusteriGiris.TabIndex = 3;
            this.tlCntrlMusteriGiris.Text = "Musteri Giriş";
            this.tlCntrlMusteriGiris.Click += new System.EventHandler(this.tlCntrlMusteriGiris_Click);
            // 
            // tlCnttlCalisanGiris
            // 
            this.tlCnttlCalisanGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tlCnttlCalisanGiris.BackgroundImage")));
            this.tlCnttlCalisanGiris.Location = new System.Drawing.Point(324, 88);
            this.tlCnttlCalisanGiris.MaxId = 1;
            this.tlCnttlCalisanGiris.Name = "tlCnttlCalisanGiris";
            this.tlCnttlCalisanGiris.ShowText = true;
            this.tlCnttlCalisanGiris.Size = new System.Drawing.Size(233, 78);
            this.tlCnttlCalisanGiris.TabIndex = 4;
            this.tlCnttlCalisanGiris.Text = "Çalışan Giriş";
            this.tlCnttlCalisanGiris.Click += new System.EventHandler(this.tlCnttlCalisanGiris_Click);
            // 
            // GirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 249);
            this.Controls.Add(this.tlCnttlCalisanGiris);
            this.Controls.Add(this.tlCntrlMusteriGiris);
            this.Controls.Add(this.tileControl1);
            this.Name = "GirisForm";
            this.Text = "GirisForm";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TileControl tileControl1;
        private DevExpress.XtraEditors.TileItem tileAdmin;
        private DevExpress.XtraEditors.TileControl tlCntrlMusteriGiris;
        private DevExpress.XtraEditors.TileControl tlCnttlCalisanGiris;
    }
}