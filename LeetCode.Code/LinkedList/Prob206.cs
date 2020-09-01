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
            //create new list 
            var temp = new List<int>();


            //iteratete through the ListNode and place values into array
            while (head != null)
            {
                temp.Add(head.val);
                head = head.next;
                
            }
            //call list.reverse 
             temp.Reverse();
            //iterate through the reversed list and place values into new linked list
            var reversedInput = new ListNode();
            var currentPosition = reversedInput;
            foreach (var value in temp)
            {
                currentPosition.val = value;
                //the link portion of the linked list 
                currentPosition.next = new ListNode();
                currentPosition = currentPosition.next;
                
            }

            //return the new linked list 
            return reversedInput;
        }
    }
}
