using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    internal class EntityDers
    {
        private int dersId;
        private string dersAd;
        private int minKont;
        private int maxKont;

        public int DersId { get => dersId; set => dersId = value; }
        public string DersAd { get => dersAd; set => dersAd = value; }
        public int MinKont { get => minKont; set => minKont = value; }
        public int MaxKont { get => maxKont; set => maxKont = value; }
    }
}
