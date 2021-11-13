using System;
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
            switch (textBox1.Text)
            {
                case "9583":
                case "1747":
                    textBox2.Text = "А, Б, В";
                    break;
                case "3331":
                case "7922":
                    textBox2.Text = "Б, В";
                    break;
                case "9455":
                case "8997":
                    textBox2.Text = "В";
                    break;
                default:
                    textBox2.Text = "Неизвестный пароль";
                    break;
            }
        }
    }
}
