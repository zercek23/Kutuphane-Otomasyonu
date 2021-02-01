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
    public partial class KitapEkle : Form
    {
        SqlConnection baglanti = new SqlConnection(@"server = (localdb)\MSSQLLocalDB; Initial Catalog = Kutuphane_Veritabani; Integrated Security = True");
        string kategoriNo = "";

        public KitapEkle()
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

        private void Form4_Load(object sender, EventArgs e)
        {
            string kayit = "SELECT * FROM Kategori";
            SqlCommand komut = new SqlCommand(kayit, baglanti);

            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                kitapTurucomboBox.Items.Add(dr["kategoriAdi"]);
            }
            baglanti.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string kayit = "insert into Kitap(ISBN,kitapAdi,yayinEviAdi,yazarAdiSoyad,stokSayisi,basimTarih,ciltNo,kategoriNo) " +
                "values (@ISBN,@kitapAdi,@yayinEviAdi,@yazarAdiSoyad,@stokSayisi,@basimTarih,@ciltNo,@kategoriNo)";

            SqlCommand komut = new SqlCommand(kayit, baglanti);
            baglanti.Open();
            komut.Parameters.AddWithValue("@ISBN", ISBNTextBox.Text);
            komut.Parameters.AddWithValue("@kitapAdi", kitapAdiTextBox.Text);
            komut.Parameters.AddWithValue("@yayinEviAdi", yayinEviAditextBox.Text);
            komut.Parameters.AddWithValue("@yazarAdiSoyad", yazarAdiSoyaditextBox.Text);
            komut.Parameters.AddWithValue("@stokSayisi", stokSayisitextBox.Text);
            komut.Parameters.AddWithValue("@basimTarih", dateTimePicker1.Value);
            komut.Parameters.AddWithValue("@ciltNo", ciltNotextBox.Text);
            komut.Parameters.AddWithValue("@kategoriNo", Convert.ToInt32(kategoriNo));

            komut.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Kitap Kayıt İşlemi Gerçekleşti.");
        }

        private void kitapTurucomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string kayit = "SELECT kategoriNo FROM Kategori where kategoriAdi = '" + kitapTurucomboBox.Text + "'";
            SqlCommand komut = new SqlCommand(kayit, baglanti);

            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();

            while (dr.Read())
            {
                kategoriNo = dr["kategoriNo"].ToString();
            }
            baglanti.Close();
        }
    }
}
