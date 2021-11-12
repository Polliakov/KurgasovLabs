using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KurgasovLabs.Lab4
{
    public partial class AccesModeChecker : Form
    {
        public AccesModeChecker()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "9583" ||
                textBox1.Text == "1747")
            {
                textBox2.Text = "А, Б, В";
            }
            else if (textBox1.Text == "3331" ||
                     textBox1.Text == "7922")
            {
                textBox2.Text = "Б, В";
            }
            else if (textBox1.Text == "9455" ||
                     textBox1.Text == "8997")
            {
                textBox2.Text = "В";
            }
            else
            {
                textBox2.Text = "Неизвестный пароль";
            }
        }
    }
}
