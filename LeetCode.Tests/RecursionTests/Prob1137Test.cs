using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using LeetCode.Code.Recursion;
namespace LeetCode.Tests.RecursionTests
{
    [TestClass]
    public class Prob1137Test
    {
        //Input: n = 4
        //Output: 4
        //Explanation:
        //T_3 = 0 + 1 + 1 = 2
        //T_4 = 1 + 1 + 2 = 4
        [TestMethod]
        public void It_should_return_4()
        {
            var p = new Prob1137();

            var result = p.Tribonacci(4);

            Assert.AreEqual(result, 4);
        }

        //Input: n = 25
        //Output: 1389537
        [TestMethod]
        public void It_should_return_1389537()
        {
            var p = new Prob1137();

            var result = p.Tribonacci(25);
            Assert.AreEqual(result, 1389537);
        }
    }
}
