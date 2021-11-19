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
    public partial class InfoCustomer : Form
    {
        public InfoCustomer()
        {
            InitializeComponent();
        }
        customer kh = new customer();
        private void InfoCustomer_Load(object sender, EventArgs e)
        {
            textBoxUser.Enabled = false;
            textBoxMoney.Enabled = false;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string id = textBoxUser.Text;
            string pass = textBoxPass.Text;
            string name = textBoxName.Text;
            string phone = textBoxPhone.Text;
            string mail = textBoxEmail.Text;
            string cmnd = textBoxCMND.Text;
            DateTime birth = dateTimePickerNS.Value;
            try
            {
                if (kh.update(id, pass, name, phone, mail, cmnd, birth))
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
        }
    }
}
