using System.Data;
using System.Data.OleDb;

namespace BookDBConn_OleDb
{
    class BookDBConn
    {
        //string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\temp\학사2019.accdb";
        string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=book.mdb";

        // for ASP.NET
        //string connectionString = WebConfigurationManager.ConnectionStrings["haksa"].ConnectionString;

        public OleDbConnection conn;

        public BookDBConn()
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
        public DataSet GetDataSet(string sql)
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            adapter.SelectCommand = new OleDbCommand(sql, conn);

            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds;
        }
    }
}
