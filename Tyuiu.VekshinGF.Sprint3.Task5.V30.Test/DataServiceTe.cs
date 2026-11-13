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
            double result = ds.GetSumSumSeries(2, 1, 1, 3, 11);
            Assert.AreEqual(132.0, result);
        }
    }
}