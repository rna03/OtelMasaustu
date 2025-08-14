namespace HotelApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            ıconSplitButton1 = new FontAwesome.Sharp.IconSplitButton();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button4 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            button5 = new Button();
            button6 = new Button();
            label3 = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // ıconSplitButton1
            // 
            ıconSplitButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            ıconSplitButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            ıconSplitButton1.IconColor = Color.Black;
            ıconSplitButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıconSplitButton1.IconSize = 48;
            ıconSplitButton1.Name = "ıconSplitButton1";
            ıconSplitButton1.Rotation = 0D;
            ıconSplitButton1.Size = new Size(23, 23);
            ıconSplitButton1.Text = "ıconSplitButton1";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(33, 11, 97);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1300, 40);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(339, 21);
            label2.TabIndex = 3;
            label2.Text = "Otel Rezervasyon ve Takip Personel Sistemi ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1268, 8);
            label1.Name = "label1";
            label1.Size = new Size(20, 22);
            label1.TabIndex = 0;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(225, 40);
            panel3.Name = "panel3";
            panel3.Size = new Size(1075, 760);
            panel3.TabIndex = 7;
            panel3.Paint += panel3_Paint;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(33, 11, 97);
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            button3.ForeColor = Color.White;
            button3.Location = new Point(12, 371);
            button3.Name = "button3";
            button3.Size = new Size(200, 64);
            button3.TabIndex = 4;
            button3.Text = "Rezervasyon işlemleri";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(33, 11, 97);
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            button2.ForeColor = Color.White;
            button2.Location = new Point(12, 301);
            button2.Name = "button2";
            button2.Size = new Size(200, 64);
            button2.TabIndex = 3;
            button2.Text = "Oda İşlemleri";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(33, 11, 97);
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            button4.ForeColor = Color.White;
            button4.Location = new Point(12, 441);
            button4.Name = "button4";
            button4.Size = new Size(200, 64);
            button4.TabIndex = 5;
            button4.Text = "Ödeme işlemleri";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(33, 11, 97);
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 231);
            button1.Name = "button1";
            button1.Size = new Size(200, 64);
            button1.TabIndex = 2;
            button1.Text = "Müşteri İşlemleri";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(62, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(105, 42);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(33, 11, 97);
            button5.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            button5.ForeColor = Color.White;
            button5.Location = new Point(12, 511);
            button5.Name = "button5";
            button5.Size = new Size(198, 64);
            button5.TabIndex = 8;
            button5.Text = "Personel işlemleri";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(33, 11, 97);
            button6.BackgroundImage = (Image)resources.GetObject("button6.BackgroundImage");
            button6.FlatAppearance.BorderColor = Color.FromArgb(33, 11, 97);
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.FromArgb(33, 11, 97);
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.Location = new Point(62, 609);
            button6.Name = "button6";
            button6.Size = new Size(100, 100);
            button6.TabIndex = 7;
            button6.TextImageRelation = TextImageRelation.ImageAboveText;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(33, 11, 97);
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.White;
            label3.Location = new Point(77, 712);
            label3.Name = "label3";
            label3.Size = new Size(85, 23);
            label3.TabIndex = 7;
            label3.Text = "ÇIKIŞ YAP";
            label3.Click += label3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 11, 97);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(225, 760);
            panel1.TabIndex = 6;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Location = new Point(32, 34);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(157, 91);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 167);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 0;
            label4.Text = "label4";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 800);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private FontAwesome.Sharp.IconSplitButton ıconSplitButton1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Panel panel3;
        private Button button3;
        private Button button2;
        private Button button4;
        private Button button1;
        private PictureBox pictureBox1;
        private Button button5;
        private Button button6;
        private Label label3;
        private Panel panel1;
        private Label label4;
        private PictureBox pictureBox2;
    }
}