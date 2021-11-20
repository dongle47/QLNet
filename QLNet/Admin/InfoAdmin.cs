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
    public partial class InfoAdmin : Form
    {
        public InfoAdmin()
        {
            InitializeComponent();
        }
        customer kh = new customer();
        private void InfoAdmin_Load(object sender, EventArgs e)
        {
            textBoxUser.Enabled = false;
            textBoxSalary.Enabled = false;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string id = textBoxUser.Text;
            string name = textBoxName.Text;
            string phone = textBoxPhone.Text;
            string mail = textBoxEmail.Text;
            string cmnd = textBoxCMND.Text;
            DateTime birth = dateTimePickerNS.Value;
            try
            {
                if (kh.update(id, name, phone, mail, cmnd, birth))
                {
                    MessageBox.Show("Đã cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
