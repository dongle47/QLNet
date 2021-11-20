using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNet
{
    class admin
    {
        MyDB mydb = new MyDB();
        public bool searchLoginByDate(DateTime date1, DateTime date2)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM check_History(@d1, @d2)", mydb.getConnection);
            command.Parameters.Add("@d1", SqlDbType.DateTime).Value = date1;
            command.Parameters.Add("@d2", SqlDbType.DateTime).Value = date2;
            mydb.openConnection();
            if ((command.ExecuteNonQuery()) == 1)
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
