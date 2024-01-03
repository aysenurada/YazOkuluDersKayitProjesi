using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityFramework;
using DataAccessLayer;
using BusinessLogicLayer;

namespace YazOkuluDersKayit
{
    public partial class OgrenciGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["OgrID"]);
            TxtId.Text = x.ToString();
            TxtId.Enabled = false;
            if (Page.IsPostBack == false) {
                List<EntityOgrenci> ogrlist = BllOgrenci.BllDetay(x);
                if (ogrlist != null && ogrlist.Count > 0) {
                    TxtAd.Text = ogrlist[0].OgrAd.ToString();
                    TxtSoyad.Text = ogrlist[0].OgrSoyad.ToString();
                    TxtNum.Text = ogrlist[0].OgrNum.ToString();
                    TxtSifre.Text = ogrlist[0].OgrSifre.ToString();
                    TxtFoto.Text = ogrlist[0].OgrFoto.ToString();
                }
                else {
                    Response.Write("Öğrenci bilgisi bulunamadı.");
                }
            }
        }

        protected void BtnGunclle_Click(object sender, EventArgs e)
        {
            EntityOgrenci ent = new EntityOgrenci();
            ent.OgrId = Convert.ToInt32(TxtId.Text);
            ent.OgrAd = TxtAd.Text;
            ent.OgrSoyad = TxtSoyad.Text;
            ent.OgrNum = TxtNum.Text;
            ent.OgrSifre = TxtSifre.Text;
            ent.OgrFoto = TxtFoto.Text;
            BllOgrenci.OgrenciGuncelleBll(ent);
            Response.Redirect("OgrenciListesi.aspx");
        }
    }
}