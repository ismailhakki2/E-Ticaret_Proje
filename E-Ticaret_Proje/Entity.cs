using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticaret_Proje
{
    public class Urün
    {
        public Guid ID { get; set; }
        public int UrünKodu { get; set; }
        public string UrünIsim { get; set; }
        public DateTime UrünTarih { get; set; }
        public string UrünFiyat { get; set; }
    }

    public class SatilmisUrünler
    {
        public string UyeIsim { get; set; }
        public int UrünKodu { get; set; }
        public string UrünIsim { get; set; }
        public string UrünFiyat { get; set; }

    }

    public class Temsilci
    {
        public Guid TemsilciID { get; set; }
        public string TemsilciIsim { get; set; }
        public string TemsilciSoyisim { get; set; }
        public string TemsilciTCNo { get; set; }
        public string TemsilciTelNo { get; set; }
        public string TemsilciAdresBilgi { get; set; }
        public string TemsilciSifre { get; set; }

    }

    public class UrünYorum
    {
        public string YorumID { get; set; }
        public string UrünID { get; set;}
        public string UyeID { get; set;}
        public string YorumMetni { get;set;}
        public string YorumTarih { get; set;}
    }

    public class Uye
    {
        public Guid UyeID { get; set; }
        public string UyeIsim { get; set; }
        public string UyeSoyisim { get; set; }
        public string UyeTelNo { get; set; }
        public string UyeAdresBilgi { get; set; }
        public string UyeSifre { get; set; }

    }
}
