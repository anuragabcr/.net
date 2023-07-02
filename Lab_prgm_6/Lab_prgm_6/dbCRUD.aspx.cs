using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Lab_prgm_6
{
    public partial class dbCRUD : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=mca;Integrated Security=True;Pooling=False");
            con.Open();
            if (!IsPostBack)
            {
                cmd = new SqlCommand("select * from employees", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    DropDownList1.Items.Add(dr.GetString(0));
                }
                dr.Close();
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from employees where id="+DropDownList1.Text, con);
            dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                TextBox1.Text = dr.GetString(1).ToString();
                TextBox2.Text = dr.GetString(2).ToString();
                TextBox3.Text = dr.GetString(3).ToString();
            }
            dr.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("update employees set salary=(salary*.15+salary) where id="+DropDownList1.Text, con);
            cmd.ExecuteNonQuery();
            Response.Write("Updated successfull");
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("delete from empolyees where id=" + DropDownList1.Text, con);
            cmd.ExecuteNonQuery();
            Response.Write("deleted successfull");
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            DropDownList1.Items.Remove(DropDownList1.SelectedItem);
        }
    }
}