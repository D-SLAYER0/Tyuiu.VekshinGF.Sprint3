using System;
using Tyuiu.VekshinGF.Sprint3.Task1.V21.Lib;

namespace Tyuiu.VekshinGF.Sprint3.Task1.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Векшин Г. Ф. | ПИНб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Циклические алгоритмы (while)                                     *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнил: Векшин Г. Ф. | ПИНб-26-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, используя цикл while, которая вычисляет             *");
            Console.WriteLine("* произведение ряда: p = ∏(((0,5 + k/5) / (cos x + 0,5))^3), k=1..12, x=1.*");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 1;
            int startValue = 1;
            int stopValue = 12;

            Console.WriteLine("x (value) = " + x);
            Console.WriteLine("Начальное значение k (startValue) = " + startValue);
            Console.WriteLine("Конечное значение k (stopValue) = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.GetMultiplySeries(x, startValue, stopValue);
            Console.WriteLine("p = " + result);

            Console.ReadLine();
        }
    }
}