using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace membership
{
    public partial class VievStatePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Model1 m1 = new Model1();
            GridView1.DataSource = m1.KULLANICI.ToList();
            GridView1.DataBind();

        }

        protected void btnkaydet_Click(object sender, EventArgs e)
        {
            drplist.Items.Add(txt.Text);
        }

        protected void btnAl_Click(object sender, EventArgs e)
        {
            Response.Write(ViewState["isim"]);
        }

        protected void btnAt_Click(object sender, EventArgs e)
        {
            ViewState["isim"] = "ayşe";
        }
    }
}