using Tyuiu.PlatonovaPE.Sprint5.Task4.V18.Lib;

namespace Tyuiu.PlatonovaPE.Sprint5.Task4.V18
{
    public class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #5 | Выполнила: Платонова П.Е. | ИСПб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнила: Платонова Полина Евгеньевна | ИСПб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл в котором есть вещественное значение. Прочитать значение из    *");
            Console.WriteLine("* файла и подставить вместо Х в формуле . Вычислить значение по формуле   *");
            Console.WriteLine("*                 x^2                                                     *");
            Console.WriteLine("*  y =  cos(x) + -----                                                    *");
            Console.WriteLine("*                  2                                                      *");
            Console.WriteLine("* (Полученное значение округлить до трёх знаков после запятой)            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = $@"C:\Users\parse\source\repos\Tyuiu.PlatonovaPE.Sprint5\Tyuiu.PlatonovaPE.Sprint5.Task4.V18\bin\Debug\net8.0\OutPutFileTask4.txt";
            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}