using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


public partial class foodpreview : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int c = 0;
        Panel1.Controls.Add(new LiteralControl("<table style=width:100%>"));

        Panel1.Controls.Add(new LiteralControl("<tr>"));
        Class1 obj = new Class1();
        obj.getconnection();
        SqlCommand cmd1 = new SqlCommand("sp_registration", obj.con);
        cmd1.CommandType = CommandType.StoredProcedure;
        cmd1.Parameters.Add("@flag", 3);
        DataTable dt = new DataTable();
        SqlDataAdapter dtadt = new SqlDataAdapter(cmd1);
        dtadt.Fill(dt);
        for(int i=0;i<dt.Rows.Count;i++)
        {
            
            Panel1.Controls.Add(new LiteralControl("<td>"))
        }
    }
}