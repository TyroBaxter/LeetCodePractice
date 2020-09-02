using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Code.LinkedList
{
    public class Prob206
    {
        //Can be implemented iteratively or recursively 
        public ListNode ReverseList(ListNode head)
        {
            if (head == null)
            {
                return head;
            }
            //create new placeholders
            var currentPosition = new ListNode();
            var previousPosition = new ListNode();

            //iterate through the ListNode and place values into placeholders
            while (head != null)
            {
                currentPosition = head.next;
                head.next = previousPosition;
                previousPosition = head;
                head = currentPosition;
            }

            return previousPosition;

        }


    }
}
