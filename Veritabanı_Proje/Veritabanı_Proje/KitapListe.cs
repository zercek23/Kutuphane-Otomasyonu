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
    public partial class KitapListe : Form
    {
        SqlConnection baglanti = new SqlConnection(@"server = (localdb)\MSSQLLocalDB; Initial Catalog = Kutuphane_Veritabani; Integrated Security = True");
        string kitapNo = "";
        public KitapListe()
        {
            InitializeComponent();
        }

        public void Listele()
        {
            baglanti.Open();
            string kayit = "SELECT * FROM Kitap";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[1].HeaderCell.Value = "ISBN";
            dataGridView1.Columns[2].HeaderCell.Value = "Kitap Adı";
            dataGridView1.Columns[3].HeaderCell.Value = "Yayın Evi Adı";
            dataGridView1.Columns[4].HeaderCell.Value = "Yazar Ad Soyad";
            dataGridView1.Columns[5].HeaderCell.Value = "Stok Sayısı";
            dataGridView1.Columns[6].HeaderCell.Value = "Basım Tarih";
            dataGridView1.Columns[7].HeaderCell.Value = "Cilt No";
        }

        public void Sifirla()
        {
            ISBNTextBox.Text = "";
            kitapAdiTextBox.Text = "";
            yazarAdiSoyaditextBox.Text = "";
            yayinEviAditextBox.Text = "";
            stokSayisitextBox.Text = "";
            dateTimePicker1.Text = "";
            ciltNotextBox.Text = "";
        }

        private void KitapListe_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            kitapNo = dataGridView1.CurrentRow.Cells["kitapNo"].Value.ToString();
            ISBNTextBox.Text = dataGridView1.CurrentRow.Cells["ISBN"].Value.ToString();
            kitapAdiTextBox.Text = dataGridView1.CurrentRow.Cells["kitapAdi"].Value.ToString();
            yazarAdiSoyaditextBox.Text = dataGridView1.CurrentRow.Cells["yazarAdiSoyad"].Value.ToString();
            yayinEviAditextBox.Text = dataGridView1.CurrentRow.Cells["yayinEviAdi"].Value.ToString();
            stokSayisitextBox.Text = dataGridView1.CurrentRow.Cells["stokSayisi"].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells["basimTarih"].Value.ToString();
            ciltNotextBox.Text = dataGridView1.CurrentRow.Cells["ciltNo"].Value.ToString();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "update Kitap set ISBN=@ISBN,kitapAdi=@kitapAdi,yayinEviAdi=@yayinEviAdi,yazarAdiSoyad=@yazarAdiSoyad," +
                "stokSayisi=@stokSayisi,basimTarih=@basimTarih,ciltNo=@ciltNo where kitapNo = '" + kitapNo + "'";

            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("@ISBN", ISBNTextBox.Text);
            komut.Parameters.AddWithValue("@kitapAdi", kitapAdiTextBox.Text);
            komut.Parameters.AddWithValue("@yayinEviAdi", yayinEviAditextBox.Text);
            komut.Parameters.AddWithValue("@yazarAdiSoyad", yazarAdiSoyaditextBox.Text);
            komut.Parameters.AddWithValue("@stokSayisi", stokSayisitextBox.Text);
            komut.Parameters.AddWithValue("@basimTarih", dateTimePicker1.Value);
            komut.Parameters.AddWithValue("@ciltNo", ciltNotextBox.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();
            Listele();
            MessageBox.Show("Kitap Düzenleme İşlemi Gerçekleşti.");
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
            Menu menu = new Menu();
            menu.ShowDialog();
        }

        private void silbtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "DELETE from Kitap where kitapNo = '" + kitapNo + "'";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            Listele();
            Sifirla();
        }
    }
}
