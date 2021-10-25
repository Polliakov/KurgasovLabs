using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KurgasovLabs.Lab3
{
    public partial class FrameworkMath : Form
    {
        public FrameworkMath()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToInt32(textBox1.Text);
            double result = Math.Pow(x, 2);
            string result_str = Convert.ToString(result);
            MessageBox.Show(result_str, "Результат");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
