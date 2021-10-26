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

            if (!GetInput("Введите радиус цилиндра.", out radius)) return;
            if (!GetInput("Введите высоту цилиндра.", out height)) return;

            double volume = Math.PI * radius * radius * height;

            MessageBox.Show("Объём цилиндра: " + Math.Abs(volume), "Результат");
        }

        private bool GetInput(string text, out double result)
        {
            while (true)
            {
                var inputBox = new Interaction.InputBox(text);

                if (inputBox.ShowDialog() != DialogResult.OK)
                {
                    result = 0;
                    return false;
                }

                if (!double.TryParse(inputBox.Result, out result))
                {
                    MessageBox.Show("Ошибка ввода!");
                    continue;
                }

                return true;
            }
        }
    }
}
