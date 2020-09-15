using System;
using System.Collections.Generic;
using System.Text;
using LeetCode.Code.Arrays;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Tests.ArraysTests
{
    [TestClass]
    public class Prob1512Test
    {
        //Input: nums = [1,2,3,1,1,3]
        //Output: 4
        //Explanation: There are 4 good pairs (0,3), (0,4), (3,4), (2,5) 0-indexed.
        [TestMethod]
        public void It_should_return_4()
        {
            var p = new Prob1512();
            var result = p.NumIdenticalPairs(new int[] { 1, 2, 3, 1, 1, 3 });
            var actual = 4;

            Assert.AreEqual(result, actual);
        }

        //Input: nums = [1,1,1,1]
        //Output: 6
        //Explanation: Each pair in the array are good.
        [TestMethod]
        public void It_should_return_6()
        {
            var p = new Prob1512();
            var result = p.NumIdenticalPairs(new int[] {1,1,1,1});
            var actual = 6;

            Assert.AreEqual(actual, result);
        }

        //Input: nums = [1,2,3]
        //Output: 0
        [TestMethod]
        public void It_should_return_0()
        {
            var p = new Prob1512();
            var result = p.NumIdenticalPairs(new int[]{1,2,3});
            var actual = 0;

            Assert.AreEqual(actual, result);
        }
    }
}
