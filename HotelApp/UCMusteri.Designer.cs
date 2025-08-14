namespace HotelApp
{
    partial class UCMusteri
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCMusteri));
            btnAra = new Button();
            dgvMusteriler = new DataGridView();
            txtAraTc = new TextBox();
            panel1 = new Panel();
            label7 = new Label();
            label5 = new Label();
            btnPdfAktar = new Button();
            btnTumunuGetir = new Button();
            panel2 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label6 = new Label();
            label1 = new Label();
            btnTemizle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            txtTc = new TextBox();
            txtEmail = new TextBox();
            txtTelefon = new TextBox();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvMusteriler).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnAra
            // 
            btnAra.Image = (Image)resources.GetObject("btnAra.Image");
            btnAra.Location = new Point(822, 171);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(57, 56);
            btnAra.TabIndex = 0;
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // dgvMusteriler
            // 
            dgvMusteriler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMusteriler.Location = new Point(37, 66);
            dgvMusteriler.Name = "dgvMusteriler";
            dgvMusteriler.RowHeadersWidth = 51;
            dgvMusteriler.Size = new Size(683, 353);
            dgvMusteriler.TabIndex = 1;
            dgvMusteriler.CellContentClick += dataGridView1_CellContentClick;
            dgvMusteriler.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // txtAraTc
            // 
            txtAraTc.BackColor = SystemColors.Window;
            txtAraTc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtAraTc.Location = new Point(764, 122);
            txtAraTc.Name = "txtAraTc";
            txtAraTc.Size = new Size(168, 34);
            txtAraTc.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnPdfAktar);
            panel1.Controls.Add(dgvMusteriler);
            panel1.Controls.Add(txtAraTc);
            panel1.Controls.Add(btnAra);
            panel1.Controls.Add(btnTumunuGetir);
            panel1.Location = new Point(46, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(975, 454);
            panel1.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.ForeColor = Color.FromArgb(33, 11, 97);
            label7.Location = new Point(764, 86);
            label7.Name = "label7";
            label7.Size = new Size(105, 23);
            label7.TabIndex = 18;
            label7.Text = "MÜŞTERİ TC";
            label7.Click += label7_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.2F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(33, 11, 97);
            label5.Location = new Point(37, 18);
            label5.Name = "label5";
            label5.Size = new Size(232, 32);
            label5.TabIndex = 13;
            label5.Text = "MÜŞTERİ İŞLEMLERİ";
            // 
            // btnPdfAktar
            // 
            btnPdfAktar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnPdfAktar.ForeColor = Color.FromArgb(33, 11, 97);
            btnPdfAktar.Image = (Image)resources.GetObject("btnPdfAktar.Image");
            btnPdfAktar.Location = new Point(902, 380);
            btnPdfAktar.Name = "btnPdfAktar";
            btnPdfAktar.Size = new Size(57, 60);
            btnPdfAktar.TabIndex = 12;
            btnPdfAktar.UseVisualStyleBackColor = true;
            btnPdfAktar.Click += btnPdfAktar_Click;
            // 
            // btnTumunuGetir
            // 
            btnTumunuGetir.BackColor = Color.FromArgb(33, 11, 97);
            btnTumunuGetir.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnTumunuGetir.ForeColor = Color.White;
            btnTumunuGetir.Location = new Point(800, 264);
            btnTumunuGetir.Name = "btnTumunuGetir";
            btnTumunuGetir.Size = new Size(107, 63);
            btnTumunuGetir.TabIndex = 3;
            btnTumunuGetir.Text = "tüm müşteriler";
            btnTumunuGetir.UseVisualStyleBackColor = false;
            btnTumunuGetir.Click += btnTumunuGetir_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnTemizle);
            panel2.Controls.Add(btnGuncelle);
            panel2.Controls.Add(btnSil);
            panel2.Controls.Add(txtTc);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(txtTelefon);
            panel2.Controls.Add(txtSoyad);
            panel2.Controls.Add(txtAd);
            panel2.Location = new Point(46, 509);
            panel2.Name = "panel2";
            panel2.Size = new Size(975, 233);
            panel2.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.FromArgb(33, 11, 97);
            label4.Location = new Point(800, 36);
            label4.Name = "label4";
            label4.Size = new Size(29, 23);
            label4.TabIndex = 20;
            label4.Text = "TC";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.FromArgb(33, 11, 97);
            label3.Location = new Point(598, 36);
            label3.Name = "label3";
            label3.Size = new Size(59, 23);
            label3.TabIndex = 19;
            label3.Text = "EMAİL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.FromArgb(33, 11, 97);
            label2.Location = new Point(411, 36);
            label2.Name = "label2";
            label2.Size = new Size(80, 23);
            label2.TabIndex = 18;
            label2.Text = "TELEFON";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.ForeColor = Color.FromArgb(33, 11, 97);
            label6.Location = new Point(227, 36);
            label6.Name = "label6";
            label6.Size = new Size(64, 23);
            label6.TabIndex = 17;
            label6.Text = "SOYAD";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.FromArgb(33, 11, 97);
            label1.Location = new Point(37, 36);
            label1.Name = "label1";
            label1.Size = new Size(33, 23);
            label1.TabIndex = 12;
            label1.Text = "AD";
            // 
            // btnTemizle
            // 
            btnTemizle.BackColor = Color.FromArgb(33, 11, 97);
            btnTemizle.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnTemizle.ForeColor = Color.White;
            btnTemizle.Location = new Point(586, 145);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(110, 55);
            btnTemizle.TabIndex = 11;
            btnTemizle.Text = "TEMİZLE";
            btnTemizle.UseVisualStyleBackColor = false;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.FromArgb(33, 11, 97);
            btnGuncelle.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGuncelle.ForeColor = Color.White;
            btnGuncelle.Location = new Point(433, 145);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(110, 55);
            btnGuncelle.TabIndex = 10;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.FromArgb(33, 11, 97);
            btnSil.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(263, 145);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(110, 55);
            btnSil.TabIndex = 9;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // txtTc
            // 
            txtTc.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtTc.Location = new Point(800, 75);
            txtTc.Name = "txtTc";
            txtTc.Size = new Size(128, 30);
            txtTc.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtEmail.Location = new Point(598, 75);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(133, 30);
            txtEmail.TabIndex = 7;
            // 
            // txtTelefon
            // 
            txtTelefon.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtTelefon.Location = new Point(411, 75);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(128, 30);
            txtTelefon.TabIndex = 6;
            // 
            // txtSoyad
            // 
            txtSoyad.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtSoyad.Location = new Point(227, 75);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(129, 30);
            txtSoyad.TabIndex = 5;
            // 
            // txtAd
            // 
            txtAd.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtAd.Location = new Point(37, 75);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(131, 30);
            txtAd.TabIndex = 4;
            // 
            // UCMusteri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UCMusteri";
            Size = new Size(1075, 760);
            Load += UserControl_MusteriEkle_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMusteriler).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAra;
        private DataGridView dgvMusteriler;
        private TextBox txtAraTc;
        private Panel panel1;
        private Panel panel2;
        private Button btnTumunuGetir;
        private TextBox txtEmail;
        private TextBox txtTelefon;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private Button btnTemizle;
        private Button btnGuncelle;
        private Button btnSil;
        private TextBox txtTc;
        private Button btnPdfAktar;
        private Label label3;
        private Label label2;
        private Label label6;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label7;
    }
}
