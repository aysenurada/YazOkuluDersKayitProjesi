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
    public partial class OgrenciSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["OgrID"]);
            Response.Write(x);

            BllOgrenci.OgrenciSilBll(x);

            Response.Redirect("OgrenciListesi.aspx");
        }
    }
}