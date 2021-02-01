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

namespace Veritabanı_Proje
{
    public partial class BilgisayarEkle : Form
    {
        SqlConnection baglanti = new SqlConnection(@"server = (localdb)\MSSQLLocalDB; Initial Catalog = Kutuphane_Veritabani; Integrated Security = True");
        public BilgisayarEkle()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
            Menu frm2 = new Menu();
            frm2.ShowDialog();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string kayit = "insert into Bilgisayar(marka,model,stokSayisi) " +
                "values (@marka,@model,@stokSayisi)";

            SqlCommand komut = new SqlCommand(kayit, baglanti);
            baglanti.Open();
            komut.Parameters.AddWithValue("@marka", markaTextBox.Text);
            komut.Parameters.AddWithValue("@model", modelTextBox.Text);
            komut.Parameters.AddWithValue("@stokSayisi", stokSayisiTextBox.Text);

            komut.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Bilgisayar Kayıt İşlemi Gerçekleşti.");
        }
    }
}
