namespace HotelApp
{
    partial class UCPersonel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCPersonel));
            panel1 = new Panel();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            label6 = new Label();
            label1 = new Label();
            btnPdfAktar = new Button();
            btnEkle = new Button();
            btnTemizle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            label5 = new Label();
            txtTcKimlikNo = new TextBox();
            txtSifre = new TextBox();
            txtEmail = new TextBox();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            dgvPersoneller = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPersoneller).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnPdfAktar);
            panel1.Controls.Add(btnEkle);
            panel1.Controls.Add(btnTemizle);
            panel1.Controls.Add(btnGuncelle);
            panel1.Controls.Add(btnSil);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtTcKimlikNo);
            panel1.Controls.Add(txtSifre);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtSoyad);
            panel1.Controls.Add(txtAd);
            panel1.Controls.Add(dgvPersoneller);
            panel1.Location = new Point(33, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(1009, 698);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.FromArgb(33, 11, 97);
            label2.Location = new Point(677, 284);
            label2.Name = "label2";
            label2.Size = new Size(53, 23);
            label2.TabIndex = 25;
            label2.Text = "ŞİFRE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.FromArgb(33, 11, 97);
            label4.Location = new Point(677, 338);
            label4.Name = "label4";
            label4.Size = new Size(29, 23);
            label4.TabIndex = 24;
            label4.Text = "TC";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.FromArgb(33, 11, 97);
            label3.Location = new Point(677, 224);
            label3.Name = "label3";
            label3.Size = new Size(59, 23);
            label3.TabIndex = 23;
            label3.Text = "EMAİL";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.ForeColor = Color.FromArgb(33, 11, 97);
            label6.Location = new Point(677, 163);
            label6.Name = "label6";
            label6.Size = new Size(64, 23);
            label6.TabIndex = 22;
            label6.Text = "SOYAD";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.FromArgb(33, 11, 97);
            label1.Location = new Point(677, 103);
            label1.Name = "label1";
            label1.Size = new Size(33, 23);
            label1.TabIndex = 21;
            label1.Text = "AD";
            // 
            // btnPdfAktar
            // 
            btnPdfAktar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnPdfAktar.ForeColor = Color.FromArgb(33, 11, 97);
            btnPdfAktar.Image = (Image)resources.GetObject("btnPdfAktar.Image");
            btnPdfAktar.Location = new Point(903, 619);
            btnPdfAktar.Name = "btnPdfAktar";
            btnPdfAktar.Size = new Size(57, 60);
            btnPdfAktar.TabIndex = 20;
            btnPdfAktar.UseVisualStyleBackColor = true;
            btnPdfAktar.Click += btnPdfAktar_Click_1;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.FromArgb(33, 11, 97);
            btnEkle.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnEkle.ForeColor = Color.White;
            btnEkle.Location = new Point(677, 421);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(110, 55);
            btnEkle.TabIndex = 19;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click_1;
            // 
            // btnTemizle
            // 
            btnTemizle.BackColor = Color.FromArgb(33, 11, 97);
            btnTemizle.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnTemizle.ForeColor = Color.White;
            btnTemizle.Location = new Point(677, 517);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(110, 55);
            btnTemizle.TabIndex = 18;
            btnTemizle.Text = "TEMİZLE";
            btnTemizle.UseVisualStyleBackColor = false;
            btnTemizle.Click += btnTemizle_Click_1;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.FromArgb(33, 11, 97);
            btnGuncelle.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGuncelle.ForeColor = Color.White;
            btnGuncelle.Location = new Point(850, 421);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(110, 55);
            btnGuncelle.TabIndex = 17;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click_1;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.FromArgb(33, 11, 97);
            btnSil.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(850, 517);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(110, 55);
            btnSil.TabIndex = 16;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.2F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(33, 11, 97);
            label5.Location = new Point(28, 38);
            label5.Name = "label5";
            label5.Size = new Size(247, 32);
            label5.TabIndex = 15;
            label5.Text = "PERSONEL İŞLEMLERİ";
            // 
            // txtTcKimlikNo
            // 
            txtTcKimlikNo.Location = new Point(825, 338);
            txtTcKimlikNo.Name = "txtTcKimlikNo";
            txtTcKimlikNo.Size = new Size(125, 27);
            txtTcKimlikNo.TabIndex = 9;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(825, 280);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(125, 27);
            txtSifre.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(825, 220);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 7;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(825, 162);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(125, 27);
            txtSoyad.TabIndex = 6;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(825, 103);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(125, 27);
            txtAd.TabIndex = 1;
            // 
            // dgvPersoneller
            // 
            dgvPersoneller.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersoneller.Location = new Point(28, 91);
            dgvPersoneller.Name = "dgvPersoneller";
            dgvPersoneller.RowHeadersWidth = 51;
            dgvPersoneller.Size = new Size(620, 549);
            dgvPersoneller.TabIndex = 0;
            dgvPersoneller.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // UCPersonel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "UCPersonel";
            Size = new Size(1075, 760);
            Load += UCPersonel_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPersoneller).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtAd;
        private DataGridView dgvPersoneller;
        private TextBox txtTcKimlikNo;
        private TextBox txtSifre;
        private TextBox txtEmail;
        private TextBox txtSoyad;
        private Label label5;
        private Button btnSil;
        private Button btnGuncelle;
        private Button btnTemizle;
        private Button btnEkle;
        private Button btnPdfAktar;
        private Label label1;
        private Label label6;
        private Label label3;
        private Label label2;
        private Label label4;
    }
}
