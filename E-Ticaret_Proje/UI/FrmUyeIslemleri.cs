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
    public partial class FrmUyeIslemleri : Form
    {
        public FrmUyeIslemleri()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmUyeIslemleri_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select * from Uye", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtUyeID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtUyeIsim.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtUyeSoyisim.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            mskUyeTelNo.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtUyeAdres.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtUyeSıfre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
           
        }

        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO Uye(UyeIsim,UyeSoyisim,UyeTelNo,UyeAdresBilgi,UyeSifre) values(@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());

            
            komut.Parameters.AddWithValue("@p1", txtUyeIsim.Text);
            komut.Parameters.AddWithValue("@p2", txtUyeSoyisim.Text);
            komut.Parameters.AddWithValue("@p3", mskUyeTelNo.Text);
            komut.Parameters.AddWithValue("@p4", txtUyeAdres.Text);
            komut.Parameters.AddWithValue("@p5", txtUyeSıfre.Text);
            komut.ExecuteNonQuery();

            bgl.baglanti().Close();
            MessageBox.Show("Uye Eklendi!");
        }

        private void btnUyeGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Uye set UyeSoyisim=@p1,UyeTelNo=@p2,UyeAdresBilgi=@p3, UyeSifre=@p4 where UyeIsim = @p5", bgl.baglanti());

            komut.Parameters.AddWithValue("@p5", txtUyeIsim.Text);
            komut.Parameters.AddWithValue("@p1", txtUyeSoyisim.Text);
            komut.Parameters.AddWithValue("@p2", mskUyeTelNo.Text);
            komut.Parameters.AddWithValue("@p3", txtUyeAdres.Text);
            komut.Parameters.AddWithValue("@p4", txtUyeSıfre.Text);
           

            komut.ExecuteNonQuery();

            bgl.baglanti().Close();
            MessageBox.Show("Uye Güncelleme İşlemi Başarıyla Yapılmıştır.");
        }

        private void btnUyeSıl_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From Uye where UyeID = @p1", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", txtUyeID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Uye Başarılı Bir Şekilde Silinmiştir.");
        }
    }
}
