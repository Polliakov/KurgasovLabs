using System;
using System.Windows.Forms;

using KurgasovLabs.Lab2;
using KurgasovLabs.Lab3;
using KurgasovLabs.Lab4;
using KurgasovLabs.Lab5;
using KurgasovLabs.Lab6;
using KurgasovLabs.Lab7;

namespace KurgasovLabs
{
    public partial class SelectorForm : Form
    {
        public SelectorForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new HelloWorld().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Birthday().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new InputControls().ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new VariableTest().ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new MyInputBox().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new DataTypes().ShowDialog();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            new BasicMath().ShowDialog();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            new FrameworkMath().ShowDialog();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            new NumberPI().ShowDialog();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            new MathExpressions().ShowDialog();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            new CylinderVolume().ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new UserValidation().ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new CaseGreeting().ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new AccesModeChecker().ShowDialog();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            new UsingExample1().ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            new ForLoop().ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            new ForLoopIcons().ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            new DigitalClock().ShowDialog();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            new TimedPassword().ShowDialog();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            new ForLoopSummation().ShowDialog();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            new Pension().ShowDialog();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            new DepositPercent().ShowDialog();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            new ClockMenuStrip().ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            new MyMenuStrip().ShowDialog();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            new DebugTest().ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            new Lab3.Addition11().ShowDialog();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            new Lab5.Addition11().ShowDialog();
        }
    }
}
