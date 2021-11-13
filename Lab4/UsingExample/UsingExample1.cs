using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace KurgasovLabs.Lab4
{
    public partial class UsingExample1 : Form
    {
        public UsingExample1()
        {
            InitializeComponent();

            UseTestValues(20);
        }

        private List<Book> books = new List<Book>();
        private decimal sellSum = 0; 

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var addForm = new BookForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                Add(addForm.BookResult);
            }
        }

        private void BtnChange_Click(object sender, EventArgs e)
        {
            int selected = lstBooks.SelectedIndex;
            if (selected == -1) return;

            var changeForm = new BookForm(books[selected]);
            if (changeForm.ShowDialog() == DialogResult.OK)
            {
                Change(selected, changeForm.BookResult);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (lstBooks.SelectedIndex == -1) return;

            books.RemoveAt(lstBooks.SelectedIndex);
            lstBooks.Items.RemoveAt(lstBooks.SelectedIndex);         
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            int selected = lstBooks.SelectedIndex;
            if (selected == -1) return;

            sellSum += books[selected].Sell();
            tbSellSum.Text = sellSum.ToString("F2");
            tbCount.Text = books[selected].Count.ToString();
        }

        private void Add(Book book)
        {
            books.Add(book);
            lstBooks.Items.Add(book.Title);
        }

        private void Change(int index, Book book)
        {
            books[index] = book;
            lstBooks.Items.RemoveAt(index);
            lstBooks.Items.Insert(index, book.Title);
            lstBooks.SelectedIndex = index;
        }

        private void lstBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = lstBooks.SelectedIndex;
            if (selected == -1) return;

            tbDescription.Text = books[selected].Description;
            tbPrice.Text = books[selected].Price.ToString("F2");
            tbCount.Text = books[selected].Count.ToString();
        }

        private void UseTestValues(int count)
        {
            var rand = new Random();
            for (int i = 0; i < count; i++)
            {
                Add(new Book("Book " + i, "Description " + i, 
                             rand.Next(0, 3000), rand.Next(0, 10)));
            }
        }
    }
}
