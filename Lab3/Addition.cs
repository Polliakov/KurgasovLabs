using System;
using System.Windows.Forms;

namespace KurgasovLabs.Lab3
{
    public partial class Addition : Form
    {
        public Addition()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox1.Text, out double x))
            {
                MessageBox.Show("Ошибка ввода!");
                return;
            }

            double a;

            if (x >= -2)
            {
                a = 3.5 * x;
            }
            else
            {
                a = x + 1.5;
            }

            if (a == -1)
            {
                label2.Text = "Y(" + x + ") = не определён";
                return;
            }

            double y = a + a / (a + 1) + 2.5 * x;

            label2.Text = "Y(" + x + ") = " + y;
        }
    }
}
