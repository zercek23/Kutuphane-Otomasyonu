using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veritabanı_Proje
{
    public partial class Menu : Form
    {
        
        public Menu()
        {
            InitializeComponent();
        }

        private void personelKayitbtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            PersonelEkle frm3 = new PersonelEkle();
            frm3.ShowDialog();
        }

        private void kapatbtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Giris giris = new Giris();
            giris.ShowDialog();
        }

        private void kitapKayitbtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            KitapEkle kitapEkle = new KitapEkle();
            kitapEkle.ShowDialog();
        }

        private void uyebtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            UyeEkle uyeEkle = new UyeEkle();
            uyeEkle.ShowDialog();
        }

        private void bilgisayarKayitbtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            BilgisayarEkle bilgisayarEkle = new BilgisayarEkle();
            bilgisayarEkle.ShowDialog();
        }

        private void bilgisayarOduncbtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            BilgisayarOduncVer bilgisayarOduncVer = new BilgisayarOduncVer();
            bilgisayarOduncVer.ShowDialog();
        }

        private void kitapOduncbtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            KitapOduncVer kitapOduncVer = new KitapOduncVer();
            kitapOduncVer.ShowDialog();
        }

        private void kitapListebtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            KitapListe kitapListe = new KitapListe();
            kitapListe.ShowDialog();
        }

        private void personelListebtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            PersonelListe personelListe = new PersonelListe();
            personelListe.ShowDialog();
        }

        private void uyeListebtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            UyeListe uyeListe = new UyeListe();
            uyeListe.ShowDialog();
        }

        private void bilgisayarListebtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            BilgisayarListe bilgisayarListe = new BilgisayarListe();
            bilgisayarListe.ShowDialog();
        }

        private void oduncVerilenListe_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            OduncKitapListe oduncKitapListe = new OduncKitapListe();
            oduncKitapListe.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            OduncBilgisayarListe oduncBilgisayarListe = new OduncBilgisayarListe();
            oduncBilgisayarListe.ShowDialog();
        }
    }
}
