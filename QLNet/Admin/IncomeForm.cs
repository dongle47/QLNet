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
    public partial class IncomeForm : Form
    {
        public IncomeForm()
        {
            InitializeComponent();
        }

        private void IncomeForm_Load(object sender, EventArgs e)
        {
            radioButtonAll.Checked = true;
            radioButtonNo.Checked = true;
            SqlCommand command = new SqlCommand("SELECT * FROM income");
            fillGrid(command);
        }
        public void fillGrid(SqlCommand command)
        {
            dataGridView2.DataSource = DBSQLServerUtils.getTable(command);
            dataGridView2.ReadOnly = true;
            dataGridView2.RowTemplate.Height = 30;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if(radioButtonNo.Checked == true)
            {
                if(radioButtonAll.Checked == true)
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM income");
                    fillGrid(command);
                }
                if(radioButtonFood.Checked == true)
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM income WHERE incomeType = 'doan'");
                    fillGrid(command);
                }
                if(radioButtonMoney.Checked == true)
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM income WHERE incomeType ='naptien'");
                    fillGrid(command);
                }
            }
            else if(radioButtonYes.Checked == true)
            {
                DateTime d1 = dateTimePickerNBD.Value;
                DateTime d2 = dateTimePickerNKT.Value;

                string commandString = "";
                if(radioButtonAll.Checked == true)
                {
                    commandString = "SELECT * FROM check_Income_By_Date_All(@d1, @d2)";
                }
                else if(radioButtonFood.Checked == true)
                {
                    commandString = "SELECT * FROM check_Income_By_Date_doan(@d1, @d2)";
                }
                else if(radioButtonMoney.Checked == true)
                {
                    commandString = "SELECT * FROM check_Income_By_Date_naptien(@d1, @d2)";
                }

                SqlCommand command = new SqlCommand(commandString);
                command.Parameters.Add("@d1", SqlDbType.DateTime).Value = d1;
                command.Parameters.Add("@d2", SqlDbType.DateTime).Value = d2;
                fillGrid(command);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
