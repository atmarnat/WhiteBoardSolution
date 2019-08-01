using Microsoft.VisualStudio.TestTools.UnitTesting;
using SumOfOdd;

namespace SumOfOddsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void sumOfOddTest10()
        {
            Assert.AreEqual(25, Program.sumOfOdd(10));
           // Assert.AreEqual(16, Program.sumOfOdd(10));
        }
    }
}
