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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            
            string username = textBoxUser.Text;
            string password = textBoxPass.Text;

            SqlConnection con = DBSQLServerUtils.GetDBConnection(username, password); ;
            try
            {
                con.Open();
                MessageBox.Show("Connection successful!", "Notify", MessageBoxButtons.OK);
                
                //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-MGN3IP8\\MSSQLSERVER01; Initial Catalog=" + comboBoxDataBase.Text + "; Integrated Security=True");
                //connection.Open();
                //DataTable schema = con.GetSchema("Tables");
                //foreach (DataRow row in schema.Rows)
                //{
                //    comboBoxTable.Items.Add(row[2].ToString());
                //}
                //connection.Close();
                //panel1.Enabled = true;
                //comboBoxTable.SelectedItem = null;
                //comboBoxTable.SelectedText = "------select------";
            }
            catch (Exception E)
            {
                MessageBox.Show("Error: " + E.Message, "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (radioButtonKh.Checked == true)
            {
                MainFormCustomer f = new MainFormCustomer();
                f.Show();
            }
            else if (radioButtonNv.Checked == true)
            {
                MainFormAdmin f = new MainFormAdmin();
                f.Show();
            }
        }
    }
}
