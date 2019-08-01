using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapitalLetters;

namespace CapitalLettersTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(5, Program.CountCapitals("AbcDeFGhiK"));
            Assert.AreEqual(2, Program.CountCapitals("Star Wars"));
        }
    }
}
