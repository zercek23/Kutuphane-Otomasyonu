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
    public partial class KitapOduncVer : Form
    {
        string kullaniciNo = "", kitapNo = "";
        SqlConnection baglanti = new SqlConnection(@"server = (localdb)\MSSQLLocalDB; Initial Catalog = Kutuphane_Veritabani; Integrated Security = True");
        public KitapOduncVer()
        {
            InitializeComponent();
        }

        private void kaydetbtn_Click(object sender, EventArgs e)
        {
            string kayit = "insert into KitapKayit(kullaniciNo,kitapNo,alisTarih,verisTarih) " +
               "values (@kullaniciNo,@kitapNo,@alisTarih,@verisTarih)";

            SqlCommand komut = new SqlCommand(kayit, baglanti);
            baglanti.Open();
            komut.Parameters.AddWithValue("@kullaniciNo", kullaniciNo);
            komut.Parameters.AddWithValue("@kitapNo", kitapNo);
            komut.Parameters.AddWithValue("@alisTarih", dateTimePicker1.Value);
            komut.Parameters.AddWithValue("@verisTarih", DateTime.Now);

            komut.ExecuteNonQuery();

            baglanti.Close();

            kayit = "SELECT stokSayisi FROM Kitap where kitapNo = '" + kitapNo + "'";
            komut = new SqlCommand(kayit, baglanti);

            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            int stokSayisi = 0;
            if (dr.Read())
            {
                stokSayisi = Convert.ToInt32(dr["stokSayisi"].ToString());
                stokSayisi--;
            }
            baglanti.Close();

            kayit = "update Kitap set stokSayisi = '" + stokSayisi.ToString() + "' where kitapNo = '" + kitapNo + "' "; ;
            komut = new SqlCommand(kayit, baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Kitap Ödünç Verme İşlemi Gerçekleşti.");       
            
        }

        private void cikisbtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
            Menu frm2 = new Menu();
            frm2.ShowDialog();
        }

        private void OduncVer_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "SELECT * FROM Kullanici";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
            for (int i = 0; i < 9; i++)
            {
                if (i == 1) continue;
                dataGridView1.Columns[i].Visible = false;
            }
            dataGridView1.Columns[1].HeaderCell.Value = "Kullanıcı Adı";
            //--------------------------------------
            baglanti.Open();
            kayit = "SELECT * FROM Kitap";
            komut = new SqlCommand(kayit, baglanti);
            da = new SqlDataAdapter(komut);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            baglanti.Close();
            for (int i = 0; i < 9; i++)
            {
                if (i == 2 || i == 5) continue;
                dataGridView2.Columns[i].Visible = false;
            }
            dataGridView2.Columns[2].HeaderCell.Value = "Kitap Adı";
            dataGridView2.Columns[5].HeaderCell.Value = "Stok Sayısı";
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            kullaniciNo = dataGridView1.CurrentRow.Cells["kullaniciNo"].Value.ToString();
        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            kitapNo = dataGridView2.CurrentRow.Cells["kitapNo"].Value.ToString();
            
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "SELECT * FROM Kullanici where kullaniciAdi like '%" + textBox1.Text + "%'";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string kayit = "SELECT * FROM Kitap where kitapAdi like '%" + textBox2.Text + "%'";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            baglanti.Close();
        }
    }
}
