using System;
using System.Windows.Forms;

namespace KurgasovLabs.Interaction
{
    public partial class InputBox : Form
    {
        public string Result { get; private set; }

        public InputBox(string text)
        {
            InitializeComponent();

            label1.Text = text;
        }

        public InputBox(string text, string caption) : this(text)
        {
            Text = caption;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Result = textBox1.Text;
        }
    }
}
