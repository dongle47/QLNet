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
        area kv = new area();
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxTenKv.Text;
            try
            {
                if (kv.insert(name))
                {
                    MessageBox.Show("Đã thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            SqlCommand command = new SqlCommand("SELECT * FROM area");
            fillGrid(command);
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            if ((MessageBox.Show("Bạn có chắc muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                if (kv.delete(id))
                {
                    MessageBox.Show("Đã xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không thể xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            SqlCommand command = new SqlCommand("SELECT * FROM area");
            fillGrid(command);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EditArea f = new EditArea();
            f.labelId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            f.textBoxName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            f.ShowDialog();
        }
    }
}
