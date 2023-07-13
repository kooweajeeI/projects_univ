// (C) 정경환(khjung2053@gmail.com)
// Ver 2.0.1 - 2019.5.2.
// charset: utf-8

//using System.Data.SqlClient;
using System.Data;
using System.Data.OleDb;

// for ASP.NET
//using System.Web.Configuration;  

// ----------------------------------------------------------------------------------------------------------------------
// ASP.NET - web.config
//  ...
//  </system.web>
//
//  <connectionStrings>
//    <add name = "haksa" connectionString="Provider=Microsoft.JET.OLEDB.4.0;Data Source=|DataDirectory|\학사2019.db" />
//  </connectionStrings>
// ----------------------------------------------------------------------------------------------------------------------

public class DBConn
{
   // string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=member.accdb";
     string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=member.mdb";

    // for ASP.NET
	//string connectionString = WebConfigurationManager.ConnectionStrings["haksa"].ConnectionString;  // for ASP.NET

    public OleDbConnection conn;

    public DBConn()
    {
        conn = new OleDbConnection(connectionString);
        conn.Open();
    }

    public void Close()
    {
        conn.Close();
    }

    public OleDbConnection GetConn()
    {
        return conn;
    }

    public void ExecuteNonQuery(string sql)
    {
        OleDbCommand cmd = new OleDbCommand(sql, conn);
        cmd.ExecuteNonQuery();
    }

    public OleDbDataReader ExecuteReader(string sql)
    {
        OleDbCommand cmd = new OleDbCommand(sql, conn);
        return cmd.ExecuteReader();
    }

    public object ExecuteScalar(string sql)
    {
        OleDbCommand cmd = new OleDbCommand(sql, conn);
        return cmd.ExecuteScalar();
    }
}