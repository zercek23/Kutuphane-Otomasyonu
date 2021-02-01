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
    public partial class OduncBilgisayarListe : Form
    {
        SqlConnection baglanti = new SqlConnection(@"server = (localdb)\MSSQLLocalDB; Initial Catalog = Kutuphane_Veritabani; Integrated Security = True");
        string bilgisayarKayitNo = "", bilgisayarNo = "", kullaniciNo = "";
        public OduncBilgisayarListe()
        {
            InitializeComponent();
        }

        public void Listele()
        {
            DataTable bilgisayarTablo = new DataTable();
            List<int> bilgisayarKayitNolar = new List<int>();
            List<int> bilgisayarNolar = new List<int>();
            List<int> kullaniciNolar = new List<int>();
            List<string> kullaniciAdi = new List<string>();
            List<string> marka = new List<string>();
            List<string> model = new List<string>();
            List<string> alisTarihi = new List<string>();
            List<string> verisTarihi = new List<string>();

            baglanti.Open();
            string kayit = "SELECT * FROM BilgisayarKayit";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            SqlDataReader dr;
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                bilgisayarKayitNolar.Add(Convert.ToInt32(dr["bilgisayarKayitNo"]));
                bilgisayarNolar.Add(Convert.ToInt32(dr["bilgisayarNo"]));
                kullaniciNolar.Add(Convert.ToInt32(dr["kullaniciNo"]));
                alisTarihi.Add(dr["alisTarih"].ToString());
                verisTarihi.Add(dr["verisTarih"].ToString());
            }
            baglanti.Close();
            int sayac = 0;
            while (sayac < bilgisayarNolar.Count)
            {
                kayit = "SELECT * FROM Bilgisayar where bilgisayarNo ='" + bilgisayarNolar[sayac] + "'";
                komut = new SqlCommand(kayit, baglanti);
                baglanti.Open();
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    marka.Add(dr["marka"].ToString());
                    model.Add(dr["model"].ToString());
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

            bilgisayarTablo.Columns.Add("bilgisayarKayitNo", typeof(int));
            bilgisayarTablo.Columns.Add("bilgisayarNo", typeof(int));
            bilgisayarTablo.Columns.Add("kullaniciNo", typeof(int));
            bilgisayarTablo.Columns.Add("kullaniciAdi", typeof(string));
            bilgisayarTablo.Columns.Add("markaModel", typeof(string));
            bilgisayarTablo.Columns.Add("alisTarih", typeof(DateTime));
            bilgisayarTablo.Columns.Add("verisTarih", typeof(DateTime));
            for (int i = 0; i < kullaniciAdi.Count; i++)
            {
                bilgisayarTablo.Rows.Add(bilgisayarKayitNolar[i], bilgisayarNolar[i], kullaniciNolar[i], kullaniciAdi[i], marka[i] + " " + model[i], alisTarihi[i], verisTarihi[i]);
            }
            dataGridView1.DataSource = bilgisayarTablo;
            baglanti.Close();

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].HeaderCell.Value = "Kullanıcı Adı";
            dataGridView1.Columns[4].HeaderCell.Value = "Marka ve Model";
            dataGridView1.Columns[5].HeaderCell.Value = "Alış Tarih";
            dataGridView1.Columns[6].HeaderCell.Value = "Veriş Tarih";
        }

        private void OduncBilgisayarListe_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            bilgisayarKayitNo = dataGridView1.CurrentRow.Cells["bilgisayarKayitNo"].Value.ToString();
            bilgisayarNo = dataGridView1.CurrentRow.Cells["bilgisayarNo"].Value.ToString();
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
            string kayit = "DELETE from BilgisayarKayit where bilgisayarKayitNo = '" + bilgisayarKayitNo + "'";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            Listele();

            //Stok sayısı arttırılır
            kayit = "SELECT stokSayisi FROM Bilgisayar where bilgisayarNo = '" + bilgisayarNo + "'";
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

            kayit = "update Bilgisayar set stokSayisi = '" + stokSayisi + "' where bilgisayarNo = '" + bilgisayarNo + "'"; ;
            komut = new SqlCommand(kayit, baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("İade işlemi gerçekleşti.");
        }
    }
}
