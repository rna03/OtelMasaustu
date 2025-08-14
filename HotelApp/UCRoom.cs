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

    public partial class UCRoom : UserControl
    {
        public UCRoom()
        {
            InitializeComponent();
        }



        private void UCRoom_Load(object sender, EventArgs e)
        {

            // Sayfa yüklenince ComboBox'ı doldur
            using (var conn = DbHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Numara FROM rooms";
                    using (var cmd = new MySqlCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        cmbOdaNumaralari.Items.Clear();
                        while (reader.Read())
                        {
                            cmbOdaNumaralari.Items.Add(reader["Numara"].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Numaralar yüklenirken hata: " + ex.Message);
                }
            }
            dataGridViewOdalar.EnableHeadersVisualStyles = false;
            dataGridViewOdalar.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 11, 97); // Koyu morumsu mavi
            dataGridViewOdalar.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewOdalar.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);


            dataGridViewOdalar.DefaultCellStyle.SelectionBackColor = Color.FromArgb(33, 11, 97);  // Seçili arka plan rengi
            dataGridViewOdalar.DefaultCellStyle.SelectionForeColor = Color.White;                 // Seçili yazı rengi

            TumOdalarıListele();
        }

        private void BasliklariAyarlaOdalar()
        {
            if (dataGridViewOdalar.Columns.Contains("Numara"))
                dataGridViewOdalar.Columns["Numara"].HeaderText = "Oda Numarası";
            if (dataGridViewOdalar.Columns.Contains("Kat"))
                dataGridViewOdalar.Columns["Kat"].HeaderText = "Kat";
            if (dataGridViewOdalar.Columns.Contains("OdaTuru"))
                dataGridViewOdalar.Columns["OdaTuru"].HeaderText = "Oda Türü";
            if (dataGridViewOdalar.Columns.Contains("Fiyat"))
                dataGridViewOdalar.Columns["Fiyat"].HeaderText = "Fiyat";
            if (dataGridViewOdalar.Columns.Contains("BuyuklukM2"))
                dataGridViewOdalar.Columns["BuyuklukM2"].HeaderText = "Büyüklük (m²)";
            if (dataGridViewOdalar.Columns.Contains("CocukKabul"))
                dataGridViewOdalar.Columns["CocukKabul"].HeaderText = "Çocuk Kabul";
            if (dataGridViewOdalar.Columns.Contains("ImagePath"))
                dataGridViewOdalar.Columns["ImagePath"].HeaderText = "Resim Yolu";
            if (dataGridViewOdalar.Columns.Contains("Kapasite"))
                dataGridViewOdalar.Columns["Kapasite"].HeaderText = "Kapasite";
            if (dataGridViewOdalar.Columns.Contains("IlaveYatak"))
                dataGridViewOdalar.Columns["IlaveYatak"].HeaderText = "İlave Yatak";
        }

        private void TumOdalarıListele()
        {
            using (var conn = DbHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM rooms";
                    using (var da = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridViewOdalar.DataSource = dt;
                        BasliklariAyarlaOdalar();
                        GizleOdaKolonlari();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Listeleme hatası: " + ex.Message);
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewOdalar.SelectedRows.Count > 0)
            {
                var row = dataGridViewOdalar.SelectedRows[0];
                txtNumara.Text = row.Cells["Numara"].Value?.ToString();
                txtKat.Text = row.Cells["Kat"].Value?.ToString();
                txtOdaTuru.Text = row.Cells["OdaTuru"].Value?.ToString();
                txtFiyat.Text = row.Cells["Fiyat"].Value?.ToString();
                txtBuyuklukM2.Text = row.Cells["BuyuklukM2"].Value?.ToString();
                chkCocukKabul.Checked = Convert.ToBoolean(row.Cells["CocukKabul"].Value);
                txtImagePath.Text = row.Cells["ImagePath"].Value?.ToString();
                txtKapasite.Text = row.Cells["Kapasite"].Value?.ToString();
                chkIlaveYatak.Checked = Convert.ToBoolean(row.Cells["IlaveYatak"].Value);
            }
        }




        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnOdaAra_Click(object sender, EventArgs e)
        {

            string numara = cmbOdaNumaralari.Text.Trim();

            if (string.IsNullOrEmpty(numara))
            {
                MessageBox.Show("Lütfen oda numarası seçiniz.");
                return;
            }

            using (var conn = DbHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM rooms WHERE Numara LIKE @numara";
                    using (var da = new MySqlDataAdapter(query, conn))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@numara", "%" + numara + "%");
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridViewOdalar.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Arama hatası: " + ex.Message);
                }
            }
        }

        private void btnTumOdalar_Click_1(object sender, EventArgs e)
        {
            TumOdalarıListele();
        }

        private void btnOdaEkle_Click_1(object sender, EventArgs e)
        {
            string numara = txtNumara.Text.Trim();

            if (string.IsNullOrEmpty(numara))
            {
                MessageBox.Show("Lütfen oda numarasını giriniz.");
                return;
            }

            using (var conn = DbHelper.GetConnection())
            {
                try
                {
                    conn.Open();

                    // Önce aynı numaranın olup olmadığını kontrol et
                    string checkQuery = "SELECT COUNT(*) FROM rooms WHERE Numara = @Numara";
                    using (var checkCmd = new MySqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@Numara", numara);
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("Bu oda numarası zaten mevcut. Lütfen farklı bir numara giriniz.");
                            return;
                        }
                    }

                    // Eğer yoksa ekleme yap
                    string query = @"INSERT INTO rooms 
                (Numara, Kat, OdaTuru, Fiyat, BuyuklukM2, CocukKabul, ImagePath, Kapasite, IlaveYatak) 
                VALUES (@Numara, @Kat, @OdaTuru, @Fiyat, @BuyuklukM2, @CocukKabul, @ImagePath, @Kapasite, @IlaveYatak)";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Numara", numara);
                        cmd.Parameters.AddWithValue("@Kat", txtKat.Text.Trim());
                        cmd.Parameters.AddWithValue("@OdaTuru", txtOdaTuru.Text.Trim());

                        decimal fiyat;
                        if (!decimal.TryParse(txtFiyat.Text.Trim().Replace(',', '.'), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out fiyat))
                        {
                            MessageBox.Show("Fiyat değeri geçersiz.");
                            return;
                        }
                        cmd.Parameters.AddWithValue("@Fiyat", fiyat);

                        cmd.Parameters.AddWithValue("@BuyuklukM2", txtBuyuklukM2.Text.Trim());
                        cmd.Parameters.AddWithValue("@CocukKabul", chkCocukKabul.Checked);
                        cmd.Parameters.AddWithValue("@ImagePath", txtImagePath.Text.Trim());
                        cmd.Parameters.AddWithValue("@Kapasite", txtKapasite.Text.Trim());
                        cmd.Parameters.AddWithValue("@IlaveYatak", chkIlaveYatak.Checked);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Oda başarıyla eklendi.");
                        TumOdalarıListele();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ekleme hatası: " + ex.Message);
                }
            }
        }

        private void btnOdaGuncelle_Click_1(object sender, EventArgs e)
        {

            if (dataGridViewOdalar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen güncellenecek bir oda seçiniz.");
                return;
            }

            int id = Convert.ToInt32(dataGridViewOdalar.SelectedRows[0].Cells["Id"].Value);

            using (var conn = DbHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"UPDATE rooms SET 
                        Numara = @Numara,
                        Kat = @Kat,
                        OdaTuru = @OdaTuru,
                        Fiyat = @Fiyat,
                        BuyuklukM2 = @BuyuklukM2,
                        CocukKabul = @CocukKabul,
                        ImagePath = @ImagePath,
                        Kapasite = @Kapasite,
                        IlaveYatak = @IlaveYatak
                        WHERE Id = @Id";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Numara", txtNumara.Text.Trim());
                        cmd.Parameters.AddWithValue("@Kat", txtKat.Text.Trim());
                        cmd.Parameters.AddWithValue("@OdaTuru", txtOdaTuru.Text.Trim());
                        decimal fiyat;
                        if (!decimal.TryParse(txtFiyat.Text.Trim().Replace(',', '.'), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out fiyat))
                        {
                            MessageBox.Show("Fiyat değeri geçersiz.");
                            return;
                        }
                        cmd.Parameters.AddWithValue("@Fiyat", fiyat);

                        cmd.Parameters.AddWithValue("@BuyuklukM2", txtBuyuklukM2.Text.Trim());
                        cmd.Parameters.AddWithValue("@CocukKabul", chkCocukKabul.Checked);
                        cmd.Parameters.AddWithValue("@ImagePath", txtImagePath.Text.Trim());
                        cmd.Parameters.AddWithValue("@Kapasite", txtKapasite.Text.Trim());
                        cmd.Parameters.AddWithValue("@IlaveYatak", chkIlaveYatak.Checked);
                        cmd.Parameters.AddWithValue("@Id", id);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Oda başarıyla güncellendi.");
                        TumOdalarıListele();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Güncelleme hatası: " + ex.Message);
                }
            }
        }
        private void GizleOdaKolonlari()
        {
            if (dataGridViewOdalar.Columns.Contains("Id"))
                dataGridViewOdalar.Columns["Id"].Visible = false;
        }
        private void btnOdaSil_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewOdalar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silinecek bir oda seçiniz.");
                return;
            }
            var result = MessageBox.Show("Bu oda silinecek. Emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
                return;
            int id = Convert.ToInt32(dataGridViewOdalar.SelectedRows[0].Cells["Id"].Value);

            using (var conn = DbHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM rooms WHERE Id = @Id";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Oda başarıyla silindi.");
                        TumOdalarıListele();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Silme hatası: " + ex.Message);
                }
            }
        }

        private void btnFormuTemizle_Click_1(object sender, EventArgs e)
        {

            txtNumara.Clear();
            txtKat.Clear();
            txtOdaTuru.Clear();
            txtFiyat.Clear();
            txtBuyuklukM2.Clear();
            chkCocukKabul.Checked = false;
            txtImagePath.Clear();
            txtKapasite.Clear();
            chkIlaveYatak.Checked = false;
        }
    }
}
