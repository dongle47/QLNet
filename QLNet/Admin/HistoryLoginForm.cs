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
    public partial class HistoryLoginForm : Form
    {
        public HistoryLoginForm()
        {
            InitializeComponent();
        }

        private void HistoryLoginForm_Load(object sender, EventArgs e)
        {
            radioButtonDateNo.Checked = true;
            radioButtonUserNo.Checked = true;
            SqlCommand command = new SqlCommand("SELECT * FROM userLoginInfo");
            fillGrid(command);
        }
        public void fillGrid(SqlCommand command)
        {
            dataGridView1.DataSource = DBSQLServerUtils.getTable(command);
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 30;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            DateTime d1 = dateTimePickerNBD.Value;
            DateTime d2 = dateTimePickerNKT.Value;
            if (radioButtonUserYes.Checked == true)
            {
                string id = textBoxUser.Text;
                if(radioButtonDateYes.Checked == true)
                {
                    if(textBoxUser.Text != "" || textBoxUser != null)
                    {
                        command = new SqlCommand("select * from check_History_By_Date_And_Id (@id, @d1, @d2)");
                        command.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
                        command.Parameters.Add("@d1", SqlDbType.DateTime).Value = d1;
                        command.Parameters.Add("@d2", SqlDbType.DateTime).Value = d2;
                        fillGrid(command);
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập Username", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if(radioButtonDateNo.Checked == true)
                {
                    if(textBoxUser.Text != "" || textBoxUser != null)
                    {
                        command = new SqlCommand("SELECT * FROM userHistory(@id)");
                        command.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
                        fillGrid(command);
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập Username", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else if(radioButtonUserNo.Checked == true)
            {
                if(radioButtonDateYes.Checked == true)
                {
                    command = new SqlCommand("SELECT * FROM check_History(@d1, @d2)");
                    command.Parameters.Add("@d1", SqlDbType.DateTime).Value = d1;
                    command.Parameters.Add("@d2", SqlDbType.DateTime).Value = d2;
                    fillGrid(command);
                }
                else if(radioButtonDateNo.Checked == true)
                {
                    command = new SqlCommand("SELECT * FROM userLoginInfo");
                    fillGrid(command);
                }
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButtonUserNo_CheckedChanged(object sender, EventArgs e)
        {
            textBoxUser.Enabled = false;
        }

        private void radioButtonUserYes_CheckedChanged(object sender, EventArgs e)
        {
            textBoxUser.Enabled = true;
        }
    }
}
