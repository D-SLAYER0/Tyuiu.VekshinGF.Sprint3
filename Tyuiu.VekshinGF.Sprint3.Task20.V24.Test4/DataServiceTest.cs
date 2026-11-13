using Tyuiu.VekshinGF.Sprint3.Task20.V24.Lib;
namespace Tyuiu.VekshinGF.Sprint3.Task20.V24.Test4
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double a = 0.25;
            int startValue = 1;
            int stopValue = 8;
            double expected = 55217.45;

            double result = ds.GetMultiplySeries(a, startValue, stopValue);

            Assert.AreEqual(expected, result, 0.01);
        }
    }
}
