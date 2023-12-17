using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    public class EntityBasvuruForm
    {
        private int basId;
        private int basOgrId;
        private int basDersId;

        public int BasId { get => basId; set => basId = value; }
        public int BasOgrId { get => basOgrId; set => basOgrId = value; }
        public int BasDersId { get => basDersId; set => basDersId = value; }
    }
}
