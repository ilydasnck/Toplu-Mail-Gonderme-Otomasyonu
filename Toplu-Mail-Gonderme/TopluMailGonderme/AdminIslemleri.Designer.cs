namespace TopluMailGonderme
{
    partial class AdminIslemleri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.btnIdSil = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSeciliSil = new System.Windows.Forms.Button();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.guncelle = new System.Windows.Forms.Button();
            this.txtGuncelleSifre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGuncelleMail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGuncelleId = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtGuncelleSoyad = new System.Windows.Forms.TextBox();
            this.txtGuncelleAd = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.xtraTabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(1129, 706);
            this.splitContainer1.SplitterDistance = 376;
            this.splitContainer1.TabIndex = 0;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(376, 706);
            this.xtraTabControl1.TabIndex = 2;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.btnEkle);
            this.xtraTabPage1.Controls.Add(this.txtSifre);
            this.xtraTabPage1.Controls.Add(this.label4);
            this.xtraTabPage1.Controls.Add(this.txtMail);
            this.xtraTabPage1.Controls.Add(this.label3);
            this.xtraTabPage1.Controls.Add(this.txtSoyad);
            this.xtraTabPage1.Controls.Add(this.txtAd);
            this.xtraTabPage1.Controls.Add(this.label2);
            this.xtraTabPage1.Controls.Add(this.label1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(342, 699);
            this.xtraTabPage1.Text = "Ekle";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(62, 285);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(183, 23);
            this.btnEkle.TabIndex = 40;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(145, 215);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(100, 23);
            this.txtSifre.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "Şifre:";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(145, 173);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(100, 23);
            this.txtMail.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Mail:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(145, 130);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 23);
            this.txtSoyad.TabIndex = 35;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(145, 86);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 23);
            this.txtAd.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Ad:";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.btnIdSil);
            this.xtraTabPage2.Controls.Add(this.txtId);
            this.xtraTabPage2.Controls.Add(this.label13);
            this.xtraTabPage2.Controls.Add(this.btnSeciliSil);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(342, 699);
            this.xtraTabPage2.Text = "Sil";
            // 
            // btnIdSil
            // 
            this.btnIdSil.Location = new System.Drawing.Point(72, 211);
            this.btnIdSil.Name = "btnIdSil";
            this.btnIdSil.Size = new System.Drawing.Size(175, 23);
            this.btnIdSil.TabIndex = 19;
            this.btnIdSil.Text = "Id numarasından sil";
            this.btnIdSil.UseVisualStyleBackColor = true;
            this.btnIdSil.Click += new System.EventHandler(this.btnIdSil_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(207, 91);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(59, 23);
            this.txtId.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(69, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 17);
            this.label13.TabIndex = 17;
            this.label13.Text = "Silmek için Id girin";
            // 
            // btnSeciliSil
            // 
            this.btnSeciliSil.Location = new System.Drawing.Point(72, 159);
            this.btnSeciliSil.Name = "btnSeciliSil";
            this.btnSeciliSil.Size = new System.Drawing.Size(175, 23);
            this.btnSeciliSil.TabIndex = 16;
            this.btnSeciliSil.Text = "Seçili satırı sil";
            this.btnSeciliSil.UseVisualStyleBackColor = true;
            this.btnSeciliSil.Click += new System.EventHandler(this.btnSeciliSil_Click);
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.guncelle);
            this.xtraTabPage3.Controls.Add(this.txtGuncelleSifre);
            this.xtraTabPage3.Controls.Add(this.label7);
            this.xtraTabPage3.Controls.Add(this.txtGuncelleMail);
            this.xtraTabPage3.Controls.Add(this.label9);
            this.xtraTabPage3.Controls.Add(this.txtGuncelleId);
            this.xtraTabPage3.Controls.Add(this.label14);
            this.xtraTabPage3.Controls.Add(this.txtGuncelleSoyad);
            this.xtraTabPage3.Controls.Add(this.txtGuncelleAd);
            this.xtraTabPage3.Controls.Add(this.label11);
            this.xtraTabPage3.Controls.Add(this.label12);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(342, 699);
            this.xtraTabPage3.Text = "Güncelle";
            // 
            // guncelle
            // 
            this.guncelle.Location = new System.Drawing.Point(82, 341);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(183, 23);
            this.guncelle.TabIndex = 65;
            this.guncelle.Text = "Güncelle";
            this.guncelle.UseVisualStyleBackColor = true;
            this.guncelle.Click += new System.EventHandler(this.guncelle_Click);
            // 
            // txtGuncelleSifre
            // 
            this.txtGuncelleSifre.Location = new System.Drawing.Point(162, 279);
            this.txtGuncelleSifre.Name = "txtGuncelleSifre";
            this.txtGuncelleSifre.Size = new System.Drawing.Size(100, 23);
            this.txtGuncelleSifre.TabIndex = 64;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 17);
            this.label7.TabIndex = 63;
            this.label7.Text = "Şifre:";
            // 
            // txtGuncelleMail
            // 
            this.txtGuncelleMail.Location = new System.Drawing.Point(162, 234);
            this.txtGuncelleMail.Name = "txtGuncelleMail";
            this.txtGuncelleMail.Size = new System.Drawing.Size(100, 23);
            this.txtGuncelleMail.TabIndex = 62;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(76, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 17);
            this.label9.TabIndex = 61;
            this.label9.Text = "Mail:";
            // 
            // txtGuncelleId
            // 
            this.txtGuncelleId.Location = new System.Drawing.Point(162, 105);
            this.txtGuncelleId.Name = "txtGuncelleId";
            this.txtGuncelleId.Size = new System.Drawing.Size(100, 23);
            this.txtGuncelleId.TabIndex = 60;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(76, 105);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 17);
            this.label14.TabIndex = 59;
            this.label14.Text = "Id:";
            // 
            // txtGuncelleSoyad
            // 
            this.txtGuncelleSoyad.Location = new System.Drawing.Point(162, 187);
            this.txtGuncelleSoyad.Name = "txtGuncelleSoyad";
            this.txtGuncelleSoyad.Size = new System.Drawing.Size(100, 23);
            this.txtGuncelleSoyad.TabIndex = 58;
            // 
            // txtGuncelleAd
            // 
            this.txtGuncelleAd.Location = new System.Drawing.Point(162, 143);
            this.txtGuncelleAd.Name = "txtGuncelleAd";
            this.txtGuncelleAd.Size = new System.Drawing.Size(100, 23);
            this.txtGuncelleAd.TabIndex = 57;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(76, 189);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 17);
            this.label11.TabIndex = 56;
            this.label11.Text = "Soyad:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(76, 143);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 17);
            this.label12.TabIndex = 55;
            this.label12.Text = "Ad:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(749, 706);
            this.dataGridView1.TabIndex = 0;
            // 
            // AdminIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 706);
            this.Controls.Add(this.splitContainer1);
            this.Name = "AdminIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin İşlemleri";
            this.Load += new System.EventHandler(this.AdminIslemleri_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            this.xtraTabPage3.ResumeLayout(false);
            this.xtraTabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnIdSil;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSeciliSil;
        private System.Windows.Forms.TextBox txtGuncelleId;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtGuncelleSoyad;
        private System.Windows.Forms.TextBox txtGuncelleAd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtGuncelleMail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtGuncelleSifre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button guncelle;
    }
}