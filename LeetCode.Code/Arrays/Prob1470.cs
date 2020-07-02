using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Code.Arrays
{
    public class Prob1470
    {
        //        Given the array nums consisting of 2n elements in the form[x1, x2, ..., xn, y1, y2, ..., yn].
        // 1,2,3, ....,n , n+1, n+2,n+3 
        // 1,n, 2,n+1, 
        //Return the array in the form[x1, y1, x2, y2, ..., xn, yn].
        public static int[] Shuffle(int[] nums, int n)
        {

            //creating a new list 
            var shuffledData = new List<int>();

            for (var i = 0; i < n; i ++)
            {
                shuffledData.Add(nums[i]);
                shuffledData.Add(nums[n + i]);
                
            }

            return shuffledData.ToArray();
        }
    }
}
