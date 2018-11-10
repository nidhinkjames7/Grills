using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class registration : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            Class1 obj = new Class1();
            obj.getconnection();

            SqlCommand cmd1 = new SqlCommand("sp_registration", obj.con);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.Add("@flag", 0);

            cmd1.Parameters.Add("@fullname", txtfullname.Text);
            cmd1.Parameters.Add("@address", txtaddress.Text);
            cmd1.Parameters.Add("@dob", txtdob.Text);
            cmd1.Parameters.Add("@email", txtemail.Text);
            cmd1.Parameters.Add("@phoneno", txtphone.Text);
            cmd1.Parameters.Add("@username", txtusername.Text);
            cmd1.Parameters.Add("@password", txtpassword.Text);


            SqlCommand cmd2 = new SqlCommand("sp_registration", obj.con);
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Parameters.Add("@flag", 3);
            cmd2.Parameters.Add("@username", txtemail.Text);
            DataTable dt = new DataTable();
            SqlDataAdapter adt = new SqlDataAdapter(cmd2);
            adt.Fill(dt);
            if (dt.Rows.Count > 0)
            {

                Response.Write("<script>alert('you are already registerd please login')</script>");


            }
            else


            cmd1.ExecuteNonQuery();


            txtfullname.Text = "";
            txtaddress.Text = "";
            txtdob.Text = "";
            txtemail.Text = "";
            txtphone.Text = "";
            txtusername.Text = "";
        }      

    }
    protected void btnreset_Click(object sender, EventArgs e)
    {

        txtfullname.Text = "";
        txtaddress.Text = "";
        txtdob.Text = "";
        txtemail.Text = "";
        txtusername.Text = "";
  //      txtpassword.Text = "";
     //   txtcpassword.Text = "";

    }
}