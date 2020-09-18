using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using LeetCode.Code.Arrays;

namespace LeetCode.Tests.ArraysTests
{
    [TestClass]
    public class Prob977Test
    {
        //Input: [-4,-1,0,3,10]
        //Output: [0,1,9,16,100]

        [TestMethod]
        public void It_should_return_0_1_9_16_100()
        {
            var p = new Prob977();
            var result = p.SortedSquares(new int[] { -4, -1, 0, 3, 10 });
            var actual = new int[] { 0, 1, 9, 16, 100 };

            CollectionAssert.AreEquivalent(actual, result);
        }

        //Input: [-7,-3,2,3,11]
        //Output: [4,9,9,49,121]
        [TestMethod]
        public void It_should_return_4_9_9_49_121()
        {
            var p = new Prob977();
            var result = p.SortedSquares(new int[] { -7, -3, 2, 3, 11 });
            var actual = new int[] { 4, 9, 9, 49, 121 };

            CollectionAssert.AreEquivalent(actual, result);
        }
    }
}
