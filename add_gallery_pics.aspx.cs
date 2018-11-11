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
    protected bool Check_Size()
    {
        System.Drawing.Image img = System.Drawing.Image.FromStream(FileUpload1.PostedFile.InputStream);
        decimal size = Math.Round(((decimal)FileUpload1.PostedFile.ContentLength / (decimal)1024), 2);
        if (size > 100)
        {
            return false;
        }
        else
            return true;
    }
    protected bool Check_dimension()
    {
        System.Drawing.Image img = System.Drawing.Image.FromStream(FileUpload1.PostedFile.InputStream);
        int height = img.Height;
        int width = img.Width;
        if (height > 100 || width > 100)
        {
            return false;
        }
        else
            return true;
    }


    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnaddimage_Click(object sender, EventArgs e)
    {

        String filename = Path.Combine(Server.MapPath("~/gallery images/"), FileUpload1.FileName);
        String strExtension = Path.GetExtension(FileUpload1.FileName);
        FileUpload1.SaveAs(filename);
        Class1 obj = new Class1();
        obj.getconnection();
        SqlCommand cmd = new SqlCommand("sp_gallery", obj.con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@flag", 0);
        cmd.Parameters.Add("@foodname", txtfoodnameGallery.Text);
        cmd.Parameters.Add("@foodimage", "~/gallery images/" + FileUpload1.FileName);
         cmd.ExecuteNonQuery();
        Response.Write("<script>alert('Inserted Successfully')</script>");
        txtfoodnameGallery.Text = "";


    }

}