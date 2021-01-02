using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFF_2019
{
    public partial class Q2 : Form
    {
        public Q2()
        {
            InitializeComponent();
        }

        private void q3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Q3 q3 = new Q3();
            q3.Show();
        }

        private void q4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Q4 q4 = new Q4();
            q4.Show();
        }


        private void q6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Q6 q6 = new Q6();
            q6.Show();
        }

        private void q7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Q7 q7 = new Q7();
            q7.Show();
        }
    }
}
