using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LeetCodeUnitTests
{
    [TestClass]
    public class Prob342Test
    {
        [TestMethod]
        public void It_Should_Return_True_With_4()
        {
            Prob342 p = new Prob342();

            Assert.IsTrue(p.IsPowerOfFour(4));
        }

        [TestMethod]
        public void It_Should_Return_True_With_16()
        {
            Prob342 p = new Prob342();
            Assert.IsTrue(p.IsPowerOfFour(16));
        }

        [TestMethod]
        public void It_Should_Return_True_With_65536()
        {
            Prob342 p = new Prob342();
            Assert.IsTrue(p.IsPowerOfFour(65536));
        }

        [TestMethod]
        public void It_Should_Return_False_With_5()
        {
            Prob342 p = new Prob342();
            Assert.IsTrue(p.IsPowerOfFour(5));
        }

        [TestMethod]
        public void It_Should_Return_False_With_0()
        {
            Prob342 p = new Prob342();
            Assert.IsTrue(p.IsPowerOfFour(0));
        }

        [TestMethod]
        public void It_Should_Return_False_With_Negative_4()
        {
            Prob342 p = new Prob342();
            Assert.IsTrue(p.IsPowerOfFour(-4));
        }
    }
}
