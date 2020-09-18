using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using LeetCode.Code.Arrays;
namespace LeetCode.Tests.ArraysTests
{
    [TestClass]
    public class Prob1394Test
    {
        //Input: arr = [2,2,3,4]
        //Output: 2
        //Explanation: The only lucky number in the array is 2 because frequency[2] == 2.
        [TestMethod]
        public void It_should_return_2()
        {
            var p = new Prob1394();
            var result = p.FindLucky(new int[] { 2, 2, 3, 4 });
            var actual = 2;

            Assert.AreEqual(actual, result);
        }

        //Input: arr = [1,2,2,3,3,3]
        //Output: 3
        //Explanation: 1, 2 and 3 are all lucky numbers, return the largest of them.
        [TestMethod]
        public void It_should_return_3()
        {
            var p = new Prob1394();
            var result = p.FindLucky(new int[]{1,2,2,3,3,3});
            var actual = 3;

            Assert.AreEqual(actual, result);
        }

        //Input: arr = [2,2,2,3,3]
        //Output: -1
        //Explanation: There are no lucky numbers in the array.
        [TestMethod]
        public void It_should_return_negative_1()
        {
            var p = new Prob1394();
            var result = p.FindLucky(new int[]{2,2,2,3,3});
            var actual = -1;

            Assert.AreEqual(actual, result);
        }

        //Input: arr = [5]
        //Output: -1
        [TestMethod]
        public void It_should_return_a_negative_one()
        {
            var p = new Prob1394();
            var result = p.FindLucky(new int[]{5});
            var actual = -1;

            Assert.AreEqual(actual, result);
        }

        //Input: arr = [7,7,7,7,7,7,7]
        //Output: 7
        [TestMethod]
        public void It_should_return_7()
        {
            var p = new Prob1394();
            var result = p.FindLucky(new int[]{7,7,7,7,7,7,7});
            var actual = 7;

            Assert.AreEqual(actual, result);
        }
    }
}
