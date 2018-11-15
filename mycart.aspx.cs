using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Windows.Markup;
using System.Net;
using System.Web.UI.HtmlControls;
using System.Configuration;
using System.Text;
public partial class mycart : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["username"].ToString() == "")
        {
            Response.Redirect("~/home.aspx");
        }

        Panel1.Controls.Add(new LiteralControl("<table style=width:100%>"));
        Panel1.Controls.Add(new LiteralControl("<tr>"));
        Class1 obj = new Class1();
        obj.getconnection();
        SqlCommand cmd1 = new SqlCommand("sp_booking", obj.con);
        cmd1.CommandType = CommandType.StoredProcedure;
        cmd1.Parameters.Add("@flag", 2);
        cmd1.Parameters.Add("@username",Session["username"].ToString());
        DataTable dt = new DataTable();
        SqlDataAdapter dtadt = new SqlDataAdapter(cmd1);
        dtadt.Fill(dt);
        int c = 0;
        Panel1.Controls.Add(new LiteralControl("<table style=width:100%>"));
        Panel1.Controls.Add(new LiteralControl("<tr>"));
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            if (c < 4)
            {
                c++;
            }

            else
            {
                Panel1.Controls.Add(new LiteralControl("</td></tr>"));
                Panel1.Controls.Add(new LiteralControl("<tr>"));
                c = 0;
            }
            SqlCommand cmd2 = new SqlCommand("sp_addfood", obj.con);
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Parameters.Add("@flag", 4);
            cmd2.Parameters.Add("@food_id", dt.Rows[i][2].ToString());
            DataTable dt2 = new DataTable();
            SqlDataAdapter dtadt2 = new SqlDataAdapter(cmd2);
            dtadt2.Fill(dt2);

            if (dt2.Rows.Count > 0)
            {
                //Button bt = new Button();
                //bt.Text = "Book Now";
                //bt.ID = dt.Rows[i][0].ToString();
                //bt.Click += new EventHandler(bt_Click);
                //Button bt1 = new Button();
                HtmlImage img = new HtmlImage();
                img.Attributes.Add("class", "");
                img.Style.Add(HtmlTextWriterStyle.Display, "block");
                img.Style.Add(HtmlTextWriterStyle.Height, "166px");
                img.Style.Add(HtmlTextWriterStyle.Width, "278px");
                img.Src = dt2.Rows[0][2].ToString();
                Panel1.Controls.Add(new LiteralControl("<td><table runat=server>"));
                Panel1.Controls.Add(new LiteralControl("<tr><td>"));
                Panel1.Controls.Add(img);
                Panel1.Controls.Add(new LiteralControl("</td></tr>")); Panel1.Controls.Add(new LiteralControl("</td></tr>"));
                Panel1.Controls.Add(new LiteralControl("<tr><td>Food Name</td><td>" + dt2.Rows[0][1].ToString()));
                Panel1.Controls.Add(new LiteralControl("</td></tr>"));
                Panel1.Controls.Add(new LiteralControl("<tr><td> Food Description</td><td>" + dt2.Rows[0][3].ToString()));
                Panel1.Controls.Add(new LiteralControl("</td></tr>"));
                Panel1.Controls.Add(new LiteralControl("<tr><td>Food Cost</td><td>" + dt2.Rows[0][4].ToString()));
                Panel1.Controls.Add(new LiteralControl("</td></tr>"));
                Panel1.Controls.Add(new LiteralControl("<tr><td>"));

                Panel1.Controls.Add(new LiteralControl("<tr><td>Food Quantity </td><td>" + dt.Rows[i][3].ToString()));
                Panel1.Controls.Add(new LiteralControl("</td></tr>"));
                Panel1.Controls.Add(new LiteralControl("<tr><td>"));
                Panel1.Controls.Add(new LiteralControl("<a href=Default2.aspx?id=" + dt.Rows[i][0].ToString() + "&id1=1>"));
                

                Panel1.Controls.Add(new LiteralControl("Book</a>"));
                Panel1.Controls.Add(new LiteralControl("</td></tr>"));
                Panel1.Controls.Add(new LiteralControl("<tr><td>"));
                Panel1.Controls.Add(new LiteralControl("<a href=Default2.aspx?id=" + dt.Rows[i][0].ToString() + "&id1=2>"));
                
                Panel1.Controls.Add(new LiteralControl("Delete</a>"));
                Panel1.Controls.Add(new LiteralControl("</td></tr>"));
                Panel1.Controls.Add(new LiteralControl("</table></td>"));

            }
        }
        Panel1.Controls.Add(new LiteralControl("</tr>"));
        Panel1.Controls.Add(new LiteralControl("</table>"));
    }

    //private void bt1_Click(object sender, EventArgs e)
    //{
    //    throw new NotImplementedException();
    //    Class1 obj = new Class1();
    //    obj.getconnection();
    //    SqlCommand cmd1 = new SqlCommand("sp_booking", obj.con);
    //    cmd1.CommandType = CommandType.StoredProcedure;
    //    cmd1.Parameters.Add("@flag", 3);

    //    cmd1.Parameters.Add("@book_id", sender.ToString());
    //    cmd1.ExecuteNonQuery();
            
    //}

    //private void bt_Click(object sender, EventArgs e)
    //{
    //    Class1 obj = new Class1();
    //    obj.getconnection();
    //    SqlCommand cmd1 = new SqlCommand("sp_booking", obj.con);
    //    cmd1.CommandType = CommandType.StoredProcedure;
    //    cmd1.Parameters.Add("@flag", 4);

    //    cmd1.Parameters.Add("@book_id", );
    //    cmd1.ExecuteNonQuery();
    //}
}