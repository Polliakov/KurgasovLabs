using System;
using System.Windows.Forms;

namespace KurgasovLabs.Lab3
{
    public partial class CylinderVolume : Form
    {
        public CylinderVolume()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double radius;
            double height;

            while (true)
            {
                var inputBoxRadius = new Interaction.InputBox("Введите радиус цилиндра.");

                if (inputBoxRadius.ShowDialog() != DialogResult.OK) return;

                if (!double.TryParse(inputBoxRadius.Result, out radius))
                {
                    MessageBox.Show("Ошибка ввода!");
                    continue;
                }

                break;
            }

            while (true)
            {
                var inputBoxHeight = new Interaction.InputBox("Введите высоту цилиндра.");

                if (inputBoxHeight.ShowDialog() != DialogResult.OK) return;

                if (!double.TryParse(inputBoxHeight.Result, out height))
                {
                    MessageBox.Show("Ошибка ввода!");
                    continue;
                }

                break;
            }

            double volume = Math.PI * radius * radius * height;

            MessageBox.Show("Объём цилиндра: " + volume);
        }
    }
}
