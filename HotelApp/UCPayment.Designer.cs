namespace HotelApp
{
    partial class UCPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCPayment));
            panel1 = new Panel();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button6 = new Button();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            panel2 = new Panel();
            label5 = new Label();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(textBox2);
            panel1.Location = new Point(28, 427);
            panel1.Name = "panel1";
            panel1.Size = new Size(1020, 276);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(33, 11, 97);
            button1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.White;
            button1.Location = new Point(377, 169);
            button1.Name = "button1";
            button1.Size = new Size(118, 65);
            button1.TabIndex = 17;
            button1.Text = "ÖDEME YAP";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.FromArgb(33, 11, 97);
            label3.Location = new Point(341, 44);
            label3.Name = "label3";
            label3.Size = new Size(61, 23);
            label3.TabIndex = 16;
            label3.Text = "TUTAR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.FromArgb(33, 11, 97);
            label2.Location = new Point(609, 44);
            label2.Name = "label2";
            label2.Size = new Size(149, 23);
            label2.TabIndex = 15;
            label2.Text = "ÖDEME YÖNTEMİ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.FromArgb(33, 11, 97);
            label1.Location = new Point(78, 44);
            label1.Name = "label1";
            label1.Size = new Size(127, 23);
            label1.TabIndex = 14;
            label1.Text = "ÖDEME TARİHİ";
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button6.ForeColor = Color.FromArgb(33, 11, 97);
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.Location = new Point(932, 184);
            button6.Name = "button6";
            button6.Size = new Size(57, 60);
            button6.TabIndex = 13;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox1.Location = new Point(78, 90);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(168, 30);
            textBox1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(609, 89);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(196, 31);
            comboBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox2.Location = new Point(341, 90);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(163, 30);
            textBox2.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(28, 29);
            panel2.Name = "panel2";
            panel2.Size = new Size(1020, 375);
            panel2.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.2F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(33, 11, 97);
            label5.Location = new Point(18, 24);
            label5.Name = "label5";
            label5.Size = new Size(214, 32);
            label5.TabIndex = 14;
            label5.Text = "ÖDEME İŞLEMLERİ";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(33, 11, 97);
            button3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button3.ForeColor = Color.White;
            button3.Location = new Point(817, 161);
            button3.Name = "button3";
            button3.Size = new Size(115, 75);
            button3.TabIndex = 5;
            button3.Text = "TÜM ÖDEMELER";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(18, 82);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(686, 258);
            dataGridView1.TabIndex = 0;
            // 
            // UCPayment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UCPayment";
            Size = new Size(1075, 760);
            Load += UCPayment_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button3;
        private Button button6;
        private Button button1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
    }
}
