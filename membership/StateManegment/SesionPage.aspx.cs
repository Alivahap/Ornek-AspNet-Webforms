using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace membership.StateManegment
{
    public partial class SesionPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void btnAt_Click(object sender, EventArgs e)
        {
            Session["grup"] = "Y15L22GH";
            Session["grup1"] = "ikinci değer";
        }

        protected void btnAl_Click(object sender, EventArgs e)
        {
            Response.Write(Session["grup"]+""+Session.SessionID);

            Response.Write("---"+Session.SessionID);

        }
    }
}