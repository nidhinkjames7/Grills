using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void submit_Click(object sender, EventArgs e)
    {

        Class1 obj = new Class1();
        obj.getconnection();
        SqlCommand cmd1 = new SqlCommand("sp_registration", obj.con);
        cmd1.CommandType = CommandType.StoredProcedure;
        cmd1.Parameters.Add("@flag", 2);
        cmd1.Parameters.Add("@username",txtusername.Text);
        cmd1.Parameters.Add("@password",txtpassword.Text);
        DataTable dt = new DataTable();
        SqlDataAdapter dtadt = new SqlDataAdapter(cmd1);
        dtadt.Fill(dt);
        if (dt.Rows.Count > 0)
        {

            Response.Redirect("foodpreview.aspx?id=" + txtusername.Text);
        }
        else if (txtusername.Text == "Admin" && txtpassword.Text == "admin123")
        {
            Response.Redirect("adminpage.aspx?id=" + txtusername.Text);
        }
        else
            Response.Write("<script>alert('Invalid User')</script>");
            txtusername.Text = "";   
    }
}