using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClockAngle;

namespace ClockAngleTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(180, Program.Angle(0, 6));
            Assert.AreEqual(0, Program.Angle(0, 12));
        }
    }
}
