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
    public partial class OgrenciListesi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<EntityOgrenci> ogrlist = BllOgrenci.BllListele();
            Repeater1.DataSource = ogrlist;
            Repeater1.DataBind();
        }
    }
}