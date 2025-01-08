using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace TopluMailGonderme
{
    public partial class RibbonForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public RibbonForm()
        {
            InitializeComponent();
        }

        private void RibbonForm_Load(object sender, EventArgs e)
        {
            ArkaPlan arka = new ArkaPlan();
            arka.MdiParent = this;
            arka.Show();

        }

        //Mail Gönder
        private void barButtonItem22_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form2 form2 = new Form2();
            form2.MdiParent = this;
            form2.Show();

        }

        private void kullaniciEkle_ItemClick(object sender, ItemClickEventArgs e)
        {
            KullaniciIslemleri ekle = new KullaniciIslemleri();
            ekle.MdiParent = this;
            ekle.Show();
            

        }

        private void kullaniciSil_ItemClick(object sender, ItemClickEventArgs e)
        {
            KullaniciIslemleri sil = new KullaniciIslemleri();
           
            sil.MdiParent = this;
            sil.Show();


        }

        private void kullaniciGuncelle_ItemClick(object sender, ItemClickEventArgs e)
        {
            KullaniciIslemleri guncelle = new KullaniciIslemleri();
            guncelle.MdiParent = this;
            guncelle.Show();

        }

       

        private void yetkilendirmeOgrenci_ItemClick(object sender, ItemClickEventArgs e)
        {
            Yetkilendirme ogrenci = new Yetkilendirme();
            ogrenci.MdiParent = this;
            ogrenci.Show();

        }

        private void yetkilendirmeOgretimGorevlisi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Yetkilendirme ogretimGorevlisi = new Yetkilendirme();
            ogretimGorevlisi.MdiParent = this;
            ogretimGorevlisi.Show();

        }

        private void yetkilendirmeAdmin_ItemClick(object sender, ItemClickEventArgs e)
        {
            Yetkilendirme admin = new Yetkilendirme();
            admin.MdiParent = this;
            admin.Show();

        }

        private void bolumEkle_ItemClick(object sender, ItemClickEventArgs e)
        {
            BolumIslemleri ekle = new BolumIslemleri();
            ekle.MdiParent = this;
            ekle.Show();

        }

        private void bolumGuncelle_ItemClick(object sender, ItemClickEventArgs e)
        {
            BolumIslemleri guncelle = new BolumIslemleri();
            guncelle.MdiParent = this;
            guncelle.Show();

        }

        private void bolumCikar_ItemClick(object sender, ItemClickEventArgs e)
        {
            BolumIslemleri sil = new BolumIslemleri();
            sil.MdiParent = this;
            sil.Show();
        }

        private void ogrenciEkle_ItemClick(object sender, ItemClickEventArgs e)
        {
            OgrenciIslemleri ekle = new OgrenciIslemleri();
            ekle.MdiParent = this;
            ekle.Show();

        }

        private void ogrenciSil_ItemClick(object sender, ItemClickEventArgs e)
        {
            OgrenciIslemleri sil = new OgrenciIslemleri();
            sil.MdiParent = this;
            sil.Show();

        }

        private void ogrenciGuncelle_ItemClick(object sender, ItemClickEventArgs e)
        {
            OgrenciIslemleri guncelle = new OgrenciIslemleri();
            guncelle.MdiParent = this;
            guncelle.Show();
        }

        private void ogretimGorevlisiEkle_ItemClick(object sender, ItemClickEventArgs e)
        {
            OgretimGorevlisiIslemleri ekle = new OgretimGorevlisiIslemleri();
            ekle.MdiParent = this;
            ekle.Show();
        }

        private void ogretimGorevlisiSil_ItemClick(object sender, ItemClickEventArgs e)
        {
            OgretimGorevlisiIslemleri sil = new OgretimGorevlisiIslemleri();
            sil.MdiParent = this;
            sil.Show();
        }

        private void ogretimGorevlisiGuncelle_ItemClick(object sender, ItemClickEventArgs e)
        {
            OgretimGorevlisiIslemleri guncelle = new OgretimGorevlisiIslemleri();
            guncelle.MdiParent = this;
            guncelle.Show();
        }

        private void adminEkle_ItemClick(object sender, ItemClickEventArgs e)
        {
            AdminIslemleri ekle = new AdminIslemleri();
            ekle.MdiParent = this;
            ekle.Show();
        }

        private void adminSil_ItemClick(object sender, ItemClickEventArgs e)
        {
            AdminIslemleri cikar = new AdminIslemleri();
            cikar.MdiParent = this;
            cikar.Show();

        }

        private void adminGuncelle_ItemClick(object sender, ItemClickEventArgs e)
        {
            AdminIslemleri guncelle = new AdminIslemleri();
            guncelle.MdiParent = this;
            guncelle.Show();
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult result = MessageBox.Show("Uygulamayı kapatmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void grupOlustur_ItemClick(object sender, ItemClickEventArgs e)
        {
            GrupOlustur grup = new GrupOlustur();
            grup.MdiParent = this;
            grup.Show();

        }

       

        private void barButtonItem23_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form2 guncel = new Form2();
            guncel.MdiParent = this;
            guncel.Show();

        }

        private void barButtonItem24_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form2 sil = new Form2();
            sil.MdiParent = this;
            sil.Show();

        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            MailSablonlari ekle = new MailSablonlari();
            ekle.MdiParent = this;
            ekle.Show();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

       
    }
}