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
using System.Data.SqlClient;


namespace E_Ticaret_Proje
{
    public partial class FrmTemsilciIslemleri : Form
    {
        public FrmTemsilciIslemleri()
        {
            InitializeComponent();
        }
        
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmTemsilciIslemleri_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select * from Temsilci", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
        }

        private void btnTemsilciEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO Temsilci(TemsilciIsim,TemsilciSoyisim,TemsilciTCNo,TemsilciTelNo,TemsilciAdresBilgi,TemsilciSifre) values(@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", txtTemsilciIsim.Text);
            komut.Parameters.AddWithValue("@p2", txtTemsilciSoyisim.Text);
            komut.Parameters.AddWithValue("@p3", mskTemsilciTCNO.Text);
            komut.Parameters.AddWithValue("@p4", mskTemsilciTelNo.Text);
            komut.Parameters.AddWithValue("@p5", txtTemsilciAdres.Text);
            komut.Parameters.AddWithValue("@p6", txtTemsilciSifre.Text);
            komut.ExecuteNonQuery();

            bgl.baglanti().Close();
            MessageBox.Show("Temsilci Eklendi!");
        }

        private void btnTemsilciGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Temsilci set TemsilciIsim = @p1,TemsilciSoyisim=@p2,TemsilciTelNo=@p3,TemsilciAdresBilgi=@p4, TemsilciSifre=@p5 where TemsilciTCNo = @p6", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", txtTemsilciIsim.Text);
            komut.Parameters.AddWithValue("@p2", txtTemsilciSoyisim.Text);
            komut.Parameters.AddWithValue("@p3", mskTemsilciTelNo.Text);
            komut.Parameters.AddWithValue("@p4", txtTemsilciAdres.Text);
            komut.Parameters.AddWithValue("@p5", txtTemsilciSifre.Text);
            komut.Parameters.AddWithValue("@p6", mskTemsilciTCNO.Text);

            komut.ExecuteNonQuery();

            bgl.baglanti().Close();
            MessageBox.Show("Temsilci Güncelleme İşlemi Başarıyla Yapılmıştır.");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtTemsilciID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtTemsilciIsim.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtTemsilciSoyisim.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            mskTemsilciTCNO.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskTemsilciTelNo.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtTemsilciAdres.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtTemsilciSifre.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void btnTemsilciSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From Temsilci where TemsilciID = @p1", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", txtTemsilciID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Temsilci Başarılı Bir Şekilde Silinmiştir.");
        }
    }
}
