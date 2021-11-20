using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNet
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        MyDB db = new MyDB();

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string database = comboBoxDataBase.SelectedItem.ToString();
            string username = textBoxUser.Text;
            string password = textBoxPass.Text;

            SqlConnection con = DBSQLServerUtils.GetDBConnection(database, username, password); ;
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM users WHERE userUsername=@id AND userPassword=@Pass AND userRole='ad'", db.getConnection);
                command.Parameters.Add("@id", SqlDbType.NVarChar).Value = textBoxUser.Text;
                command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = textBoxPass.Text;
                DataTable tableAd = DBSQLServerUtils.getTable(command);

                if (tableAd.Rows.Count > 0)
                {
                    string userId = tableAd.Rows[0][0].ToString();
                    MainFormAdmin f = new MainFormAdmin();
                    f.labelUsername.Text = userId;
                    f.Show();
                }
                else
                {
                    command = new SqlCommand("SELECT * FROM users WHERE userUsername=@id AND userPassword=@Pass AND userRole='kh'", db.getConnection);
                    command.Parameters.Add("@id", SqlDbType.NVarChar).Value = textBoxUser.Text;
                    command.Parameters.Add("@Pass", SqlDbType.NVarChar).Value = textBoxPass.Text;
                    DataTable tableKh = DBSQLServerUtils.getTable(command);

                    if (tableKh.Rows.Count > 0)
                    {
                        string userId = tableKh.Rows[0][0].ToString();
                        MainFormCustomer f = new MainFormCustomer();
                        f.labelId.Text = userId;
                        f.Show();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

            }
            catch (Exception E)
            {
                MessageBox.Show("Error: " + E.Message, "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            textBoxPass.PasswordChar = '*';

            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-MGN3IP8\\MSSQLSERVER01; Initial Catalog=QLThuVien; Integrated Security=True");

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT name FROM master.sys.databases";

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            DataTable table = dataset.Tables[0];
            for (int i = 0; i < dataset.Tables[0].Rows.Count; i++)
            {
                comboBoxDataBase.Items.Add(dataset.Tables[0].Rows[i][0].ToString());
                connection.Close();
            }
            comboBoxDataBase.SelectedItem = "QLNet";
        }

    }
}
