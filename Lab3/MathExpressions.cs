using System;
using System.Windows.Forms;

namespace KurgasovLabs.Lab3
{
    public partial class MathExpressions : Form
    {
        public MathExpressions()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a;
            double b;

            if (!double.TryParse(textBox1.Text, out a) |
                !double.TryParse(textBox2.Text, out b))
            {
                MessageBox.Show("Ошибка ввода!");
            }

            double z1 = Math.Sqrt(2 * b + 2 * Math.Sqrt(b * b - 4)) /
                        Math.Sqrt(b * b - 4 + b + 2);

            double z2 = Math.Sqrt((a + b) / (a - 3));

            label3.Text = z1.ToString();
            label4.Text = z2.ToString();
        }
    }
}
