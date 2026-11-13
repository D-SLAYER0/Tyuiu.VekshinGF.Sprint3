using Tyuiu.VekshinGF.Sprint3.Task6.V18.Lib;
namespace Tyuiu.VekshinGF.Sprint3.Task6.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Векшин Г. Ф. | ПИНб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Циклические алгоритмы (вложенные циклы)                           *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Векшин Г. Ф. | ПИНб-26-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Напишите программу, которая ищет среди целых чисел, принадлежащих       *");
            Console.WriteLine("* числовому отрезку [9, 18] сумму всех делителей меньше 10.               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = 9;
            int stopValue = 18;

            Console.WriteLine("Начало отрезка (startValue) = " + startValue);
            Console.WriteLine("Конец отрезка (stopValue) = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int result = ds.GetSumTheDivisors(startValue, stopValue);
            Console.WriteLine("Сумма делителей меньше 10 = " + result);

            Console.ReadLine();
        }
    }
}
