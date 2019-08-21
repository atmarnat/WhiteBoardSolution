using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumOccurrences;

namespace NumOccurTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(4, Program.NumOccurences("Mississippi", 's'));
            Assert.AreEqual(1, Program.NumOccurences("dog", 'o'));
            Assert.AreEqual(1, Program.NumOccurences("904tu whwrb w495y8um49u bw509yu .", '.'));
            Assert.AreEqual(7, Program.NumOccurences("Awadda oo mao mao, baba o mao mamao", 'o'));
        }
    }
}
