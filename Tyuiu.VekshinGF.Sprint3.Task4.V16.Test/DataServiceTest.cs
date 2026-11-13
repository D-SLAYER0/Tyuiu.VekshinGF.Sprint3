using Tyuiu.VekshinGF.Sprint3.Task4.V16.Lib;
namespace Tyuiu.VekshinGF.Sprint3.Task4.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            double result = ds.Calculate(startValue, stopValue);

            // Проверяем, что результат не равен нулю и не NaN
            Assert.IsFalse(double.IsNaN(result));
            Assert.IsFalse(double.IsInfinity(result));
            Assert.AreNotEqual(0, result);

            // Выводим результат для проверки
            Console.WriteLine($"Result: {result}");
        }

        [TestMethod]
        public void GetMultiplyFunctionValue_SkipZero_DoesNotThrow()
        {
            DataService ds = new DataService();
            int startValue = -1;
            int stopValue = 1;

            // Должно выполниться без исключения (x=0 пропускается)
            double result = ds.Calculate(startValue, stopValue);

            Assert.IsFalse(double.IsNaN(result));
        }
    }
}
