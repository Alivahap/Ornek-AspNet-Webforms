using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace membership.NewFolder1
{
    public partial class ViewStatePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnat_Click(object sender, EventArgs e)
        {
           
            Response.Redirect("~/default.aspx?link=" + txt.Text+"&isim= alişan");


        }

        protected void btnAnasayfa_Click(object sender, EventArgs e)
        {

        }
    }
}