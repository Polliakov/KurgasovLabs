using System;
using System.Windows.Forms;

namespace KurgasovLabs.Lab5
{
    public partial class DigitalClock : Form
    {
        
        public DigitalClock()
        {
            InitializeComponent();

            label4.Text = DateTime.Now.ToString();

        }


        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}