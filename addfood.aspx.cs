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

public partial class addfood : System.Web.UI.Page
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

        if (Session["username"].ToString() == "")
        {
            Response.Redirect("~/home.aspx");
        }

    }

 /*   protected void Button1_Click(object sender, EventArgs e)
    {
        if (FileUpload1.HasFile)
        {
            String filename = Path.Combine(Server.MapPath("~/foodimages/"), FileUpload1.FileName);
            String strExtension = Path.GetExtension(FileUpload1.FileName);
            if (strExtension == ".jpg" || strExtension == ".bmp" || strExtension == ".gif")
            {
                //if (Check_dimension() && Check_Size())
                // {
                FileUpload1.SaveAs(filename);

                Image1.ImageUrl = "~/foodimages/" + FileUpload1.FileName;
                ViewState["filepath"] = Image1.ImageUrl;
            }
            //    else
            //    {

        //       Response.Write("<script>alert('Select image with appropriate size ')</script>");

        //    }
            //     }
            else
            {
                Response.Write("<script>alert('Select a valid image')</script>");
            }

        }
        else
        {

            Response.Write("<script>alert('Upload image')</script>");

        }
    }

*/
    protected void btnaddfood_Click(object sender, EventArgs e)
    {

        String filename = Path.Combine(Server.MapPath("~/foodimages/"), FileUpload1.FileName);
        String strExtension = Path.GetExtension(FileUpload1.FileName);
        FileUpload1.SaveAs(filename);
        Class1 obj = new Class1();
        obj.getconnection();
        SqlCommand cmd = new SqlCommand("sp_addfood", obj.con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@flag", 0);
        cmd.Parameters.Add("@foodname", txtfoodname.Text);
        cmd.Parameters.Add("@foodimage", "~/foodimages/" + FileUpload1.FileName); 
        cmd.Parameters.Add("@fooddesc", txtfooddesc.Text);
        cmd.Parameters.Add("@foodcost", txtfoodcost.Text);
        cmd.Parameters.Add("@foodquantity", txtfoodquantity.Text);
        cmd.ExecuteNonQuery();
        Response.Write("<script>alert('Inserted Successfully')</script>");

        txtfoodname.Text = "";
        txtfooddesc.Text = "";
        txtfoodcost.Text = "";
        txtfoodquantity.Text = "";


    }
}