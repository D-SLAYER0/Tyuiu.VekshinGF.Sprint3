using Tyuiu.VekshinGF.Sprint3.Task3.V18.Lib;

namespace Tyuiu.VekshinGF.Sprint3.Task3.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Векшин Г. Ф. | ПИНб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Обработка строк (foreach)                                         *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Векшин Г. Ф. | ПИНб-26-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach заменить цифры на букву n в строке:              *");
            Console.WriteLine("* \"4n5nvf 56 bgy\"                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string input = "4n5nvf 56 bgy";
            char item = 'n';

            Console.WriteLine("Исходная строка: " + input);
            Console.WriteLine("Символ замены: " + item);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string result = ds.ReplaceNumOnChar(input, item);
            Console.WriteLine("Результат: " + result);

            Console.ReadLine();
        }
    }
}
