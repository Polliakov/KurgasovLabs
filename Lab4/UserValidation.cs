using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

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
            String UserName,Pass;
            UserName = Microsoft.VisualBasic.Interaction.InputBox("Введите ваше имя");
            Pass = Microsoft.VisualBasic.Interaction.InputBox("Введите пароль");
            if (UserName == "Генри" & Pass == "Цветок")
            {
                Microsoft.VisualBasic.Interaction.MsgBox("Добро пожаловать, Генри! Как поживаешь?");
                pictureBox1.Image = KurgasovLabs.Properties.Resources.Henri;
            }
            else if (UserName == "Феликс" & Pass == "Листок")
            {
                Microsoft.VisualBasic.Interaction.MsgBox("Добро пожаловать, Феликс! Сыграем?");
                pictureBox1.Image = KurgasovLabs.Properties.Resources.Feliks;
            }
            else
            {
                Microsoft.VisualBasic.Interaction.MsgBox("Извините, я вас не знаю.");
            }
        }
    }
}
