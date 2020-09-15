using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Code.Arrays
{
    public class Prob1512
    {
        public int NumIdenticalPairs(int[] nums)
        {
            var countPairs = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        countPairs++;
                    }
                }
            }


            return countPairs;
        }
    }
}
