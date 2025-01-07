using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TopluMailGonderme
{
    public partial class GirisYap : Form
    {
        public static string GirisYapanMail { get; set; }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-0CQELNT\\SQLEXPRESS; initial catalog=toplumail; Integrated Security=TRUE");
        public GirisYap()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string mail = textBox1.Text;
            string password = textBox2.Text;
            bool kayitli_mi = false;
            string yetkiSeviyesi = "";

            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Login WHERE Mail = @Mail AND Password = @Password", conn);
            cmd.Parameters.AddWithValue("@Mail", mail);
            cmd.Parameters.AddWithValue("@Password", password);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                kayitli_mi = true;
                GirisYapanMail = mail;
                yetkiSeviyesi = dr["AuthorizationLevel"].ToString(); // Yetki seviyesini alıyoruz.
            }

            conn.Close();

            if (kayitli_mi)
            {
                MessageBox.Show("Giriş başarılı");

                // Kullanıcı yetki seviyesine göre yönlendirme yap
                if (yetkiSeviyesi == "Öğrenci")
                {
                    Ogrenci ogrenciForm = new Ogrenci();
                    await Task.Delay(1000);
                    ogrenciForm.Show();
                    this.Hide();
                }
                else if (yetkiSeviyesi == "Admin")
                {

                    RibbonForm adminForm = new RibbonForm();
                    await Task.Delay(1000);
                    adminForm.Show();
                    this.Hide();
                }
                else if (yetkiSeviyesi == "Öğretim Görevlisi")
                {
                    OgretimGorevlisiPaneli ogretimGorevlisiPaneli = new OgretimGorevlisiPaneli();
                    await Task.Delay(1000);
                    ogretimGorevlisiPaneli.Show();
                    this.Hide();
                }
                else
                {
                    Bekleme bekleme = new Bekleme();
                    await Task.Delay(1000);
                    bekleme.Show();
                    this.Hide();

                }
            }
            else
            {
                MessageBox.Show("Giriş başarısız, tekrar deneyin");
            }
        }
    }
}
