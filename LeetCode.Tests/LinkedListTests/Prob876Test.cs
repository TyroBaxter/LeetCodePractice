using LeetCode.Code.LinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Tests.LinkedListTests
{
    [TestClass]
    public class Prob876Test
    {
        //        Example 1:

        //Input: [1,2,3,4,5]
        //Output: Node 3 from this list (Serialization: [3,4,5])
        //The returned node has value 3.  (The judge's serialization of this node is [3,4,5]).
        //Note that we returned a ListNode object ans, such that:
        //ans.val = 3, ans.next.val = 4, ans.next.next.val = 5, and ans.next.next.next = NULL.

        [TestMethod]
        public void It_should_return_3()
        {
            //sorry 
            var result = Prob876.MiddleNode(new ListNode
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

            Assert.AreEqual(result.val, 3);


        }

        //        Example 2:

        //Input: [1,2,3,4,5,6]
        //        Output: Node 4 from this list (Serialization: [4,5,6])
        //Since the list has two middle nodes with values 3 and 4, we return the second one.
        [TestMethod]
        public void It_should_return_4()
        {
            var result = Prob876.MiddleNode(new Prob876.ListNode
            {
                val = 1,
                next =

                    new Prob876.ListNode
                    {
                        val = 2,
                        next =

                            new Prob876.ListNode
                            {
                                val = 3,
                                next =

                                    new Prob876.ListNode
                                    {
                                        val = 4,
                                        next =

                                            new Prob876.ListNode
                                            {
                                                val = 5,
                                                next =

                                                    new Prob876.ListNode
                                                    {
                                                        val = 6
                                                    }

                                            }

                                    }

                            }

                    }

            });

            Assert.AreEqual(result.val, 4);
        }


    }
}
