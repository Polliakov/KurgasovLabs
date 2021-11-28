using System;
using System.Windows.Forms;

namespace KurgasovLabs.Lab5
{
    public partial class Pension : Form
    {
        public Pension()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int startAge;
            int endAge;
            decimal contribution;
            decimal rate;

            if (!int.TryParse(textBox1.Text, out startAge) |
                !int.TryParse(textBox2.Text, out endAge) |
                !decimal.TryParse(textBox3.Text, out contribution) |
                !decimal.TryParse(textBox4.Text, out rate))
            {
                MessageBox.Show("Ошибка ввода!");
                return;
            }

            if (startAge < 0 || endAge < 0 || contribution < 0 || rate < 0)
            {
                MessageBox.Show("Значения не могут быть меньше нуля!");
                return;
            }

            textBox5.Text = "Возраст  Сумма вложений, Р  Сумма на счёте, Р  Прибыль, Р" +
                             Environment.NewLine;

            decimal contributionSum = 0;
            decimal depositSum;
            // Округление в меньшую сторону до 2 знаков после запятой.
            contribution -= contribution % 0.01M;
            for (int age = startAge; age <= endAge; age++)
            {
                contributionSum += contribution;
                depositSum = contributionSum * (1 + rate / 100);
                decimal profit = depositSum - contributionSum;

                textBox5.Text += string.Format("{0,-9}{1,-19}{2,-19}{3,-10}" + 
                    Environment.NewLine,
                    age, contributionSum, Math.Round(depositSum, 2), Math.Round(profit, 2));
            }
        }
    }
}
