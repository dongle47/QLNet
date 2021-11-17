using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNet
{
    class Customer
    {
        MyDB mydb = new MyDB();

        public bool insertCustomer(string userName, string password, string name, string email, string phone, string cmnd, DateTime dateOfBirth)
        {
            
            
            SqlCommand command = new SqlCommand("EXEC dbo.insert_kh @userName, @password, @name, @phone, @email, @cmnd, @dateOfBirth", mydb.getConnection);

            command.Parameters.Add("@userName", SqlDbType.NVarChar).Value = userName;
            command.Parameters.Add("@password", SqlDbType.NVarChar).Value = password;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
            command.Parameters.Add("@cmnd", SqlDbType.NVarChar).Value = cmnd;
            command.Parameters.Add("@dateOfBirth", SqlDbType.DateTime).Value = dateOfBirth;

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
        
        public bool deleteCustomer(string userName)
        {
            SqlCommand command = new SqlCommand("EXEC dbo.deleteUserCurMoneyCus @userName", mydb.getConnection);
            command.Parameters.Add("@userName", SqlDbType.NVarChar).Value = userName;
            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
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
