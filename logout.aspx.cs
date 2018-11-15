using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;


public partial class logout : System.Web.UI.Page
{
    protected void Page_Init(object Sender, EventArgs e)
    {
        //Response.Cache.SetCacheability(HttpCacheability.NoCache);
        //Response.Cache.SetExpires(DateTime.Now.AddDays(-1));
        //Session["username"] = string.Empty;
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["username"] = "";
        //Response.Buffer = true;
        //Response.Cache.SetExpires(DateTime.Now.AddDays(-1));
        //Response.Expires = 0;
        //Response.CacheControl = "no-cache";
        //Response.Redirect("~/home.aspx");


        //Session["username"] = null;
        //Session.Abandon();
        //Response.Cache.SetCacheability(HttpCacheability.NoCache);
        //Response.Cache.SetExpires(DateTime.Now.AddDays(-1));
        //Response.Cache.SetNoStore();
        /* Ends here */

        //if (Session["username"] == null)
        //    Response.Redirect("~/home.aspx");
    }
    //protected void Timer1_Tick1(object sender, EventArgs e)
    //{
    //    string redirectUrl = FormsAuthentication.LoginUrl + "?ReturnUrl=~/home.aspx";
    //    FormsAuthentication.SignOut();
    //    Response.Redirect("~/home.aspx");
    //}
    protected void Timer1_Tick(object sender, EventArgs e)
    {
        //Session.Clear();
        //Session.Abandon();
        Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(-1));
        Response.Cache.SetCacheability(HttpCacheability.NoCache);
        Response.Cache.SetNoStore();

        try
        {
            //Session.Abandon();
            FormsAuthentication.SignOut();
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Buffer = true;
            Response.ExpiresAbsolute = DateTime.Now.AddDays(-1d);
            Response.Expires = -1000;
            Response.CacheControl = "no-cache";
            //Response.Redirect("login.aspx", true);
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
        Response.Redirect("home.aspx");
    }
}