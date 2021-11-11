using System;

using System.Windows.Forms;

namespace KurgasovLabs.Lab6
{
    public partial class ClockMenuStrip : Form
    {
        public ClockMenuStrip()
        {
            InitializeComponent();
        }

        private void dateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Label1.Text = DateTime.Now.ToString("yyy.MM.dd");
        }

        private void времяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Label1.Text = DateTime.Now.ToString("HH.mm.dd");
        }

        private void деньToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Label1.Text = DateTime.Now.ToString("dd");
        }
    }
}
