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
    public partial class ListComputer : Form
    {
        public ListComputer()
        {
            InitializeComponent();
        }

        private void textBoxkeyboard_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListComputer_Load(object sender, EventArgs e)
        {

        }

        public void fillGrid(SqlCommand command)
        {
            dataGridView1.DataSource = DBSQLServerUtils.getTable(command);
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 30;
        }
    }
}
