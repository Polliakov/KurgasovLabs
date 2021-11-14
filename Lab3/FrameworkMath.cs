
using System;
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
            if (!double.TryParse(textBox1.Text, out double x))
            {
                MessageBox.Show("Ошибка ввода!");
                return;
            }

            double result = Math.Pow(x, 2);
            MessageBox.Show(result.ToString(), "Результат");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
