using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HotelApp
{
    public partial class MainForm : Form
    {
        private string kullaniciRol; // Rol bilgisini saklayacağız
        private string kullaniciAdSoyad;


        public MainForm(string rol, string adSoyad)
        {
            InitializeComponent();
            kullaniciRol = rol; // Rol bilgisini sakla
            kullaniciAdSoyad = adSoyad;

            label4.Text = "Hoşgeldin, " + kullaniciAdSoyad;
        }
        public static MainForm Instance;
        private void Form1_Load(object sender, EventArgs e)
        {

            Instance = this;
        }
        public void LoadUserControl(UserControl uc)
        {
            panel3.Controls.Clear();
            panel3.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            // Kullanıcıya emin mi diye sor
            DialogResult result = MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?",
                                                  "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Mevcut formu kapat
                this.Hide();

                // Tekrar Login formunu aç
                Login loginForm = new Login();
                loginForm.Show();
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            UcReservation ucReservation = new UcReservation();
            LoadUserControl(ucReservation);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UCMusteri ucMusteri = new UCMusteri();
            LoadUserControl(ucMusteri);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UCRoom ucRoom = new UCRoom();
            LoadUserControl(ucRoom);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UCPayments ucPayments = new UCPayments();
            LoadUserControl(ucPayments);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (kullaniciRol == "admin")
            {
                UCPersonel personelKontrol = new UCPersonel();
                LoadUserControl(personelKontrol);
            }
            else
            {
                MessageBox.Show("Bu sayfaya sadece admin erişebilir.");
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Uygulamayı tamamen kapat

        }
    }
}
