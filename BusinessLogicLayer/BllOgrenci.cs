using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFramework;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BllOgrenci
    {
        public static int OgrenciEkleBll(EntityOgrenci p)
        {
            if (p.OgrAd != null && p.OgrSoyad != null && p.OgrNum != null && p.OgrFoto != null && p.OgrSifre != null)
            {
                return DalOgrenci.OgrenciEkle(p);
            }
            return -1;
        }

        public static List<EntityOgrenci> BllListele()
        {
            return DalOgrenci.OgrenciListesi();
        }

        public static bool OgrenciSilBll(int p)
        {
            // Her zaman true döner, çünkü p bir int değeridir ve ToString() null dönmeyecek.
            //if (p.ToString() != null)
            //{
            //    return DalOgrenci.OgrenciSil(p);
            //}

            //return false;

            return DalOgrenci.OgrenciSil(p);
        }

        public static List<EntityOgrenci> BllDetay(int p)
        {
            return DalOgrenci.OgrenciDetay(p);
        }

        public static bool OgrenciGuncelleBll(EntityOgrenci p)
        {
            if (p.OgrAd != null && p.OgrAd != "" && p.OgrSoyad != null && p.OgrSoyad != "" && p.OgrNum != null && p.OgrNum != "" && p.OgrFoto != null && p.OgrFoto != "" && p.OgrSifre != null && p.OgrSifre != "" && p.OgrId > 0)
            {
                return DalOgrenci.OgrenciGuncelle(p);
            }

            return false;
        }
    }
}
