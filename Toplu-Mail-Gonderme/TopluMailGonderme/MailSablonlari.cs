using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TopluMailGonderme
{
    public partial class MailSablonlari : Form
    {// Veritabanı bağlantısı
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-0CQELNT\\SQLEXPRESS; Initial Catalog=toplumail; Integrated Security=True");

        public MailSablonlari()
        {
            InitializeComponent();
        }

        // Şablonları listeleme metodu
        public void Listele()
        {
            try
            {
                string query = "SELECT Id, Name, Title, Description FROM MailSablonlari";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme sırasında hata oluştu: " + ex.Message);
            }
        }

        // Form yüklendiğinde mevcut şablonları listeleme
        private void MailSablonForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        // Şablon ekleme işlemi
        private void btnEkle_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan verileri al
            string name = txtIsim.Text.Trim();
            string title = txtBaslik.Text.Trim();
            string description = txtIcerik.Text.Trim();

            // Boş alan kontrolü
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(title) || string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Veritabanına ekleme işlemi
            try
            {
                string query = "INSERT INTO MailSablonlari (Title, Description,Name) VALUES (@Title, @Description, @Name)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Parametreleri ekle
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Title", title);
                    cmd.Parameters.AddWithValue("@Description", description);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Mail şablonu başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Alanları temizle
                    txtIsim.Clear();
                    txtBaslik.Clear();
                    txtIcerik.Clear();

                    // Şablonları güncelle
                    Listele();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ekleme sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            // Girilen verileri al
            string id = txtGuncelleId.Text.Trim();
            string name = txtGuncelleIsim.Text.Trim();
            string title = txtGuncelleBaslik.Text.Trim();
            string description = txtGuncelleIcerik.Text.Trim();

            // Id kontrolü
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Lütfen güncellenecek şablonun Id'sini giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // En az bir alanın dolu olması kontrolü
            if (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(title) && string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Id dışındaki alanlardan en az birini doldurmalısınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Önceki değerleri veritabanından çek
                string querySelect = "SELECT * FROM MailSablonlari WHERE Id = @Id";
                SqlCommand cmdSelect = new SqlCommand(querySelect, conn);
                cmdSelect.Parameters.AddWithValue("@Id", id);

                conn.Open();
                SqlDataReader reader = cmdSelect.ExecuteReader();
                if (reader.Read())
                {
                    // Mevcut değerleri al
                    string currentName = reader["Name"].ToString();
                    string currentTitle = reader["Title"].ToString();
                    string currentDescription = reader["Description"].ToString();
                    reader.Close();

                    // Girilen alanlar boşsa mevcut değerleri kullan
                    string newName = string.IsNullOrEmpty(name) ? currentName : name;
                    string newTitle = string.IsNullOrEmpty(title) ? currentTitle : title;
                    string newDescription = string.IsNullOrEmpty(description) ? currentDescription : description;

                    // Güncelleme sorgusu
                    string queryUpdate = "UPDATE MailSablonlari SET Name = @Name, Title = @Title, Description = @Description WHERE Id = @Id";
                    SqlCommand cmdUpdate = new SqlCommand(queryUpdate, conn);
                    cmdUpdate.Parameters.AddWithValue("@Name", newName);
                    cmdUpdate.Parameters.AddWithValue("@Title", newTitle);
                    cmdUpdate.Parameters.AddWithValue("@Description", newDescription);
                    cmdUpdate.Parameters.AddWithValue("@Id", id);

                    cmdUpdate.ExecuteNonQuery();
                    MessageBox.Show("Şablon başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Alanları temizle ve listeyi güncelle
                    txtGuncelleId.Clear();
                    txtGuncelleIsim.Clear();
                    txtGuncelleBaslik.Clear();
                    txtGuncelleIcerik.Clear();
                    Listele();
                }
                else
                {
                    MessageBox.Show("Girdiğiniz Id'ye sahip bir şablon bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void seciliSatirSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // Bir satırın seçili olduğunu kontrol et
            {
                // Seçili satırdan ID'yi al (örnek olarak ID sütunu)
                int selectedID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                // Silme sorgusu oluştur
                string komut = "DELETE FROM MailSablonlari WHERE Id = @ID";

                using (SqlCommand cmd = new SqlCommand(komut, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", selectedID);

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

        private void idSil_Click(object sender, EventArgs e)
        {
            // Seçili satırdan ID'yi al (örnek olarak ID sütunu)
            int selectedID = Convert.ToInt32(textBox5.Text);

            // Silme sorgusu oluştur
            string komut = "DELETE FROM MailSablonlari WHERE ID = @ID";

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

    }
}