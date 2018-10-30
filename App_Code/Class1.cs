using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Class1
{
		//
		// TODO: Add constructor logic here
		//
        public SqlConnection con;
        public void getconnection()
        {
            String str= ConfigurationManager.ConnectionStrings["grillConnectionString"].ConnectionString;
            con=new SqlConnection(str);
            con.Open();
        }

}