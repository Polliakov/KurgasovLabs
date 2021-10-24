using System;
using System.Windows.Forms;

namespace KurgasovLabs.Lab3
{
    public partial class Addition7 : Form
    {
        public Addition7()
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

            if (x == 3)
            {
                label2.Text = "Y(3) = не определён";
                return;
            }
            else if (x >= -2)
            {
                a = 4 * x + 2.5;
            }
            else
            {
                a = 1.5 * x + 8;
            }

            double y = a + 2.8 * x + (x + a) / (3 - x);

            label2.Text = "Y(" + x + ") = " + y;
        }
    }
}
