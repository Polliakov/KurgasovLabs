﻿using System;
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
            if (!int.TryParse(textBox1.Text, out int startAge) |
                !int.TryParse(textBox2.Text, out int endAge) |
                !decimal.TryParse(textBox3.Text, out decimal contribution) |
                !decimal.TryParse(textBox4.Text, out decimal rate))
            {
                MessageBox.Show("Ошибка ввода!");
                return;
            }

            textBox5.Text = "Возраст  Сумма вложений, Р  Сумма на счёте, Р  Прибыль, Р" +
                              Environment.NewLine;

            decimal contributionSum = 0;
            decimal depositSum = 0;
            for (int age = startAge; age <= endAge; age++)
            {
                contributionSum += contribution;
                depositSum = contributionSum * (1 + rate / 100);
                decimal profit = depositSum - contributionSum;

                textBox5.Text += string.Format("{0,-9}{1,-19}{2,-19}{3,-10}" + 
                    Environment.NewLine,
                    age, contributionSum, depositSum, profit);
            }
        }
    }
}
