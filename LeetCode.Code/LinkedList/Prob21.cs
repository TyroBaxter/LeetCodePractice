using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Code.LinkedList
{
    public class Prob21
    {
        //Merge two sorted linked lists and return it as a new sorted list.
        //The new list should be made by splicing together the nodes of the first two lists.
        public ListNode MergeTwoLists(ListNode initialInput, ListNode secondInput)
        {
            //convert each LinkedNode to a list
            List<int> convertedInitialInput = null;
            while (initialInput != null)
            {
                convertedInitialInput.Add(initialInput.val);
            }

            List<int> convertedSecondInput = null;
            while (secondInput != null)
            {
                convertedSecondInput.Add(secondInput.val);
            }
            //combine both lists 
            var combinedConvertedInput = convertedInitialInput.Concat(convertedSecondInput);
            //sort the combined list 
            var outputList = combinedConvertedInput.ToList();
            outputList.Sort();

            //turn the combined list into a LinkedNode 
            ListNode mergedInput = null;



            return mergedInput;
        }
    }
}
