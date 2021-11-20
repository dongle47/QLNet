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
    public partial class EditArea : Form
    {
        public EditArea()
        {
            InitializeComponent();
        }
        area kv = new area();
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(labelId.Text);
            string name = textBoxName.Text;
            try
            {
                if (kv.update(id, name))
                {
                    MessageBox.Show("Đã cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }
    }
}
