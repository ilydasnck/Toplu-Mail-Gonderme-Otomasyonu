using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TopluMailGonderme
{
    public partial class Ogrenci : Form
    {
        private string connectionString = "Data Source=DESKTOP-0CQELNT\\SQLEXPRESS; initial catalog=toplumail; Integrated Security=TRUE";

        public Ogrenci()
        {
            InitializeComponent();
        }


        private void LoadStudentInfo()
        {
            string mail = GirisYap.GirisYapanMail; // Giriş yapan kullanıcının mail adresi

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Ogrenci WHERE Mail = @Mail";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Mail", mail);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    textBoxAd.Text = reader["Name"].ToString();
                    textBoxSoyad.Text = reader["Surname"].ToString();
                    textBoxMail.Text = reader["Mail"].ToString();
                    // Şifreyi okumak istemiyorsanız şifre textbox'ını doldurmayabilirsiniz
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string ad = textBoxAd.Text;
            string soyad = textBoxSoyad.Text;
            string mail = textBoxMail.Text;
            string yeniSifre = textBoxSifre.Text; // Kullanıcıdan girilen yeni şifre
            string sifreTekrar = textBoxSifreTekrar.Text; // Şifre doğrulama

            if (string.IsNullOrWhiteSpace(yeniSifre) || yeniSifre != sifreTekrar)
            {
                MessageBox.Show("Şifreler uyumsuz veya boş bırakılamaz.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Ogrenci SET Name = @Ad, Surname = @Soyad, Password = @Sifre WHERE Mail = @Mail";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Ad", ad);
                cmd.Parameters.AddWithValue("@Soyad", soyad);
                cmd.Parameters.AddWithValue("@Mail", mail);
                cmd.Parameters.AddWithValue("@Sifre", yeniSifre);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Bilgiler başarıyla güncellendi.");
                    this.Close(); // Formu kapat
                }
                else
                {
                    MessageBox.Show("Bir hata oluştu, lütfen tekrar deneyin.");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); // Formu kapat
        }

        private void Ogrenci_Load_1(object sender, EventArgs e)
        {
            LoadStudentInfo();

        }
    }
}
