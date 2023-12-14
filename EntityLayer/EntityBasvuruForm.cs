using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    internal class EntityBasvuruForm
    {
        private int basid;
        private int basDersid;
        private int basOgrid;

        public int Basid { get => basid; set => basid = value; }
        public int BasDersid { get => basDersid; set => basDersid = value; }
        public int BasOgrid { get => basOgrid; set => basOgrid = value; }
    }
}
