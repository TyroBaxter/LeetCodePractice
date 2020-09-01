using LeetCode.Code.LinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Tests.LinkedListTests
{
    [TestClass]
    public class Prob206Test
    {
        //Input: 1->2->3->4->5->NULL
        //Output: 5->4->3->2->1->NULL
        [TestMethod]
        public void It_should_return_a_reversed_linked_list()
        {
            var p = new Prob206();
            var result = p.ReverseList(new ListNode
            {
                val = 1,
                next = new ListNode
                {
                    val = 2,
                    next = new ListNode
                    {
                        val = 3,
                        next = new ListNode
                        {
                            val = 4,
                            next = new ListNode
                            {
                                val = 5
                            }
                        }
                    }
                }
            });

            Assert.AreEqual(result, (new ListNode
            {
                val = 5,
                next = new ListNode
                {
                    val = 4,
                    next = new ListNode
                    {
                        val = 3,
                        next = new ListNode
                        {
                            val = 2,
                            next = new ListNode
                            {
                                val = 1
                            }
                        }
                    }
                }
            });
        }
    }
}
