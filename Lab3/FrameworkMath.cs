// КОМЕНТАРИИ УДАЛИТЬ ПЕРЕД ОТПРАВКОЙ

using System;
// Не нужные using желательно удалять.
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace KurgasovLabs.Lab3
{
    public partial class FrameworkMath : Form
    {
        public FrameworkMath()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //double x = Convert.ToInt32(textBox1.Text);

            /* Не отлавливается RuntimeExeption вызываемое Convert.ToInt32() при некорректном вводе строки.
             * Для решения проблеммы можно использовать метод int.TryParse() или блоки try{} catch{}.
             * 
             * Приведение к int значения, предпологаемо типа double ( Convert.ToInt32() ).
             * Следует использовать Convert.ToDouble() или double.TryParse().
             */
            if (!double.TryParse(textBox1.Text, out double x))
            {
                MessageBox.Show("Ошибка ввода!");
                return;
            }

            double result = Math.Pow(x, 2);

            //string result_str = Convert.ToString(result);
            //MessageBox.Show(result_str, "Результат");

            /* Ненужное объявление переменной result_str, переменная используется только 1 раз для вывода.
             * 
             * Примечание: Convert.ToString(result) и result.ToString() не имеют существенных различий,
             * второй вариант имеет боле краткую форму и более читаем.
             * 
             * Нарушение нотации именования переменных. 
             * Для локальных переменных нотация camelCase.
             */
            MessageBox.Show(result.ToString(), "Результат");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        /* Графическая часть:
         * Не нужно жмыхать кнопки (Зошто?).
         * *Использование выравнивания упрощает создание ровного интерфейса,
         * верхняя панель при выборе нескольких элементов.
         */
    }
}
