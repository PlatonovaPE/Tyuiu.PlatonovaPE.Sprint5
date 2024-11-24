using Tyuiu.PlatonovaPE.Sprint5.Task3.V28.Lib;

namespace Tyuiu.PlatonovaPE.Sprint5.Task3.V28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Платонова Полина Евгеньвна  | ИСПб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл                     *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("* Выполнила: Платонова Полина Евгеньвна  | ИСПб-24-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение вычислить его значение при x = 3, результат сохранить    *");
            Console.WriteLine("* в бинарный файл OutPutFileTask3.bin и вывести на консоль. Округлить     *");
            Console.WriteLine("* до трёх знаков после запятой.                                           *");
            Console.WriteLine("*          1                                                              *");
            Console.WriteLine("*    y = - -(x^3-3x^2+4)                                                  *");
            Console.WriteLine("*          4                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 3;
            Console.WriteLine($"Значение переменной x  = {x}");

            string path = ds.SaveToFileTextData(x);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Файл: {path}");
            Console.WriteLine("Создан!");
        }
    }
}