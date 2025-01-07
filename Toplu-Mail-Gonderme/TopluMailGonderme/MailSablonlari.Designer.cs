namespace TopluMailGonderme
{
    partial class MailSablonlari
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
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtIcerik = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBaslik = new System.Windows.Forms.TextBox();
            this.baslik = new System.Windows.Forms.Label();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtGuncelleIsim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtGuncelleIcerik = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGuncelleBaslik = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGuncelleId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
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
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(266, 450);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.txtIsim);
            this.xtraTabPage1.Controls.Add(this.label1);
            this.xtraTabPage1.Controls.Add(this.btnEkle);
            this.xtraTabPage1.Controls.Add(this.txtIcerik);
            this.xtraTabPage1.Controls.Add(this.label4);
            this.xtraTabPage1.Controls.Add(this.txtBaslik);
            this.xtraTabPage1.Controls.Add(this.baslik);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(232, 443);
            this.xtraTabPage1.Text = "Ekle";
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(129, 29);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(100, 23);
            this.txtIsim.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 46;
            this.label1.Text = "İsim:";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(46, 393);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(183, 23);
            this.btnEkle.TabIndex = 45;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtIcerik
            // 
            this.txtIcerik.Location = new System.Drawing.Point(46, 140);
            this.txtIcerik.Multiline = true;
            this.txtIcerik.Name = "txtIcerik";
            this.txtIcerik.Size = new System.Drawing.Size(183, 219);
            this.txtIcerik.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 43;
            this.label4.Text = "İçerik:";
            // 
            // txtBaslik
            // 
            this.txtBaslik.Location = new System.Drawing.Point(129, 58);
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.Size = new System.Drawing.Size(100, 23);
            this.txtBaslik.TabIndex = 42;
            // 
            // baslik
            // 
            this.baslik.AutoSize = true;
            this.baslik.Location = new System.Drawing.Point(43, 62);
            this.baslik.Name = "baslik";
            this.baslik.Size = new System.Drawing.Size(45, 17);
            this.baslik.TabIndex = 41;
            this.baslik.Text = "Başlık:";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.txtGuncelleId);
            this.xtraTabPage2.Controls.Add(this.label6);
            this.xtraTabPage2.Controls.Add(this.txtGuncelleIsim);
            this.xtraTabPage2.Controls.Add(this.label2);
            this.xtraTabPage2.Controls.Add(this.btnGuncelle);
            this.xtraTabPage2.Controls.Add(this.txtGuncelleIcerik);
            this.xtraTabPage2.Controls.Add(this.label3);
            this.xtraTabPage2.Controls.Add(this.txtGuncelleBaslik);
            this.xtraTabPage2.Controls.Add(this.label5);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(232, 443);
            this.xtraTabPage2.Text = "Güncelle";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(232, 443);
            this.xtraTabPage3.Text = "Sil";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(530, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtGuncelleIsim
            // 
            this.txtGuncelleIsim.Location = new System.Drawing.Point(109, 50);
            this.txtGuncelleIsim.Name = "txtGuncelleIsim";
            this.txtGuncelleIsim.Size = new System.Drawing.Size(100, 23);
            this.txtGuncelleIsim.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 53;
            this.label2.Text = "İsim:";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(26, 392);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(183, 23);
            this.btnGuncelle.TabIndex = 52;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtGuncelleIcerik
            // 
            this.txtGuncelleIcerik.Location = new System.Drawing.Point(26, 151);
            this.txtGuncelleIcerik.Multiline = true;
            this.txtGuncelleIcerik.Name = "txtGuncelleIcerik";
            this.txtGuncelleIcerik.Size = new System.Drawing.Size(183, 219);
            this.txtGuncelleIcerik.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 50;
            this.label3.Text = "İçerik:";
            // 
            // txtGuncelleBaslik
            // 
            this.txtGuncelleBaslik.Location = new System.Drawing.Point(109, 75);
            this.txtGuncelleBaslik.Name = "txtGuncelleBaslik";
            this.txtGuncelleBaslik.Size = new System.Drawing.Size(100, 23);
            this.txtGuncelleBaslik.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 48;
            this.label5.Text = "Başlık:";
            // 
            // txtGuncelleId
            // 
            this.txtGuncelleId.Location = new System.Drawing.Point(109, 18);
            this.txtGuncelleId.Name = "txtGuncelleId";
            this.txtGuncelleId.Size = new System.Drawing.Size(100, 23);
            this.txtGuncelleId.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 17);
            this.label6.TabIndex = 55;
            this.label6.Text = "Id:";
            // 
            // MailSablonlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MailSablonlari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MailSablonları";
            this.Load += new System.EventHandler(this.MailSablonForm_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtIcerik;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBaslik;
        private System.Windows.Forms.Label baslik;
        private System.Windows.Forms.TextBox txtGuncelleIsim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtGuncelleIcerik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGuncelleBaslik;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGuncelleId;
        private System.Windows.Forms.Label label6;
    }
}