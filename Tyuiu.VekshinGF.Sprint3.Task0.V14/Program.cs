using System;
using Tyuiu.VekshinGF.Sprint3.Task0.V14.Lib;

namespace Tyuiu.VekshinGF.Sprint3.Task0.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Векшин Г. Ф. | ПИНб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Циклические алгоритмы                                             *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Векшин Г. Ф. | ПИНб-26-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу вычисления произведения ряда:                        *");
            Console.WriteLine("* p = ∏(1/k^n)^(-1), при n = 2, k от 1 до 5.                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int n = 2;
            int startValue = 1;
            int stopValue = 5;

            Console.WriteLine("n (value) = " + n);
            Console.WriteLine("Начальное значение k (startValue) = " + startValue);
            Console.WriteLine("Конечное значение k (stopValue) = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.GetMultiplySeries(n, startValue, stopValue);

            Console.WriteLine("p = " + result);

            Console.ReadLine();
        }
    }
}