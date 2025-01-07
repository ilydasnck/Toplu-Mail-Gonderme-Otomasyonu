using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TopluMailGonderme
{
    public partial class KayitOl : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-0CQELNT\\SQLEXPRESS; initial catalog=toplumail; Integrated Security=TRUE");

        public KayitOl()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string firstName = textBox1.Text.Trim(); // Ad
            string lastName = textBox2.Text.Trim(); // Soyad
            string mail = textBox3.Text.Trim(); // Mail
            string password = textBox4.Text.Trim(); // Şifre
            string confirmPassword = textBox5.Text.Trim(); // Şifre Doğrulama

            // Basit doğrulama kontrolleri
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(mail) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Tüm alanları doldurmanız gerekmektedir.");
                return;
            }

            if (!mail.Contains("@") || !mail.Contains("."))
            {
                MessageBox.Show("Geçerli bir e-posta adresi giriniz.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Şifreler eşleşmiyor.");
                return;
            }

            try
            {
                conn.Open();

                // E-posta adresinin zaten kayıtlı olup olmadığını kontrol et
                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Login WHERE Mail = @mail", conn);
                checkCmd.Parameters.AddWithValue("@mail", mail);
                int userCount = (int)checkCmd.ExecuteScalar();

                if (userCount > 0)
                {
                    MessageBox.Show("Bu e-posta adresi zaten kayıtlı.");
                }
                else
                {
                    // Kullanıcıyı veritabanına ekle
                    SqlCommand cmd = new SqlCommand("INSERT INTO Login (Name, Surname, Mail, Password) VALUES (@firstName, @lastName, @mail, @password)", conn);
                    cmd.Parameters.AddWithValue("@firstName", firstName);
                    cmd.Parameters.AddWithValue("@lastName", lastName);
                    cmd.Parameters.AddWithValue("@mail", mail);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Kayıt başarılı!");
                    GirisYap giris = new GirisYap();
                    await Task.Delay(1000);
                    giris.Show();
                    this.Hide();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GirisYap girisYap = new GirisYap();

            // Yeni formu göster
            girisYap.Show();

            // Mevcut formu kapat
            this.Hide();
        }
    }
}
