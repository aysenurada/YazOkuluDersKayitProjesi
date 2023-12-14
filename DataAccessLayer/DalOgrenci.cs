using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityFramework;

namespace DataAccessLayer
{
    public class DalOgrenci
    {
        public static int OgrenciEkle(EntityOgrenci parametre)
        {
            SqlCommand komut1 = new SqlCommand("Insert Into TblOgrenci (OgrAd, OgrSoyad, OgrNumara, OgrFoto, OgrSifre) Values (@p1, @p2, @p3, @p4, @p5)", Baglanti.baglan);

            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }

            komut1.Parameters.AddWithValue("@p1", parametre.OgrAd);
            komut1.Parameters.AddWithValue("@p2", parametre.OgrSoyad);
            komut1.Parameters.AddWithValue("@p3", parametre.OgrNum);
            komut1.Parameters.AddWithValue("@p4", parametre.OgrFoto);
            komut1.Parameters.AddWithValue("@p5", parametre.OgrSifre);

            return komut1.ExecuteNonQuery();
        }
    }
}
