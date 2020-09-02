using LeetCode.Code.Extensions;
using LeetCode.Code.LinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Tests.LinkedListTests
{
    [TestClass]
    public class Prob21Test
    {
        //Input: 1->2->4, 1->3->4
        //Output: 1->1->2->3->4->4
        [TestMethod]
        public void It_should_merge_the_two_linked_lists()
        {
            var p = new Prob21();

            var result = p.MergeTwoLists(new[]
            {
                1,2,4
            }.ToLinkedList(), new []
            {
                1,3,4
            }.ToLinkedList());
            
        }
    }
}
