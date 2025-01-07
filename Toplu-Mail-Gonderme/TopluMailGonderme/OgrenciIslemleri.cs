using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace TopluMailGonderme
{
    public partial class OgrenciIslemleri : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-0CQELNT\\SQLEXPRESS; initial catalog=toplumail; Integrated Security=TRUE");
        public OgrenciIslemleri()
        {
            InitializeComponent();
        }

        public void Listele()
        {
            string komut = "SELECT Id,Name,Surname,Mail,Department,Grade,Password FROM Ogrenci";
            SqlDataAdapter da = new SqlDataAdapter(komut, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            // TextBox'lardan alınan veriler
            string ad = txtAd.Text.Trim();
            string soyad = txtSoyad.Text.Trim();
            string mail = txtMail.Text.Trim();
            string sifre = txtSifre.Text.Trim();
            string bolum = txtBolum.Text.Trim();
            string sinif = txtSinif.Text.Trim();

            // Boş alan kontrolü
            if (string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(soyad) ||
                string.IsNullOrEmpty(mail) || string.IsNullOrEmpty(sifre) || string.IsNullOrEmpty(bolum) || string.IsNullOrEmpty(sinif))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // SQL Ekleme Komutu
                string komut = "INSERT INTO Ogrenci (Name, Surname, Mail, Department, Grade, Password) VALUES (@Ad, @Soyad, @Mail, @Bolum, @Sinif, @Sifre)";

                // SqlCommand nesnesi
                using (SqlCommand cmd = new SqlCommand(komut, conn))
                {
                    // Parametreleri ekle
                    cmd.Parameters.AddWithValue("@Ad", ad);
                    cmd.Parameters.AddWithValue("@Soyad", soyad);
                    cmd.Parameters.AddWithValue("@Mail", mail);
                    cmd.Parameters.AddWithValue("@Bolum", bolum);
                    cmd.Parameters.AddWithValue("@Sinif", sinif);
                    cmd.Parameters.AddWithValue("@Sifre", sifre);


                    // Bağlantıyı aç ve komutu çalıştır
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Kayıt başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // TextBox'ları temizle
                    txtAd.Clear();
                    txtSoyad.Clear();
                    txtMail.Clear();
                    txtSifre.Clear();
                    txtBolum.Clear();
                    txtSinif.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Bağlantıyı kapat
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            Listele();
        


    }

        private void OgrenciIslemleri_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnSeciliSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // Bir satırın seçili olduğunu kontrol et
            {
                // Seçili satırdan ID'yi al (örnek olarak ID sütunu)
                int selectedID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);

                // Silme sorgusu oluştur
                string komut = "DELETE FROM Ogrenci WHERE ID = @ID";

                using (SqlCommand cmd = new SqlCommand(komut, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", selectedID);

                    // Bağlantıyı aç ve sorguyu çalıştır
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Kayıt başarıyla silindi.");
                }

                // Güncellenmiş verileri listele
                Listele();
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir satır seçin.");
            }

        }

        private void btnIdSil_Click(object sender, EventArgs e)
        {
            // Seçili satırdan ID'yi al (örnek olarak ID sütunu)
            int selectedID = Convert.ToInt32(txtId.Text);

            // Silme sorgusu oluştur
            string komut = "DELETE FROM Ogrenci WHERE ID = @ID";

            using (SqlCommand cmd = new SqlCommand(komut, conn))
            {
                cmd.Parameters.AddWithValue("@ID", selectedID);

                // Bağlantıyı aç ve sorguyu çalıştır
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Kayıt başarıyla silindi.");
            }

            // Güncellenmiş verileri listele
            Listele();
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            // ID'nin girilmiş olduğunu kontrol et
            if (string.IsNullOrWhiteSpace(txtGuncelleId.Text))
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz kaydın ID'sini girin.");
                return;
            }

            // Güncellenecek alanları dinamik olarak oluştur
            List<string> updateFields = new List<string>();
            List<SqlParameter> parameters = new List<SqlParameter>();

            if (!string.IsNullOrWhiteSpace(txtGuncelleAd.Text))
            {
                updateFields.Add("Name = @Ad");
                parameters.Add(new SqlParameter("@Ad", txtGuncelleAd.Text));
            }

            if (!string.IsNullOrWhiteSpace(txtGuncelleSoyad.Text))
            {
                updateFields.Add("Surname = @Soyad");
                parameters.Add(new SqlParameter("@Soyad", txtGuncelleSoyad.Text));
            }

            if (!string.IsNullOrWhiteSpace(txtGuncelleMail.Text))
            {
                updateFields.Add("Mail = @Mail");
                parameters.Add(new SqlParameter("@Mail", txtGuncelleMail.Text));
            }

            if (!string.IsNullOrWhiteSpace(txtGuncelleSifre.Text))
            {
                updateFields.Add("Password = @Sifre");
                parameters.Add(new SqlParameter("@Sifre", txtGuncelleSifre.Text));
            }
            if (!string.IsNullOrWhiteSpace(txtGuncelleBolum.Text))
            {
                updateFields.Add("Department = @Bolum");
                parameters.Add(new SqlParameter("@Bolum", txtGuncelleBolum.Text));
            }

            if (!string.IsNullOrWhiteSpace(txtGuncelleSinif.Text))
            {
                updateFields.Add("Grade = @Sinif");
                parameters.Add(new SqlParameter("@Sifre", txtGuncelleSinif.Text));
            }

            // Eğer hiçbir alan dolu değilse uyarı göster
            if (updateFields.Count == 0)
            {
                MessageBox.Show("Lütfen en az bir alan doldurun.");
                return;
            }

            // Güncelleme sorgusunu oluştur
            string updateQuery = $"UPDATE Ogrenci SET {string.Join(", ", updateFields)} WHERE Id = @Id";
            parameters.Add(new SqlParameter("@Id", txtGuncelleId.Text));

            // Veritabanına bağlan ve sorguyu çalıştır
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-0CQELNT\\SQLEXPRESS; initial catalog=toplumail; Integrated Security=TRUE"))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        // Parametreleri ekle
                        cmd.Parameters.AddRange(parameters.ToArray());
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Kayıt başarıyla güncellendi.");
                        }
                        else
                        {
                            MessageBox.Show("Güncelleme sırasında bir hata oluştu veya belirtilen ID bulunamadı.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bir hata oluştu: {ex.Message}");
                }
                Listele();
            }
        
    }
    }
}