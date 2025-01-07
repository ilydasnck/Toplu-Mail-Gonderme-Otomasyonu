using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TopluMailGonderme
{
    public partial class GrupOlustur : Form
    {
        // SQL Server bağlantı dizesi
        private string connectionString = "Data Source=DESKTOP-0CQELNT\\SQLEXPRESS; initial catalog=toplumail; Integrated Security=TRUE";

        public GrupOlustur()
        {
            InitializeComponent();
        }

     

        private void LoadDataGrid()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Id, Name, Surname, Mail, Password, AuthorizationLevel FROM Login"; // Örnek tablo adı: Ogrenci
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }

        private void btnCreateTable_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTableName.Text))
            {
                MessageBox.Show("Lütfen yeni tablo adı girin.");
                return;
            }

            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir veya daha fazla satır seçin.");
                return;
            }

            string newTableName = txtTableName.Text.Trim();

            // Yeni tablo oluşturma sorgusu
            string createTableQuery = $@"
                CREATE TABLE {newTableName} (
                    Id INT PRIMARY KEY,
                    Name NVARCHAR(50),
                    Surname NVARCHAR(50),
                    Mail NVARCHAR(100),
                    Password NVARCHAR(50),
                    AuthorizationLevel NVARCHAR(50),

                )";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Yeni tablo oluştur
                    SqlCommand createCommand = new SqlCommand(createTableQuery, connection);
                    createCommand.ExecuteNonQuery();

                    // Seçili satırların verilerini ekle
                    foreach (DataGridViewRow selectedRow in dataGridView1.SelectedRows)
                    {
                        if (selectedRow.Cells["ID"].Value != null)
                        {
                            int id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                            string ad = selectedRow.Cells["Name"].Value.ToString();
                            string soyad = selectedRow.Cells["Surname"].Value.ToString();
                            string email = selectedRow.Cells["Mail"].Value.ToString();
                            string password = selectedRow.Cells["Password"].Value.ToString();
                            string authorizationLevel = selectedRow.Cells["AuthorizationLevel"].Value.ToString();

                            string insertDataQuery = $@"
                                INSERT INTO {newTableName} (ID, Name, Surname, Mail, Password, AuthorizationLevel)
                                VALUES (@Id, @Name, @Surname, @Mail, @Password, @AuthorizationLevel)";

                            SqlCommand insertCommand = new SqlCommand(insertDataQuery, connection);
                            insertCommand.Parameters.AddWithValue("@Id", id);
                            insertCommand.Parameters.AddWithValue("@Name", ad);
                            insertCommand.Parameters.AddWithValue("@Surname", soyad);
                            insertCommand.Parameters.AddWithValue("@Mail", email);
                            insertCommand.Parameters.AddWithValue("@Password", password);
                            insertCommand.Parameters.AddWithValue("@AuthorizationLevel", authorizationLevel);
                            insertCommand.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show($"Tablo '{newTableName}' başarıyla oluşturuldu ve seçili satırların verileri eklendi.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void GrupOlustur_Load(object sender, EventArgs e)
        {
            // DataGridView'i doldur
            LoadDataGrid();
            // Çoklu seçim etkinleştir
            dataGridView1.MultiSelect = true;

        }

        
    }
}
