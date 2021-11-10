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
    public partial class ListCustomer : Form
    {
        public ListCustomer()
        {
            InitializeComponent();
        }

        private void ListCustomer_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM users");
            fillGrid(command);
        }

        public void fillGrid(SqlCommand command)
        {
            dataGridViewListCustomer.DataSource = DBSQLServerUtils.getTable(command);
            dataGridViewListCustomer.ReadOnly = true;
            dataGridViewListCustomer.RowTemplate.Height = 30;
        }

        private void dataGridViewListCustomer_Click(object sender, EventArgs e)
        {
            labelUserId.Text = dataGridViewListCustomer.CurrentRow.Cells[0].Value.ToString();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EditCustomer f = new EditCustomer();
            f.textBoxUserName.Text = labelUserId.Text;
            f.ShowDialog();
        }
    }
}
