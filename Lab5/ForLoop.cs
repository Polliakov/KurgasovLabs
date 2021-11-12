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

        private void button1_ClickAsync(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                richTextBox1.Text = richTextBox1.Text + "Строка " + i + Environment.NewLine;
            }
        }
    }
}
