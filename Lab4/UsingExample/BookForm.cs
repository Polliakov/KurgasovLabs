using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KurgasovLabs.Lab4
{
    public partial class BookForm : Form
    {
        public BookForm()
        {
            InitializeComponent();
        }

        public BookForm(Book book) : this()
        {
            Text = book.Title;
            tbTitle.Text = book.Title;
            tbDescription.Text = book.Description;
        }

        public Book BookResult { get; private set; }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbTitle.Text))
            {
                tbTitle.Text = "Без имени";
            }
            if (string.IsNullOrWhiteSpace(tbDescription.Text))
            {
                tbDescription.Text = "Без описания";
            }

            BookResult = new Book(tbTitle.Text, tbDescription.Text);
        }
    }
}
