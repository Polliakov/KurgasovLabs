using System;
using System.Windows.Forms;

namespace KurgasovLabs.Lab7
{
    public partial class DebugTest : Form
    {
        public DebugTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int age;
            age = Convert.ToInt32(textBox1.Text);
            if (age > 13 && age < 20)
                textBox2.Text = "Вы тинейджер";
            else
                textBox2.Text = "Вы не тинейджер";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
