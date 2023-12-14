using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    internal class EntityDers
    {
        private string dersAd;
        private int minkont;
        private int maxkont;
        private int dersid;

        public string DersAd { get => dersAd; set => dersAd = value; }
        public int Minkont { get => minkont; set => minkont = value; }
        public int Maxkont { get => maxkont; set => maxkont = value; }
        public int Id { get => id; set => id = value; }
    }
}
