using System;
using System.Windows.Forms;

namespace KurgasovLabs.Lab4
{
    public partial class UserValidation : Form
    {
        public UserValidation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var inputBoxName = new Interaction.InputBox("Введите ваше имя.");
            var inputBoxPassword = new Interaction.InputBox("Введите пароль.");

            if (inputBoxName.ShowDialog() != DialogResult.OK) return;
            if (inputBoxPassword.ShowDialog() != DialogResult.OK) return;

            string userName = inputBoxName.Result;
            string password = inputBoxPassword.Result;

            if (userName == "Генри" && password == "Цветок")
            {
                pictureBox1.Image = Properties.Resources.Henri;
                MessageBox.Show("Добро пожаловать, Генри! Как поживаешь?");
            }
            else if (userName == "Феликс" && password == "Листок")
            {
                pictureBox1.Image = Properties.Resources.Feliks;
                MessageBox.Show("Добро пожаловать, Феликс! Сыграем?");
            }
            else
            {
                MessageBox.Show("Извините, я вас не знаю.");
            }
        }
    }
}