using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.VekshinGF.Sprint3.Task4.V16.Lib
{
    public class DataService : ISprint3Task4V16
    {
        public double Calculate(int startValue, int stopValue)
        {
            double p = 1;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    continue; // пропускаем x = 0
                }

                double y = ((Math.Cos(x) + x) / x) + 0.25;
                p *= y;
            }

            return Math.Round(p, 3);
        }
    }
}
