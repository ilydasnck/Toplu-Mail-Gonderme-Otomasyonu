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
    public partial class BolumIslemleri : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-0CQELNT\\SQLEXPRESS; initial catalog=toplumail; Integrated Security=TRUE");
        public BolumIslemleri()
        {
            InitializeComponent();
        }
        public void Listele()
        {
            string komut = "SELECT Id,Department,Faculty,ProgramType FROM Departments";
            SqlDataAdapter da = new SqlDataAdapter(komut, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }


        private void btnEkle_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan bilgileri al
            string department = txtBolum.Text.Trim();   // Bölüm bilgisi
            string faculty = txtFakulte.Text.Trim();   // Fakülte bilgisi
            string degreeLevel = cmbTur.SelectedItem?.ToString(); // ComboBox'tan seçilen tür

            // Boş alan kontrolü
            if (string.IsNullOrEmpty(department) || string.IsNullOrEmpty(faculty) || string.IsNullOrEmpty(degreeLevel))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Veritabanına ekleme işlemi
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-0CQELNT\\SQLEXPRESS; initial catalog=toplumail; Integrated Security=TRUE"))
                {
                    connection.Open();

                    // SQL INSERT sorgusu
                    string query = "INSERT INTO Departments (Department, Faculty, ProgramType) VALUES (@Department, @Faculty, @DegreeLevel)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parametreleri ekle
                        command.Parameters.AddWithValue("@Department", department);
                        command.Parameters.AddWithValue("@Faculty", faculty);
                        command.Parameters.AddWithValue("@DegreeLevel", degreeLevel);

                        // Sorguyu çalıştır
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Kayıt başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Alanları temizle
                            txtBolum.Clear();
                            txtFakulte.Clear();
                            cmbTur.SelectedIndex = -1;
                        }
                        else
                        {
                            MessageBox.Show("Kayıt eklenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Listele();
        }

        private void BolumIslemleri_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void seciliSatirSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // Bir satırın seçili olduğunu kontrol et
            {
                // Seçili satırdan ID'yi al (örnek olarak ID sütunu)
                int selectedID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                // Silme sorgusu oluştur
                string komut = "DELETE FROM Departments WHERE Id = @ID";

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
            string komut = "DELETE FROM Departments WHERE ID = @ID";

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

        //Güncelleme butonu

        private void button1_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan Id'yi al
            string id = txtIdGuncelle.Text.Trim();
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Lütfen güncellenecek kaydın ID'sini girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kullanıcıdan diğer bilgileri al
            string department = txtBolumGuncelle.Text.Trim();
            string faculty = txtFakulteGuncelle.Text.Trim();
            string degreeLevel = cmbTurGuncelle.SelectedItem?.ToString();

            // Diğer alanların en az birinin doldurulmasını kontrol et
            if (string.IsNullOrEmpty(department) && string.IsNullOrEmpty(faculty) && string.IsNullOrEmpty(degreeLevel))
            {
                MessageBox.Show("Lütfen ID dışında en az bir alanı doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-0CQELNT\\SQLEXPRESS; initial catalog=toplumail; Integrated Security=TRUE"))
                {
                    connection.Open();

                    // Mevcut kaydı almak için SELECT sorgusu
                    string selectQuery = "SELECT Department, Faculty, ProgramType FROM Departments WHERE Id = @Id";
                    SqlCommand selectCommand = new SqlCommand(selectQuery, connection);
                    selectCommand.Parameters.AddWithValue("@Id", id);

                    SqlDataReader reader = selectCommand.ExecuteReader();
                    if (reader.Read())
                    {
                        // Mevcut değerleri oku
                        string currentDepartment = reader["Department"].ToString();
                        string currentFaculty = reader["Faculty"].ToString();
                        string currentDegreeLevel = reader["ProgramType"].ToString();
                        reader.Close();

                        // Güncelleme için yeni değerleri belirle
                        string newDepartment = string.IsNullOrEmpty(department) ? currentDepartment : department;
                        string newFaculty = string.IsNullOrEmpty(faculty) ? currentFaculty : faculty;
                        string newDegreeLevel = string.IsNullOrEmpty(degreeLevel) ? currentDegreeLevel : degreeLevel;

                        // Güncelleme sorgusu
                        string updateQuery = "UPDATE Departments SET Department = @Department, Faculty = @Faculty, ProgramType = @DegreeLevel WHERE Id = @Id";
                        SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                        updateCommand.Parameters.AddWithValue("@Department", newDepartment);
                        updateCommand.Parameters.AddWithValue("@Faculty", newFaculty);
                        updateCommand.Parameters.AddWithValue("@DegreeLevel", newDegreeLevel);
                        updateCommand.Parameters.AddWithValue("@Id", id);

                        // Sorguyu çalıştır
                        int rowsAffected = updateCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Kayıt başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Alanları temizle
                            txtIdGuncelle.Clear();
                            txtBolumGuncelle.Clear();
                            txtFakulteGuncelle.Clear();
                            cmbTurGuncelle.SelectedIndex = -1;

                            // Güncel verileri listele
                            Listele();
                        }
                        else
                        {
                            MessageBox.Show("Kayıt güncellenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        reader.Close();
                        MessageBox.Show("Belirtilen ID'ye sahip bir kayıt bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
