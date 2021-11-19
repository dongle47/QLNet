using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNet
{
    class computer
    {
        MyDB mydb = new MyDB();
        public bool insert(int id, string des, int idArea, string processor, string monitor, string keyboard, string headphone)
        {
            SqlCommand command = new SqlCommand("EXEC dbo.insert_computer @id, @des, @idArea, " +
                "@processor, @monitor, @keyboard, @headphone", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@des", SqlDbType.NVarChar).Value = des;
            command.Parameters.Add("@idArea", SqlDbType.Int).Value = idArea;
            command.Parameters.Add("@processor", SqlDbType.NVarChar).Value = processor;
            command.Parameters.Add("@monitor", SqlDbType.NVarChar).Value = monitor;
            command.Parameters.Add("@keyboard", SqlDbType.NVarChar).Value = keyboard;
            command.Parameters.Add("@headphone", SqlDbType.NVarChar).Value = headphone;
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

        public bool update(int id, string des, int idArea, string processor, string monitor, string keyboard, string headphone)
        {
            SqlCommand command = new SqlCommand("EXEC dbo.update_computer @id, @des, @idArea, " +
                "@processor, @monitor, @keyboard, @headphone", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@des", SqlDbType.NVarChar).Value = des;
            command.Parameters.Add("@idArea", SqlDbType.Int).Value = idArea;
            command.Parameters.Add("@processor", SqlDbType.NVarChar).Value = processor;
            command.Parameters.Add("@monitor", SqlDbType.NVarChar).Value = monitor;
            command.Parameters.Add("@keyboard", SqlDbType.NVarChar).Value = keyboard;
            command.Parameters.Add("@headphone", SqlDbType.NVarChar).Value = headphone;
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
            SqlCommand command = new SqlCommand("EXEC dbo.delete_computer @comId = @id", mydb.getConnection);
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
