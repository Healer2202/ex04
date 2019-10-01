using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIsContain5()
        {
            int[] Arr1 = new int[] { 1, 2, 3, 4 };
            bool kq1 = InvalidProgramException.IsContain5(Arr1);
            Assert.AreEqual(false, kq1);

            int[] Arr2 = new int[] { 1, 2, 3, 5 };
            bool kq2 = InvalidProgramException.IsContain5(Arr2);
            Assert.AreEqual(true, kq2);
        }
    }
}
