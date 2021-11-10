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
    public partial class MainFormCustomer : Form
    {
        public MainFormCustomer()
        {
            InitializeComponent();
        }

        private void xemThôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoUser f = new InfoUser();
            f.Show();
        }
    }
}
