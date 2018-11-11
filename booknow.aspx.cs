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



public partial class booknow : System.Web.UI.Page
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
        SqlCommand cmd1 = new SqlCommand("sp_addfood", obj.con);
        cmd1.CommandType = CommandType.StoredProcedure;
        cmd1.Parameters.Add("@flag", 4);
        cmd1.Parameters.Add("@food_id",Request.QueryString["id"].ToString());
        DataTable dt = new DataTable();
        SqlDataAdapter dtadt = new SqlDataAdapter(cmd1);
        dtadt.Fill(dt);

        if( dt.Rows.Count>0)
        {

            HtmlImage img = new HtmlImage();
            img.Attributes.Add("class", "");
            img.Style.Add(HtmlTextWriterStyle.Display, "block");
            img.Style.Add(HtmlTextWriterStyle.Height, "166px");
            img.Style.Add(HtmlTextWriterStyle.Width, "278px");
            img.Src = dt.Rows[0][2].ToString();
            Panel1.Controls.Add(new LiteralControl("<table runat=server>"));
            Panel1.Controls.Add(new LiteralControl("<tr><td>"));
            Panel1.Controls.Add(img);
            Panel1.Controls.Add(new LiteralControl("</td></tr>"));
            Panel1.Controls.Add(new LiteralControl("<tr><td>Food Name</td><td>" + dt.Rows[0][1].ToString()));
            Panel1.Controls.Add(new LiteralControl("</td></tr>"));
            Panel1.Controls.Add( new LiteralControl("<tr><td> Food Description</td><td>"+ dt.Rows[0][3].ToString()));
            Panel1.Controls.Add(new LiteralControl("</td></tr>"));
            Panel1.Controls.Add(new LiteralControl("<tr><td>Food Cost</td><td>" + dt.Rows[0][4].ToString()));
            Panel1.Controls.Add(new LiteralControl("</td></tr>"));
            Panel1.Controls.Add(new LiteralControl("</table>"));
            ViewState["qty"] = dt.Rows[0][5].ToString();
            ViewState["amt"] = dt.Rows[0][4].ToString();
        }

       
        
    } 
    public void quantity(object sender, EventArgs e)
    {
        if(Int32.Parse(txtquantity.Text)>Int32.Parse(ViewState["qty"].ToString()))
        {
            Response.Write("<script>alert('Food Item Not Available')</script>");
        }
    }
    public void calculate(object sender, EventArgs e)
    {
        int a = Int32.Parse(txtquantity.Text) * Int32.Parse(ViewState["amt"].ToString());
        lbltamt.Text = a.ToString();
    }

    public void btnbooknow_Click(object sender, EventArgs e)
    {

        Class1 obj = new Class1();
        obj.getconnection();
        SqlCommand cmd1 = new SqlCommand("sp_booking", obj.con);
        cmd1.CommandType = CommandType.StoredProcedure;
        cmd1.Parameters.Add("@flag", 1);
        cmd1.Parameters.Add("@username",Session["username"].ToString() );
        cmd1.Parameters.Add("@food_id",Request.QueryString["id"].ToString());
        cmd1.Parameters.Add("@foodquantity", txtquantity.Text);
        cmd1.Parameters.Add("@status", 0);
        cmd1.Parameters.Add("@delivery", "not delivered");
        cmd1.ExecuteNonQuery();
        update_qty();
        Response.Write("<script>alert('Booking Successful')</script>");
        txtquantity.Text = "";
        lbltamt.Text = "";
    }
    protected void update_qty()
    {
        int qnty = Int32.Parse(ViewState["qty"].ToString()) - Int32.Parse(txtquantity.Text);
        Class1 obj = new Class1();
        obj.getconnection();

        SqlCommand cmd1 = new SqlCommand("sp_addfood", obj.con);
        cmd1.CommandType = CommandType.StoredProcedure;
        cmd1.Parameters.Add("@flag", 5);
        cmd1.Parameters.Add("@food_id", Request.QueryString["id"].ToString());
        cmd1.Parameters.Add("@foodquantity", qnty);
        cmd1.ExecuteNonQuery();
    }
    public void btncart_Click(object sender, EventArgs e)
    {


        Class1 obj = new Class1();
        obj.getconnection();
        SqlCommand cmd1 = new SqlCommand("sp_booking", obj.con);
        cmd1.CommandType = CommandType.StoredProcedure;
        cmd1.Parameters.Add("@flag", 1);
        cmd1.Parameters.Add("@username", Session["username"].ToString());
        cmd1.Parameters.Add("@food_id", Request.QueryString["id"].ToString());
        cmd1.Parameters.Add("@foodquantity", txtquantity.Text);
        cmd1.Parameters.Add("@status", 1);
        cmd1.Parameters.Add("@delivery", "not delivered");
        cmd1.ExecuteNonQuery();
        Response.Write("<script>alert('Added to Your Wishlist')</script>");
        txtquantity.Text = "";
        lbltamt.Text = "";

    }
}