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
            int x = 1;
            int startValue = 1;
            int stopValue = 12;
            double expected = 16947810.88;

            double result = ds.GetMultiplySeries(x, startValue, stopValue);

            // Assert (допустимая погрешность 0.01 для округленных значений)
            Assert.AreEqual(expected, result, 0.01);

        }
    }
}
