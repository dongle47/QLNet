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
            DateTime d1 = dateTimePickerNBD.Value;
            DateTime d2 = dateTimePickerNKT.Value;

            SqlCommand command = new SqlCommand("SELECT * FROM check_History(@d1, @d2)");
            command.Parameters.Add("@d1", SqlDbType.DateTime).Value = d1;
            command.Parameters.Add("@d2", SqlDbType.DateTime).Value = d2;
            fillGrid(command);
        }
    }
}
