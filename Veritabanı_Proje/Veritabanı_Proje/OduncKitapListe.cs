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
    public partial class OduncKitapListe : Form
    {
        SqlConnection baglanti = new SqlConnection(@"server = (localdb)\MSSQLLocalDB; Initial Catalog = Kutuphane_Veritabani; Integrated Security = True");
        string kitapKayitNo = "", kitapNo = "", kullaniciNo = "";
        public OduncKitapListe()
        {
            InitializeComponent();
        }

        public void Listele()
        {
            DataTable kitapTablo = new DataTable();
            List<int> kitapKayitNolar = new List<int>();
            List<int> kitapNolar = new List<int>();
            List<int> kullaniciNolar = new List<int>();
            List<string> kullaniciAdi = new List<string>();
            List<string> kitapAdi = new List<string>();
            List<string> alisTarihi = new List<string>();
            List<string> verisTarihi = new List<string>();

            baglanti.Open();
            string kayit = "SELECT * FROM KitapKayit";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            SqlDataReader dr;
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                kitapKayitNolar.Add(Convert.ToInt32(dr["kitapKayitNo"]));
                kitapNolar.Add(Convert.ToInt32(dr["kitapNo"]));
                kullaniciNolar.Add(Convert.ToInt32(dr["kullaniciNo"]));
                alisTarihi.Add(dr["alisTarih"].ToString());
                verisTarihi.Add(dr["verisTarih"].ToString());
            }
            baglanti.Close();
            int sayac = 0;
            while (sayac < kitapNolar.Count)
            {
                kayit = "SELECT * FROM Kitap where kitapNo ='" + kitapNolar[sayac] + "'";
                komut = new SqlCommand(kayit, baglanti);
                baglanti.Open();
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    kitapAdi.Add(dr["kitapAdi"].ToString());
                }
                baglanti.Close();
                sayac++;                
            }
            sayac = 0;
            while (sayac < kullaniciNolar.Count)
            {
                kayit = "SELECT * FROM Kullanici where kullaniciNo ='" + kullaniciNolar[sayac] + "'";
                komut = new SqlCommand(kayit, baglanti);
                baglanti.Open();
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    kullaniciAdi.Add(dr["kullaniciAdi"].ToString());
                }
                baglanti.Close();
                sayac++;
            }

            kitapTablo.Columns.Add("kitapKayitNo", typeof(int));
            kitapTablo.Columns.Add("kitapNo", typeof(int));
            kitapTablo.Columns.Add("kullaniciNo", typeof(int));
            kitapTablo.Columns.Add("kullaniciAdi", typeof(string));
            kitapTablo.Columns.Add("kitapAdi", typeof(string));
            kitapTablo.Columns.Add("alisTarih", typeof(DateTime));
            kitapTablo.Columns.Add("verisTarih", typeof(DateTime));
            for (int i = 0; i < kullaniciAdi.Count; i++)
            {
                kitapTablo.Rows.Add(kitapKayitNolar[i], kitapNolar[i], kullaniciNolar[i], kullaniciAdi[i], kitapAdi[i], alisTarihi[i], verisTarihi[i]);
            }
            dataGridView1.DataSource = kitapTablo;
            baglanti.Close();

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].HeaderCell.Value = "Kullanıcı Adı";
            dataGridView1.Columns[4].HeaderCell.Value = "Kitap Adı";
            dataGridView1.Columns[5].HeaderCell.Value = "Alış Tarih";
            dataGridView1.Columns[6].HeaderCell.Value = "Veriş Tarih";
        }        

        private void OduncKitapListe_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            kitapKayitNo = dataGridView1.CurrentRow.Cells["kitapKayitNo"].Value.ToString();
            kitapNo = dataGridView1.CurrentRow.Cells["kitapNo"].Value.ToString();
            kullaniciNo = dataGridView1.CurrentRow.Cells["kullaniciNo"].Value.ToString();
        }      

        private void cikisbtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
            Menu menu = new Menu();
            menu.ShowDialog();
        }

        private void kaydetbtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "DELETE from KitapKayit where kitapKayitNo = '" + kitapKayitNo + "'";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            Listele();

            //Stok sayısı arttırılır
            kayit = "SELECT stokSayisi FROM Kitap where kitapNo = '" + kitapNo + "'";
            komut = new SqlCommand(kayit, baglanti);
            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            int stokSayisi = 0;
            if (dr.Read())
            {
                stokSayisi = Convert.ToInt32(dr["stokSayisi"].ToString());
                stokSayisi++;
            }
            baglanti.Close();

            kayit = "update Kitap set stokSayisi = '" + stokSayisi + "' where kitapNo = '" + kitapNo + "'"; ;
            komut = new SqlCommand(kayit, baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("İade işlemi gerçekleşti.");

        }
    }
}
