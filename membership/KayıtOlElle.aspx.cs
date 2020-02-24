using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace membership
{
    public partial class KayıtOlElle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MembershipCreateStatus st;
            Membership.CreateUser(TextBox1.Text, TextBox2.Text, TextBox3.Text,
                TextBox4.Text, TextBox5.Text, true, out st);
            if (st == MembershipCreateStatus.Success)
            {
                Response.Redirect("~/GirisYapElle.aspx");
            }
            else
            {
                Response.Write("<script> alert('hatalı') </script> ");
            }



        }
    }
}