using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using iTextDocument = iTextSharp.text.Document;
using PdfFont = iTextSharp.text.Font;


namespace HotelApp
{
    public partial class UCPersonel : UserControl
    {
        public UCPersonel()
        {
            InitializeComponent();
            this.Load += UCPersonel_Load;
            dgvPersoneller.SelectionChanged += dataGridView1_SelectionChanged;
        }

        private void UCPersonel_Load(object sender, EventArgs e)
        {
            dgvPersoneller.EnableHeadersVisualStyles = false;
            dgvPersoneller.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 11, 97); // Koyu morumsu mavi
            dgvPersoneller.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;



            dgvPersoneller.DefaultCellStyle.SelectionBackColor = Color.FromArgb(33, 11, 97);  // Seçili arka plan rengi
            dgvPersoneller.DefaultCellStyle.SelectionForeColor = Color.White;                 // Seçili yazı rengi
            PersonelleriGetir();
        }
        private void PersonelleriGetir()
        {
            using (var conn = DbHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Id, Ad, Soyad, Email, Sifre, Rol, TcKimlikNo FROM users WHERE Rol = 'Personel'";

                    using (var da = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvPersoneller.DataSource = dt;
                        // Id kolonunu gizle (kullanıcıya gösterme)
                        if (dgvPersoneller.Columns.Contains("Id"))
                            dgvPersoneller.Columns["Id"].Visible = false;

                        // Kolon başlıklarını anlamlı yap
                        dgvPersoneller.Columns["Ad"].HeaderText = "Ad";
                        dgvPersoneller.Columns["Soyad"].HeaderText = "Soyad";
                        dgvPersoneller.Columns["Email"].HeaderText = "E-posta";
                        dgvPersoneller.Columns["Sifre"].HeaderText = "Şifre";
                        dgvPersoneller.Columns["Rol"].HeaderText = "Rol";
                        dgvPersoneller.Columns["TcKimlikNo"].HeaderText = "TC Kimlik No";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPersoneller.SelectedRows.Count > 0)
            {
                var row = dgvPersoneller.SelectedRows[0];
                txtAd.Text = row.Cells["Ad"].Value.ToString();
                txtSoyad.Text = row.Cells["Soyad"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtSifre.Text = row.Cells["Sifre"].Value.ToString();
                txtTcKimlikNo.Text = row.Cells["TcKimlikNo"].Value.ToString();
            }
        }


        private void Temizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtEmail.Clear();
            txtSifre.Clear();
            txtTcKimlikNo.Clear();
        }






     
        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            using (var conn = DbHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"INSERT INTO users (Ad, Soyad, Email, Sifre, TcKimlikNo, Rol)
                 VALUES (@ad, @soyad, @email, @sifre, @tc, @rol)";


                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ad", txtAd.Text);
                        cmd.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@sifre", txtSifre.Text);
                        cmd.Parameters.AddWithValue("@tc", txtTcKimlikNo.Text);
                        cmd.Parameters.AddWithValue("@rol", "Personel");  // Otomatik rol ekleniyor

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Personel eklendi.");
                        PersonelleriGetir();
                        Temizle();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ekleme hatası: " + ex.Message);
                }
            }
        }

        private void btnGuncelle_Click_1(object sender, EventArgs e)
        {
            if (dgvPersoneller.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen güncellenecek bir personel seçin.");
                return;
            }

            int id = Convert.ToInt32(dgvPersoneller.SelectedRows[0].Cells["Id"].Value);

            using (var conn = DbHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"UPDATE users 
                                     SET Ad = @ad, Soyad = @soyad, Email = @email, Sifre = @sifre, TcKimlikNo = @tc
                                     WHERE Id = @id";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ad", txtAd.Text);
                        cmd.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@sifre", txtSifre.Text);
                        cmd.Parameters.AddWithValue("@tc", txtTcKimlikNo.Text);
                        cmd.Parameters.AddWithValue("@id", id);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Personel güncellendi.");
                        PersonelleriGetir();
                        Temizle();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Güncelleme hatası: " + ex.Message);
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvPersoneller.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silinecek bir personel seçin.");
                return;
            }

            var result = MessageBox.Show("Bu oda silinecek. Emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
                return;


            int id = Convert.ToInt32(dgvPersoneller.SelectedRows[0].Cells["Id"].Value);

            using (var conn = DbHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM users WHERE Id = @id";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Personel silindi.");
                        PersonelleriGetir();
                        Temizle();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Silme hatası: " + ex.Message);
                }
            }
        }

        private void btnTemizle_Click_1(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnPdfAktar_Click_1(object sender, EventArgs e)
        {
            if (dgvPersoneller.Rows.Count == 0)
            {
                MessageBox.Show("PDF'e aktarılacak personel listesi bulunamadı.");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Dosyası|*.pdf";
            saveFileDialog.Title = "Personel Listesini Kaydet";
            saveFileDialog.FileName = "PersonelListesi.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                    {
                        iTextDocument pdfDoc = new iTextDocument(PageSize.A4, 10f, 10f, 10f, 10f);
                        PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();

                        // Başlık
                        Paragraph title = new Paragraph(
                            "Personel Listesi",
                            new PdfFont(PdfFont.FontFamily.HELVETICA, 16f, PdfFont.BOLD)
                        );
                        title.Alignment = Element.ALIGN_CENTER;
                        title.SpacingAfter = 20f;
                        pdfDoc.Add(title);

                        // Tablo oluştur
                        PdfPTable table = new PdfPTable(dgvPersoneller.Columns.Count);
                        table.WidthPercentage = 100;

                        // Sütun başlıkları
                        foreach (DataGridViewColumn column in dgvPersoneller.Columns)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                            cell.BackgroundColor = new BaseColor(240, 240, 240);
                            table.AddCell(cell);
                        }

                        // Satırlar
                        foreach (DataGridViewRow row in dgvPersoneller.Rows)
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
                    }

                    MessageBox.Show("PDF dosyası başarıyla kaydedildi.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("PDF kaydetme hatası: " + ex.Message);
                }
            }
        }
    }
}
