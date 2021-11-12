using System;
using System.Windows.Forms;

namespace KurgasovLabs.Lab5
{
    public partial class ForLoopSummation : Form
    {
        public ForLoopSummation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int summ = 0;

            for(int i = 1; i <= 1000; i++)
            {
                summ += i;
            }

            MessageBox.Show(summ.ToString(), "Сумма");
        }
    }
}
