using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.VekshinGF.Sprint3.Task0.V14.Lib;

namespace Tyuiu.VekshinGF.Sprint3.Task0.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void GetMultiplySeries_n2_k1_to_5_Returns14400()
        {
            
            DataService ds = new DataService();
            int n = 2;
            int startValue = 1;
            int stopValue = 5;
            double expected = 14400.0;

            
            double result = ds.GetMultiplySeries(n, startValue, stopValue);

            Assert.AreEqual(expected, result, 0.00001);
        }

        [TestMethod]
        public void GetMultiplySeries_n1_k1_to_3_Returns6()
        {
            
            DataService ds = new DataService();
            int n = 1;
            int startValue = 1;
            int stopValue = 3;
            double expected = 6.0; // (1/1)^-1 * (1/2)^-1 * (1/3)^-1 = 1 * 2 * 3 = 6

            
            double result = ds.GetMultiplySeries(n, startValue, stopValue);

            
            Assert.AreEqual(expected, result, 0.00001);
        }
    }
}