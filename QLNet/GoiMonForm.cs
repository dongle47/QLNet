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
    public partial class GoiMonForm : Form
    {
        public GoiMonForm()
        {
            InitializeComponent();
        }

        private void GoiMonForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM menu");
            fillGrid(command);
        }
        public void fillGrid(SqlCommand command)
        {
            dataGridViewMenu.DataSource = DBSQLServerUtils.getTable(command);
            dataGridViewMenu.ReadOnly = true;
            dataGridViewMenu.RowTemplate.Height = 30;
        }
    }
}
