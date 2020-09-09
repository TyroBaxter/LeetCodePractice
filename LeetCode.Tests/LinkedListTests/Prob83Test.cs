using LeetCode.Code.Extensions;
using LeetCode.Code.LinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Tests.LinkedListTests
{
    [TestClass]
    public class Prob83Test
    {
        [TestMethod]
        public void It_should_return_1_2()
        {
            var p = new Prob83();
            //var result = p.DeleteDuplicates(new[]
            //{
            //    1,1,2
            //}.ToLinkedList());
            var result = p.DeleteDuplicates(new ListNode
            {
                val = 1,
                next = new ListNode
                {
                    val = 1,
                    next = new ListNode
                    {
                        val = 2

                    }
                }
            });

            Assert.AreEqual(result, (new ListNode
            {
                val = 1,
                next = new ListNode
                {
                    val = 2
                }
            }));
        }

        [TestMethod]
        public void It_should_return_1_2_3()
        {
            var p = new Prob83();
            var result = p.DeleteDuplicates(new[]
            {
                1,1,2,3,3
            }.ToLinkedList());

            Assert.AreEqual(result, new[] { 1, 2, 3 }.ToLinkedList());
        }
    }
}
