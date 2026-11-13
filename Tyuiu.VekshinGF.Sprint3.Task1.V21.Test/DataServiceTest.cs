using Tyuiu.VekshinGF.Sprint3.Task1.V21;
using Tyuiu.VekshinGF.Sprint3.Task1.V21.Lib;
namespace Tyuiu.VekshinGF.Sprint3.Task1.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            
           DataService ds = new DataService();
           int x = 1, start = 1, stop = 12;

            double expected = 1.7339e27;
            double delta = 1e24;   // допустимая погрешность для большого double

            double result = ds.GetMultiplySeries(x, start, stop);

            Assert.AreEqual(expected, result, delta);
            
        }
    }
}
