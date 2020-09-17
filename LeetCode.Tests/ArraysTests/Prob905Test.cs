using System;
using System.Collections.Generic;
using System.Text;
using LeetCode.Code.Arrays;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Tests.ArraysTests
{
    [TestClass]
    public class Prob905Test
    {
        //Input: [3,1,2,4]
        //Output: [2,4,3,1]
        //The outputs [4,2,3,1], [2,4,1,3], and [4,2,1,3] would also be accepted.
        [TestMethod]
        public void It_should_return_odds_and_evens()
        {
            var p = new Prob905();
            var actual = p.SortArrayByParity(new int[]{3,1,2,4});
            var result = new int[] {4,2,1,3};

            CollectionAssert.AreEquivalent(result, actual);
        }
    }
}
