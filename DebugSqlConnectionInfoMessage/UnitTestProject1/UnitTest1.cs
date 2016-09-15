using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AllPrintsCaptured()
        {
            var helper = new Helper.Helper();
            var msgs = helper.RunTestPrintsSpWorks();
            var expected = new List<string>() { "hello world 1", "hello world 2" };
            CollectionAssert.AreEqual(expected, msgs);
        }

        [TestMethod]
        public void NotAllPrintsCaptured()
        {
            var helper = new Helper.Helper();
            var msgs = helper.RunTestPrintsSpFails();
            var expected = new List<string>() { "hello world 1", "hello world 2" };
            CollectionAssert.AreEqual(expected, msgs);
        }
    }
}
