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
        MyDB mydb = new MyDB();
        public static SqlConnection
        //GetDBConnection(string datasource, string database, string username, string password)
        //{
        //    string connString = "Data Source=" + datasource + ";Initial Catalog="
        //                + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;
        //    SqlConnection conn = new SqlConnection(connString);
        //    return conn;
        //}
        GetDBConnection(string database, string username, string password)
        {
            string connString = "Data Source = DESKTOP-MGN3IP8\\MSSQLSERVER01; Initial Catalog= "+database+"; "
                         + "Persist Security Info=True;User ID=" + username + ";Password=" + password;
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }

        public static DataTable getTable(SqlCommand command)
        {
            command.Connection = new SqlConnection("Data Source = localhost\\MSSQLSERVER01; Initial Catalog=QLNet; Integrated Security=True");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool changePassword(string id, string pass)
        {
            SqlCommand command = new SqlCommand("EXEC changePassUserSQL @customerId = @id, @newPass = @pass", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
            command.Parameters.Add("@pass", SqlDbType.NVarChar).Value = pass;
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
    }
}
