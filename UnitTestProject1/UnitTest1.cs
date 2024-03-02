using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = 21;

            int y = 10;

            int sum = x + y;
        }


        [TestMethod]
        public void TestMethod2()
        {
            int x = 15;
            int y = 15;
            int wait = 30;
            var res = x + y;
            Assert.AreEqual(wait,res);
        }
    }
}
