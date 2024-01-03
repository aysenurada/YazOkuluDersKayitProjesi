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
    public class DalDers
    {
        public static List<EntityDers> DersListesi()
        {
            List<EntityDers> degerler = new List<EntityDers>();
            SqlCommand komut = new SqlCommand("Select DersAd From TblDersler", Baglanti.baglan);
            if (komut.Connection.State != ConnectionState.Open) {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityDers ent = new EntityDers();
                try {
                    ent.DersId = Convert.ToInt32(dr["DersID"].ToString());
                }
                catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                }
                ent.DersAd = dr["DersAd"].ToString();
                try {
                    ent.MinKont = int.Parse(dr["DersMinKontenjan"].ToString());
                    ent.MaxKont = int.Parse(dr["DersMaxKontenjan"].ToString());
                }
                catch { }
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static int TalepEkle(EntityBasvuruForm parametre)
        {
            SqlCommand komut1 = new SqlCommand("Insert Into TblBasvuruForm (OgrID, DersID) Values (@p1, @p2)", Baglanti.baglan);
            komut1.Parameters.AddWithValue("@p1", parametre.BasOgrId);
            komut1.Parameters.AddWithValue("@p2", parametre.BasDersId);
            if (komut1.Connection.State != ConnectionState.Open) {
                komut1.Connection.Open();
            }
            return komut1.ExecuteNonQuery();
        }
    }
}
