using Tyuiu.VekshinGF.Sprint3.Task2.V24.Lib;

namespace Tyuiu.VekshinGF.Sprint3.Task1.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Векшин Г. Ф. | ПИНб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Циклические алгоритмы (do...while)                                *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнил: Векшин Г. Ф. | ПИНб-26-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, используя цикл do...while, которая вычисляет        *");
            Console.WriteLine("* произведение ряда: p = ∏(a^k + 4)cos a, k=1..8, a = 0,25.               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double a = 0.25;
            int startValue = 1;
            int stopValue = 8;

            Console.WriteLine("a (value) = " + a);
            Console.WriteLine("Начальное значение k (startValue) = " + startValue);
            Console.WriteLine("Конечное значение k (stopValue) = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.GetMultiplySeries(a, startValue, stopValue);
            Console.WriteLine("p = " + result);

            Console.ReadLine();
        }
    }
}