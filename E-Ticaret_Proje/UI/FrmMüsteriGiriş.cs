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
    public partial class FrmMüsteriGiriş : Form
    {
        public FrmMüsteriGiriş()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void btnMüsteriGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Uye Where UyeIsim=@p1 and UyeSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtKullanıcıAdi.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);

            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmMüsteriPaneli fr = new FrmMüsteriPaneli();
                fr.Show();
                this.Visible=false;
                
            }
            else
            {
                MessageBox.Show("Hatalı giriş!");
            }
            bgl.baglanti().Close();
        }
    }
}
