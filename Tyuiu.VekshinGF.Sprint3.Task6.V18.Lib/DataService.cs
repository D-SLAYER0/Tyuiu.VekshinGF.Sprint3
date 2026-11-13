using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.VekshinGF.Sprint3.Task6.V18.Lib
{
    public class DataService : ISprint3Task6V18
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int totalSum = 0;

            for (int number = startValue; number <= stopValue; number++)
            {
                for (int divisor = 1; divisor <= number; divisor++)
                {
                    if (number % divisor == 0 && divisor < 10)
                    {
                        totalSum += divisor;
                    }
                }
            }

            return totalSum;
        }
    }
}
