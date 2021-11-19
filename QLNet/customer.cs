using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNet
{
    class customer
    {
        MyDB mydb = new MyDB();
        public bool insert(string id, string pass, string name, string phone, string mail, string cmnd, DateTime birth)
        {
            SqlCommand command = new SqlCommand("EXEC dbo.insert_kh @id, @pass, @name, @phn, @mail, @cmnd, @birth", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
            command.Parameters.Add("@pass", SqlDbType.NVarChar).Value = pass;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@phn", SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("@mail", SqlDbType.NVarChar).Value = mail;
            command.Parameters.Add("@cmnd", SqlDbType.NVarChar).Value = cmnd;
            command.Parameters.Add("@birth", SqlDbType.DateTime).Value = birth;
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

        public bool update(string id, string pass, string name, string phone, string mail, string cmnd, DateTime birth)
        {
            SqlCommand command = new SqlCommand("EXEC dbo.update_kh @id, @pass, @name, @phn, @mail, @cmnd, @birth", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
            command.Parameters.Add("@pass", SqlDbType.NVarChar).Value = pass;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@phn", SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("@mail", SqlDbType.NVarChar).Value = mail;
            command.Parameters.Add("@cmnd", SqlDbType.NVarChar).Value = cmnd;
            command.Parameters.Add("@birth", SqlDbType.DateTime).Value = birth;
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

        public bool delete(string id)
        {
            SqlCommand command = new SqlCommand("EXEC deleteUserCurMoneyCus @customerId = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
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

        public bool napTien(string id, int price)
        {
            SqlCommand command = new SqlCommand("EXEC addMoneyToCustomer @cusId = @id, @price = @pr", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
            command.Parameters.Add("@pr", SqlDbType.NVarChar).Value = price;
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
