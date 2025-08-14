using System;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace HotelApp
{
    public partial class Login : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = txtKullaniciAdi.Text.Trim();
            string sifre = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT * FROM Users WHERE Email = @Email AND Sifre = @Sifre";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Sifre", sifre);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string rol = reader["Rol"].ToString();
                            string ad = reader["Ad"].ToString();
                            string soyad = reader["Soyad"].ToString();
                            string adSoyad = ad + " " + soyad;

                            if (rol == "admin" || rol == "personel")
                            {
                                MessageBox.Show("Giriş başarılı! Hoş geldiniz " + adSoyad);
                                this.Hide();

                                MainForm anaForm = new MainForm(rol, adSoyad); // AdSoyad gönderiliyor
                                anaForm.Show();
                            }
                            else
                            {
                                MessageBox.Show("Bu kullanıcı giriş yapamaz. Yetkisiz rol.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Email veya şifre yanlış.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Uygulamayı tamamen kapat
        }

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}