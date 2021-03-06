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
    public partial class EditComputer : Form
    {
        public EditComputer()
        {
            InitializeComponent();
        }
        computer com = new computer();
        private void labelId_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(labelId.Text);
            int idArea = Convert.ToInt32( labelidArea.Text);
            string processor = textBoxProcessor.Text;
            string monitor = textBoxMonitor.Text;
            string keyboard = textBoxkeyboard.Text;
            string headphone = textBoxHeadphone.Text;
            string des = textBoxDescrip.Text;

            try
            {
                if (com.update(id, des , idArea, processor, monitor, keyboard, headphone))
                {
                    MessageBox.Show("Đã sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đã sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
