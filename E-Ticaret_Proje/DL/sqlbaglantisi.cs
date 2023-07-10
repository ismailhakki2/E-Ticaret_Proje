using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace E_Ticaret_Proje
{
    class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-LCGJ1EN;Initial Catalog=eTicaretPlatformu;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
