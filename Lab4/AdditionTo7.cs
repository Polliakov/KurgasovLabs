using System;

using System.Windows.Forms;

namespace KurgasovLabs.Lab4
{
    public partial class AdditionTo7 : KurgasovLabs.Lab5.Addition7
    {
        public AdditionTo7()
        {
            InitializeComponent();
        }

        private void AdditionTo7_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch(listBox1.SelectedIndex)
            {
                case 0:
                    MessageBox.Show("Мы рады, что Вам нравится! Благодарим за заказ.");
                    break;
                case 1:
                    MessageBox.Show("Мы рады, что Вам понравилось! Благодарим за заказ.");
                    break;
                case 2:
                    MessageBox.Show("Мы рады, что Вы довольны! Благодарим за заказ.");
                    break;
                case 3:
                    MessageBox.Show("Приходите ещё, Ваш отзыв учтётся! Благодарим за заказ.");
                    break;
                case 4:
                    MessageBox.Show("Приходите ещё, Ваш отзыв учтётся! Благодарим за заказ.");
                    break;
                case 5:
                    MessageBox.Show("Нам жаль, что было что-то не так! Приходите ещё, Ваш отзыв учтётся. Благодарим за заказ.");
                    break;
                case 6:
                    MessageBox.Show("Нам жаль, что Вы остались недовольны! Приходите ещё, Ваш отзыв учтётся. Благодарим за заказ.");
                    break;
                case 7:
                    MessageBox.Show("Приносим извинения! Приходите ещё, Ваш отзыв учтётся. Благодарим за заказ.");
                    break;
                case 8:
                    MessageBox.Show("Приносим извинения! Приходите ещё, Ваш отзыв учтётся. Благодарим за заказ.");
                    break;
                case 9:
                    MessageBox.Show("Нам очень жаль, что Вам не понравилось! Приходите ещё, Ваш отзыв учтётся. Благодарим за заказ.");
                    break;
            }
        }
    }
}
