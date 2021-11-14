using System;
using System.Windows.Forms;

namespace KurgasovLabs.Lab3
{
    public partial class NumberPI : Form
    {
        public NumberPI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int iPi = Convert.ToInt32(Math.PI);
            double dPi = Math.PI;
            string sPi = Math.PI.ToString();
            object objPi = 3.14;

            textBox1.Text = iPi.ToString();
            textBox2.Text = dPi.ToString();
            textBox3.Text = sPi;
            textBox4.Text = objPi.ToString();
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
