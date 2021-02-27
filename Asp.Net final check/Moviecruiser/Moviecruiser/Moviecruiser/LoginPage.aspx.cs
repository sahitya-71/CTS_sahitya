using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Moviecruiser
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {

            if (Txtname.Text == "Sahitya" && Txtpassword.Text == "471")
            {
                Session["name"] = Txtname.Text;
                FormsAuthentication.RedirectFromLoginPage(Txtname.Text, true);
            }
           
        }
        protected void ValidateUsername(object source, ServerValidateEventArgs args)
        {
            if (args.Value != "Sahitya")
                args.IsValid = false;
            else
                args.IsValid = true;
        }
       
              protected void ValidatePassword(object source, ServerValidateEventArgs args)
        {
            if (args.Value != "471")
                args.IsValid = false;
            else
                args.IsValid = true;
        }



    }
    }
