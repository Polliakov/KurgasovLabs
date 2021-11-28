using System;
using System.Windows.Forms;

namespace KurgasovLabs.Lab5
{
    public partial class DepositPercent : Form
    {
        public DepositPercent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal summ;
            decimal rate;
            int months;

            if (!decimal.TryParse(textBox1.Text, out summ) |
                !int.TryParse(textBox2.Text, out months) |
                !decimal.TryParse(textBox3.Text, out rate))
            {
                MessageBox.Show("Некорректные данные!");
                return;
            }
            if (summ < 0 || months < 0 || rate < 0)
            {
                MessageBox.Show("Значения не могут быть отрицательными!");
                return;
            }

            // Округление в меньшую сторону до 2 знаков.
            summ -= summ % 0.01M;

            decimal profit;

            if (radioButton1.Checked)
            {
                profit = summ * (rate / 100) * (months / 12);
            }
            else if (radioButton2.Checked)
            {
                decimal deposit = summ;

                for (int i = 0; i < months; i++)
                {
                    deposit += deposit * (rate / 100);
                }

                profit = deposit - summ;
            }
            else
            {
                MessageBox.Show("Выберите схему начисления процентов!");
                return;
            }

            label4.Text = Math.Round(profit, 2).ToString();
        }
    }
}
