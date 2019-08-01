using Microsoft.VisualStudio.TestTools.UnitTesting;
using JulianDay;
namespace JulianDayTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(1, Program.Julian(1, 1));
            Assert.AreEqual(365, Program.Julian(12, 31));
            Assert.AreEqual(32, Program.Julian(2, 1));

        }
    }
}
