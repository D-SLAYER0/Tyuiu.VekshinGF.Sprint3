using Tyuiu.VekshinGF.Sprint3.Task6.V18.Lib;
namespace Tyuiu.VekshinGF.Sprint3.Task6.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = 9;
            int stopValue = 18;
            int expected = 95;

            int result = ds.GetSumTheDivisors(startValue, stopValue);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetSumDivisorsLessThan10_1_to_5_Returns12()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 5;
            // 1: 1; 2: 1,2; 3: 1,3; 4: 1,2,4; 5: 1,5 → сумма = 1+1+2+1+3+1+2+4+1+5 = 21
            // Но делители < 10, так что все подходят
            // 1: 1; 2: 1,2; 3: 1,3; 4: 1,2,4; 5: 1,5 → 1+1+2+1+3+1+2+4+1+5 = 21
            int expected = 21;

            int result = ds.GetSumTheDivisors(startValue, stopValue);

            Assert.AreEqual(expected, result);
        }
    }
}
