﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace membership
{
    public partial class GirisYapElle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Membership.ValidateUser(TextBox1.Text, TextBox2.Text))
            {
                FormsAuthentication.RedirectFromLoginPage(TextBox1.Text,true);
                
            }


        }
    }
}