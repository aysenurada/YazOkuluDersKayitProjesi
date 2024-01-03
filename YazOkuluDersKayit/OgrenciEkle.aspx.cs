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
    public partial class WebFrom : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityOgrenci ent = new EntityOgrenci();
            ent.OgrAd = TxtAd.Text;
            ent.OgrSoyad = TxtSoyad.Text;
            ent.OgrNum = TxtNum.Text;
            ent.OgrFoto = TxtFoto.Text;
            ent.OgrSifre = TxtSifre.Text;
            BllOgrenci.OgrenciEkleBll(ent);
        }
    }
}