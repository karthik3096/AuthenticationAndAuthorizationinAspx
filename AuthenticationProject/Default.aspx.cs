using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AuthenticationProject
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (HttpContext.Current.User.IsInRole("Hr"))

            {

                MessageRole.InnerText = "Welcome HR ";

            }

            if (HttpContext.Current.User.IsInRole("Admin"))
            {
                MessageRole.InnerText = "Welcome Admin";
            }
        }
    }
}