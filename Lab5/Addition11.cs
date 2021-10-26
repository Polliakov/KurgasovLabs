using System;
using System.Windows.Forms;

namespace KurgasovLabs.Lab5
{
    public partial class Addition11 : Form
    {
        public Addition11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const double A = 0.1;
            const double B = 1;
            const double H = (B - A) / 10;
            const int N = 80;

            double x = A;    
            double s;
            double y;

            textBox1.Text = "x      Y(x)       S(x)" +
                Environment.NewLine;
            while (x <= B)
            {
                s = 0;
                y = 2 * (Math.Pow(Math.Cos(x - 1), 2));

                for (int n = 1; n <= N; n++)
                {
                    s += Math.Pow(-1, n) * Math.Pow(2 * x, 2 * n) / Fcl(2 * n);
                }

                textBox1.Text += string.Format("{0,-7:F2}{1,-11:F4}{2,-11:F4}" +
                    Environment.NewLine,
                    x, y, s);

                x += H;
            }
        }

        private double Fcl(int number)
        {
            double result = 1;
            for (double i = number; i > 1; i--)
            {
                result *= i;
            }
            return result;
        }
    }
}
