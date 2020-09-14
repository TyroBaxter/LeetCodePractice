using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

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
        }



        [TestMethod]
        public void It_should_return_true_false_false_false_false()
        {
            //Input: candies = [4,2,1,1,2], extraCandies = 1
            //Output: [true,false,false,false,false]
        }

        [TestMethod]
        public void It_should_return_true_false_true()
        {
            ///Input: candies = [12,1,12], extraCandies = 10
            //Output: [true,false,true]
        }
    }
}
