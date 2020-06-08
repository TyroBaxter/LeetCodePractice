using LeetCode.Code;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Tests
{
    [TestClass]
    public class Prob771Test
    {
        [TestMethod]
        public void Example1()
        {
            //Input: J = "aA", S = "aAAbbbb"
            //Output: 3
            var p = new Prob771();
            var result = p.NumJewelsInStones("aA", "aAAbbbb");

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Example2()
        {
            //Input: J = "z", S = "ZZ"
            //Output: 0
            var p = new Prob771();
            var result = p.NumJewelsInStones("z", "ZZ");

            Assert.AreEqual(0, result);
        }
    }
}
