using Tyuiu.PlatonovaPE.Sprint5.Task2.V12.Lib;
namespace Tyuiu.PlatonovaPE.Sprint5.Task2.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #5 | Выполнила: Платонова Полина Евгеньена | ИСПб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл      *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнила: Платонова Полина Евгеньена | ИСПб-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры. Заменить нечетные элементы массива на 0.       *");
            Console.WriteLine("*                                                                         *");
            int[,] a = { { -5, -5, 9 }, { -7, 3, -4 }, { 8, 7, 9 } };
            int rows = a.GetUpperBound(0) + 1;
            int cols = a.GetUpperBound(1) + 1;
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("Массив: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{a[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("***************************************************************************");
            string res = ds.SaveToFileTextData(a);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Файл: " + res + " Создан!");
            Console.ReadKey();
        }
    }
}