using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class updatefood : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

/*    protected void btnupdatefood_Click(object sender, EventArgs e)
    {

        String filename = Path.Combine(Server.MapPath("~/food images/"), FileUpload1.FileName);
        Class1 obj = new Class1();
        obj.getconnection();
        SqlCommand cmd = new SqlCommand("sp_addfood", obj.con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@flag", 2);
        cmd.Parameters.Add("@foodname", txtfoodname.Text);
        cmd.Parameters.Add("@foodimage", filename);
        cmd.Parameters.Add("@fooddesc", txtfooddesc.Text);
        cmd.Parameters.Add("@foodcost", txtfoodcost.Text);
        cmd.Parameters.Add("@foodquantity", txtfoodquantity.Text);
        cmd.ExecuteNonQuery();
        Response.Write("<script>alert('Updated Successfully')</script>");

        txtfoodname.Text = "";
        txtfooddesc.Text = "";
        txtfoodcost.Text = "";
        txtfoodquantity.Text = "";


    } */

}