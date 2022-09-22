using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AuthenticationProject
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Login_Click(object sender, EventArgs e)
        {
            string role = string.Empty;
            string username = tb_UserName.Text;
            bool RightToGo = false;
            if(username == "user"&& tb_Password.Text == "Admin")
            {
               
                role = "Admin";
                RightToGo = true;
            }
            else if(username == "Hr" && tb_Password.Text == "HrLogin")
            {
                 role = "Hr";
                RightToGo = true;
            }
            if (RightToGo == true)
            {
                FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1, username, DateTime.Now, DateTime.Now.AddMinutes(2), true, role, FormsAuthentication.FormsCookiePath);
                string hashCookies = FormsAuthentication.Encrypt(ticket);

                HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, hashCookies);
                Response.Cookies.Add(cookie);

                Response.Redirect("~/Default.aspx");
            }
            else
            {
                lbl_Message.Visible = true;
                lbl_Message.Text = "Please check your username and password";
            }
        }
    }
}