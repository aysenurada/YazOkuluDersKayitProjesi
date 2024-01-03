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
            if (komut1.Connection.State != ConnectionState.Open) {
                komut1.Connection.Open();
            }
            komut1.Parameters.AddWithValue("@p1", parametre.OgrAd);
            komut1.Parameters.AddWithValue("@p2", parametre.OgrSoyad);
            komut1.Parameters.AddWithValue("@p3", parametre.OgrNum);
            komut1.Parameters.AddWithValue("@p4", parametre.OgrFoto);
            komut1.Parameters.AddWithValue("@p5", parametre.OgrSifre);
            return komut1.ExecuteNonQuery();
        }

        public static List<EntityOgrenci> OgrenciListesi()
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand komut2 = new SqlCommand("Select * From TblOgrenci", Baglanti.baglan);
            if (komut2.Connection.State != ConnectionState.Open) {
                komut2.Connection.Open();
            }
            SqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read()) {
                EntityOgrenci ent = new EntityOgrenci();
                ent.OgrId = Convert.ToInt32(dr["OgrID"].ToString());
                ent.OgrAd = dr["OgrAd"].ToString();
                ent.OgrSoyad = dr["OgrSoyad"].ToString();
                ent.OgrNum = dr["OgrNumara"].ToString();
                ent.OgrFoto = dr["OgrFoto"].ToString();
                ent.OgrSifre = dr["OgrSifre"].ToString();
                ent.OgrBakiye = Convert.ToDouble(dr["OgrBakiye"]).ToString();
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static bool OgrenciSil(int parametre)
        {
            SqlCommand komut3 = new SqlCommand("Delete From TblOgrenci Where OgrID = @p1", Baglanti.baglan);
            if (komut3.Connection.State != ConnectionState.Open) {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@p1", parametre);
            return komut3.ExecuteNonQuery() > 0;
        }

        public static List<EntityOgrenci> OgrenciDetay(int id)
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand komut4 = new SqlCommand("Select * From TblOgrenci Where OgrID = @p1", Baglanti.baglan);
            komut4.Parameters.AddWithValue("@p1", id);
            if (komut4.Connection.State != ConnectionState.Open) {
                komut4.Connection.Open();
            }
            SqlDataReader dr = komut4.ExecuteReader();
            while (dr.Read()) {
                EntityOgrenci ent = new EntityOgrenci();
                ent.OgrAd = dr["OgrAd"].ToString();
                ent.OgrSoyad = dr["OgrSoyad"].ToString();
                ent.OgrNum = dr["OgrNumara"].ToString();
                ent.OgrFoto = dr["OgrFoto"].ToString();
                ent.OgrSifre = dr["OgrSifre"].ToString();
                ent.OgrBakiye = Convert.ToDouble(dr["OgrBakiye"]).ToString();
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static bool OgrenciGuncelle(EntityOgrenci deger)
        {
            SqlCommand komut5 = new SqlCommand("Update TblOgrenci Set OgrAd = @p1, OgrSoyad = @p2, OgrNumara = @p3, OgrFoto = @p4, OgrSifre = @p5 Where OgrID = @p6", Baglanti.baglan);
            if (komut5.Connection.State != ConnectionState.Open) {
                komut5.Connection.Open();
            }
            komut5.Parameters.AddWithValue("@p1", deger.OgrAd);
            komut5.Parameters.AddWithValue("@p2", deger.OgrSoyad);
            komut5.Parameters.AddWithValue("@p3", deger.OgrNum);
            komut5.Parameters.AddWithValue("@p4", deger.OgrFoto);
            komut5.Parameters.AddWithValue("@p5", deger.OgrSifre);
            komut5.Parameters.AddWithValue("@p6", deger.OgrId);
            return komut5.ExecuteNonQuery() > 0;
        }
    }
}
