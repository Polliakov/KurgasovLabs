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

        private void button2_Click(object sender, EventArgs e)
        {
           if (textBox2.Text == "")
            {
                MessageBox.Show("Не заполнено!");
                Close();
            }
           
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
