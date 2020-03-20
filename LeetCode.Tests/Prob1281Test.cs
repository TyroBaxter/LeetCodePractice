using LeetCode.Code;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Tests
{
    [TestClass]
    public class Prob1281Test
    {
        [TestMethod]
        public void It_should_return_15()
        {
            var p = new Prob1281();
            var result = p.SubtractProductAndSum(234);

            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void It_should_return_21()
        {
            var p = new Prob1281();
            var result = p.SubtractProductAndSum(4421);

            Assert.AreEqual(21, result);
        }
    }
}
