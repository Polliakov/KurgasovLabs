using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            int N = 1000;
            int result = 0;
            for(int i = 1; N >= i; i++)
            {
                result += i;
            }
            MessageBox.Show(Convert.ToString(result));
        }
    }
}
