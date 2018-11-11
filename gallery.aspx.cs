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

public partial class gallery : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        int c = 0;
        Panel1.Controls.Add(new LiteralControl("<table style=width:100%>"));
        Panel1.Controls.Add(new LiteralControl("<tr>"));
        Class1 obj = new Class1();
        obj.getconnection();
        SqlCommand cmd1 = new SqlCommand("sp_gallery", obj.con);
        cmd1.CommandType = CommandType.StoredProcedure;
        cmd1.Parameters.Add("@flag", 1);
        DataTable dt = new DataTable();
        SqlDataAdapter dtadt = new SqlDataAdapter(cmd1);
        dtadt.Fill(dt);
        for(int i=0;i<dt.Rows.Count;i++)
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
                HtmlImage img = new HtmlImage();
                img.Attributes.Add("class", "");
                img.Style.Add(HtmlTextWriterStyle.Display, "block");
                img.Style.Add(HtmlTextWriterStyle.Height, "166px");
                img.Style.Add(HtmlTextWriterStyle.Width, "278px");
                img.Src = dt.Rows[i][2].ToString();
                Panel1.Controls.Add(new LiteralControl("<td><table runat=server>"));
                Panel1.Controls.Add(new LiteralControl("<tr><td>"));
                Panel1.Controls.Add(img);
                Panel1.Controls.Add(new LiteralControl("</a>"));
                Panel1.Controls.Add(new LiteralControl("</td></tr>"));
                Panel1.Controls.Add(new LiteralControl("<tr><td>" + dt.Rows[i][1].ToString()));
                Panel1.Controls.Add(new LiteralControl("</td></tr>"));
                Panel1.Controls.Add(new LiteralControl("</table>"));
                Panel1.Controls.Add(new LiteralControl("</td>"));               
        }
        Panel1.Controls.Add(new LiteralControl("</tr>"));
        Panel1.Controls.Add(new LiteralControl("</table>"));
    }

}