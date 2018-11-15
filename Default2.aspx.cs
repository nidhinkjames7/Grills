using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
         if(Request.QueryString["id1"].ToString()=="1")
         {
             updateqry();
             
         }
        else
         {
             delquery();
         }
         Response.Redirect("mycart.aspx");
    }
    protected void updateqry()
    {
        Class1 obj = new Class1();
        obj.getconnection();
        SqlCommand cmd1 = new SqlCommand("sp_booking", obj.con);
        cmd1.CommandType = CommandType.StoredProcedure;
        cmd1.Parameters.Add("@flag", 3);

        cmd1.Parameters.Add("@book_id", Request.QueryString["id"].ToString());
        cmd1.ExecuteNonQuery();
    }
    protected void delquery()
    {
        Class1 obj = new Class1();
            obj.getconnection();
            SqlCommand cmd1 = new SqlCommand("sp_booking", obj.con);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.Add("@flag", 4);

            cmd1.Parameters.Add("@book_id", Request.QueryString["id"].ToString());
            cmd1.ExecuteNonQuery();
    }
}