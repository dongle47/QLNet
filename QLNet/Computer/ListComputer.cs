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
        computer com = new computer();
        private void textBoxkeyboard_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListComputer_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM area");
            comboBoxArea.DataSource = DBSQLServerUtils.getTable(command);
            comboBoxArea.DisplayMember = "areaName";
            comboBoxArea.ValueMember = "areaId";
            comboBoxArea.SelectedIndex = 0;

            SqlCommand command1 = new SqlCommand("SELECT * FROM computerInfo");
            fillGrid(command1);
        }

        public void fillGrid(SqlCommand command)
        {
            dataGridView1.DataSource = DBSQLServerUtils.getTable(command);
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 30;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxId.Text);
            string des = textBoxDescript.Text;
            int idArea = Convert.ToInt32(comboBoxArea.SelectedValue.ToString());
            string processor = textBoxProcessor.Text;
            string monitor = textBoxMonitor.Text;
            string keyboard = textBoxkeyboard.Text;
            string headphone = textBoxHeadphone.Text;

            try
            {
                if (com.insert(id, des, idArea, processor, monitor, keyboard, headphone))
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
            SqlCommand command = new SqlCommand("SELECT * FROM computerInfo");
            fillGrid(command);

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            if ((MessageBox.Show("Are You Sure You Want To Delete This Worker", "Delete Worker", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                if (com.delete(id))
                {
                    MessageBox.Show("Worker Deleted", "Delete Worker", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Worker Not Deleted", "Delete Worker", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            SqlCommand command = new SqlCommand("SELECT * FROM computerInfo");
            fillGrid(command);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EditComputer f = new EditComputer();
            f.labelId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            f.labelidArea.Text = (comboBoxArea.SelectedValue.ToString());
            f.textBoxMonitor.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            f.textBoxProcessor.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            f.textBoxkeyboard.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            f.textBoxHeadphone.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            f.textBoxDescrip.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            f.ShowDialog();
        }
    }
}
