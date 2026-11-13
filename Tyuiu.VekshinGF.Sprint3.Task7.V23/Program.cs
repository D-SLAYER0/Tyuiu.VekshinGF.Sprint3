using Tyuiu.VekshinGF.Sprint3.Task7.V23.Lib;
namespace Tyuiu.VekshinGF.Sprint3.Task7.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Векшин Г. Ф. | ПИНб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Массивы и таблица значений функции                                *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнил: Векшин Г. Ф. | ПИНб-26-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции:           *");
            Console.WriteLine("* F(x) = 4 - 2x + (2 + cos(x)) / (2x - 2)                                 *");
            Console.WriteLine("* Табулирование на диапазоне [-5; 5] с шагом 1.                           *");
            Console.WriteLine("* При делении на ноль вернуть значение 0.                                 *");
            Console.WriteLine("* Значения округлить до двух знаков после запятой.                        *");
            Console.WriteLine("* Значения занести в массив!                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Начало диапазона (startValue) = " + startValue);
            Console.WriteLine("Конец диапазона (stopValue) = " + stopValue);
            Console.WriteLine("Шаг = 1");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double[] result = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("Таблица значений F(x):");
            Console.WriteLine("  x  |  F(x)");
            Console.WriteLine("-----|--------");
            for (int i = 0; i < result.Length; i++)
            {
                int x = startValue + i;
                Console.WriteLine($"  {x,3} | {result[i],7}");
            }

            Console.WriteLine();
            Console.WriteLine("Массив значений: [" + string.Join(", ", result) + "]");

            Console.ReadLine();
        }
    }
}
