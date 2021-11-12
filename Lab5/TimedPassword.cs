using System;
using System.Windows.Forms;

namespace KurgasovLabs.Lab5
{
    public partial class TimedPassword : Form
    {
        public TimedPassword()
        {
            InitializeComponent();

            time = 20;
            label1.Text = time.ToString("0 c");
        }

        const string password = "qwer";
        private int time;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == password)
            {
                timer1.Stop();
                MessageBox.Show("Вы ввели верный пароль!");
                Close();
            }
            else
            {
                MessageBox.Show("Невеврный пароль, попробуйте снова");
                textBox1.Text = string.Empty;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = (--time).ToString("0 c");

            if (time == 0)
            {
                timer1.Stop();
                MessageBox.Show("Извините, время вышло");
                Close();
            }
        }
    }
}
