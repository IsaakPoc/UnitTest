﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(true, false);
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual(true, true);
        }
    }
}
