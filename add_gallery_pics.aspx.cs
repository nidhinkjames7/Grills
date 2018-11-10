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

public partial class add_gallery_pics : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnaddimage_Click(object sender, EventArgs e)
    {

        String filename = Path.Combine(Server.MapPath("~/gallery images/"), FileUpload1.FileName);
        Class1 obj = new Class1();
        obj.getconnection();
        SqlCommand cmd = new SqlCommand("sp_gallery", obj.con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@flag", 0);
        cmd.Parameters.Add("@foodname", txtfoodnameGallery.Text);
        cmd.Parameters.Add("@foodimage", filename);
         cmd.ExecuteNonQuery();
        Response.Write("<script>alert('Inserted Successfully')</script>");

        txtfoodnameGallery.Text = "";


    }

}