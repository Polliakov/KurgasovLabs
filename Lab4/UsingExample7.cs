using System;
using System.Windows.Forms;

namespace KurgasovLabs.Lab4
{
    public partial class UsingExample7 : Form
    {
        public UsingExample7()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int s = 0;
            if (checkBox1.Checked)
            {
                s = s + 230;
            }
            if (checkBox2.Checked)
            {
                s = s + 750;
            }
            if (checkBox3.Checked)
            {
                s = s + 470;
            }
            if (checkBox4.Checked)
            {
                s = s + 750;
            }
            if (checkBox5.Checked)
            {
                s = s + 120;
            }
            if (checkBox6.Checked)
            {
                s = s + 60;
            }
            if (checkBox7.Checked)
            {
                s = s + 60;
            }
            if (checkBox8.Checked)
            {
                s = s + 60;
            }
            if (checkBox9.Checked)
            {
                s = s + 160;
            }
            if (checkBox10.Checked)
            {
                s = s + 350;
            }
            if (checkBox11.Checked)
            {
                s = s + 270;
            }
            if (checkBox12.Checked)
            {
                s = s + 230;
            }
            if (checkBox13.Checked)
            {
                s = s + 190;
            }

            textBox1.Text = "Сумма Вашего заказа = " + s + " рублей";
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
