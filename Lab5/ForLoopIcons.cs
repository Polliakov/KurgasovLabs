using System;
using System.Windows.Forms;

namespace KurgasovLabs.Lab5
{
    public partial class ForLoopIcons : Form
    {
        public ForLoopIcons()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 4; i++)
            {
                pictureBox1.Image = (System.Drawing.Image)
                    Properties.Resources.ResourceManager.GetObject("Emoji0" + i);

                MessageBox.Show(i < 4 ? "Показать следующую рожицу!" : 
                                        "Рожицы закончились :(");
            }
        }
    }
}
