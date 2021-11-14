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

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (textBox1.Text)
            {
                case "9583": 
                    label1.Text = "А, Б, В";
                    break;
                case "1747":
                    label1.Text = "А, Б, В";
                    break;
                case "3331": 
                    label1.Text = "Б, В";
                    break;
                case "7922": 
                    label1.Text = "Б, В";
                    break;
                case "9455":
                    label1.Text = "В";
                    break;
                case "8997":
                    label1.Text = "В";
                    break;
                default:
                    label1.Text = "У Вас нет доступа";
                    break;
            }

        }
    }
}
