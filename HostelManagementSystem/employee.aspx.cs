using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace HostelManagementSystem
{
    public partial class employee : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source =.\\SQLEXPRESS;Initial Catalog=rohitdb;integrated Security=True");
            con.Open();
        }

        protected void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("insert into employee values('" + txtempid.Text + "','" + txtname.Text + "','" + txtdesig.Text + "','" + txtdepart.Text + "'," + txtsalary.Text + ",'" + txtdoj.Text + "'," + txtphno.Text + ",'" + txtemail + "')", con);
                cmd.ExecuteNonQuery();
                Response.Write("Record successfully inserted");
                txtname.Text = "";
                txtdesig.Text = "";
                txtdepart.Text = "";
                txtphno.Text = "";
                txtemail.Text = "";
                txtempid.Text = "";
                txtempid.Focus();
                Response.Redirect("employee.aspx");

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            
        }

        protected void btnback_Click(object sender, EventArgs e)
        {
            Response.Redirect("dashbord.aspx");
        }

        


       
    }
}