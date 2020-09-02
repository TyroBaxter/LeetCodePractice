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

        public ListNode MergeTwoListsTakeTwo(ListNode currentFirstInput, ListNode currentSecondInput)
        {
            var newHead = new ListNode(-1);
            var currentPosition = newHead;

            //initial guard-clause null check
            while (currentFirstInput != null && currentSecondInput != null)
            {

                if (currentFirstInput.val <= currentSecondInput.val)
                {
                    currentPosition.next = currentFirstInput;
                    currentFirstInput = currentFirstInput.next;
                }
                else
                {
                    currentPosition.next = currentSecondInput;
                    currentSecondInput = currentSecondInput.next;
                }

                currentPosition = currentPosition.next;
            }

            while (currentFirstInput != null)
            {
                currentPosition.next = currentFirstInput;
                currentPosition = currentPosition.next;
                currentFirstInput = currentFirstInput.next;
            }

            while (currentSecondInput != null)
            {
                currentPosition.next = currentSecondInput;
                currentPosition = currentPosition.next;
                currentSecondInput = currentSecondInput.next;
            }

            //this assigns the pointer from newHead which will then follow the new 'chain'
            //that currentPosition created as it reassigned pointers while traversing
            //along currentFirstInput and currentSecondInput
            var mergedInputResult = newHead.next;

            //This then destroys the linkage newHead has with the variables that exist outside the method.
            //This is done to prevent memory leakage, as a temporary variable internal to a method should not
            //persist outside of that method. This is done as a Best Practice and is not related to the functionality
            //of the method. It is also probable that the C# garbage collector will take care of this on its own anyway,
            //but better to be safe than sorry. 
            newHead.next = null;

            return mergedInputResult;






        }
    }
}
