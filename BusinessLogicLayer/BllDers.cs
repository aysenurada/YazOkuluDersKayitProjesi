using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFramework;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BllDers
    {
        public static List<EntityDers> BllListele()
        {
            return DalDers.DersListesi();
        }

        public static int TalepEkleBll(EntityBasvuruForm p)
        {
            return DalDers.TalepEkle(p);
        }
    }
}
