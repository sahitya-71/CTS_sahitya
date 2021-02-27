using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Moviecruiser
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btnlogin_Click(object sender, EventArgs e)
        {
            if (Txtname.Text == "Sahitya" && Txtpassword.Text == "123")
            {
                Session["name"] = Txtname.Text;
                FormsAuthentication.RedirectFromLoginPage(Txtname.Text, true);

            }
            else
                Response.Write("Inavlid Credentials");
            
        }
    }
}