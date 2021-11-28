using System;
using System.Windows.Forms;

namespace KurgasovLabs.Lab3
{
    public partial class Addition11 : Form
    {
        public Addition11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x;

            if (!double.TryParse(textBox1.Text, out x))
            {
                MessageBox.Show("Ошибка ввода!");
                return;
            }

            double a;


            if (x == 0)
            {
                label2.Text = "Y(0) = не определён";
                return;
            }
            else if (x > -6 && x <= -3)
            {
                a = 3.7 * x;
            }
            else if (x > -3 && x <= 8)
            {
                a = x * x + 3 * x - 3;
            }
            else
            {
                label2.Text = "Y(" + x + ") = не определён";
                return;
            }

            double y = (2 + x) / x + Math.Pow(a, 3) - 3 * x;

            label2.Text = "Y(" + x + ") = " + y;
        }
    }
}
