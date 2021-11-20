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
    public partial class MainFormAdmin : Form
    {
        public MainFormAdmin()
        {
            InitializeComponent();
        }
        MyDB db = new MyDB();
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("EXEC infoAdminById @username = @id", db.getConnection);
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = labelUsername.Text;
            DataTable table = DBSQLServerUtils.getTable(command);

            if (table.Rows.Count > 0)
            {
                InfoAdmin f = new InfoAdmin();
                f.textBoxUser.Text = table.Rows[0][0].ToString();
                f.textBoxPass.Text = table.Rows[0][1].ToString();
                f.textBoxName.Text = table.Rows[0][2].ToString();
                f.textBoxPhone.Text = table.Rows[0][3].ToString();
                f.textBoxEmail.Text = table.Rows[0][4].ToString();
                f.textBoxEmail.Text = table.Rows[0][4].ToString();
                f.textBoxCMND.Text = table.Rows[0][5].ToString();
                f.dateTimePickerNS.Value = (DateTime)table.Rows[0][6];
                f.textBoxSalary.Text = table.Rows[0][7].ToString();
                f.Show();
            }
        }

        private void nạpTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListCustomer f = new ListCustomer();
            f.Show();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListMenu f = new ListMenu();
            f.Show();
        }

        private void máyTínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListComputer f = new ListComputer();
            f.Show();
        }

        private void khuVựcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AreaList f = new AreaList();
            f.ShowDialog();
        }

        private void nạpTiềnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NapTienWindow f = new NapTienWindow();
            f.ShowDialog();
        }

        private void MainFormAdmin_Load(object sender, EventArgs e)
        {

        }

        private void lịchSửĐăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoryLoginForm f = new HistoryLoginForm();
            f.ShowDialog();
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT dbo.avgIncome()", db.getConnection);
            DataTable table = DBSQLServerUtils.getTable(command);
            IncomeForm f = new IncomeForm();
            f.labelIncomeAvg.Text = "Thu nhập hằng tháng: " + table.Rows[0][0].ToString();
            f.ShowDialog();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePasswordForm f = new ChangePasswordForm();
            f.labelId.Text = this.labelUsername.Text;
            f.ShowDialog();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BillForm f = new BillForm();
            f.ShowDialog();
        }
    }
}
