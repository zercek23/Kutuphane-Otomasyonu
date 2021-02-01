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
    public partial class Giris : Form
    {
        private SqlConnection baglanti;
        private SqlCommand komut;
        private SqlDataReader dr;

        public Giris()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti = new SqlConnection(@"server =(localdb)\MSSQLLocalDB; Initial Catalog = Kutuphane_Veritabani; Integrated Security = True");
            komut = new SqlCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "SELECT * FROM Kullanici where kullaniciAdi='" + textBox1.Text + "' AND sifre='" + textBox2.Text + "'" +
                "AND (kullaniciTur = 'personel' OR kullaniciTur = 'admin')";
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                this.Visible = false;
                Menu frm2 = new Menu();
                frm2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
            }
            baglanti.Close();           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
