using Tyuiu.VekshinGF.Sprint3.Task5.V30.Lib;

namespace Tyuiu.VekshinGF.Sprint3.Task5.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void GetSumSumSeries_x2_i1_3_k1_11_Returns68()
        {
            DataService ds = new DataService();
            int x = 2;
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 3;
            int stopValue2 = 11;
            double expected = 68;

            double result = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetSumSumSeries_x0_Returns0()
        {
            DataService ds = new DataService();
            int x = 0;
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 3;
            int stopValue2 = 11;

            // x³=0, внутр. сумма = Σ(k=1..11)(-k) = -66, внешн. = 3×(-66) = -198, +x=0
            double expected = -198;

            double result = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

            Assert.AreEqual(expected, result);
        }
    }
}