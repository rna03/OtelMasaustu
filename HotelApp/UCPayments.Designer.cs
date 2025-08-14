namespace HotelApp
{
    partial class UCPayments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCPayments));
            panel1 = new Panel();
            btnPdfAktar = new Button();
            btnTumunuGetir = new Button();
            label5 = new Label();
            btnGuncelle = new Button();
            btnSil = new Button();
            label3 = new Label();
            label2 = new Label();
            comboOdemeYontemi = new ComboBox();
            txtTutar = new TextBox();
            dgvOdemeler = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOdemeler).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(btnPdfAktar);
            panel1.Controls.Add(btnTumunuGetir);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnGuncelle);
            panel1.Controls.Add(btnSil);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(comboOdemeYontemi);
            panel1.Controls.Add(txtTutar);
            panel1.Controls.Add(dgvOdemeler);
            panel1.Location = new Point(30, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(1009, 698);
            panel1.TabIndex = 0;
            // 
            // btnPdfAktar
            // 
            btnPdfAktar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnPdfAktar.ForeColor = Color.FromArgb(33, 11, 97);
            btnPdfAktar.Image = (Image)resources.GetObject("btnPdfAktar.Image");
            btnPdfAktar.Location = new Point(929, 614);
            btnPdfAktar.Name = "btnPdfAktar";
            btnPdfAktar.Size = new Size(57, 60);
            btnPdfAktar.TabIndex = 22;
            btnPdfAktar.UseVisualStyleBackColor = true;
            btnPdfAktar.Click += btnPdfAktar_Click;
            // 
            // btnTumunuGetir
            // 
            btnTumunuGetir.BackColor = Color.FromArgb(33, 11, 97);
            btnTumunuGetir.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnTumunuGetir.ForeColor = Color.White;
            btnTumunuGetir.Location = new Point(734, 488);
            btnTumunuGetir.Name = "btnTumunuGetir";
            btnTumunuGetir.Size = new Size(192, 63);
            btnTumunuGetir.TabIndex = 21;
            btnTumunuGetir.Text = "TÜM ÖDEMELER";
            btnTumunuGetir.UseVisualStyleBackColor = false;
            btnTumunuGetir.Click += btnTumunuGetir_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.2F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(33, 11, 97);
            label5.Location = new Point(28, 31);
            label5.Name = "label5";
            label5.Size = new Size(214, 32);
            label5.TabIndex = 20;
            label5.Text = "ÖDEME İŞLEMLERİ";
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.FromArgb(33, 11, 97);
            btnGuncelle.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGuncelle.ForeColor = Color.White;
            btnGuncelle.Location = new Point(863, 366);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(110, 55);
            btnGuncelle.TabIndex = 19;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.FromArgb(33, 11, 97);
            btnSil.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(683, 357);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(110, 55);
            btnSil.TabIndex = 18;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.FromArgb(33, 11, 97);
            label3.Location = new Point(750, 292);
            label3.Name = "label3";
            label3.Size = new Size(61, 23);
            label3.TabIndex = 17;
            label3.Text = "TUTAR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.FromArgb(33, 11, 97);
            label2.Location = new Point(662, 190);
            label2.Name = "label2";
            label2.Size = new Size(149, 23);
            label2.TabIndex = 16;
            label2.Text = "ÖDEME YÖNTEMİ";
            // 
            // comboOdemeYontemi
            // 
            comboOdemeYontemi.FormattingEnabled = true;
            comboOdemeYontemi.Location = new Point(835, 185);
            comboOdemeYontemi.Name = "comboOdemeYontemi";
            comboOdemeYontemi.Size = new Size(151, 28);
            comboOdemeYontemi.TabIndex = 2;
            // 
            // txtTutar
            // 
            txtTutar.Location = new Point(835, 288);
            txtTutar.Name = "txtTutar";
            txtTutar.Size = new Size(149, 27);
            txtTutar.TabIndex = 1;
            // 
            // dgvOdemeler
            // 
            dgvOdemeler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOdemeler.Location = new Point(28, 103);
            dgvOdemeler.Name = "dgvOdemeler";
            dgvOdemeler.RowHeadersWidth = 51;
            dgvOdemeler.Size = new Size(600, 511);
            dgvOdemeler.TabIndex = 0;
            dgvOdemeler.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // UCPayments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "UCPayments";
            Size = new Size(1075, 760);
            Load += UCPayments_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOdemeler).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvOdemeler;
        private ComboBox comboOdemeYontemi;
        private TextBox txtTutar;
        private Label label2;
        private Label label3;
        private Button btnSil;
        private Button btnGuncelle;
        private Label label5;
        private Button btnTumunuGetir;
        private Button btnPdfAktar;
    }
}
