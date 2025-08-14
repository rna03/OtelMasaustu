namespace HotelApp
{
    partial class UcReservation
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
            panel1 = new Panel();
            label3 = new Label();
            label5 = new Label();
            btnTcIleAra = new Button();
            rtbTCKimlik = new RichTextBox();
            dgvRezervasyonlar = new DataGridView();
            panel2 = new Panel();
            label10 = new Label();
            label7 = new Label();
            label4 = new Label();
            label2 = new Label();
            label6 = new Label();
            label1 = new Label();
            btnMusteriEkle = new Button();
            rtbTc = new RichTextBox();
            rtbEmail = new RichTextBox();
            rtbTelefon = new RichTextBox();
            rtbSoyad = new RichTextBox();
            rtbAd = new RichTextBox();
            dgvMusteriler = new DataGridView();
            panel3 = new Panel();
            label9 = new Label();
            label8 = new Label();
            btnOdemeYap = new Button();
            txtToplamTutar = new TextBox();
            cmbOdemeYontemi = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRezervasyonlar).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMusteriler).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnTcIleAra);
            panel1.Controls.Add(rtbTCKimlik);
            panel1.Controls.Add(dgvRezervasyonlar);
            panel1.Location = new Point(36, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(722, 343);
            panel1.TabIndex = 0;
       
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.FromArgb(33, 11, 97);
            label3.Location = new Point(556, 100);
            label3.Name = "label3";
            label3.Size = new Size(105, 23);
            label3.TabIndex = 22;
            label3.Text = "MÜŞTERİ TC";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.2F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(33, 11, 97);
            label5.Location = new Point(27, 19);
            label5.Name = "label5";
            label5.Size = new Size(218, 32);
            label5.TabIndex = 21;
            label5.Text = "REZERVASYONLAR";
            // 
            // btnTcIleAra
            // 
            btnTcIleAra.BackColor = Color.FromArgb(33, 11, 97);
            btnTcIleAra.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnTcIleAra.ForeColor = Color.White;
            btnTcIleAra.Location = new Point(585, 202);
            btnTcIleAra.Name = "btnTcIleAra";
            btnTcIleAra.Size = new Size(110, 55);
            btnTcIleAra.TabIndex = 19;
            btnTcIleAra.Text = "LİSTELE";
            btnTcIleAra.UseVisualStyleBackColor = false;
            btnTcIleAra.Click += btnTcIleAra_Click_1;
            // 
            // rtbTCKimlik
            // 
            rtbTCKimlik.Location = new Point(556, 136);
            rtbTCKimlik.Name = "rtbTCKimlik";
            rtbTCKimlik.Size = new Size(154, 33);
            rtbTCKimlik.TabIndex = 2;
            rtbTCKimlik.Text = "";
            // 
            // dgvRezervasyonlar
            // 
            dgvRezervasyonlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRezervasyonlar.Location = new Point(27, 69);
            dgvRezervasyonlar.Name = "dgvRezervasyonlar";
            dgvRezervasyonlar.RowHeadersWidth = 51;
            dgvRezervasyonlar.Size = new Size(502, 255);
            dgvRezervasyonlar.TabIndex = 0;
            dgvRezervasyonlar.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnMusteriEkle);
            panel2.Controls.Add(rtbTc);
            panel2.Controls.Add(rtbEmail);
            panel2.Controls.Add(rtbTelefon);
            panel2.Controls.Add(rtbSoyad);
            panel2.Controls.Add(rtbAd);
            panel2.Controls.Add(dgvMusteriler);
            panel2.Location = new Point(36, 388);
            panel2.Name = "panel2";
            panel2.Size = new Size(997, 347);
            panel2.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 14.2F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(33, 11, 97);
            label10.Location = new Point(27, 15);
            label10.Name = "label10";
            label10.Size = new Size(152, 32);
            label10.TabIndex = 23;
            label10.Text = "MÜŞTERİLER";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.ForeColor = Color.FromArgb(33, 11, 97);
            label7.Location = new Point(646, 187);
            label7.Name = "label7";
            label7.Size = new Size(29, 23);
            label7.TabIndex = 26;
            label7.Text = "TC";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.FromArgb(33, 11, 97);
            label4.Location = new Point(556, 99);
            label4.Name = "label4";
            label4.Size = new Size(80, 23);
            label4.TabIndex = 25;
            label4.Text = "TELEFON";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.FromArgb(33, 11, 97);
            label2.Location = new Point(777, 99);
            label2.Name = "label2";
            label2.Size = new Size(59, 23);
            label2.TabIndex = 24;
            label2.Text = "EMAİL";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.ForeColor = Color.FromArgb(33, 11, 97);
            label6.Location = new Point(777, 23);
            label6.Name = "label6";
            label6.Size = new Size(64, 23);
            label6.TabIndex = 23;
            label6.Text = "SOYAD";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.FromArgb(33, 11, 97);
            label1.Location = new Point(556, 23);
            label1.Name = "label1";
            label1.Size = new Size(33, 23);
            label1.TabIndex = 22;
            label1.Text = "AD";
            // 
            // btnMusteriEkle
            // 
            btnMusteriEkle.BackColor = Color.FromArgb(33, 11, 97);
            btnMusteriEkle.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnMusteriEkle.ForeColor = Color.White;
            btnMusteriEkle.Location = new Point(667, 263);
            btnMusteriEkle.Name = "btnMusteriEkle";
            btnMusteriEkle.Size = new Size(125, 64);
            btnMusteriEkle.TabIndex = 21;
            btnMusteriEkle.Text = "MÜŞTERİ EKLE";
            btnMusteriEkle.UseVisualStyleBackColor = false;
            btnMusteriEkle.Click += btnMusteriEkle_Click_1;
            // 
            // rtbTc
            // 
            rtbTc.Location = new Point(646, 213);
            rtbTc.Name = "rtbTc";
            rtbTc.Size = new Size(166, 33);
            rtbTc.TabIndex = 7;
            rtbTc.Text = "";
            // 
            // rtbEmail
            // 
            rtbEmail.Location = new Point(777, 125);
            rtbEmail.Name = "rtbEmail";
            rtbEmail.Size = new Size(140, 33);
            rtbEmail.TabIndex = 6;
            rtbEmail.Text = "";
            // 
            // rtbTelefon
            // 
            rtbTelefon.Location = new Point(556, 125);
            rtbTelefon.Name = "rtbTelefon";
            rtbTelefon.Size = new Size(139, 33);
            rtbTelefon.TabIndex = 5;
            rtbTelefon.Text = "";
            // 
            // rtbSoyad
            // 
            rtbSoyad.Location = new Point(777, 49);
            rtbSoyad.Name = "rtbSoyad";
            rtbSoyad.Size = new Size(140, 27);
            rtbSoyad.TabIndex = 4;
            rtbSoyad.Text = "";
            // 
            // rtbAd
            // 
            rtbAd.Location = new Point(556, 49);
            rtbAd.Name = "rtbAd";
            rtbAd.Size = new Size(139, 27);
            rtbAd.TabIndex = 3;
            rtbAd.Text = "";
            // 
            // dgvMusteriler
            // 
            dgvMusteriler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMusteriler.Location = new Point(27, 61);
            dgvMusteriler.Name = "dgvMusteriler";
            dgvMusteriler.RowHeadersWidth = 51;
            dgvMusteriler.Size = new Size(502, 255);
            dgvMusteriler.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGray;
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(btnOdemeYap);
            panel3.Controls.Add(txtToplamTutar);
            panel3.Controls.Add(cmbOdemeYontemi);
            panel3.Location = new Point(785, 23);
            panel3.Name = "panel3";
            panel3.Size = new Size(248, 343);
            panel3.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label9.ForeColor = Color.FromArgb(33, 11, 97);
            label9.Location = new Point(45, 137);
            label9.Name = "label9";
            label9.Size = new Size(149, 23);
            label9.TabIndex = 28;
            label9.Text = "ÖDEME YÖNTEMİ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label8.ForeColor = Color.FromArgb(33, 11, 97);
            label8.Location = new Point(45, 44);
            label8.Name = "label8";
            label8.Size = new Size(61, 23);
            label8.TabIndex = 27;
            label8.Text = "TUTAR";
            // 
            // btnOdemeYap
            // 
            btnOdemeYap.BackColor = Color.FromArgb(33, 11, 97);
            btnOdemeYap.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnOdemeYap.ForeColor = Color.White;
            btnOdemeYap.Location = new Point(58, 227);
            btnOdemeYap.Name = "btnOdemeYap";
            btnOdemeYap.Size = new Size(125, 64);
            btnOdemeYap.TabIndex = 20;
            btnOdemeYap.Text = "ÖDEME YAP";
            btnOdemeYap.UseVisualStyleBackColor = false;
            btnOdemeYap.Click += btnOdemeYap_Click_1;
            // 
            // txtToplamTutar
            // 
            txtToplamTutar.Location = new Point(43, 79);
            txtToplamTutar.Name = "txtToplamTutar";
            txtToplamTutar.Size = new Size(151, 27);
            txtToplamTutar.TabIndex = 0;
            // 
            // cmbOdemeYontemi
            // 
            cmbOdemeYontemi.FormattingEnabled = true;
            cmbOdemeYontemi.Location = new Point(45, 172);
            cmbOdemeYontemi.Name = "cmbOdemeYontemi";
            cmbOdemeYontemi.Size = new Size(151, 28);
            cmbOdemeYontemi.TabIndex = 2;
            // 
            // UcReservation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UcReservation";
            Size = new Size(1075, 760);
            Load += Musteri_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRezervasyonlar).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMusteriler).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dgvRezervasyonlar;
        private RichTextBox rtbTCKimlik;
        private RichTextBox rtbEmail;
        private RichTextBox rtbTelefon;
        private RichTextBox rtbSoyad;
        private RichTextBox rtbAd;
        private DataGridView dgvMusteriler;
        private RichTextBox rtbTc;
        private Panel panel3;
        private TextBox txtToplamTutar;
        private ComboBox cmbOdemeYontemi;
        private Button btnTcIleAra;
        private Button btnOdemeYap;
        private Button btnMusteriEkle;
        private Label label5;
        private Label label3;
        private Label label1;
        private Label label6;
        private Label label4;
        private Label label2;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}
