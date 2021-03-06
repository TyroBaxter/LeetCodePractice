﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Code.Arrays
{
    public class Prob1480
    {
        //Given an array nums. We define a running sum of an array as runningSum[i] = sum(nums[0]…nums[i]).
        //Return the running sum of nums.
        //Input: nums = [1,2,3,4]
        //Output: [1,3,6,10]
        //Explanation: Running sum is obtained as follows: [1, 1+2, 1+2+3, 1+2+3+4].
        public int[] RunningSum(int[] nums)
        {
            if (nums.Length == 1)
            {
                return nums;
            }
            //to reduce space complexity, operating on the input int[] nums itself
            for (int i = 1; i < nums.Length; i++)
            {
                nums[i] = nums[i] + nums[i-1];
            }

            return nums;
          
        }
    }
}