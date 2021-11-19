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
    public partial class NapTienWindow : Form
    {
        public NapTienWindow()
        {
            InitializeComponent();
        }
        customer kh = new customer();
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NapTienWindow_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM curMoneyCus");
            fillGrid(command);
        }
        public void fillGrid(SqlCommand command)
        {
            dataGridView1.DataSource = DBSQLServerUtils.getTable(command);
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 30;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            labelId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void buttonNap_Click(object sender, EventArgs e)
        {
            string id = labelId.Text;
            int price = Convert.ToInt32(textBoxMoney.Text);
            try
            {
                if (kh.napTien(id, price))
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
            SqlCommand command = new SqlCommand("SELECT * FROM curMoneyCus");
            fillGrid(command);
        }
    }
}
