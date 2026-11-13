using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.VekshinGF.Sprint3.Task1.V21.Lib
{
    public class DataService : ISprint3Task1V21
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double p = 1;
            int k = startValue;                 // инициализация счётчика

            while (k <= stopValue)             
            {
                double numerator = 0.5 + (double)k / value;
                double denominator = Math.Cos(value) + 0.5;
                double term = Math.Pow(numerator / denominator, 3);
                p *= term;
                k++;                            
            }
            return p;
        }
    }
}
