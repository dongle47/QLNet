using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNet
{
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }
        DBSQLServerUtils dbsql = new DBSQLServerUtils();
        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if(textBoxOldPass.Text != textBoxNewPass.Text && textBoxNewPass.Text == textBoxNewPass2.Text)
            {
                string id = labelId.Text;
                string pass = (textBoxNewPass.Text);
                try
                {
                    if (dbsql.changePassword(id, pass))
                    {
                        MessageBox.Show("Đã đổi mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else if(textBoxOldPass.Text == textBoxNewPass.Text)
            {
                MessageBox.Show("Mật khẩu mới phải khác mật khẩu cũ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(textBoxNewPass2.Text != textBoxNewPass.Text)
            {
                MessageBox.Show("Xác nhận mật khẩu không trùng nhau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
