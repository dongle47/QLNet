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
            

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EditCustomer f = new EditCustomer();
            f.textBoxUserName.Text = labelUserId.Text;
            f.textBoxUserName.Text = dataGridViewListCustomer.CurrentRow.Cells[0].Value.ToString();
            f.textBoxPass.Text = dataGridViewListCustomer.CurrentRow.Cells[1].Value.ToString();
            f.textBoxFullName.Text = dataGridViewListCustomer.CurrentRow.Cells[2].Value.ToString();
            f.textBoxEmail.Text = dataGridViewListCustomer.CurrentRow.Cells[3].Value.ToString();
            f.textBoxPhone.Text = dataGridViewListCustomer.CurrentRow.Cells[4].Value.ToString();
            f.textBoxCMND.Text = dataGridViewListCustomer.CurrentRow.Cells[5].Value.ToString();
            f.dateTimePicker1.Value = Convert.ToDateTime(dataGridViewListCustomer.CurrentRow.Cells[8].Value);
            
            f.ShowDialog();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();

            string userName = textBoxUserName.Text;
            string password = textBoxPass.Text;
            string name = textBoxFullName.Text;
            string email = textBoxEmail.Text;
            string phone = textBoxPhone.Text;
            string cmnd = textBoxCMND.Text;
            DateTime bdate = dateTimePicker1.Value;

            customer.insertCustomer(userName, password, name, email, phone, cmnd, bdate);
        }

        private void dataGridViewListCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            string userName = dataGridViewListCustomer.CurrentRow.Cells[0].Value.ToString();
            customer.deleteCustomer(userName);

            SqlCommand command = new SqlCommand("SELECT * FROM users");
            fillGrid(command);
        }
    }
}
