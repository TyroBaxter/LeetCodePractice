﻿using LeetCode.Code.Arrays;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Tests.ArraysTests
{
    [TestClass]
    public class Prob1431Test
    {


        [TestMethod]
        public void It_should_return_true_true_true_false_true()
        {
            //Input: candies = [2,3,5,1,3], extraCandies = 3
            //Output: [true,true,true,false,true] 
            var p = new Prob1431();
            var result = p.KidsWithCandies(new int[] { 2, 3, 5, 1, 3 }, 3);
            IList<bool> actual = new List<bool> { true, true, true, false, true };
            
            CollectionAssert.AreEquivalent(result.ToArray(), actual.ToArray());
                       
        }



        [TestMethod]
        public void It_should_return_true_false_false_false_false()
        {
            //Input: candies = [4,2,1,1,2], extraCandies = 1
            //Output: [true,false,false,false,false]
            var p = new Prob1431();
            IList<bool> result = p.KidsWithCandies(new int[] { 4, 2, 1, 1, 2 }, 1);
            IList<bool> actual = new List<bool> { true, false, false, false, false };
                        
            CollectionAssert.AreEquivalent(result.ToArray(), actual.ToArray());
        }

        [TestMethod]
        public void It_should_return_true_false_true()
        {
            ///Input: candies = [12,1,12], extraCandies = 10
            //Output: [true,false,true]
            var p = new Prob1431();
            var result = p.KidsWithCandies(new int[] { 12, 1, 12 }, 10);
            var actual = new List<bool>(3) { true, false, true };

            CollectionAssert.AreEquivalent(result.ToArray(), actual.ToArray());
        }
    }
}
