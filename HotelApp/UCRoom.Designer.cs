namespace HotelApp
{
    partial class UCRoom
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
            label11 = new Label();
            label10 = new Label();
            btnTumOdalar = new Button();
            btnOdaAra = new Button();
            cmbOdaNumaralari = new ComboBox();
            dataGridViewOdalar = new DataGridView();
            panel2 = new Panel();
            chkIlaveYatak = new CheckBox();
            chkCocukKabul = new CheckBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnFormuTemizle = new Button();
            btnOdaSil = new Button();
            btnOdaGuncelle = new Button();
            btnOdaEkle = new Button();
            txtKapasite = new TextBox();
            txtImagePath = new TextBox();
            txtBuyuklukM2 = new TextBox();
            txtFiyat = new TextBox();
            txtOdaTuru = new TextBox();
            txtKat = new TextBox();
            txtNumara = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOdalar).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(btnTumOdalar);
            panel1.Controls.Add(btnOdaAra);
            panel1.Controls.Add(cmbOdaNumaralari);
            panel1.Controls.Add(dataGridViewOdalar);
            panel1.Location = new Point(33, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(997, 384);
            panel1.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 14.2F, FontStyle.Bold);
            label11.ForeColor = Color.FromArgb(33, 11, 97);
            label11.Location = new Point(18, 16);
            label11.Name = "label11";
            label11.Size = new Size(184, 32);
            label11.TabIndex = 26;
            label11.Text = "ODA İŞLEMLERİ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label10.ForeColor = Color.FromArgb(33, 11, 97);
            label10.Location = new Point(790, 105);
            label10.Name = "label10";
            label10.Size = new Size(139, 23);
            label10.TabIndex = 25;
            label10.Text = "ODA NUMARASI";
            // 
            // btnTumOdalar
            // 
            btnTumOdalar.BackColor = Color.FromArgb(33, 11, 97);
            btnTumOdalar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnTumOdalar.ForeColor = Color.White;
            btnTumOdalar.Location = new Point(809, 266);
            btnTumOdalar.Name = "btnTumOdalar";
            btnTumOdalar.Size = new Size(132, 62);
            btnTumOdalar.TabIndex = 21;
            btnTumOdalar.Text = "TÜM ODALAR";
            btnTumOdalar.UseVisualStyleBackColor = false;
            btnTumOdalar.Click += btnTumOdalar_Click_1;
            // 
            // btnOdaAra
            // 
            btnOdaAra.BackColor = Color.FromArgb(33, 11, 97);
            btnOdaAra.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnOdaAra.ForeColor = Color.White;
            btnOdaAra.Location = new Point(825, 183);
            btnOdaAra.Name = "btnOdaAra";
            btnOdaAra.Size = new Size(87, 47);
            btnOdaAra.TabIndex = 20;
            btnOdaAra.Text = "ARA";
            btnOdaAra.UseVisualStyleBackColor = false;
            btnOdaAra.Click += btnOdaAra_Click;
            // 
            // cmbOdaNumaralari
            // 
            cmbOdaNumaralari.FormattingEnabled = true;
            cmbOdaNumaralari.Location = new Point(790, 131);
            cmbOdaNumaralari.Name = "cmbOdaNumaralari";
            cmbOdaNumaralari.Size = new Size(151, 28);
            cmbOdaNumaralari.TabIndex = 4;
            // 
            // dataGridViewOdalar
            // 
            dataGridViewOdalar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOdalar.Location = new Point(18, 64);
            dataGridViewOdalar.Name = "dataGridViewOdalar";
            dataGridViewOdalar.RowHeadersWidth = 51;
            dataGridViewOdalar.Size = new Size(730, 291);
            dataGridViewOdalar.TabIndex = 0;
            dataGridViewOdalar.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(chkIlaveYatak);
            panel2.Controls.Add(chkCocukKabul);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnFormuTemizle);
            panel2.Controls.Add(btnOdaSil);
            panel2.Controls.Add(btnOdaGuncelle);
            panel2.Controls.Add(btnOdaEkle);
            panel2.Controls.Add(txtKapasite);
            panel2.Controls.Add(txtImagePath);
            panel2.Controls.Add(txtBuyuklukM2);
            panel2.Controls.Add(txtFiyat);
            panel2.Controls.Add(txtOdaTuru);
            panel2.Controls.Add(txtKat);
            panel2.Controls.Add(txtNumara);
            panel2.Location = new Point(33, 436);
            panel2.Name = "panel2";
            panel2.Size = new Size(997, 296);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // chkIlaveYatak
            // 
            chkIlaveYatak.AutoSize = true;
            chkIlaveYatak.Location = new Point(646, 81);
            chkIlaveYatak.Name = "chkIlaveYatak";
            chkIlaveYatak.Size = new Size(18, 17);
            chkIlaveYatak.TabIndex = 34;
            chkIlaveYatak.UseVisualStyleBackColor = true;
            // 
            // chkCocukKabul
            // 
            chkCocukKabul.AutoSize = true;
            chkCocukKabul.Location = new Point(863, 81);
            chkCocukKabul.Name = "chkCocukKabul";
            chkCocukKabul.Size = new Size(18, 17);
            chkCocukKabul.TabIndex = 33;
            chkCocukKabul.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label9.ForeColor = Color.FromArgb(33, 11, 97);
            label9.Location = new Point(579, 33);
            label9.Name = "label9";
            label9.Size = new Size(169, 23);
            label9.TabIndex = 32;
            label9.Text = "İLAVE YATAK VAR MI";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label8.ForeColor = Color.FromArgb(33, 11, 97);
            label8.Location = new Point(422, 142);
            label8.Name = "label8";
            label8.Size = new Size(83, 23);
            label8.TabIndex = 31;
            label8.Text = "KAPASİTE";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.ForeColor = Color.FromArgb(33, 11, 97);
            label7.Location = new Point(241, 142);
            label7.Name = "label7";
            label7.Size = new Size(108, 23);
            label7.TabIndex = 30;
            label7.Text = "RESİM YOLU";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.ForeColor = Color.FromArgb(33, 11, 97);
            label6.Location = new Point(790, 33);
            label6.Name = "label6";
            label6.Size = new Size(186, 23);
            label6.TabIndex = 29;
            label6.Text = "ÇOCUK KABUL VAR MI";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.FromArgb(33, 11, 97);
            label5.Location = new Point(38, 142);
            label5.Name = "label5";
            label5.Size = new Size(128, 23);
            label5.TabIndex = 28;
            label5.Text = "BÜYÜKLÜK(m²)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.FromArgb(33, 11, 97);
            label4.Location = new Point(579, 142);
            label4.Name = "label4";
            label4.Size = new Size(52, 23);
            label4.TabIndex = 27;
            label4.Text = "FİYAT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.FromArgb(33, 11, 97);
            label3.Location = new Point(422, 33);
            label3.Name = "label3";
            label3.Size = new Size(95, 23);
            label3.TabIndex = 26;
            label3.Text = "ODA TÜRÜ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.FromArgb(33, 11, 97);
            label2.Location = new Point(227, 33);
            label2.Name = "label2";
            label2.Size = new Size(39, 23);
            label2.TabIndex = 25;
            label2.Text = "KAT";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.FromArgb(33, 11, 97);
            label1.Location = new Point(41, 33);
            label1.Name = "label1";
            label1.Size = new Size(84, 23);
            label1.TabIndex = 24;
            label1.Text = "NUMARA";
            // 
            // btnFormuTemizle
            // 
            btnFormuTemizle.BackColor = Color.FromArgb(33, 11, 97);
            btnFormuTemizle.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnFormuTemizle.ForeColor = Color.White;
            btnFormuTemizle.Location = new Point(612, 231);
            btnFormuTemizle.Name = "btnFormuTemizle";
            btnFormuTemizle.Size = new Size(111, 42);
            btnFormuTemizle.TabIndex = 23;
            btnFormuTemizle.Text = "TEMİZLE";
            btnFormuTemizle.UseVisualStyleBackColor = false;
            btnFormuTemizle.Click += btnFormuTemizle_Click_1;
            // 
            // btnOdaSil
            // 
            btnOdaSil.BackColor = Color.FromArgb(33, 11, 97);
            btnOdaSil.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnOdaSil.ForeColor = Color.White;
            btnOdaSil.Location = new Point(422, 231);
            btnOdaSil.Name = "btnOdaSil";
            btnOdaSil.Size = new Size(111, 42);
            btnOdaSil.TabIndex = 22;
            btnOdaSil.Text = "SİL";
            btnOdaSil.UseVisualStyleBackColor = false;
            btnOdaSil.Click += btnOdaSil_Click_1;
            // 
            // btnOdaGuncelle
            // 
            btnOdaGuncelle.BackColor = Color.FromArgb(33, 11, 97);
            btnOdaGuncelle.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnOdaGuncelle.ForeColor = Color.White;
            btnOdaGuncelle.Location = new Point(241, 229);
            btnOdaGuncelle.Name = "btnOdaGuncelle";
            btnOdaGuncelle.Size = new Size(111, 44);
            btnOdaGuncelle.TabIndex = 21;
            btnOdaGuncelle.Text = "GÜNCELLE";
            btnOdaGuncelle.UseVisualStyleBackColor = false;
            btnOdaGuncelle.Click += btnOdaGuncelle_Click_1;
            // 
            // btnOdaEkle
            // 
            btnOdaEkle.BackColor = Color.FromArgb(33, 11, 97);
            btnOdaEkle.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnOdaEkle.ForeColor = Color.White;
            btnOdaEkle.Location = new Point(41, 229);
            btnOdaEkle.Name = "btnOdaEkle";
            btnOdaEkle.Size = new Size(110, 44);
            btnOdaEkle.TabIndex = 20;
            btnOdaEkle.Text = "EKLE";
            btnOdaEkle.UseVisualStyleBackColor = false;
            btnOdaEkle.Click += btnOdaEkle_Click_1;
            // 
            // txtKapasite
            // 
            txtKapasite.Location = new Point(422, 175);
            txtKapasite.Name = "txtKapasite";
            txtKapasite.Size = new Size(125, 27);
            txtKapasite.TabIndex = 8;
            // 
            // txtImagePath
            // 
            txtImagePath.Location = new Point(241, 175);
            txtImagePath.Name = "txtImagePath";
            txtImagePath.Size = new Size(125, 27);
            txtImagePath.TabIndex = 7;
            // 
            // txtBuyuklukM2
            // 
            txtBuyuklukM2.Location = new Point(41, 175);
            txtBuyuklukM2.Name = "txtBuyuklukM2";
            txtBuyuklukM2.Size = new Size(125, 27);
            txtBuyuklukM2.TabIndex = 5;
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(579, 175);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(125, 27);
            txtFiyat.TabIndex = 4;
            // 
            // txtOdaTuru
            // 
            txtOdaTuru.Location = new Point(422, 71);
            txtOdaTuru.Name = "txtOdaTuru";
            txtOdaTuru.Size = new Size(125, 27);
            txtOdaTuru.TabIndex = 3;
            // 
            // txtKat
            // 
            txtKat.Location = new Point(227, 71);
            txtKat.Name = "txtKat";
            txtKat.Size = new Size(125, 27);
            txtKat.TabIndex = 2;
            // 
            // txtNumara
            // 
            txtNumara.Location = new Point(41, 71);
            txtNumara.Name = "txtNumara";
            txtNumara.Size = new Size(125, 27);
            txtNumara.TabIndex = 1;
            // 
            // UCRoom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UCRoom";
            Size = new Size(1075, 760);
            Load += UCRoom_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOdalar).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridViewOdalar;
        private Panel panel2;
        private TextBox txtKapasite;
        private TextBox txtImagePath;
        private TextBox txtBuyuklukM2;
        private TextBox txtFiyat;
        private TextBox txtOdaTuru;
        private TextBox txtKat;
        private TextBox txtNumara;
        private ComboBox cmbOdaNumaralari;
        private Button btnOdaAra;
        private Button btnTumOdalar;
        private Button btnOdaEkle;
        private Button btnOdaGuncelle;
        private Button btnOdaSil;
        private Button btnFormuTemizle;
        private Label label2;
        private Label label1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label10;
        private Label label11;
        private CheckBox chkIlaveYatak;
        private CheckBox chkCocukKabul;
    }
}
