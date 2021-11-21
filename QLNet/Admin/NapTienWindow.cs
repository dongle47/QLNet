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
        MyDB db = new MyDB();
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NapTienWindow_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM curMoneyCus");
            fillGrid(command);

            command = new SqlCommand("SELECT * from dbo.findBestCustomer()", db.getConnection);
            DataTable table = DBSQLServerUtils.getTable(command);
            if (table.Rows.Count > 0)
            {
                labelUsername.Text = "Username: " + table.Rows[0][0].ToString();
                labelId.Text ="Username: " + table.Rows[0][0].ToString();
                labelName.Text = "Tên: " + table.Rows[0][1].ToString();
                labelNgsinh.Text = "Ngày sinh: " + table.Rows[0][2].ToString();
                labelSDT.Text = "SĐT: " + table.Rows[0][3].ToString();
                labelMail.Text = "Email: " + table.Rows[0][4].ToString();
                labelCMND.Text = "CMND: " + table.Rows[0][5].ToString();
                labelMoney.Text = "Tổng tiền nạp: "+ table.Rows[0][6].ToString();
            }

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
                    MessageBox.Show("Đã thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đã thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            SqlCommand command = new SqlCommand("SELECT * FROM curMoneyCus");
            fillGrid(command);
        }
    }
}
