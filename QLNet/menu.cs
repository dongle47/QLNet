using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNet
{
    class menu
    {
        MyDB mydb = new MyDB();
        public bool insert(string name, int price)
        {
            SqlCommand command = new SqlCommand("EXEC insertMenu @foodName=@name, @foodPrice=@price", mydb.getConnection);
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@price", SqlDbType.Int).Value = price;
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

        public bool update(int id, string name, int price)
        {
            SqlCommand command = new SqlCommand("EXEC updateMenu @foodId=@id, @foodName=@name, @foodPrice=@price", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@price", SqlDbType.Int).Value = price;
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

        public bool delete(int id)
        {
            SqlCommand command = new SqlCommand("EXEC deleteMenu @foodId = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
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
