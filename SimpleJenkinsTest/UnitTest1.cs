using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleJenkinsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void TestMethod1()
        {

            throw new NotImplementedException();

        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(1, 1);
        }
    }
}
