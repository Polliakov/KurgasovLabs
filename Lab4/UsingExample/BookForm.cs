using System;
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
            tbPrice.Text = book.Price.ToString("F2");
            tbCount.Text = book.Count.ToString();
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
            if (!decimal.TryParse(tbPrice.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("Неверный формат поля \"цена\"", "Ошибка");
                return;
            }
            price -= price % 0.01M;
            if (!int.TryParse(tbCount.Text, out int count) || count < 0)
            {
                MessageBox.Show("Неверный формат поля \"Количество\"", "Ошибка");
                return;
            }

            BookResult = new Book(tbTitle.Text, tbDescription.Text, price, count);
            DialogResult = DialogResult.OK;
        }
    }
}
