using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Code.LinkedList
{
    public class Prob83
    {
        //Given a sorted linked list, delete all duplicates such that each element appear only 
        public ListNode DeleteDuplicates(ListNode head)
        {
            var result = new ListNode();
            Dictionary<int, int> temp = new Dictionary<int, int>();
            //walk through the nodes of the input
            while (head != null)
            {
                temp.Add(head.val, head.val);
                head = head.next;
            }
            //add each val to a dictionary as the key
            //if the val already exists it can't be added to the dictionary as all keys must be unique

            //foreach value in the temp dictionary, add it to the result linked list 
            //var currentPosition = result.val;
            
            foreach (var value in temp.Values)
            {
                result.val = value;
                result = result.next;
            }
            //return the result linked list                      
            return result;
        }
    }
}
