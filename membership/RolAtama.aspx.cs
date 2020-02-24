using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace membership
{
    public partial class RolAtama : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) { 
            drpkullanici.DataTextField = "UserName";
            drpkullanici.DataSource = Membership.GetAllUsers();

            drprol.DataSource = Roles.GetAllRoles();
            

            drpkullanici.DataBind();
            drprol.DataBind();
            }
        }

        protected void btnata_Click(object sender, EventArgs e)
        {
            Roles.AddUserToRole(drpkullanici.Text, drprol.Text);

        }
    }
}