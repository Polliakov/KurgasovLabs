using System;
using System.Windows.Forms;

namespace KurgasovLabs.Lab4
{
    public partial class CaseGreeting : Form
    {
        public CaseGreeting()
        {
            InitializeComponent();
        }

        private void CaseGreeting_Load(object sender, EventArgs e)
        {
            lstCountryBox.Items.Add("Англия");
            lstCountryBox.Items.Add("Германия");
            lstCountryBox.Items.Add("Мексика");
            lstCountryBox.Items.Add("Италия");
            lstCountryBox.Items.Add("Россия");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCountry.Text = lstCountryBox.Text;

            switch (lstCountryBox.SelectedIndex)
            {
                case 0:
                    lblGreeting.Text = "Hello, programmer";
                    break;
                case 1:
                    lblGreeting.Text = "Hallo, programmierer";
                    break;
                case 2:
                    lblGreeting.Text = "Hola, programador";
                    break;
                case 3:
                    lblGreeting.Text = "Ciao, programmatore";
                    break;
                case 4:
                    lblGreeting.Text = "Здравстуй, программист";
                    break;
            }
        }
        private void lstCountryBox_MouseHover(object sender, EventArgs e)
        {
            if (lstCountryBox.SelectedIndex == -1)
            {
                lblGreeting.Text = "Пожалуйста выберите страну";
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}  
