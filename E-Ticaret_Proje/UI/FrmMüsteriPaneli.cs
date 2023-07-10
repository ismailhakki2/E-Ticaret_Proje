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
    public partial class FrmMüsteriPaneli : Form
    {
        public FrmMüsteriPaneli()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmMüsteriPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select * from Urün", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtUrünID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtUrünKodu.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtUrünIsim.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            mskUrünTarih.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtUrünFiyat.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
        }

        private void btnSatınAl_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From Urün where UrünID = @p1", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", txtUrünID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Satın Alma İşlemi Başarılı Bir Şekilde Gerçekleşmiştir.");
        }

        private void btnSatilanUrünler_Click(object sender, EventArgs e)
        {
            FrmSatilmisUrünler fr = new FrmSatilmisUrünler();
            fr.Show();
            this.Hide();
        }
    }
}
