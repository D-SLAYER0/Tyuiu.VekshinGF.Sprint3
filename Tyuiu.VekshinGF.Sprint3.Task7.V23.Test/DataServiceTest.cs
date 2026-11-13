using Tyuiu.VekshinGF.Sprint3.Task7.V23.Lib;
namespace Tyuiu.VekshinGF.Sprint3.Task7.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double[] result = ds.GetMassFunction(-5, 5);

            Assert.AreEqual(11, result.Length);
        }

        [TestMethod]
        public void GetFunctionArray_x1_ReturnsZero()
        {
            DataService ds = new DataService();
            double[] result = ds.GetMassFunction(-5, 5);

            // x = 1 находится на индексе 6 (startValue = -5, индекс = 1 - (-5) = 6)
            Assert.AreEqual(0, result[6]);
        }

        [TestMethod]
        public void GetFunctionArray_minus5_to_5_CheckValues()
        {
            DataService ds = new DataService();
            double[] result = ds.GetMassFunction(-5, 5);

            // Проверка нескольких ключевых значений
            Assert.AreEqual(13.81, result[0]);  // x = -5
            Assert.AreEqual(2.50, result[5]);   // x = 0
            Assert.AreEqual(0, result[6]);      // x = 1 (деление на ноль)
            Assert.AreEqual(-5.71, result[10]); // x = 5
        }
    }
}

