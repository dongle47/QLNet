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
    public partial class BillForm : Form
    {
        public BillForm()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("");
            if(textBoxSearch.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int id = Convert.ToInt32( textBoxSearch.Text);
                command = new SqlCommand("EXEC infoBillById @billId = @id");
                command.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
                fillGridBill(command);

                command = new SqlCommand("EXEC infoListFoodByIdBill @billId = @id");
                command.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
                fillGridFood(command);
            }
        }
        public void fillGridBill(SqlCommand command)
        {
            dataGridViewBIll.DataSource = DBSQLServerUtils.getTable(command);
            dataGridViewBIll.ReadOnly = true;
            dataGridViewBIll.RowTemplate.Height = 30;
        }
        public void fillGridFood(SqlCommand command)
        {
            dataGridViewFood.DataSource = DBSQLServerUtils.getTable(command);
            dataGridViewFood.ReadOnly = true;
            dataGridViewFood.RowTemplate.Height = 30;
        }


    }
}
