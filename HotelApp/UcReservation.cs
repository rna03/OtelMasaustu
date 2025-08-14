using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HotelApp
{
    public partial class UcReservation : UserControl
    {
        public UcReservation()
        {
            InitializeComponent();
            this.Load += Musteri_Load;

        }
        // Seçilen kullanıcı ID'si diğer UserControl'de kullanılmak üzere burada tutuluyor
        public static int SecilenUserId;
        private void Musteri_Load(object sender, EventArgs e)//ucreservation
        {
            dgvRezervasyonlar.EnableHeadersVisualStyles = false;
            dgvRezervasyonlar.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 11, 97); // Koyu morumsu mavi
            dgvRezervasyonlar.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvRezervasyonlar.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);


            dgvRezervasyonlar.DefaultCellStyle.SelectionBackColor = Color.FromArgb(33, 11, 97);  // Seçili arka plan rengi
            dgvRezervasyonlar.DefaultCellStyle.SelectionForeColor = Color.White;                 // Seçili yazı rengi
            dgvMusteriler.EnableHeadersVisualStyles = false;
            dgvMusteriler.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 11, 97); // Koyu morumsu mavi
            dgvMusteriler.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvMusteriler.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);


            dgvMusteriler.DefaultCellStyle.SelectionBackColor = Color.FromArgb(33, 11, 97);  // Seçili arka plan rengi
            dgvMusteriler.DefaultCellStyle.SelectionForeColor = Color.White;
            cmbOdemeYontemi.Items.Clear();  // Önce temizle
            cmbOdemeYontemi.Items.Add("Nakit");
            cmbOdemeYontemi.Items.Add("Kredi Kartı");
            TumRezervasyonlariGetir(); // Sayfa yüklenince tüm rezervasyonları getir


        }
        private void TumRezervasyonlariGetir()
        {
            using (var conn = DbHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM reservations";

                    using (var da = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvRezervasyonlar.DataSource = dt;

                        GizleRezervasyonKolonlari();
                        BasliklariAyarlaRezervasyon();
                        GizleMusteriKolonlari();
                        BasliklariAyarlaMusteri();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
        private void GizleRezervasyonKolonlari()
        {
            if (dgvRezervasyonlar.Columns.Contains("Id"))
                dgvRezervasyonlar.Columns["Id"].Visible = false;
            if (dgvRezervasyonlar.Columns.Contains("UserId"))
                dgvRezervasyonlar.Columns["UserId"].Visible = false;
            if (dgvRezervasyonlar.Columns.Contains("RoomId"))
                dgvRezervasyonlar.Columns["RoomId"].Visible = false;
            if (dgvRezervasyonlar.Columns.Contains("MusteriId"))
                dgvRezervasyonlar.Columns["MusteriId"].Visible = false;
        }

        private void GizleMusteriKolonlari()
        {
            if (dgvMusteriler.Columns.Contains("Id"))
                dgvMusteriler.Columns["Id"].Visible = false;
            if (dgvMusteriler.Columns.Contains("RezervasyonId"))
                dgvMusteriler.Columns["RezervasyonId"].Visible = false;
        }

        private void BasliklariAyarlaRezervasyon()
        {
            if (dgvRezervasyonlar.Columns.Contains("GirisTarihi"))
                dgvRezervasyonlar.Columns["GirisTarihi"].HeaderText = "Giriş Tarihi";
            if (dgvRezervasyonlar.Columns.Contains("CikisTarihi"))
                dgvRezervasyonlar.Columns["CikisTarihi"].HeaderText = "Çıkış Tarihi";
            if (dgvRezervasyonlar.Columns.Contains("ToplamTutar"))
                dgvRezervasyonlar.Columns["ToplamTutar"].HeaderText = "Toplam Tutar";
            if (dgvRezervasyonlar.Columns.Contains("IptalEdildi"))
                dgvRezervasyonlar.Columns["IptalEdildi"].HeaderText = "İptal Durumu";
            if (dgvRezervasyonlar.Columns.Contains("IptalTarihi"))
                dgvRezervasyonlar.Columns["IptalTarihi"].HeaderText = "İptal Tarihi";
        }

        private void BasliklariAyarlaMusteri()
        {
            if (dgvMusteriler.Columns.Contains("Ad"))
                dgvMusteriler.Columns["Ad"].HeaderText = "Ad";
            if (dgvMusteriler.Columns.Contains("Soyad"))
                dgvMusteriler.Columns["Soyad"].HeaderText = "Soyad";
            if (dgvMusteriler.Columns.Contains("Telefon"))
                dgvMusteriler.Columns["Telefon"].HeaderText = "Telefon";
            if (dgvMusteriler.Columns.Contains("Email"))
                dgvMusteriler.Columns["Email"].HeaderText = "E-posta";
            if (dgvMusteriler.Columns.Contains("TcKimlikNo"))
                dgvMusteriler.Columns["TcKimlikNo"].HeaderText = "TC Kimlik No";
        }


        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRezervasyonlar.SelectedRows.Count > 0)
            {
                var row = dgvRezervasyonlar.SelectedRows[0];
                int rezervasyonId = Convert.ToInt32(row.Cells["Id"].Value);

                using (var conn = DbHelper.GetConnection())
                {
                    try
                    {
                        conn.Open();

                        // 1️⃣ Seçilen rezervasyona ait müşterileri getir
                        string query = "SELECT * FROM musteri WHERE RezervasyonId = @rezId";
                        using (var da = new MySqlDataAdapter(query, conn))
                        {
                            da.SelectCommand.Parameters.AddWithValue("@rezId", rezervasyonId);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dgvMusteriler.DataSource = dt;
                            GizleRezervasyonKolonlari();
                            BasliklariAyarlaRezervasyon();
                            GizleMusteriKolonlari();
                            BasliklariAyarlaMusteri();
                        }

                        // 2️⃣ ToplamTutar'ı TextBox'a getir
                        string toplamTutarQuery = "SELECT ToplamTutar FROM reservations WHERE Id = @rezId";
                        using (var cmd = new MySqlCommand(toplamTutarQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@rezId", rezervasyonId);
                            object result = cmd.ExecuteScalar();
                            if (result != null)
                            {
                                txtToplamTutar.Text = result.ToString();
                            }
                            else
                            {
                                txtToplamTutar.Text = "0";
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }

        }

      

        private void btnOdemeYap_Click_1(object sender, EventArgs e)
        {
            if (dgvRezervasyonlar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir rezervasyon seçin.");
                return;
            }

            var selectedRow = dgvRezervasyonlar.SelectedRows[0];
            int rezervasyonId = Convert.ToInt32(selectedRow.Cells["Id"].Value);
            string odemeYontemi = cmbOdemeYontemi.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(odemeYontemi))
            {
                MessageBox.Show("Lütfen bir ödeme yöntemi seçin.");
                return;
            }

            using (var conn = DbHelper.GetConnection())
            {
                try
                {
                    conn.Open();

                    // 1️⃣ Ödeme daha önce yapılmış mı kontrol et
                    string kontrolQuery = "SELECT COUNT(*) FROM payments WHERE ReservationId = @rezId";
                    using (var kontrolCmd = new MySqlCommand(kontrolQuery, conn))
                    {
                        kontrolCmd.Parameters.AddWithValue("@rezId", rezervasyonId);
                        int odemeSayisi = Convert.ToInt32(kontrolCmd.ExecuteScalar());

                        if (odemeSayisi > 0)
                        {
                            MessageBox.Show("Bu rezervasyonun ödemesi daha önce yapılmış.");
                            return;
                        }
                    }

                    // 2️⃣ Toplam tutarı rezervasyondan al
                    string tutarQuery = "SELECT ToplamTutar FROM reservations WHERE Id = @rezId";
                    decimal tutar = 0;

                    using (var tutarCmd = new MySqlCommand(tutarQuery, conn))
                    {
                        tutarCmd.Parameters.AddWithValue("@rezId", rezervasyonId);
                        var result = tutarCmd.ExecuteScalar();
                        if (result != null)
                        {
                            tutar = Convert.ToDecimal(result);
                        }
                    }

                    // 3️⃣ Ödeme kaydı ekle
                    string insertQuery = @"INSERT INTO payments (ReservationId, OdemeTarihi, OdemeYontemi, Tutar)
                                   VALUES (@rezId, @tarih, @yontem, @tutar)";

                    using (var cmd = new MySqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@rezId", rezervasyonId);
                        cmd.Parameters.AddWithValue("@tarih", DateTime.Now);
                        cmd.Parameters.AddWithValue("@yontem", odemeYontemi);
                        cmd.Parameters.AddWithValue("@tutar", tutar);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Ödeme başarıyla yapıldı.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void btnTcIleAra_Click_1(object sender, EventArgs e)
        {

            string aranan = rtbTCKimlik.Text.Trim();

            if (string.IsNullOrEmpty(aranan))
            {
                MessageBox.Show("Lütfen TC kimlik numarası giriniz.");
                return;
            }

            using (var conn = DbHelper.GetConnection())
            {
                try
                {
                    conn.Open();

                    // Kullanıcıyı isim, soyisim veya TC'ye göre bul
                    string userQuery = @"SELECT id FROM users 
                                         WHERE TcKimlikNo = @arama LIMIT 1";

                    int userId = -1;

                    using (var cmd = new MySqlCommand(userQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@arama", aranan);
                        var result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            userId = Convert.ToInt32(result);
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı bulunamadı.");
                            return;
                        }
                    }

                    // Kullanıcının rezervasyonlarını getir
                    string rezervasyonQuery = "SELECT * FROM reservations WHERE UserId = @userId";

                    using (var da = new MySqlDataAdapter(rezervasyonQuery, conn))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@userId", userId);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvRezervasyonlar.DataSource = dt;
                        GizleRezervasyonKolonlari();
                        BasliklariAyarlaRezervasyon();
                        GizleMusteriKolonlari();
                        BasliklariAyarlaMusteri();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void btnMusteriEkle_Click_1(object sender, EventArgs e)
        {
            if (dgvRezervasyonlar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir rezervasyon seçin.");
                return;
            }

            var rezervasyonRow = dgvRezervasyonlar.SelectedRows[0];
            int rezervasyonId = Convert.ToInt32(rezervasyonRow.Cells["Id"].Value);
            int roomId = Convert.ToInt32(rezervasyonRow.Cells["RoomId"].Value);

            using (var conn = DbHelper.GetConnection())
            {
                try
                {
                    conn.Open();

                    // rooms tablosundan kapasite + ilaveYatak
                    string roomQuery = "SELECT Kapasite, IlaveYatak FROM rooms WHERE Id = @roomId";
                    int kapasite = 0, ilaveYatak = 0;

                    using (var cmd = new MySqlCommand(roomQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@roomId", roomId);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                kapasite = Convert.ToInt32(reader["Kapasite"]);
                                ilaveYatak = Convert.ToInt32(reader["IlaveYatak"]);
                            }
                        }
                    }

                    // rezervasyona ait mevcut müşteri sayısı
                    string musteriSayisiQuery = "SELECT COUNT(*) FROM musteri WHERE RezervasyonId = @rezId";
                    int mevcutMusteriSayisi = 0;
                    using (var cmd = new MySqlCommand(musteriSayisiQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@rezId", rezervasyonId);
                        mevcutMusteriSayisi = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    int maxKapasite = kapasite + ilaveYatak;
                    if (mevcutMusteriSayisi >= maxKapasite)
                    {
                        MessageBox.Show("Odanın kapasitesi dolmuştur. Yeni müşteri eklenemez.");
                        return;
                    }

                    // Yeni müşteri ekle
                    string insertQuery = @"INSERT INTO musteri 
                (Ad, Soyad, Telefon, Email, TcKimlikNo, RezervasyonId) 
                VALUES (@ad, @soyad, @telefon, @email, @tc, @rezId)";

                    using (var cmd = new MySqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@ad", rtbAd.Text.Trim());
                        cmd.Parameters.AddWithValue("@soyad", rtbSoyad.Text.Trim());
                        cmd.Parameters.AddWithValue("@telefon", rtbTelefon.Text.Trim());
                        cmd.Parameters.AddWithValue("@email", rtbEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@tc", rtbTc.Text.Trim());
                        cmd.Parameters.AddWithValue("@rezId", rezervasyonId);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Müşteri başarıyla eklendi.");
                    }

                    // DataGridView2’yi güncelle
                    dataGridView1_SelectionChanged(null, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
    }
}
