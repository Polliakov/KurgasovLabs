using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KurgasovLabs.Lab5
{
    public partial class ForLoop : Form
    {
        public ForLoop()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                richTextBox1.Text = richTextBox1.Text + "Строка " + i + "\n";
                Task.Delay(100).GetAwaiter().GetResult();
            }
        }
    }
}
