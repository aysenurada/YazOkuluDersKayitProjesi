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
    public partial class Dersler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false) {
                List<EntityDers> entityDers = BllDers.BllListele();
                DropDownList1.DataSource = BllDers.BllListele();
                DropDownList1.DataTextField = "DersAd";
                DropDownList1.DataValueField = "DersId";
                DropDownList1.DataBind();
            }
        }

        protected void BtnDersTalep_Click(object sender, EventArgs e)
        {
            EntityBasvuruForm ent = new EntityBasvuruForm();
            ent.BasOgrId = int.Parse(TextBox1.Text);
            ent.BasDersId = int.Parse(DropDownList1.SelectedValue.ToString());
            BllDers.TalepEkleBll(ent);
        }
    }
}