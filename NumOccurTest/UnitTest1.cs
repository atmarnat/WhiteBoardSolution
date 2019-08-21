using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumOccurrences;
using CharCount;

namespace NumOccurTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(4, CharCounts.CharacterCount("Mississippi", 's'));
            Assert.AreEqual(1, CharCounts.CharacterCount("dog", 'o'));
            Assert.AreEqual(1, Program.NumOccurences("904tu whwrb w495y8um49u bw509yu .", '.'));
            Assert.AreEqual(7, Program.NumOccurences("Awadda oo mao mao, baba o mao mamao", 'o'));
        }
    }
}
