using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


namespace HostelManagementSystem
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        int res;

        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection("Data Source=.\\SQLEXPRESS; Integrated Security=True; Initial Catalog=rohitdb");
        con.Open();
        cmd = new SqlCommand("select count(*) from login where userid='" + txtuser.Text  + "' and pass='" + txtpwd.Text + "'", con);
        res = (int)cmd.ExecuteScalar();
        if (res > 0)
        {
            Response.Write ("Valid user!!!");
           // Response.Redirect("dashbord.aspx?username ="+txtuser.Text);

            HttpCookie cookie = new HttpCookie("mycookie");
            cookie["Username"] = txtuser.Text;
            //cookie["pwd"] = TextBox2.Text;
            Response.Cookies.Add(cookie); //Response.SetCookie(cookie);
            cookie.Expires = DateTime.Now.AddMinutes(2);
            Response.Redirect("dashbord.aspx");
           

            }
        else
           Response.Write ("Invalid user");

        }
       catch (Exception ex)
         {
             Response.Write(ex.Message);
          }
       finally
        {
           con.Close();
        }

            }

        protected void btnout_Click(object sender, EventArgs e)
        {
            Response.Redirect("signin.aspx");
        }

       
        }
    }
