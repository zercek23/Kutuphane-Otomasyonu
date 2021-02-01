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
    public partial class UyeListe : Form
    {
        SqlConnection baglanti = new SqlConnection(@"server = (localdb)\MSSQLLocalDB; Initial Catalog = Kutuphane_Veritabani; Integrated Security = True");
        string iletisimNo = "", ilNo = "", ilceNo = "", okulNo = "";
        public UyeListe()
        {
            InitializeComponent();
        }

        public void Listele()
        {
            baglanti.Open();
            string kayit = "SELECT * FROM Kullanici where kullaniciTur = 'uye'";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();


            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[1].HeaderCell.Value = "Kullanıcı Adı";
            dataGridView1.Columns[2].HeaderCell.Value = "Şifre";
            dataGridView1.Columns[3].HeaderCell.Value = "TC No";
            dataGridView1.Columns[4].HeaderCell.Value = "Ad Soyad";
            dataGridView1.Columns[5].HeaderCell.Value = "Cinsiyet";
            dataGridView1.Columns[6].HeaderCell.Value = "Doğum Tarih";
        }

        public void Sifirla()
        {
            kullaniciAdiText.Text = "";
            sifreText.Text = "";
            tcText.Text = "";
            adSoyadText.Text = "";
            dateTimePicker1.Text = "";
            ilComboBox.Text = "";
            ilceComboBox.Text = "";
            telefonText.Text = "";
            epostaText.Text = "";
            cinsiyetComboBox.Text = "";
            adresText.Text = "";
            okulAdicomboBox.Text = "";
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string kayit1 = "update IletisimBilgileri set telefon=@telefon,adres=@adres,eposta=@eposta,ilNo=@ilNo,ilceNo=@ilceNo,okulNo=@okulNo where iletisimNo ='" + iletisimNo + "'";
            SqlCommand komut = new SqlCommand(kayit1, baglanti);

            baglanti.Open();

            komut.Parameters.AddWithValue("@telefon", telefonText.Text);
            komut.Parameters.AddWithValue("@adres", adresText.Text);
            komut.Parameters.AddWithValue("@eposta", epostaText.Text);
            komut.Parameters.AddWithValue("@ilNo", Convert.ToInt32(ilNo));
            komut.Parameters.AddWithValue("@ilceNo", Convert.ToInt32(ilceNo));
            komut.Parameters.AddWithValue("@okulNo", Convert.ToInt32(okulNo));

            komut.ExecuteNonQuery();

            string kayit2 = "update Kullanici set kullaniciAdi=@kullaniciAdi,sifre=@sifre,tcNo=@tcNo,adSoyad=@adSoyad,cinsiyet=@cinsiyet,dogumTarih=@dogumTarih where iletisimNo = '" + iletisimNo + "'";

            komut = new SqlCommand(kayit2, baglanti);
            komut.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdiText.Text);
            komut.Parameters.AddWithValue("@sifre", sifreText.Text);
            komut.Parameters.AddWithValue("@tcNo", tcText.Text);
            komut.Parameters.AddWithValue("@adSoyad", adSoyadText.Text);
            komut.Parameters.AddWithValue("@dogumTarih", dateTimePicker1.Value);
            komut.Parameters.AddWithValue("@cinsiyet", cinsiyetComboBox.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Personel Düzenleme İşlemi Gerçekleşti.");
            Listele();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Menu menu = new Menu();
            menu.ShowDialog();
        }

        private void silbtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "DELETE from Kullanici where iletisimNo = '" + iletisimNo + "'";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            Listele();
            Sifirla();
        }

        private void ilceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Close();
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
            
        }

        private void okulAdicomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Close();

            string kayit2 = "SELECT ilceNo FROM Ilce where ilceAdi = '" + ilceComboBox.Text + "'";
            SqlCommand komut = new SqlCommand(kayit2, baglanti);
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
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            iletisimNo = dataGridView1.CurrentRow.Cells["iletisimNo"].Value.ToString();
            kullaniciAdiText.Text = dataGridView1.CurrentRow.Cells["kullaniciAdi"].Value.ToString();
            sifreText.Text = dataGridView1.CurrentRow.Cells["sifre"].Value.ToString();
            tcText.Text = dataGridView1.CurrentRow.Cells["tcNo"].Value.ToString();
            adSoyadText.Text = dataGridView1.CurrentRow.Cells["adSoyad"].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells["dogumTarih"].Value.ToString();

            baglanti.Open();
            string kayit = "SELECT * FROM IletisimBilgileri where iletisimNo = '" + iletisimNo + "'";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataReader dr;
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                telefonText.Text = dr["telefon"].ToString();
                adresText.Text = dr["adres"].ToString();
                epostaText.Text = dr["eposta"].ToString();
                ilNo = dr["ilNo"].ToString();
                ilceNo = dr["ilceNo"].ToString();
                okulNo = dr["okulNo"].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            kayit = "SELECT ilAdi FROM Il where ilNo ='" + ilNo + "'";
            komut = new SqlCommand(kayit, baglanti);
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                ilComboBox.Text = dr["ilAdi"].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            kayit = "SELECT ilceAdi FROM Ilce where ilceNo ='" + ilceNo + "'";
            komut = new SqlCommand(kayit, baglanti);
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                ilceComboBox.Text = dr["ilceAdi"].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            kayit = "SELECT okulAdi FROM Okul where okulNo ='" + okulNo + "'";
            komut = new SqlCommand(kayit, baglanti);
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                okulAdicomboBox.Text = dr["okulAdi"].ToString();
            }
            baglanti.Close();
        }

        private void ilComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ilceComboBox.Items.Clear();
            baglanti.Close();
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

        

        private void UyeListe_Load(object sender, EventArgs e)
        {
            Listele();
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

    }
}
