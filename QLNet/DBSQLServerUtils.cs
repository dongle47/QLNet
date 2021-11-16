using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNet
{
    class DBSQLServerUtils
    {
        public static SqlConnection
        //GetDBConnection(string datasource, string database, string username, string password)
        //{
        //    string connString = "Data Source=" + datasource + ";Initial Catalog="
        //                + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;
        //    SqlConnection conn = new SqlConnection(connString);
        //    return conn;
        //}
        GetDBConnection(string username, string password)
        {
            string connString = "Data Source = localhost; Initial Catalog= QLNet; "
                         + "Persist Security Info=True;User ID=" + username + ";Password=" + password;
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }

        //public void openConnection()
        //{
        //    SqlCommand con = DBSQLServerUtils.GetDBConnection(); 
        //    if (conn.State == System.Data.ConnectionState.Closed)
        //    {
        //        con.Open();
        //    }
        //}
        //public void closeConnection()
        //{
        //    if (con.State == System.Data.ConnectionState.Open)
        //    {
        //        con.Close();
        //    }
        //}

        public static DataTable getTable(SqlCommand command)
        {
            command.Connection = new SqlConnection("Data Source=localhost; Initial Catalog=QLNet; Integrated Security=True");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
