using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using LeetCode.Code.Strings;

namespace LeetCode.Tests.StringsTests
{
    [TestClass]
    public class Prob1221Test
    {
        [TestMethod]
        public void It_should_return_4()
        {
            //Input: s = "RLRRLLRLRL"
            //Output: 4
            //Explanation: s can be split into "RL", "RRLL", "RL", "RL", each substring contains same number of 'L' and 'R'.
            var p = new Prob1221();

            var result = p.BalancedStringSplit("RLRRLLRLRL");
            Assert.AreEqual(result, 4);
        }

        [TestMethod]
        public void It_should_return_3()
        {
            //Input: s = "RLLLLRRRLR"
            //Output: 3
            //Explanation: s can be split into "RL", "LLLRRR", "LR", each substring contains same number of 'L' and 'R'.
            var p = new Prob1221();

            var result = p.BalancedStringSplit("RLLLLRRRLR");
            Assert.AreEqual(result, 3);
        }

        [TestMethod]
        public void It_should_return_1()
        {
            //Input: s = "LLLLRRRR"
            //Output: 1
            //Explanation: s can be split into "LLLLRRRR".
            var p = new Prob1221();

            var result = p.BalancedStringSplit("LLLLRRRR");
            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void It_should_return_2()
        {
            //Input: s = "RLRRRLLRLL"
            //Output: 2
            //Explanation: s can be split into "RL", "RRRLLRLL", since each substring contains an equal number of 'L' and 'R'
            var p = new Prob1221();

            var result = p.BalancedStringSplit("RLRRRLLRLL");
            Assert.AreEqual(result, 2);
        }
    }
}
