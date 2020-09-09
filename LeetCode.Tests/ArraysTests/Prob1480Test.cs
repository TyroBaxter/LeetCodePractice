using LeetCode.Code.Arrays;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Tests.ArraysTests
{
    [TestClass]
    public class Prob1480Test
    {
        [TestMethod]
        public void It_should_return_1_3_6_10()
        {
            var p = new Prob1480();
            var result = p.RunningSum(new int[] { 1, 2, 3, 4 });

            CollectionAssert.AreEquivalent(result, new int[] { 1, 3, 6, 10 });
        }

        [TestMethod]
        public void It_should_return_1_2_3_4_5()
        {
            var p = new Prob1480();
            var result = p.RunningSum(new int[]{1,1,1,1,1});

            CollectionAssert.AreEquivalent(result, new int[] {1,2,3,4,5 });
        }
    }
}
