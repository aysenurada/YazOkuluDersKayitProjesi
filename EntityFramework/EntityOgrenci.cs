using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    public class EntityOgrenci
    {
        private int ogrId;
        private string ogrAd;
        private string ogrSoyad;
        private string ogrNum;
        private string ogrFoto;
        private string ogrSifre;
        private string ogrBakiye;

        public int OgrId { get => ogrId; set => ogrId = value; }
        public string OgrAd { get => ogrAd; set => ogrAd = value; }
        public string OgrSoyad { get => ogrSoyad; set => ogrSoyad = value; }
        public string OgrNum { get => ogrNum; set => ogrNum = value; }
        public string OgrFoto { get => ogrFoto; set => ogrFoto = value; }
        public string OgrSifre { get => ogrSifre; set => ogrSifre = value; }
        public string OgrBakiye { get => ogrBakiye; set => ogrBakiye = value; }
    }
}
