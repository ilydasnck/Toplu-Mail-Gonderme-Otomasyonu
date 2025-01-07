namespace TopluMailGonderme
{
    partial class BolumIslemleri
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
            this.cmbTur = new System.Windows.Forms.ComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtFakulte = new System.Windows.Forms.TextBox();
            this.txtBolum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.idSil = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.seciliSatirSil = new System.Windows.Forms.Button();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.cmbTurGuncelle = new System.Windows.Forms.ComboBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtFakulteGuncelle = new System.Windows.Forms.TextBox();
            this.txtBolumGuncelle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtIdGuncelle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
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
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 361;
            this.splitContainer1.TabIndex = 0;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(361, 450);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.cmbTur);
            this.xtraTabPage1.Controls.Add(this.btnEkle);
            this.xtraTabPage1.Controls.Add(this.txtFakulte);
            this.xtraTabPage1.Controls.Add(this.txtBolum);
            this.xtraTabPage1.Controls.Add(this.label4);
            this.xtraTabPage1.Controls.Add(this.label3);
            this.xtraTabPage1.Controls.Add(this.label2);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(327, 443);
            this.xtraTabPage1.Text = "Ekle";
            // 
            // cmbTur
            // 
            this.cmbTur.FormattingEnabled = true;
            this.cmbTur.Items.AddRange(new object[] {
            "Önlisans",
            "Lisans",
            "Yükseklisans",
            "Doktora"});
            this.cmbTur.Location = new System.Drawing.Point(143, 137);
            this.cmbTur.Name = "cmbTur";
            this.cmbTur.Size = new System.Drawing.Size(121, 24);
            this.cmbTur.TabIndex = 20;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(28, 207);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(236, 23);
            this.btnEkle.TabIndex = 12;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtFakulte
            // 
            this.txtFakulte.Location = new System.Drawing.Point(143, 90);
            this.txtFakulte.Name = "txtFakulte";
            this.txtFakulte.Size = new System.Drawing.Size(121, 23);
            this.txtFakulte.TabIndex = 17;
            // 
            // txtBolum
            // 
            this.txtBolum.Location = new System.Drawing.Point(143, 46);
            this.txtBolum.Name = "txtBolum";
            this.txtBolum.Size = new System.Drawing.Size(121, 23);
            this.txtBolum.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Program Türü:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Fakülte:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Bölüm:";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.idSil);
            this.xtraTabPage2.Controls.Add(this.textBox5);
            this.xtraTabPage2.Controls.Add(this.label5);
            this.xtraTabPage2.Controls.Add(this.seciliSatirSil);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(327, 443);
            this.xtraTabPage2.Text = "Sil";
            // 
            // idSil
            // 
            this.idSil.Location = new System.Drawing.Point(61, 201);
            this.idSil.Name = "idSil";
            this.idSil.Size = new System.Drawing.Size(175, 23);
            this.idSil.TabIndex = 11;
            this.idSil.Text = "Id numarasından sil";
            this.idSil.UseVisualStyleBackColor = true;
            this.idSil.Click += new System.EventHandler(this.idSil_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(196, 81);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(59, 23);
            this.textBox5.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Silmek için Id girin";
            // 
            // seciliSatirSil
            // 
            this.seciliSatirSil.Location = new System.Drawing.Point(61, 149);
            this.seciliSatirSil.Name = "seciliSatirSil";
            this.seciliSatirSil.Size = new System.Drawing.Size(175, 23);
            this.seciliSatirSil.TabIndex = 8;
            this.seciliSatirSil.Text = "Seçili satırı sil";
            this.seciliSatirSil.UseVisualStyleBackColor = true;
            this.seciliSatirSil.Click += new System.EventHandler(this.seciliSatirSil_Click);
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.label8);
            this.xtraTabPage3.Controls.Add(this.txtIdGuncelle);
            this.xtraTabPage3.Controls.Add(this.cmbTurGuncelle);
            this.xtraTabPage3.Controls.Add(this.btnGuncelle);
            this.xtraTabPage3.Controls.Add(this.txtFakulteGuncelle);
            this.xtraTabPage3.Controls.Add(this.txtBolumGuncelle);
            this.xtraTabPage3.Controls.Add(this.label1);
            this.xtraTabPage3.Controls.Add(this.label6);
            this.xtraTabPage3.Controls.Add(this.label7);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(327, 443);
            this.xtraTabPage3.Text = "Güncelle";
            // 
            // cmbTurGuncelle
            // 
            this.cmbTurGuncelle.FormattingEnabled = true;
            this.cmbTurGuncelle.Items.AddRange(new object[] {
            "Önlisans",
            "Lisans",
            "Yükseklisans",
            "Doktora"});
            this.cmbTurGuncelle.Location = new System.Drawing.Point(158, 183);
            this.cmbTurGuncelle.Name = "cmbTurGuncelle";
            this.cmbTurGuncelle.Size = new System.Drawing.Size(121, 24);
            this.cmbTurGuncelle.TabIndex = 27;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(43, 253);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(236, 23);
            this.btnGuncelle.TabIndex = 21;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtFakulteGuncelle
            // 
            this.txtFakulteGuncelle.Location = new System.Drawing.Point(158, 136);
            this.txtFakulteGuncelle.Name = "txtFakulteGuncelle";
            this.txtFakulteGuncelle.Size = new System.Drawing.Size(121, 23);
            this.txtFakulteGuncelle.TabIndex = 26;
            // 
            // txtBolumGuncelle
            // 
            this.txtBolumGuncelle.Location = new System.Drawing.Point(158, 92);
            this.txtBolumGuncelle.Name = "txtBolumGuncelle";
            this.txtBolumGuncelle.Size = new System.Drawing.Size(121, 23);
            this.txtBolumGuncelle.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Program Türü:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Fakülte:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Bölüm:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(435, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtIdGuncelle
            // 
            this.txtIdGuncelle.Location = new System.Drawing.Point(158, 50);
            this.txtIdGuncelle.Name = "txtIdGuncelle";
            this.txtIdGuncelle.Size = new System.Drawing.Size(121, 23);
            this.txtIdGuncelle.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 17);
            this.label8.TabIndex = 29;
            this.label8.Text = "Id:";
            // 
            // BolumIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "BolumIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bölüm İşlemleri";
            this.Load += new System.EventHandler(this.BolumIslemleri_Load);
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
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtFakulte;
        private System.Windows.Forms.TextBox txtBolum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTur;
        private System.Windows.Forms.Button idSil;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button seciliSatirSil;
        private System.Windows.Forms.ComboBox cmbTurGuncelle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtFakulteGuncelle;
        private System.Windows.Forms.TextBox txtBolumGuncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIdGuncelle;
    }
}