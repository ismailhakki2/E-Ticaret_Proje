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
    public partial class FrmTemsilciPaneli : Form
    {
        public FrmTemsilciPaneli()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void btnTemsilciIslemleri_Click(object sender, EventArgs e)
        {
            FrmTemsilciIslemleri fr = new FrmTemsilciIslemleri();
            fr.Show();
        }

        private void btnUrünIslemleri_Click(object sender, EventArgs e)
        {
            FrmUrünIslemleri fr = new FrmUrünIslemleri();
            fr.Show();
        }

        private void btnUyeIslemleri_Click(object sender, EventArgs e)
        {
            FrmUyeIslemleri fr = new FrmUyeIslemleri();
            fr.Show();
        }

        private void btnUrunYorumları_Click(object sender, EventArgs e)
        {
            FrmUyeYorumlari fr = new FrmUyeYorumlari();
            fr.Show();
        }

        private void FrmTemsilciPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select * from Urün", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select * from Uye", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;
        }
    }
}
