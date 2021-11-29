using System;
using System.Windows.Forms;

namespace KurgasovLabs.Lab5
{
    public partial class TimedPassword : Form
    {
        public int i = 15;

        public TimedPassword()
        {
            InitializeComponent();
            textBox1.Text = "";
            textBox1.PasswordChar = '*';
            textBox1.MaxLength = 12;
        }

        private void TimedPassword_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var password = "qwe123";
            if(textBox1.Text == password)
            {
                timer1.Stop();
                MessageBox.Show("Вы ввели правильный пароль!");
            }
            else
            {
                MessageBox.Show("Неправильный пароль, попробуйте ещё раз");
                textBox1.Text = "";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = (--i).ToString();
            if (i <= 0)
            {
                timer1.Stop();
            }
            if (i == 0)
            {
                MessageBox.Show("Время вышло");
                Close();
            }
        }

    }
}