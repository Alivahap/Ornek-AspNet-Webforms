using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace membership
{
    public partial class ZiyaretciPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Application["ziyaretci"] == null) return;
            ltrZiyaretci.Text =Application["ziyaretci"].ToString();
                 

        }
    }
}