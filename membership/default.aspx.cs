using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace membership
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string isim = Request.QueryString["isim"];
            string deger = Request.QueryString["link"];
            Response.Write(deger);
            Response.Write(isim);

        }

        protected void btnAl_Click(object sender, EventArgs e)
        {
            if(Request.Cookies["isim"] != null && Request.Cookies["soyisim"] != null)
            {
            lbl.Text = Request.Cookies["isim"].Value + Request.Cookies["soyisim"].Value;
            }


        }
    }
}