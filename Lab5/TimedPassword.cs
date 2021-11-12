using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KurgasovLabs.Lab5
{
    public partial class TimedPassword : Form
    {

        private int m;
        private int s;

        public TimedPassword()
        {
            InitializeComponent();

            timer1.Interval = 500;
            m = 0;
            s = 0;
            label1.Text = "00";
            label2.Text = "00";
            label4.Text = DateTime.Now.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            m = 0;
            s = 0;
            label2.Text = "00";
            label1.Text = "00";
            label3.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label3.Visible)
            {
                label3.Visible = false;
                return;
            }

            s++;
            if (s == 60)
            {
                s = 0;
                m++;
                if (m == 60)
                {
                    m = 0;
                    s = 0;
                }
                label1.Text = m.ToString("00");
            }

            label2.Text = s.ToString("00");
            label3.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Enabled = false;
                button1.Text = "Пуск";
                button2.Enabled = true;
            }
            else
            {
                timer1.Enabled = true;
                button1.Text = "Стоп";
                button2.Enabled = false;
            }

        }

    }
}