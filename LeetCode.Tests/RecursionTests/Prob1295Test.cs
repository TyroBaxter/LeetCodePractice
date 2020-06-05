using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using LeetCode.Code;


namespace LeetCode.Tests
{
    [TestClass]
    public class Prob1295Test
    {
        [TestMethod]
        public void It_should_return_2()
        {
            //Input: nums = [12, 345, 2, 6, 7896]
            //Output: 2
            //Explanation:
            //12 contains 2 digits(even number of digits).
            //345 contains 3 digits(odd number of digits).
            //2 contains 1 digit(odd number of digits).
            //6 contains 1 digit(odd number of digits).
            //7896 contains 4 digits(even number of digits).
            //Therefore only 12 and 7896 contain an even number of digits.
            var p = new Prob1295();

            var result = p.FindNumbers(new int[] { 12, 345, 2, 6, 7896 });
            Assert.AreEqual(result, 2);
        }

        [TestMethod]
        public void It_should_return_1()
        {
            //Input: nums = [555, 901, 482, 1771]
            //Output: 1
            //Explanation:Only 1771 contains an even number of digits.
            var p = new Prob1295();

            var result = p.FindNumbers(new int[] { 555, 901, 482, 1771 });
            Assert.AreEqual(result, 1);
         
        }
    }
}
