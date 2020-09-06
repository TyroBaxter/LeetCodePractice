using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Code.LinkedList
{
    public class Prob1290
    {
        //    Given head which is a reference node to a singly-linked list.
        //   The value of each node in the linked list is either 0 or 1. 
        //   The linked list holds the binary representation of a number.

        //    Return the decimal value of the number in the linked list.
        public int GetDecimalValue(ListNode head)
        {
            //While this solution is straightforward and more human readable than others, e.g.
            //using bitwise operators, the use of StringBuilder introduces increased space
            //complexity

            StringBuilder temp = new StringBuilder();
            while (head != null)
            {
                temp.Append(head.val);
                head = head.next;
            }

            int result = Convert.ToInt32(temp.ToString(), 2);
            return result;
        }
    }
}
