using System;
using System.Windows.Forms;

namespace KurgasovLabs.Lab5
{
    public partial class Addition7 : Form
    {
        public Addition7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const double A = 0.1;
            const double B = 1;
            const double H = (B - A) / 10;
            const int N = 100;

            double x = A;
            double s;
            double y;

            textBox1.Text = "x      Y(x)       S(x)" +
                Environment.NewLine;
            while (x <= B)
            {
                s = 1;
                y = Math.Pow(Math.E, 2 * x);

                for (int n = 1; n <= N; n++)
                {
                    s += Math.Pow(2 * x, n) / Fcl(n);
                }
                //F / f - Формат дробных чисел с фиксированной точкой, указывает количество десятичных разрядов после запятой
                
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
