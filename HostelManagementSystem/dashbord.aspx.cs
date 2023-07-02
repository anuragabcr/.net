using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HostelManagementSystem
{
    public partial class dashbord : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          //  Response.Write(Request.QueryString["username"]);
           // String username = Request.QueryString["username"];  
           // Label3.Text = "Welcome " + username;
            //Label3.Visible = true;

            HttpCookie c = Request.Cookies["mycookie"];
            if (c != null)
            {
                Label3.Text = c["Username"];
                Label3.Visible = true;
            }
            
        }

        protected void btnemp_Click(object sender, EventArgs e)
        {
            Response.Redirect("employee.aspx");
        }

        protected void btnemp2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {

        }

        protected void btnemp0_Click(object sender, EventArgs e)
        {
            Response.Redirect("guest.aspx");
        }
    }
}