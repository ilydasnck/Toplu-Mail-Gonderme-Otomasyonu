using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TopluMailGonderme
{
    public partial class Form2 : Form
    {
        private string connectionString = "Data Source=DESKTOP-0CQELNT\\SQLEXPRESS; initial catalog=toplumail; Integrated Security=TRUE";
        private List<string> attachments = new List<string>();

        public Form2()
        {
            InitializeComponent();
            LoadTableNamesIntoComboBox();
        }
        private void LoadTableNamesIntoComboBox()
        {
            string query = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        cmbGrup.Items.Clear(); // ComboBox'u temizle
                        while (reader.Read())
                        {
                            cmbGrup.Items.Add(reader["TABLE_NAME"].ToString()); // Tablo isimlerini ekle
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tablo isimleri yüklenirken hata oluştu: " + ex.Message);
            }
        }

        // Txt dosyasındaki mailleri çekme
        private void buttonTxt_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Multiselect = false;

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader file = new StreamReader(openFile.FileName))
                    {
                        string line;
                        while ((line = file.ReadLine()) != null)
                        {
                            listBoxEmails.Items.Add(line);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dosya okuma hatası: " + ex.Message);
            }
        }

        private void cmbGrup_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxEmails.Items.Clear();
            string selectedGroup = cmbGrup.SelectedItem.ToString();

            try
            {
                string checkMailColumnQuery = $@"
            SELECT COLUMN_NAME 
            FROM INFORMATION_SCHEMA.COLUMNS 
            WHERE TABLE_NAME = '{selectedGroup}' AND COLUMN_NAME = 'Mail'";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(checkMailColumnQuery, connection))
                    {
                        object result = command.ExecuteScalar();
                        if (result != null) // Mail sütunu var mı kontrol edilir
                        {
                            string query = $"SELECT Mail FROM {selectedGroup}";

                            using (SqlCommand mailCommand = new SqlCommand(query, connection))
                            using (SqlDataReader reader = mailCommand.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    listBoxEmails.Items.Add(reader["Mail"].ToString());
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Seçilen tablodaki 'Mail' sütunu bulunamadı. Lütfen geçerli bir tablo seçin.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı hatası: " + ex.Message);
            }
        }



        private void buttonSend_Click(object sender, EventArgs e)
        {
            buttonSend.Enabled = false;
            pictureBoxLoading.Visible = true;
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                CheckForIllegalCrossThreadCalls = false;
                using (var client = new SmtpClient())
                {
                    client.Timeout = 30000;
                    client.AuthenticationMechanisms.Remove("XOAUTH2");
                    client.Connect(textBoxSMTP.Text, int.Parse(textBoxPORT.Text), checkBoxSSL.Checked);
                    client.Authenticate(textBoxUSER.Text, textBoxPASSWORD.Text);

                    BodyBuilder builder = new BodyBuilder
                    {
                        HtmlBody = textBoxHTMLBody.Text
                    };

                    foreach (string filePath in attachments)
                    {
                        builder.Attachments.Add(filePath);
                    }

                    MimeMessage mail = new MimeMessage();
                    mail.From.Add(new MailboxAddress("Toplu Mail Otomasyonu", textBoxUSER.Text));
                    mail.Subject = textBoxSubject.Text;
                    mail.Body = builder.ToMessageBody();

                    int baslangicSaniye = int.Parse(textBoxBas.Text);
                    int bitisSaniye = int.Parse(textBoxSon.Text);

                    if (baslangicSaniye > bitisSaniye || baslangicSaniye < 0 || bitisSaniye < 0)
                    {
                        MessageBox.Show("Geçerli bir aralık giriniz!");
                        return;
                    }

                    Random random = new Random();
                    foreach (string email in listBoxEmails.Items)
                    {
                        try
                        {
                            mail.Bcc.Clear();
                            mail.Bcc.Add(new MailboxAddress(null, email));
                            client.Send(mail);

                            string logEntry = $"{email} adresine başarıyla gönderildi - {DateTime.Now:yyyy-MM-dd HH:mm:ss}";
                            AddLog(logEntry);

                            int beklemeSuresi = random.Next(baslangicSaniye, bitisSaniye + 1);
                            Thread.Sleep(beklemeSuresi * 1000);
                        }
                        catch (Exception ex)
                        {
                            string logEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {email} adresine gönderim HATA: {ex.Message}";
                            AddLog(logEntry);
                        }
                    }

                    client.Disconnect(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mail gönderim hatası: " + ex.Message);
            }
        }

        private void AddLog(string logEntry)
        {
            if (listBoxLog.InvokeRequired)
            {
                listBoxLog.Invoke(new Action(() => listBoxLog.Items.Add(logEntry)));
            }
            else
            {
                listBoxLog.Items.Add(logEntry);
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            buttonSend.Enabled = true;
            pictureBoxLoading.Visible = false;
            AddLog("Mail gönderim işlemi tamamlandı.");
        }

        private void buttonAttachFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Multiselect = true,
                    Filter = "Tüm Dosyalar|*.*"
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    attachments.AddRange(openFileDialog.FileNames);
                    textBoxAttachment.Text = string.Join(", ", attachments);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dosya ekleme hatası: " + ex.Message);
            }
        }
        private void buttonSendSingle_Click(object sender, EventArgs e)
        {
            try
            {
                string emailToSend = txtMail.Text;

                if (string.IsNullOrEmpty(emailToSend))
                {
                    MessageBox.Show("Lütfen geçerli bir e-posta adresi girin.");
                    return;
                }

                buttonSendSingle.Enabled = false;
                pictureBoxLoading.Visible = true;

                using (var client = new SmtpClient())
                {
                    client.Timeout = 30000;
                    client.AuthenticationMechanisms.Remove("XOAUTH2");
                    client.Connect(textBoxSMTP.Text, int.Parse(textBoxPORT.Text), checkBoxSSL.Checked);
                    client.Authenticate(textBoxUSER.Text, textBoxPASSWORD.Text);

                    BodyBuilder builder = new BodyBuilder
                    {
                        HtmlBody = textBoxHTMLBody.Text
                    };

                    foreach (string filePath in attachments)
                    {
                        builder.Attachments.Add(filePath);
                    }

                    MimeMessage mail = new MimeMessage();
                    mail.From.Add(new MailboxAddress("Toplu Mail Otomasyonu", textBoxUSER.Text));
                    mail.To.Add(new MailboxAddress(null, emailToSend));
                    mail.Subject = textBoxSubject.Text;
                    mail.Body = builder.ToMessageBody();

                    client.Send(mail);

                    string logEntry = $"{emailToSend} adresine başarıyla gönderildi - {DateTime.Now:yyyy-MM-dd HH:mm:ss}";
                    AddLog(logEntry);

                    client.Disconnect(true);
                }

                pictureBoxLoading.Visible = false;
                buttonSendSingle.Enabled = true;
                AddLog("Tekli mail gönderim işlemi tamamlandı.");
            }
            catch (Exception ex)
            {
                pictureBoxLoading.Visible = false;
                buttonSendSingle.Enabled = true;
                MessageBox.Show("Mail gönderim hatası: " + ex.Message);
            }
        }

        
    }
}
