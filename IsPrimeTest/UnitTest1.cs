using Microsoft.VisualStudio.TestTools.UnitTesting;
using IsPrime;

namespace IsPrimeTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsFalse(Program.IsPrime(0));
            Assert.IsFalse(Program.IsPrime(1));
            Assert.IsTrue(Program.IsPrime(2));
            Assert.IsTrue(Program.IsPrime(3));
            Assert.IsFalse(Program.IsPrime(4));
            Assert.IsTrue(Program.IsPrime(5));
            Assert.IsFalse(Program.IsPrime(6));
            Assert.IsTrue(Program.IsPrime(7));
            Assert.IsFalse(Program.IsPrime(8));
            Assert.IsFalse(Program.IsPrime(9));
            Assert.IsFalse(Program.IsPrime(10));
            Assert.IsTrue(Program.IsPrime(11));
            Assert.IsFalse(Program.IsPrime(12));
            Assert.IsTrue(Program.IsPrime(13));
            Assert.IsFalse(Program.IsPrime(14));
        }
    }
}
