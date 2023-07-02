using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Notebook
{
    public partial class note : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        HttpCookie notes;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=mca;Integrated Security=True;Pooling=False");
            con.Open();
            notes = Request.Cookies["notes"];
            if (notes != null)
            {
                if (notes["id"] == "-1")
                {
                    Label1.Text = "Create a New Note";
                    Button1.Text = "Create";
                }
                else
                {
                    Label1.Text = "Update The Note";
                    Button1.Text = "Update";
                    if (!IsPostBack)
                    {
                        cmd = new SqlCommand("select * from notes where id="+notes["id"], con);
                        dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                        
                            TextBox1.Text = dr.GetString(1).ToString();
                            TextBox2.Text = dr.GetString(2).ToString();
                        }
                        dr.Close();
                    }
                    
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (notes["id"] == "-1")
            {
                cmd = new SqlCommand("INSERT INTO notes (title, text) VALUES (@title, @text)", con);
                cmd.Parameters.AddWithValue("@title", TextBox1.Text);
                cmd.Parameters.AddWithValue("@text", TextBox2.Text);
                cmd.ExecuteNonQuery();
            }
            else
            {
                cmd = new SqlCommand("UPDATE notes SET title = @Title, text = @Text WHERE id = @Id", con);
                cmd.Parameters.AddWithValue("@Title", TextBox1.Text);
                cmd.Parameters.AddWithValue("@Text", TextBox2.Text);
                cmd.Parameters.AddWithValue("@Id", int.Parse(notes["id"]));
                cmd.ExecuteNonQuery();
            }
            Response.Redirect("home.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("home.aspx");
        }
    }
}