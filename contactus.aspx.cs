using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class contactus : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public void btncontact_Click(object sender,EventArgs e)
    {
        Class1 obj = new Class1();
        obj.getconnection();

        SqlCommand cmd1 = new SqlCommand("sp_contactus", obj.con);
        cmd1.CommandType = CommandType.StoredProcedure;
        cmd1.Parameters.Add("@flag", 0);

        cmd1.Parameters.Add("@name", name.Text);
        cmd1.Parameters.Add("@email", email.Text);
        cmd1.Parameters.Add("@subject", subject.Text);
        cmd1.Parameters.Add("@message", message.Text);
        Response.Write("<script>alert('Message Send')</script>");
    }
}