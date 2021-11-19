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
        customer kh = new customer();
        private void ListCustomer_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM customerList");
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
            f.textBoxPass.Text = dataGridViewListCustomer.CurrentRow.Cells[1].Value.ToString();
            f.textBoxFullName.Text = dataGridViewListCustomer.CurrentRow.Cells[2].Value.ToString();
            f.textBoxPhone.Text = dataGridViewListCustomer.CurrentRow.Cells[3].Value.ToString();
            f.textBoxEmail.Text = dataGridViewListCustomer.CurrentRow.Cells[4].Value.ToString();
            f.textBoxCMND.Text = dataGridViewListCustomer.CurrentRow.Cells[5].Value.ToString();
            f.dateTimePicker1.Value = (DateTime)dataGridViewListCustomer.CurrentRow.Cells[6].Value;
            f.ShowDialog();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string id = textBoxUserName.Text;
            string pass = textBoxPass.Text;
            string name = textBoxFullName.Text;
            string phone = textBoxPhone.Text;
            string mail = textBoxEmail.Text;
            string cmnd = textBoxEmail.Text;
            DateTime birth = dateTimePicker1.Value;

            try
            {
                if (kh.insert(id, pass, name, phone, mail, cmnd, birth))
                {
                    MessageBox.Show("Information Updated", "Edit Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Edit Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Edit Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            SqlCommand command = new SqlCommand("SELECT * FROM customerList");
            fillGrid(command);
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            string id = labelUserId.Text;
            if ((MessageBox.Show("Are You Sure You Want To Delete This Worker", "Delete Worker", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                if (kh.delete(id))
                {
                    MessageBox.Show("Worker Deleted", "Delete Worker", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Worker Not Deleted", "Delete Worker", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            SqlCommand command = new SqlCommand("SELECT * FROM customerList");
            fillGrid(command);
        }
    }
}
