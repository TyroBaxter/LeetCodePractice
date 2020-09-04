using LeetCode.Code.LinkedList;
using LeetCode.Code.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Tests.LinkedListTests
{
    [TestClass]
    public class Prob1290Test
    {
        [TestMethod]
        public void It_should_return_5()
        {
            var p = new Prob1290();

            var result = p.GetDecimalValue(new[]
            {
                1
            }.ToLinkedList());

            Assert.AreEqual(result, 5);

        }

        [TestMethod]
        public void It_should_return_0()
        {
            var p = new Prob1290();

            var result = p.GetDecimalValue(new[]
            {
                0
            }.ToLinkedList());

            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void It_should_return_1880()
        {
            var p = new Prob1290();

            var result = p.GetDecimalValue(new[]
            {
                1,0,0,1,0,0,1,1,1,0,0,0,0,0,0
            }.ToLinkedList());

            Assert.AreEqual(result, 1880);
        }



    }
}
