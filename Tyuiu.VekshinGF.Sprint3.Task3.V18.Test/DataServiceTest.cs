using Tyuiu.VekshinGF.Sprint3.Task3.V18.Lib;
namespace Tyuiu.VekshinGF.Sprint3.Task3.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string input = "4n5nvf 56 bgy";
            char item = 'n';
            string expected = "nnnnvf nn bgy";

            
            string result = ds.ReplaceNumOnChar(input, item);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ReplaceNumOnChar_EmptyString_ReturnsEmpty()
        {
            DataService ds = new DataService();
            string input = "";
            char item = 'n';
            string expected = "";

            string result = ds.ReplaceNumOnChar(input, item);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ReplaceNumOnChar_NoDigits_ReturnsOriginal()
        {
            DataService ds = new DataService();
            string input = "abc xyz";
            char item = 'n';
            string expected = "abc xyz";

            string result = ds.ReplaceNumOnChar(input, item);

            Assert.AreEqual(expected, result);
        }
    }
}
