namespace OgrenciBilgilendirmeApp
{
    partial class OgrenciIslem
    {
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtNumara;
        private System.Windows.Forms.ComboBox cmbSinif;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblNumara;
        private System.Windows.Forms.Label lblSinif;
        private System.Windows.Forms.GroupBox grpOgrenciBilgileri;

        private void InitializeComponent()
        {
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtNumara = new TextBox();
            cmbSinif = new ComboBox();
            btnKaydet = new Button();
            btnGuncelle = new Button();
            btnBul = new Button();
            lblAd = new Label();
            lblSoyad = new Label();
            lblNumara = new Label();
            lblSinif = new Label();
            grpOgrenciBilgileri = new GroupBox();
            btnDers = new Button();
            btn_geri = new Button();
            grpOgrenciBilgileri.SuspendLayout();
            SuspendLayout();
            // 
            // txtAd
            // 
            txtAd.Location = new Point(155, 41);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(200, 25);
            txtAd.TabIndex = 1;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(155, 81);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(200, 25);
            txtSoyad.TabIndex = 3;
            // 
            // txtNumara
            // 
            txtNumara.Location = new Point(155, 121);
            txtNumara.Name = "txtNumara";
            txtNumara.Size = new Size(200, 25);
            txtNumara.TabIndex = 5;
            // 
            // cmbSinif
            // 
            cmbSinif.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSinif.Location = new Point(155, 161);
            cmbSinif.Name = "cmbSinif";
            cmbSinif.Size = new Size(200, 25);
            cmbSinif.TabIndex = 7;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.LightGreen;
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.Location = new Point(74, 265);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(100, 40);
            btnKaydet.TabIndex = 1;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.LightBlue;
            btnGuncelle.FlatStyle = FlatStyle.Flat;
            btnGuncelle.Location = new Point(199, 265);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(100, 40);
            btnGuncelle.TabIndex = 2;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnBul
            // 
            btnBul.BackColor = Color.LightGoldenrodYellow;
            btnBul.FlatStyle = FlatStyle.Flat;
            btnBul.Location = new Point(324, 265);
            btnBul.Name = "btnBul";
            btnBul.Size = new Size(100, 40);
            btnBul.TabIndex = 3;
            btnBul.Text = "Bul";
            btnBul.UseVisualStyleBackColor = false;
            btnBul.Click += btnBul_Click;
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(55, 41);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(29, 19);
            lblAd.TabIndex = 0;
            lblAd.Text = "Ad:";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Location = new Point(55, 81);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(49, 19);
            lblSoyad.TabIndex = 2;
            lblSoyad.Text = "Soyad:";
            // 
            // lblNumara
            // 
            lblNumara.AutoSize = true;
            lblNumara.Location = new Point(55, 121);
            lblNumara.Name = "lblNumara";
            lblNumara.Size = new Size(61, 19);
            lblNumara.TabIndex = 4;
            lblNumara.Text = "Numara:";
            // 
            // lblSinif
            // 
            lblSinif.AutoSize = true;
            lblSinif.Location = new Point(55, 161);
            lblSinif.Name = "lblSinif";
            lblSinif.Size = new Size(37, 19);
            lblSinif.TabIndex = 6;
            lblSinif.Text = "Sınıf:";
            // 
            // grpOgrenciBilgileri
            // 
            grpOgrenciBilgileri.Controls.Add(lblAd);
            grpOgrenciBilgileri.Controls.Add(txtAd);
            grpOgrenciBilgileri.Controls.Add(lblSoyad);
            grpOgrenciBilgileri.Controls.Add(txtSoyad);
            grpOgrenciBilgileri.Controls.Add(lblNumara);
            grpOgrenciBilgileri.Controls.Add(txtNumara);
            grpOgrenciBilgileri.Controls.Add(lblSinif);
            grpOgrenciBilgileri.Controls.Add(cmbSinif);
            grpOgrenciBilgileri.Location = new Point(30, 30);
            grpOgrenciBilgileri.Name = "grpOgrenciBilgileri";
            grpOgrenciBilgileri.Size = new Size(440, 220);
            grpOgrenciBilgileri.TabIndex = 0;
            grpOgrenciBilgileri.TabStop = false;
            grpOgrenciBilgileri.Text = "Öğrenci Bilgileri";
            // 
            // btnDers
            // 
            btnDers.BackColor = Color.LightGreen;
            btnDers.FlatStyle = FlatStyle.Flat;
            btnDers.Location = new Point(74, 311);
            btnDers.Name = "btnDers";
            btnDers.Size = new Size(350, 40);
            btnDers.TabIndex = 1;
            btnDers.Text = "Ders Seçimi";
            btnDers.UseVisualStyleBackColor = false;
            btnDers.Click += btnDers_Click;
            // 
            // btn_geri
            // 
            btn_geri.Font = new Font("Segoe UI", 7F);
            btn_geri.Location = new Point(30, 5);
            btn_geri.Name = "btn_geri";
            btn_geri.Size = new Size(62, 19);
            btn_geri.TabIndex = 4;
            btn_geri.Text = "Geri";
            btn_geri.TextAlign = ContentAlignment.TopCenter;
            btn_geri.UseVisualStyleBackColor = true;
            btn_geri.Click += btn_geri_Click;
            // 
            // OgrenciIslem
            // 
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(500, 368);
            Controls.Add(btn_geri);
            Controls.Add(grpOgrenciBilgileri);
            Controls.Add(btnDers);
            Controls.Add(btnKaydet);
            Controls.Add(btnGuncelle);
            Controls.Add(btnBul);
            Font = new Font("Segoe UI", 10F);
            Name = "OgrenciIslem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Öğrenci Bilgilendirme Sistemi";
            Load += OgrenciIslem_Load;
            grpOgrenciBilgileri.ResumeLayout(false);
            grpOgrenciBilgileri.PerformLayout();
            ResumeLayout(false);
        }

        private Button btnDers;
        private Button btn_geri;
    }
}
