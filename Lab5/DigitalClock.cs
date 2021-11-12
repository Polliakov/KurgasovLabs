using System;
using System.Windows.Forms;

namespace KurgasovLabs.Lab5
{
    public partial class DigitalClock : Form
    {
        public DigitalClock()
        {
            InitializeComponent();

            label1.Text = DateTime.Now.ToShortDateString() + ", " +
                          DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToShortDateString() + ", " +
                          DateTime.Now.ToLongTimeString();
        }
    }
}