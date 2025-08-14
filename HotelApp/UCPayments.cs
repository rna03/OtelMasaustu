using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using iTextDocument = iTextSharp.text.Document;


namespace HotelApp
{
    public partial class UCPayments : UserControl
    {
        public UCPayments()
        {
            InitializeComponent();
            this.Load += UCPayments_Load;
            dgvOdemeler.SelectionChanged += dataGridView1_SelectionChanged;

        }

        private void UCPayments_Load(object sender, EventArgs e)
        {
            dgvOdemeler.EnableHeadersVisualStyles = false;
            dgvOdemeler.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 11, 97); // Koyu morumsu mavi
            dgvOdemeler.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;



            dgvOdemeler.DefaultCellStyle.SelectionBackColor = Color.FromArgb(33, 11, 97);  // Seçili arka plan rengi
            dgvOdemeler.DefaultCellStyle.SelectionForeColor = Color.White;                 // Seçili yazı rengi
            comboOdemeYontemi.Items.Clear();  // Önce temizle
            comboOdemeYontemi.Items.Add("Nakit");
            comboOdemeYontemi.Items.Add("Kredi Kartı");
            TumOdemeleriGetir();
        }

        private void TumOdemeleriGetir()
        {
            using (var conn = DbHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Id, ReservationId, OdemeTarihi, OdemeYontemi, Tutar FROM payments";

                    using (var da = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvOdemeler.DataSource = dt;
                        // Kullanıcıya gösterilmesini istemediğimiz kolonları gizle
                        if (dgvOdemeler.Columns.Contains("Id"))
                            dgvOdemeler.Columns["Id"].Visible = false;

                        if (dgvOdemeler.Columns.Contains("ReservationId"))
                            dgvOdemeler.Columns["ReservationId"].Visible = false;

                        // Başlıkları daha anlaşılır yap
                        dgvOdemeler.Columns["OdemeTarihi"].HeaderText = "Ödeme Tarihi";
                        dgvOdemeler.Columns["OdemeYontemi"].HeaderText = "Ödeme Yöntemi";
                        dgvOdemeler.Columns["Tutar"].HeaderText = "Tutar (₺)";
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

            if (dgvOdemeler.SelectedRows.Count > 0)
            {
                var row = dgvOdemeler.SelectedRows[0];
                txtTutar.Text = row.Cells["Tutar"].Value.ToString();
                comboOdemeYontemi.SelectedItem = row.Cells["OdemeYontemi"].Value.ToString();
            }
        }

      



        private void btnTumunuGetir_Click_1(object sender, EventArgs e)
        {

            TumOdemeleriGetir();
        }

        private void btnSil_Click_1(object sender, EventArgs e)
        {

            if (dgvOdemeler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silinecek bir kayıt seçin.");
                return;
            }


            var confirm = MessageBox.Show("Seçili kaydı silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes)
                return;

            int paymentId = Convert.ToInt32(dgvOdemeler.SelectedRows[0].Cells["Id"].Value);

            using (var conn = DbHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM payments WHERE Id = @id";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", paymentId);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Kayıt silindi.");
                        TumOdemeleriGetir();
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

            if (dgvOdemeler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen güncellenecek bir kayıt seçin.");
                return;
            }

            int paymentId = Convert.ToInt32(dgvOdemeler.SelectedRows[0].Cells["Id"].Value);
            decimal tutar;
            if (!decimal.TryParse(txtTutar.Text, out tutar))
            {
                MessageBox.Show("Geçerli bir tutar girin.");
                return;
            }

            string odemeYontemi = comboOdemeYontemi.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(odemeYontemi))
            {
                MessageBox.Show("Lütfen ödeme yöntemi seçin.");
                return;
            }

            using (var conn = DbHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"UPDATE payments 
                                     SET Tutar = @tutar, OdemeYontemi = @yontem 
                                     WHERE Id = @id";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@tutar", tutar);
                        cmd.Parameters.AddWithValue("@yontem", odemeYontemi);
                        cmd.Parameters.AddWithValue("@id", paymentId);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Kayıt güncellendi.");
                        TumOdemeleriGetir();
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
            saveFile.Title = "Ödemeleri PDF'ye Aktar";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream stream = new FileStream(saveFile.FileName, FileMode.Create))
                    {
                        iTextDocument pdfDoc = new iTextDocument(PageSize.A4);
                        PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();

                        PdfPTable table = new PdfPTable(dgvOdemeler.Columns.Count);

                        // Sütun başlıkları
                        foreach (DataGridViewColumn column in dgvOdemeler.Columns)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText))
                            {
                                BackgroundColor = new BaseColor(240, 240, 240)
                            };
                            table.AddCell(cell);
                        }

                        // Satırlar
                        foreach (DataGridViewRow row in dgvOdemeler.Rows)
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

                        MessageBox.Show("PDF başarıyla oluşturuldu.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("PDF oluşturulamadı: " + ex.Message);
                }
            }
        }
    }
}
