using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace HostelManagementSystem
{
    public partial class guest : System.Web.UI.Page
    {

        SqlConnection con;
        SqlCommand cmd;
        SqlCommand rd;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source =.\\SQLEXPRESS;Initial Catalog=rohitdb;integrated Security=True");
            con.Open();
       
        }

        protected void btnback_Click(object sender, EventArgs e)
        {
            Response.Redirect("dashbord.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {

        }

        protected void btnadd_Click(object sender, EventArgs e)
        {

            try
            {
                cmd = new SqlCommand("insert into guest values('" + guestid.Text + "','" + name.Text + "','" + place.Text + "','" + age.Text + "'," + phoneno.Text + ",'" + dob.Text + "'," + email.Text + ")", con);
                cmd.ExecuteNonQuery();
                Response.Write("Record successfully inserted");
                guestid.Text = "";
                name.Text = "";
                place.Text = "";
                age.Text = "";
                phoneno.Text = "";
                dob.Text = "";
                email.Text = "";
                guestid.Focus();
                Response.Redirect("employee.aspx");

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}