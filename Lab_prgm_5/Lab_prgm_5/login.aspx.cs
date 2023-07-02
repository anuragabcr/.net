using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab_prgm_5
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie c = Request.Cookies["login"];
            if (c!= null)
            {
                Label4.Text = c["name"];
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie c = new HttpCookie("login");
            c["name"] = TextBox1.Text;
            Response.Cookies.Add(c);
            c.Expires = DateTime.Now.AddDays(2);
            Response.Redirect("final.aspx");
        }
    }
}