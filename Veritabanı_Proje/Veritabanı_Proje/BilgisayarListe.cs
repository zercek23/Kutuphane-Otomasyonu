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
    public partial class BilgisayarListe : Form
    {
        SqlConnection baglanti = new SqlConnection(@"server = (localdb)\MSSQLLocalDB; Initial Catalog = Kutuphane_Veritabani; Integrated Security = True");
        string bilgisayarNo = "";
        public BilgisayarListe()
        {
            InitializeComponent();
        }

        public void Listele()
        {
            baglanti.Open();
            string kayit = "SELECT * FROM Bilgisayar";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();


            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderCell.Value = "Marka";
            dataGridView1.Columns[2].HeaderCell.Value = "Model";
            dataGridView1.Columns[3].HeaderCell.Value = "Stok Sayısı";
        }

        public void Sifirla()
        {
            markaTextBox.Text = "";
            modelTextBox.Text = "";
            stokSayisiTextBox.Text = "";
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Menu menu = new Menu();
            menu.ShowDialog();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {         

            baglanti.Open();

            string kayit2 = "update Bilgisayar set marka=@marka,model=@model,stokSayisi=@stokSayisi where bilgisayarNo = '" + bilgisayarNo + "'";

            SqlCommand komut = new SqlCommand(kayit2, baglanti);
            komut.Parameters.AddWithValue("@marka", markaTextBox.Text);
            komut.Parameters.AddWithValue("@model", modelTextBox.Text);
            komut.Parameters.AddWithValue("@stokSayisi", stokSayisiTextBox.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Bilgisayar Kayıt Düzenleme İşlemi Gerçekleşti.");
            Listele();
        }

        private void silbtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "DELETE from Bilgisayar where bilgisayarNo = '" + bilgisayarNo + "'";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            Listele();
            Sifirla();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            bilgisayarNo = dataGridView1.CurrentRow.Cells["bilgisayarNo"].Value.ToString();
            markaTextBox.Text = dataGridView1.CurrentRow.Cells["marka"].Value.ToString();
            modelTextBox.Text = dataGridView1.CurrentRow.Cells["model"].Value.ToString();
            stokSayisiTextBox.Text = dataGridView1.CurrentRow.Cells["stokSayisi"].Value.ToString();            
        }

        private void BilgisayarListe_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
