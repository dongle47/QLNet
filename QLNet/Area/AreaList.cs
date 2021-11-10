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
    public partial class AreaList : Form
    {
        public AreaList()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AreaList_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM area");
            fillGrid(command);
        }

        public void fillGrid(SqlCommand command)
        {
            dataGridView1.DataSource = DBSQLServerUtils.getTable(command);
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 30;
        }
    }
}
