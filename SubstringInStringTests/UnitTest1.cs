using Microsoft.VisualStudio.TestTools.UnitTesting;
using SubstringInString;

namespace SubstringInStringTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(1 == Program.IndexOfSubstring("Mississippi", "is"));
            Assert.IsTrue(-1 == Program.IndexOfSubstring("Turtle", "Turtles"));
            Assert.IsTrue(0 == Program.IndexOfSubstring("", ""));
        }
    }
}
