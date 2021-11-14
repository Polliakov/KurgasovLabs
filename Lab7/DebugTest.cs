using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KurgasovLabs.Lab7
{
    public partial class DebugTest : Form
    {
        public DebugTest()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Age;
            Age = Convert.ToInt32(textBox1.Text);
            if(Age >= 13 && Age <20){
                textBox2.Text = "Вы Тинэйджер";
            }
            else
            {
                textBox2.Text = "Вы не тинэйджер";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
