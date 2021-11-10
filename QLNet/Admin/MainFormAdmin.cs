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
    public partial class MainFormAdmin : Form
    {
        public MainFormAdmin()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoUser f = new InfoUser();
            f.Show();
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
    }
}
