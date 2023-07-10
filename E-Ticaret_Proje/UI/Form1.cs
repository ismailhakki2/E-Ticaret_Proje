using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Ticaret_Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTemsilci_Click(object sender, EventArgs e)
        {
            FrmTemsilciGiris frm = new FrmTemsilciGiris();
            frm.Show();
            this.Hide();
        }

        private void btnMüsteri_Click(object sender, EventArgs e)
        {
            FrmMüsteriGiriş frm = new FrmMüsteriGiriş();
            frm.Show();
            this.Hide();

        }


    }
}
