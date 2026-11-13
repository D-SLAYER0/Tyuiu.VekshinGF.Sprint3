using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.VekshinGF.Sprint3.Task2.V24.Lib
{
    public class DataService : ISprint3Task2V24
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double p = 1;
            int k = startValue;

            do
            {
                p *= (Math.Pow(value, k) + 4) * Math.Cos(value);
                k++;
            }
            while (k <= stopValue);

            return Math.Round(p, 3);
        }
    }
}
