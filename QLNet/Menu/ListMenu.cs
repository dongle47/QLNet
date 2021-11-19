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
    public partial class ListMenu : Form
    {
        public ListMenu()
        {
            InitializeComponent();
        }
        menu menu = new menu();
        private void ListMenu_Load(object sender, EventArgs e)
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxFoodName.Text;
            int price = Convert.ToInt32( textBoxPrice.Text);
            try
            {
                if (menu.insert(name, price))
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
            SqlCommand command = new SqlCommand("SELECT * FROM menu");
            fillGrid(command);

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EditMenu f = new EditMenu();
            f.labelId.Text = dataGridViewMenu.CurrentRow.Cells[0].Value.ToString();
            f.textBoxFoodName.Text = dataGridViewMenu.CurrentRow.Cells[1].Value.ToString();
            f.textBoxPrice.Text = dataGridViewMenu.CurrentRow.Cells[2].Value.ToString();
            f.ShowDialog();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32( dataGridViewMenu.CurrentRow.Cells[0].Value);
            if ((MessageBox.Show("Are You Sure You Want To Delete This Worker", "Delete Worker", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                if (menu.delete(id))
                {
                    MessageBox.Show("Worker Deleted", "Delete Worker", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Worker Not Deleted", "Delete Worker", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            SqlCommand command = new SqlCommand("SELECT * FROM menu");
            fillGrid(command);
        }
    }
}
