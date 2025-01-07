using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TopluMailGonderme
{
    public partial class ArkaPlan : Form
    {
        public ArkaPlan()
        {
            this.ControlBox = false;
            InitializeComponent();

        }

        private void navBarItem1_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            KullaniciIslemleri kullaniciIslemleri = new KullaniciIslemleri();
            kullaniciIslemleri.Show();
        }

        private void navBarItem2_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            KullaniciIslemleri kullanici = new KullaniciIslemleri();
            kullanici.Show();

        }

        private void navBarItem3_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            KullaniciIslemleri guncelle = new KullaniciIslemleri();
            guncelle.Show();
        }

        private void navBarItem4_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Yetkilendirme yetki = new Yetkilendirme();
            yetki.Show();
        }

        private void navBarItem5_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Yetkilendirme yetki1 = new Yetkilendirme();
            yetki1.Show();

        }

        private void navBarItem6_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Yetkilendirme yetki2 = new Yetkilendirme();
            yetki2.Show();
        }

        private void navBarItem7_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            BolumIslemleri bolum = new BolumIslemleri();
            bolum.Show();
        }

        private void navBarItem8_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            BolumIslemleri bolum1 = new BolumIslemleri();
            bolum1.Show();

        }

        private void navBarItem9_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            BolumIslemleri bolum2 = new BolumIslemleri();
            bolum2.Show();
        }

        private void navBarItem10_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void navBarItem11_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Form2 form1 = new Form2();
            form1.Show();

        }

        private void navBarItem12_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void navBarItem13_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            GrupOlustur grup = new GrupOlustur();
            grup.Show();
        }

        private void navBarItem14_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            GrupOlustur grup1 = new GrupOlustur();
            grup1.Show();
        }

        private void navBarItem15_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            GrupOlustur grup2 = new GrupOlustur();
            grup2.Show();
        }

        private void navBarItem16_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            OgrenciIslemleri ogrenci = new OgrenciIslemleri();
            ogrenci.Show();
        }

        private void navBarItem17_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            OgrenciIslemleri ogrenci1 = new OgrenciIslemleri();
            ogrenci1.Show();

        }

        private void navBarItem18_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            OgrenciIslemleri ogrenci2 = new OgrenciIslemleri();
            ogrenci2.Show();
        }

        private void navBarItem19_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Form2 form3 = new Form2();
            form3.Show();
        }

        private void navBarItem20_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            OgretimGorevlisiIslemleri ogretimGorevlisi = new OgretimGorevlisiIslemleri();
            ogretimGorevlisi.Show();
        }

        private void navBarItem24_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            AdminIslemleri admin = new AdminIslemleri();
            admin.Show();
        }
    }
}
