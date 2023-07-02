using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Notebook
{
    public partial class home : System.Web.UI.Page
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
                updateGridView();

                cmd = new SqlCommand("select * from notes", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    DropDownList1.Items.Add(dr.GetInt32(0).ToString());
                }
                dr.Close();
            }
        }

        protected void updateGridView()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from notes", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie notes = new HttpCookie("notes");
            notes["id"] = DropDownList1.Text;
            notes.Expires.AddDays(5);
            Response.Cookies.Add(notes);
            Response.Redirect("note.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("delete from notes where id="+DropDownList1.Text, con);
            DropDownList1.Items.Remove(DropDownList1.SelectedItem);
            cmd.ExecuteNonQuery();
            updateGridView();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            HttpCookie notes = new HttpCookie("notes");
            notes["id"] = "-1";
            notes.Expires.AddDays(5);
            Response.Cookies.Add(notes);
            Response.Redirect("note.aspx");
        }
    }
}