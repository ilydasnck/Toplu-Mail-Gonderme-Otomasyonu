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
    public partial class Yetkilendirme : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-0CQELNT\\SQLEXPRESS; initial catalog=toplumail; Integrated Security=TRUE");
        public Yetkilendirme()
        {
            InitializeComponent();
        }

        public void Listele()
        {
            string komut = "SELECT Id,Name,Surname,AuthorizationLevel FROM Login";
            SqlDataAdapter da = new SqlDataAdapter(komut, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Yetkilendirme_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnYetkiVer_Click(object sender, EventArgs e)
        {
            string id = txtId.Text.Trim(); // Kullanıcıdan ID değerini alıyoruz
            string yetki;

            // ID ve yetki kontrolü
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Lütfen ID alanını doldurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // İşlemi sonlandır
            }

            if (cmbYetki.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir yetki seçin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // İşlemi sonlandır
            }

            yetki = cmbYetki.SelectedItem.ToString(); // Yetkiyi alıyoruz

            // Eğer kontrollerden geçerse, burada işlem yapılabilir
            MessageBox.Show($"ID: {id}\nYetki: {yetki}", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);



            // Veritabanına yetkilendirme işlemi
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-0CQELNT\\SQLEXPRESS; initial catalog=toplumail; Integrated Security=TRUE"))
                {
                    connection.Open();

                    string query = "UPDATE Login SET AuthorizationLevel = @Yetki WHERE Id = @Id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);
                        command.Parameters.AddWithValue("@Yetki", yetki);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Yetkilendirme başarıyla tamamlandı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Belirtilen ID ile eşleşen kayıt bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

    }
}
