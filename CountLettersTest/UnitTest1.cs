using Microsoft.VisualStudio.TestTools.UnitTesting;
using CountLetters;

namespace CountLettersTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(12, Program.NumLetters("Melinda Rocks"));
            Assert.AreEqual(0, Program.NumLetters(" "));
            Assert.AreEqual(0, Program.NumLetters(""));
            Assert.AreEqual(8, Program.NumLetters("a a a a a a a a"));
            Assert.AreEqual(13, Program.NumLetters("We Like To Party"));
            Assert.AreEqual(16, Program.NumLetters("awadda umma mow mow"));
            Assert.AreEqual(17, Program.NumLetters("test-42-8509345 ,e"));
        }
    }
}
