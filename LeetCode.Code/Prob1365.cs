using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Code
{
    public class Prob1365
    {
        //Given the array nums, for each nums[i] find out how many numbers in the 
        //    array are smaller than it.That is, for each nums[i] you have to count 
        //        the number of valid j's such that j != i and nums[j] < nums[i].

        //    Return the answer in an array.

        public int[] SmallerNumbersThanCurrent(int[] nums)
        {
            var numPlaceCount = nums.Length;
            var newNumArray = new int[numPlaceCount];

            var arrayIndex = 0;
            foreach (var num in nums)
            {
                newNumArray[arrayIndex] = CountNumbersSmallerThan(nums, num);
                arrayIndex++;
            }
            return newNumArray;
        }

        private int CountNumbersSmallerThan(int[] nums, int num)
        {
            var counter = 0; 
            foreach (var number in nums)
            {
                if (num > number)
                {
                    counter++;
                }
            }
            return counter;
        }


    }
}
