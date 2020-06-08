using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using LeetCode.Code.Arrays;

namespace LeetCode.Tests.ArraysTests
{
    [TestClass]
    public class Prob1470Test
    {
        [TestMethod]
        public void It_should_return_235417()
        {
            //        Input: nums = [2, 5, 1, 3, 4, 7], n = 3
            //Output: [2, 3, 5, 4, 1, 7]
            //Explanation: Since x1 = 2, x2 = 5, x3 = 1, y1 = 3, y2 = 4, y3 = 7 then the answer is [2, 3, 5, 4, 1, 7].
            var p = new Prob1470();

            var result = p.Shuffle(new int[] { 2, 5, 1, 3, 4, 7 }, 3);
            CollectionAssert.AreEquivalent(result, new int[] { 2, 3, 5, 4, 1, 7 });
        }

        [TestMethod]
        public void It_should_return_14233241()
        {
            //        Input: nums = [1, 2, 3, 4, 4, 3, 2, 1], n = 4
            //Output: [1, 4, 2, 3, 3, 2, 4, 1]
            var p = new Prob1470();

            var result = p.Shuffle(new int[] { 1, 2, 3, 4, 4, 3, 2, 1 }, 4);
            CollectionAssert.AreEquivalent(result, new int[] { 1, 4, 2, 3, 3, 2, 4, 1 });
        }

        [TestMethod]
        public void It_should_return_1212()
        {
            //        Input: nums = [1, 1, 2, 2], n = 2
            //Output: [1, 2, 1, 2]
            var p = new Prob1470();

            var result = p.Shuffle(new int[] { 1, 1, 2, 2 }, 2);
            CollectionAssert.AreEquivalent(result, new int[] { 1, 2, 1, 2 });
        }
    }
}
