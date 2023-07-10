using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace E_Ticaret_Proje
{
    public partial class FrmTemsilciGiris : Form
    {
        public FrmTemsilciGiris()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void btnTemsilciGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Temsilci Where TemsilciIsim=@p1 and TemsilciSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtTemsilciKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@p2", txtTemsilciSifre.Text);
            
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmTemsilciPaneli fr = new FrmTemsilciPaneli();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı giriş!");
            }
            bgl.baglanti().Close();
        }
    }
}
