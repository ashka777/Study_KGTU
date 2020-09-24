using System;
using System.Windows.Forms;

namespace lr1 // Соломянюк А.В. 17ЗИЭ-1.
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Focus(); //Установка фокуса (курсора) на TextBox
        }

        int i = 0; // Переменная счетчик
        //Событие на нажатие клавиши на клавиатуре
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            char text = e.KeyChar; //Записываем нажатую клавишу в переменную
            if (!Char.IsLetter(text) && text != 8) //Проверяем на ввод только Букв и разрешаем удаление
            {
                if (Char.IsDigit(text))
                {
                    i++;
                    if (i == 4)
                        textBox1.Enabled = false; //Деактивирует поле ввода после 4х попыток ввода цыфр
                }
                e.Handled = true; // Если вводим цифры то событие не обрабатывается 

            }
        }
        // Событие замены регистра тектса
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Функция замены текста нажнего регистра на верхний
            TextBox textb = (TextBox)sender;
            int cursorLocation = textb.SelectionStart;
            if (textb.Text.Length > 0) //Заменяет регистр с первого введенного символа 
            {
                //Применяет верхний регистр к каждому введенному последующему символу
                textb.Text = textb.Text.Substring(0, 1).ToUpper() + textb.Text.Substring(1).ToUpper();
                if (cursorLocation > textb.Text.Length)
                {
                    textb.Select(textb.Text.Length, 0);
                }
                else
                {
                    textb.Select(cursorLocation, 0);
                }
            }
        }
        // Кнопка завершения программы "Close"
        private void button2_Click(object sender, EventArgs e)
        {
            //Закрывает программу
            Application.Exit();
        }
        // Кнопка "ДА"
        private void button1_Click(object sender, EventArgs e)
        {
            //Проверка на выбор текста в ListBox
            if (listBox1.Text.ToString() == "Label")
                label1.Text = textBox1.Text; // в Label
            else //Иначе в TextBox
                textBox2.Text = textBox1.Text;
        }
    }
}
