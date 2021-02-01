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
    public partial class UyeEkle : Form
    {
        SqlConnection baglanti = new SqlConnection(@"server = (localdb)\MSSQLLocalDB; Initial Catalog = Kutuphane_Veritabani; Integrated Security = True");
        string ilNo = "", ilceNo = "", okulNo = "";
        public UyeEkle()
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

        private void ilceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            okulAdicomboBox.Items.Clear();
            string kayit = "SELECT ilceNo FROM Ilce where ilceAdi = '" + ilceComboBox.Text + "'";
            SqlCommand komut = new SqlCommand(kayit, baglanti);


            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();

            while (dr.Read())
            {
                ilceNo = dr["ilceNo"].ToString();
            }
            baglanti.Close();

            string kayit1 = "SELECT * FROM Okul where ilceNo = '" + ilceNo + "'";
            komut = new SqlCommand(kayit1, baglanti);

            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                okulAdicomboBox.Items.Add(dr["okulAdi"]);
            }
            baglanti.Close();

            //------------------------------------------------------------------------------------------

            string kayit2 = "SELECT ilceNo FROM Ilce where ilceAdi = '" + ilceComboBox.Text + "'";
            komut = new SqlCommand(kayit2, baglanti);

            
            baglanti.Open();
            dr = komut.ExecuteReader();

            while (dr.Read())
            {
                ilceNo = dr["ilceNo"].ToString();
            }
            baglanti.Close();
        }

        private void okulAdicomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string kayit2 = "SELECT okulNo FROM Okul where okulAdi = '" + okulAdicomboBox.Text + "'";
            SqlCommand komut = new SqlCommand(kayit2, baglanti);

            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();

            while (dr.Read())
            {
                okulNo = dr["okulNo"].ToString();
            }
            baglanti.Close();
        }

        private void ilComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ilceComboBox.Items.Clear();
            string kayit = "SELECT ilNo FROM Il where ilAdi = '" + ilComboBox.Text + "'";
            SqlCommand komut = new SqlCommand(kayit, baglanti);


            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();

            while (dr.Read())
            {
                ilNo = dr["ilNo"].ToString();
            }
            baglanti.Close();

            string kayit1 = "SELECT * FROM Ilce where ilNo = '" + ilNo + "'";
            komut = new SqlCommand(kayit1, baglanti);

            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                ilceComboBox.Items.Add(dr["ilceAdi"]);
            }
            baglanti.Close();
        }

        private void UyeEkle_Load(object sender, EventArgs e)
        {
            string kayit = "SELECT *FROM Il";
            SqlCommand komut = new SqlCommand(kayit, baglanti);

            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                ilComboBox.Items.Add(dr["ilAdi"]);
            }
            baglanti.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string kayit1 = "insert into IletisimBilgileri(telefon,adres,eposta,ilNo,ilceNo,okulNo) values (@telefon,@adres,@eposta,@ilNo,@ilceNo,@okulNo)";
            SqlCommand komut = new SqlCommand(kayit1, baglanti);

            baglanti.Open();

            komut.Parameters.AddWithValue("@telefon", telefonText.Text);
            komut.Parameters.AddWithValue("@adres", adresText.Text);
            komut.Parameters.AddWithValue("@eposta", epostaText.Text);
            komut.Parameters.AddWithValue("@ilNo", Convert.ToInt32(ilNo));
            komut.Parameters.AddWithValue("@ilceNo", Convert.ToInt32(ilceNo));
            komut.Parameters.AddWithValue("@okulNo", Convert.ToInt32(okulNo));


            komut.ExecuteNonQuery();

            string altKayit = "select iletisimNo from IletisimBilgileri where telefon = '" + telefonText.Text + "'";
            komut = new SqlCommand(altKayit, baglanti);

            SqlDataReader dr;
            dr = komut.ExecuteReader();
            string iletisimNo = "";

            if (dr.Read())
            {
                iletisimNo = dr["iletisimNo"].ToString();
            }
            dr.Close();
            string kayit2 = "insert into Kullanici(kullaniciAdi,sifre,tcNo,adSoyad,cinsiyet,dogumTarih,iletisimNo,kullaniciTur) " +
                "values (@kullaniciAdi,@sifre,@tcNo,@adSoyad,@cinsiyet,@dogumTarih,@iletisimNo,@kullaniciTur)";

            komut = new SqlCommand(kayit2, baglanti);
            komut.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdiText.Text);
            komut.Parameters.AddWithValue("@sifre", sifreText.Text);
            komut.Parameters.AddWithValue("@tcNo", tcText.Text);
            komut.Parameters.AddWithValue("@adSoyad", adSoyadText.Text);
            komut.Parameters.AddWithValue("@dogumTarih", dateTimePicker1.Value);
            komut.Parameters.AddWithValue("@cinsiyet", cinsiyetComboBox.Text);
            komut.Parameters.AddWithValue("@iletisimNo", iletisimNo);
            komut.Parameters.AddWithValue("@kullaniciTur", "uye");

            komut.ExecuteNonQuery();

            baglanti.Close();

            string kayit3 = "select kullaniciNo from Kullanici where iletisimNo= '" + iletisimNo + "'";
            komut = new SqlCommand(kayit3, baglanti);
            baglanti.Open();
            dr = komut.ExecuteReader();
            string kullaniciNo = "";

            if (dr.Read())
            {
                kullaniciNo = dr["kullaniciNo"].ToString();
            }
            dr.Close();
            string kayit4 = "insert into Uye(kullaniciNo,kayitTarih,okuduguKitapSayisi) " +
                "values (@kullaniciNo,@kayitTarih,@okuduguKitapSayisi)";

            komut = new SqlCommand(kayit4, baglanti);
            komut.Parameters.AddWithValue("@kullaniciNo", kullaniciNo);
            komut.Parameters.AddWithValue("@kayitTarih", DateTime.Now);
            komut.Parameters.AddWithValue("@okuduguKitapSayisi", 0);

            komut.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("Üye Kayıt İşlemi Gerçekleşti.");
        }
    }
}
