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

public partial class booknow : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Panel1.Controls.Add(new LiteralControl("<table style=width:100%>"));
        Panel1.Controls.Add(new LiteralControl("<tr>"));
        Class1 obj = new Class1();
        obj.getconnection();
        SqlCommand cmd1 = new SqlCommand("sp_addfood", obj.con);
        cmd1.CommandType = CommandType.StoredProcedure;
        cmd1.Parameters.Add("@flag", 4);
        cmd1.Parameters.Add("@food_id",Request.QueryString["id"].ToString());
        DataTable dt = new DataTable();
        SqlDataAdapter dtadt = new SqlDataAdapter(cmd1);
        dtadt.Fill(dt);

    } 
}