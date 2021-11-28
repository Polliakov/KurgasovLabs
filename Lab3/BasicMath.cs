using System;
using System.Windows.Forms;

namespace KurgasovLabs.Lab3
{
    public partial class BasicMath : Form
    {
        public BasicMath()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double leftOperand;
            double rightOperand;

            if (!double.TryParse(textBox1.Text, out leftOperand) |
                !double.TryParse(textBox2.Text, out rightOperand))
            {
                MessageBox.Show("Ошибка ввода!");
            }
            double result = 0;

            if (radioButton1.Checked)
            {
                result = leftOperand + rightOperand;
            }
            else if (radioButton2.Checked)
            {
                result = leftOperand - rightOperand;
            }
            else if (radioButton3.Checked)
            {
                result = leftOperand * rightOperand;
            }
            else if (radioButton4.Checked)
            {
                result = leftOperand / rightOperand;
            }

            label4.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
