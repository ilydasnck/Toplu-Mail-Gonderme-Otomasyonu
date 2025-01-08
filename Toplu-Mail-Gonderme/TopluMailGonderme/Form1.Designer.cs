namespace TopluMailGonderme
{
    partial class Form2
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonSendSingle = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxSon = new System.Windows.Forms.TextBox();
            this.pictureBoxLoading = new System.Windows.Forms.PictureBox();
            this.textBoxBas = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBoxSSL = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPASSWORD = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxUSER = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPORT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSMTP = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBoxEmails = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTxt = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbGrup = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxHTMLBody = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAttachFile = new System.Windows.Forms.Button();
            this.textBoxAttachment = new System.Windows.Forms.TextBox();
            this.btnPdf = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoading)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // listBoxLog
            // 
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.ItemHeight = 16;
            this.listBoxLog.Location = new System.Drawing.Point(3, 30);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.Size = new System.Drawing.Size(532, 1028);
            this.listBoxLog.TabIndex = 29;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1924, 1055);
            this.panel4.TabIndex = 37;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnPdf);
            this.panel5.Controls.Add(this.listBoxLog);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1392, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(532, 1055);
            this.panel5.TabIndex = 40;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(3, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 20);
            this.label14.TabIndex = 38;
            this.label14.Text = "Log Kaydı";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.buttonSendSingle);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.textBoxSon);
            this.panel3.Controls.Add(this.pictureBoxLoading);
            this.panel3.Controls.Add(this.textBoxBas);
            this.panel3.Controls.Add(this.checkBox2);
            this.panel3.Controls.Add(this.checkBoxSSL);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.textBoxPASSWORD);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.textBoxUSER);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.textBoxPORT);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.textBoxSMTP);
            this.panel3.Controls.Add(this.buttonSend);
            this.panel3.Location = new System.Drawing.Point(563, 115);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 574);
            this.panel3.TabIndex = 39;
            // 
            // buttonSendSingle
            // 
            this.buttonSendSingle.Location = new System.Drawing.Point(241, 335);
            this.buttonSendSingle.Name = "buttonSendSingle";
            this.buttonSendSingle.Size = new System.Drawing.Size(120, 31);
            this.buttonSendSingle.TabIndex = 33;
            this.buttonSendSingle.Text = "Tekli Gönder";
            this.buttonSendSingle.UseVisualStyleBackColor = true;
            this.buttonSendSingle.Click += new System.EventHandler(this.buttonSendSingle_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(173, 252);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(188, 17);
            this.label11.TabIndex = 28;
            this.label11.Text = "saniye aralığında gönderilsin";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(81, 254);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 17);
            this.label10.TabIndex = 27;
            this.label10.Text = "-";
            // 
            // textBoxSon
            // 
            this.textBoxSon.Location = new System.Drawing.Point(107, 249);
            this.textBoxSon.Name = "textBoxSon";
            this.textBoxSon.Size = new System.Drawing.Size(50, 22);
            this.textBoxSon.TabIndex = 26;
            // 
            // pictureBoxLoading
            // 
            this.pictureBoxLoading.Image = global::TopluMailGonderme.Properties.Resources.lg_dual_ring_loader;
            this.pictureBoxLoading.Location = new System.Drawing.Point(142, 387);
            this.pictureBoxLoading.Name = "pictureBoxLoading";
            this.pictureBoxLoading.Size = new System.Drawing.Size(180, 125);
            this.pictureBoxLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLoading.TabIndex = 18;
            this.pictureBoxLoading.TabStop = false;
            this.pictureBoxLoading.Visible = false;
            // 
            // textBoxBas
            // 
            this.textBoxBas.Location = new System.Drawing.Point(25, 249);
            this.textBoxBas.Name = "textBoxBas";
            this.textBoxBas.Size = new System.Drawing.Size(50, 22);
            this.textBoxBas.TabIndex = 25;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(25, 295);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(224, 21);
            this.checkBox2.TabIndex = 17;
            this.checkBox2.Text = "Kimlik Doğrulaması Gerekli mi?";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBoxSSL
            // 
            this.checkBoxSSL.AutoSize = true;
            this.checkBoxSSL.Location = new System.Drawing.Point(390, 63);
            this.checkBoxSSL.Name = "checkBoxSSL";
            this.checkBoxSSL.Size = new System.Drawing.Size(56, 21);
            this.checkBoxSSL.TabIndex = 16;
            this.checkBoxSSL.Text = "SSL";
            this.checkBoxSSL.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Password:";
            // 
            // textBoxPASSWORD
            // 
            this.textBoxPASSWORD.Location = new System.Drawing.Point(142, 203);
            this.textBoxPASSWORD.Name = "textBoxPASSWORD";
            this.textBoxPASSWORD.Size = new System.Drawing.Size(230, 22);
            this.textBoxPASSWORD.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Gönderici Maili:";
            // 
            // textBoxUSER
            // 
            this.textBoxUSER.Location = new System.Drawing.Point(142, 154);
            this.textBoxUSER.Name = "textBoxUSER";
            this.textBoxUSER.Size = new System.Drawing.Size(230, 22);
            this.textBoxUSER.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Port:";
            // 
            // textBoxPORT
            // 
            this.textBoxPORT.Location = new System.Drawing.Point(142, 107);
            this.textBoxPORT.Name = "textBoxPORT";
            this.textBoxPORT.Size = new System.Drawing.Size(230, 22);
            this.textBoxPORT.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sunucu IP\'si/Adı:";
            // 
            // textBoxSMTP
            // 
            this.textBoxSMTP.Location = new System.Drawing.Point(142, 58);
            this.textBoxSMTP.Name = "textBoxSMTP";
            this.textBoxSMTP.Size = new System.Drawing.Size(230, 22);
            this.textBoxSMTP.TabIndex = 8;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(124, 335);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(86, 31);
            this.buttonSend.TabIndex = 2;
            this.buttonSend.Text = "Toplu Gönder";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.listBoxEmails);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.buttonTxt);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.cmbGrup);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtMail);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(1076, 115);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 574);
            this.panel2.TabIndex = 38;
            // 
            // listBoxEmails
            // 
            this.listBoxEmails.FormattingEnabled = true;
            this.listBoxEmails.ItemHeight = 16;
            this.listBoxEmails.Location = new System.Drawing.Point(22, 173);
            this.listBoxEmails.Name = "listBoxEmails";
            this.listBoxEmails.Size = new System.Drawing.Size(353, 244);
            this.listBoxEmails.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Emails";
            // 
            // buttonTxt
            // 
            this.buttonTxt.Location = new System.Drawing.Point(87, 125);
            this.buttonTxt.Name = "buttonTxt";
            this.buttonTxt.Size = new System.Drawing.Size(128, 37);
            this.buttonTxt.TabIndex = 3;
            this.buttonTxt.Text = "Txt dosyası seç";
            this.buttonTxt.UseVisualStyleBackColor = true;
            this.buttonTxt.Click += new System.EventHandler(this.buttonTxt_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 437);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 17);
            this.label13.TabIndex = 32;
            this.label13.Text = "Ya da";
            // 
            // cmbGrup
            // 
            this.cmbGrup.FormattingEnabled = true;
            this.cmbGrup.Items.AddRange(new object[] {
            "Öğrenci",
            "Öğretim Görevlisi",
            "Admin"});
            this.cmbGrup.Location = new System.Drawing.Point(22, 49);
            this.cmbGrup.Name = "cmbGrup";
            this.cmbGrup.Size = new System.Drawing.Size(164, 24);
            this.cmbGrup.TabIndex = 20;
            this.cmbGrup.SelectedIndexChanged += new System.EventHandler(this.cmbGrup_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 468);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 17);
            this.label12.TabIndex = 31;
            this.label12.Text = "Tek bir mail girin";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Veritabanından grup seç:";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(22, 501);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(262, 22);
            this.txtMail.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Ya da";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBoxHTMLBody);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxSubject);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.buttonAttachFile);
            this.panel1.Controls.Add(this.textBoxAttachment);
            this.panel1.Location = new System.Drawing.Point(60, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 574);
            this.panel1.TabIndex = 37;
            // 
            // textBoxHTMLBody
            // 
            this.textBoxHTMLBody.Location = new System.Drawing.Point(10, 155);
            this.textBoxHTMLBody.Multiline = true;
            this.textBoxHTMLBody.Name = "textBoxHTMLBody";
            this.textBoxHTMLBody.Size = new System.Drawing.Size(377, 372);
            this.textBoxHTMLBody.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Email gövdesi";
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Location = new System.Drawing.Point(136, 40);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(230, 22);
            this.textBoxSubject.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(13, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Başlık";
            // 
            // buttonAttachFile
            // 
            this.buttonAttachFile.Location = new System.Drawing.Point(10, 80);
            this.buttonAttachFile.Name = "buttonAttachFile";
            this.buttonAttachFile.Size = new System.Drawing.Size(105, 23);
            this.buttonAttachFile.TabIndex = 23;
            this.buttonAttachFile.Text = "Dosya seç";
            this.buttonAttachFile.UseVisualStyleBackColor = true;
            this.buttonAttachFile.Click += new System.EventHandler(this.buttonAttachFile_Click);
            // 
            // textBoxAttachment
            // 
            this.textBoxAttachment.Location = new System.Drawing.Point(134, 81);
            this.textBoxAttachment.Name = "textBoxAttachment";
            this.textBoxAttachment.Size = new System.Drawing.Size(230, 22);
            this.textBoxAttachment.TabIndex = 24;
            // 
            // btnPdf
            // 
            this.btnPdf.Location = new System.Drawing.Point(112, 3);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(104, 23);
            this.btnPdf.TabIndex = 39;
            this.btnPdf.Text = "Pdf Oluştur";
            this.btnPdf.UseVisualStyleBackColor = true;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.panel4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Toplu Mail Gönderme";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoading)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox listBoxLog;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonSendSingle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxSon;
        private System.Windows.Forms.PictureBox pictureBoxLoading;
        private System.Windows.Forms.TextBox textBoxBas;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBoxSSL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPASSWORD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxUSER;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPORT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSMTP;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listBoxEmails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTxt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbGrup;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxHTMLBody;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAttachFile;
        private System.Windows.Forms.TextBox textBoxAttachment;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnPdf;
    }
}

