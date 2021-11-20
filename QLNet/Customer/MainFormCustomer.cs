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
    public partial class MainFormCustomer : Form
    {
        public MainFormCustomer()
        {
            InitializeComponent();
        }
        MyDB db = new MyDB();
        private void xemThôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("EXEC infoCustomerById @username = @id", db.getConnection);
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = labelId.Text;
            DataTable table = DBSQLServerUtils.getTable(command);
            if (table.Rows.Count > 0)
            {
                InfoCustomer f = new InfoCustomer();
                f.textBoxUser.Text = table.Rows[0][0].ToString();
                f.textBoxName.Text = table.Rows[0][2].ToString();
                f.textBoxPhone.Text = table.Rows[0][3].ToString();
                f.textBoxEmail.Text = table.Rows[0][4].ToString();
                f.textBoxEmail.Text = table.Rows[0][4].ToString();
                f.textBoxCMND.Text = table.Rows[0][5].ToString();
                f.dateTimePickerNS.Value = (DateTime)table.Rows[0][6];
                f.textBoxMoney.Text = table.Rows[0][7].ToString();
                f.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gọiMónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand("EXEC createFoodBill @Id = @id", db.getConnection);
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = labelId.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                GoiMonForm f = new GoiMonForm();
                f.labelIdBill.Text = table.Rows[0][0].ToString();
                f.labelMaHoaDon.Text = "Mã hóa đơn: " + table.Rows[0][0].ToString();
                f.labelTotal.Text = "Tổng cộng" +table.Rows[0][3].ToString();
                f.ShowDialog();
            }
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePasswordForm f = new ChangePasswordForm();
            f.labelId.Text = this.labelId.Text;
            f.Show();
        }

        private void MainFormCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
