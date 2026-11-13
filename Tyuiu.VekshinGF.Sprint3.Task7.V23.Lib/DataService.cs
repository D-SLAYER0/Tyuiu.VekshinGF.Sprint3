using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.VekshinGF.Sprint3.Task7.V23.Lib
{
    public class DataService : ISprint3Task7V23
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int count = stopValue - startValue + 1;
            double[] result = new double[count];
            int index = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = 2.0 * x - 2;

                if (denominator == 0)
                {
                    result[index] = 0;
                }
                else
                {
                    double fx = 4 - 2.0 * x + (2 + Math.Cos(x)) / denominator;
                    result[index] = Math.Round(fx, 2);
                }

                index++;
            }

            return result;
        }
    }
}
