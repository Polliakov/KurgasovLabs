﻿using System;
using System.Windows.Forms;

namespace KurgasovLabs.Lab3
{
    public partial class MyInputBox : Form
    {
        public MyInputBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var inputBox = new Interaction.InputBox("Введите имя, пожалуйста.");

            if (inputBox.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = inputBox.Result;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
