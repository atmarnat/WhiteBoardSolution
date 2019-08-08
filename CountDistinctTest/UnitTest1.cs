using Microsoft.VisualStudio.TestTools.UnitTesting;
using CountDistinct;
namespace CountDistinctTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            Assert.AreEqual(5, Program.CountDistinctElements(arr));
            Assert.AreEqual(5, Program.CountDistinct2(arr));
        }
        [TestMethod]
        public void TestMethod2()
        {
            int[] arr = new int[] { 1, 1, 2, 3, 4 };
            Assert.AreEqual(4, Program.CountDistinctElements(arr));
            Assert.AreEqual(4, Program.CountDistinct2(arr));
        }
        [TestMethod]
        public void TestMethod3()
        {
            int[] arr = new int[] { 1, 1, 1, 1, 1 };
            Assert.AreEqual(1, Program.CountDistinctElements(arr));
            Assert.AreEqual(1, Program.CountDistinct2(arr));
        }
        [TestMethod]
        public void TestMethod4()
        {
            int[] arr = new int[0];
            Assert.AreEqual(0, Program.CountDistinctElements(arr));
            Assert.AreEqual(0, Program.CountDistinct2(arr));
        }
    }
}
