using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Code.LinkedList
{
    public class Prob876
    {
        //Given a non-empty, singly linked list with head node head, return a middle node of linked list.

        //If there are two middle nodes, return the second middle node.
                    
        public static ListNode MiddleNode(ListNode head)
        {
            var currentNodePosition = head; 
            // variable to store counter and interate through nodes in the singly-linked list 
            var counter = 0;
            while (currentNodePosition != null)
            {
                currentNodePosition = currentNodePosition.next;
                counter++;
            }

            var middleNodePositionalValue = (counter/2) + 1;

            var temp = head; 
            for (int i = 1; i < middleNodePositionalValue; i++)
            {
                temp = temp.next;
            }
                        
            return temp;
        }

    }
}
