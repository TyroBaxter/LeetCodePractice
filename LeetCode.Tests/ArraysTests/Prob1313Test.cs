using LeetCode.Code;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using LeetCode.Code.Arrays;

namespace LeetCode.Tests
{
    [TestClass]
    public class Prob1313Test
    {
        //Input: nums = [1,2,3,4]
        //Output: [2,4,4,4]
        [TestMethod]
        public void It_should_return_2444()
        {
            var p = new Prob1313();
            var result = p.DecompressRLElist(new int[] { 1, 2, 3, 4 });

            CollectionAssert.AreEquivalent(result, new int[] { 2, 4, 4, 4 });
        }


        //Input: nums = [1,1,2,3]
        //Output: [1,3,3]
        [TestMethod]
        public void It_should_return_133()
        {
            var p = new Prob1313();
            var result = p.DecompressRLElist(new int[] { 1, 1, 2, 3 });

            CollectionAssert.AreEquivalent(result, new int[] { 1, 3, 3 });
        }
    }
}
