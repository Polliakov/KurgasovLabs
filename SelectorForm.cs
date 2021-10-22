using System;
using System.Windows.Forms;

using KurgasovLabs.Lab2;
using KurgasovLabs.Lab3;

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
            var helloWorld = new HelloWorld();
            helloWorld.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var birthday = new Birthday();
            birthday.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var inputControls = new InputControls();
            inputControls.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var variableTest = new VariableTest();
            variableTest.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var inputBox = new MyInputBox();
            inputBox.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var dataTypes = new DataTypes();
            dataTypes.ShowDialog();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            var basicMath = new BasicMath();
            basicMath.ShowDialog();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            var frameworkMath = new FrameworkMath();
            frameworkMath.ShowDialog();
        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {

        }

        private void button28_Click(object sender, EventArgs e)
        {

        }

        private void button29_Click(object sender, EventArgs e)
        {

        }

        private void button30_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }
    }
}
