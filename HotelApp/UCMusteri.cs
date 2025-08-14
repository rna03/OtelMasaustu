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
    public partial class UCMusteri : UserControl
    {
        public UCMusteri()
        {
            InitializeComponent();


        }


        private void UserControl_MusteriEkle_Load(object sender, EventArgs e)
        {
            dgvMusteriler.EnableHeadersVisualStyles = false;
            dgvMusteriler.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 11, 97); // Koyu morumsu mavi
            dgvMusteriler.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvMusteriler.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);


            dgvMusteriler.DefaultCellStyle.SelectionBackColor = Color.FromArgb(33, 11, 97);  // Seçili arka plan rengi
            dgvMusteriler.DefaultCellStyle.SelectionForeColor = Color.White;                 // Seçili yazı rengi

            btnTumunuGetir.PerformClick(); // Tüm müşterileri otomatik getir
        }






        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMusteriler.SelectedRows.Count > 0)
            {
                var row = dgvMusteriler.SelectedRows[0];

                txtAraTc.Text = row.Cells["Id"].Value.ToString(); // genelde Id
                txtAd.Text = row.Cells["Ad"].Value.ToString();
                txtSoyad.Text = row.Cells["Soyad"].Value.ToString();
                txtTelefon.Text = row.Cells["Telefon"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtTc.Text = row.Cells["TcKimlikNo"].Value.ToString();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void OzellestirDataGridView()
        {
            if (dgvMusteriler.Columns.Contains("Id"))
                dgvMusteriler.Columns["Id"].Visible = false;

            if (dgvMusteriler.Columns.Contains("RezervasyonId"))
                dgvMusteriler.Columns["RezervasyonId"].Visible = false;

            // Başlıkları anlamlı yap
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
            if (dgvMusteriler.Columns.Contains("RezervasyonId"))
                dgvMusteriler.Columns["RezervasyonId"].HeaderText = "Rezervasyon No";
        }

        private void btnAra_Click(object sender, EventArgs e)
        {

            string tc = txtAraTc.Text.Trim();

            if (string.IsNullOrEmpty(tc))
            {
                MessageBox.Show("Lütfen bir TC kimlik numarası girin.");
                return;
            }

            using (var conn = DbHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM musteri WHERE TcKimlikNo = @tc";
                    using (var da = new MySqlDataAdapter(query, conn))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@tc", tc);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvMusteriler.DataSource = dt;

                        OzellestirDataGridView();



                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void btnTumunuGetir_Click(object sender, EventArgs e)
        {
            using (var conn = DbHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM musteri";
                    using (var da = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvMusteriler.DataSource = dt;


                        OzellestirDataGridView();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void btnPdfAktar_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "PDF Dosyası|*.pdf";
            saveFile.Title = "Müşterileri PDF'ye Aktar";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream stream = new FileStream(saveFile.FileName, FileMode.Create))
                    {
                        iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4);
                        iTextSharp.text.pdf.PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();

                        iTextSharp.text.pdf.PdfPTable table = new iTextSharp.text.pdf.PdfPTable(dgvMusteriler.Columns.Count);

                        // Sütun başlıklarını ekle
                        foreach (DataGridViewColumn column in dgvMusteriler.Columns)
                        {
                            iTextSharp.text.pdf.PdfPCell cell = new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase(column.HeaderText))
                            {
                                BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240)
                            };
                            table.AddCell(cell);
                        }

                        // Satırları ekle
                        foreach (DataGridViewRow row in dgvMusteriler.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    table.AddCell(cell.Value?.ToString() ?? "");
                                }
                            }
                        }

                        pdfDoc.Add(table);
                        pdfDoc.Close();
                        stream.Close();

                        MessageBox.Show("PDF başarıyla oluşturuldu.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("PDF oluşturulamadı: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvMusteriler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek için bir satır seçin.");
                return;
            }

            // Seçilen satırın ID'sini alıyoruz
            int musteriId = Convert.ToInt32(dgvMusteriler.SelectedRows[0].Cells["Id"].Value);

            var confirm = MessageBox.Show("Seçili müşteriyi silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes)
                return;

            using (var conn = DbHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string deleteQuery = "DELETE FROM musteri WHERE Id = @Id";
                    using (var cmd = new MySqlCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", musteriId);
                        int affected = cmd.ExecuteNonQuery();

                        if (affected > 0)
                        {
                            MessageBox.Show("Müşteri başarıyla silindi.");
                            btnTumunuGetir.PerformClick(); // Tüm müşterileri yeniden listele
                        }
                        else
                        {
                            MessageBox.Show("Silme işlemi başarısız oldu.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvMusteriler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen güncellenecek bir müşteri seçin.");
                return;
            }

            int musteriId = Convert.ToInt32(dgvMusteriler.SelectedRows[0].Cells["Id"].Value);

            using (var conn = DbHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string updateQuery = @"UPDATE musteri 
                                   SET Ad = @ad, Soyad = @soyad, Telefon = @telefon, Email = @email, 
                                       TcKimlikNo = @tc
                                   WHERE Id = @id";
                    using (var cmd = new MySqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@ad", txtAd.Text.Trim());
                        cmd.Parameters.AddWithValue("@soyad", txtSoyad.Text.Trim());
                        cmd.Parameters.AddWithValue("@telefon", txtTelefon.Text.Trim());
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@tc", txtTc.Text.Trim());

                        cmd.Parameters.AddWithValue("@id", musteriId);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Müşteri bilgileri güncellendi.");
                        btnTumunuGetir.PerformClick(); // Listeyi yenile
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {

            txtAd.Clear();
            txtSoyad.Clear();
            txtTelefon.Clear();
            txtEmail.Clear();
            txtTc.Clear();
        }
    }
}
