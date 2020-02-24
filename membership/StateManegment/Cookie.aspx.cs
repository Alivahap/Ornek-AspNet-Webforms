using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace membership.NewFolder1
{
    public partial class Cookie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

      

        protected void BtnAt_Click(object sender, EventArgs e)
        {
            HttpCookie ck = new HttpCookie("isim");
            ck.Value = txt.Text;
            ck.Expires = DateTime.Now.AddMonths(1);
            Response.Cookies.Add(ck);

            Response.Cookies["soyisim"].Value = "aydin";

        }
    }
}