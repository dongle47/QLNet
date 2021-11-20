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
        customer kh = new customer();
        private void GoiMonForm_Load(object sender, EventArgs e)
        {
            string commandStr = "SELECT * FROM menu";
            SqlCommand command = new SqlCommand(commandStr);
            fillGridMenu(command);
        }
        public void fillGridBill(SqlCommand command)
        {
            dataGridViewBill.DataSource = DBSQLServerUtils.getTable(command);
            dataGridViewBill.ReadOnly = true;
            dataGridViewBill.RowTemplate.Height = 30;
        }
        public void fillGridMenu(SqlCommand command)
        {
            dataGridViewMenu.DataSource = DBSQLServerUtils.getTable(command);
            dataGridViewMenu.ReadOnly = true;
            dataGridViewMenu.RowTemplate.Height = 30;
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            int foodId =Convert.ToInt32( dataGridViewMenu.CurrentRow.Cells[0].Value);
            int billId =Convert.ToInt32( labelIdBill.Text);
            
            try
            {
                if (kh.goiMon(billId, foodId))
                {
                    MessageBox.Show("Đã thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đã thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            SqlCommand command = new SqlCommand("EXEC infoListFoodByIdBill @billId = @id ");
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = labelIdBill.Text;
            fillGridBill(command);

            command = new SqlCommand("EXEC infoBillById @billId = @bid");
            command.Parameters.Add("@bid", SqlDbType.NVarChar).Value = labelIdBill.Text;
            DataTable table = DBSQLServerUtils.getTable(command);
            labelTotal.Text = "Tổng cộng: " + table.Rows[0][4].ToString();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            int billId = Convert.ToInt32(labelIdBill.Text);
            try
            {
                if (kh.xacNhanGoiMon(billId))
                {
                    MessageBox.Show("Đã xác nhận", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đã xác nhận", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
