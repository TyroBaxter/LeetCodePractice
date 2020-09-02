using LeetCode.Code.LinkedList;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Code.Extensions
{
    public static class ArrayExtensions
    {
        public static ListNode ToLinkedList(this int[] input)
        {
            ListNode currentPosition = null;
            ListNode previousPosition = null;
            foreach (var item in input)
            {
                //assign the current int item to the currentPosition value 
                previousPosition.val = item;
                //move to the next node 
                previousPosition = previousPosition.next;
            }

            return previousPosition;
        }
    }
}
