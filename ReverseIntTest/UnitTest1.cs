using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReverseInt;

namespace ReverseIntTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(12345, Program.ReverseInt(54321));
        }
        public void TestMethod2()
        {
            Assert.AreEqual(11111, Program.ReverseInt(11111));
        }
        public void TestMethod3()
        {
            Assert.AreEqual(12112, Program.ReverseInt(21121));
        }
        public void TestMethod4()
        {
            Assert.AreEqual(12098, Program.ReverseInt(98021));
        }
        public void TestMethod5()
        {
            Assert.AreEqual(0987, Program.ReverseInt(7890));
        }
    }
}
