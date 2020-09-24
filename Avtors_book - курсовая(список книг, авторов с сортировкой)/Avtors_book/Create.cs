using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avtors_book
{
    class Create
    {
        public static void Input_data(string file)
        {
            int x = 0;
            StreamWriter rec = new StreamWriter(file, false); //ЗАПИСЬ - ПЕРЕЗАПИСЬ (true, false).
            ConsoleKeyInfo key;
            string book = "";
            string avtor = "";
            int year = 0;
            double coin = 0;
            do
            {
                Console.WriteLine("Введите название книги не более 23 символов:");
                book = Console.ReadLine();
                Console.WriteLine("Введите автора книги не более 18 символов:");
                avtor = Console.ReadLine();
            Input_1: try
                {
                    Console.WriteLine("Введите год издания книги:");
                    year = Convert.ToInt16(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Введено неверное значение!");
                    goto Input_1;
                }
            Input_2: try
                {
                    Console.WriteLine("Введите стоимость книги не более 10 символов:");
                    coin = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Введено неверное значение!");
                    goto Input_2;
                }
                Console.WriteLine("Для окончания ввода введите * ");
                Console.WriteLine("Для ввода данных нажмите  Enter");
                key = Console.ReadKey();
                Console.Clear();
                rec.Write(book + ";" + avtor + ";" + year + ";" + coin + ";");
                x++;
            }
            while (key.KeyChar != '*');
            rec.Close();
            int i = 0;
            int j = 0;
            string[,] str = new string[100, 4];
            Console.WriteLine("В файле {0} записей", x);
            Console.WriteLine();
            Console.WriteLine("|_____Название книги_____|____Автор книги____|_Год издания_|_Стоимость_|");
            Console.WriteLine("|                        |                   |             |           |");
            StreamReader f = new StreamReader(file);
            string[] loozer = new string[4];
            loozer[0] = f.ReadToEnd();
            loozer = loozer[0].Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string Line in loozer)
            {
                str[i, j] = Line;
                j++;
                if (j > 3)
                {
                    Console.Write("| {0,-23}", str[i, 0]);
                    Console.Write("| {0,-18}", str[i, 1]);
                    Console.Write("| {0,-12}", str[i, 2]);
                    for (; str[i, 3].Length < 10; ) str[i, 3] = str[i, 3] + " ";
                    Console.WriteLine("| " + str[i, 3] + "|");
                    i++; j = 0;
                }
            }
            Console.WriteLine("Конец файла.");
            f.Close();
            Console.WriteLine("Для возврата в МЕНЮ нажмите Enter.");
            Console.ReadKey();
        }
    }
}
