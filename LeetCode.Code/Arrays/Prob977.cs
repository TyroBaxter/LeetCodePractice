using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Code.Arrays
{
    public class Prob977
    {
        //Given an array of integers A sorted in non-decreasing order, 
        //return an array of the squares of each number, also in sorted non-decreasing order.
        public int[] SortedSquares(int[] A)
        {
            foreach (var num in A)
            {
                Math.Pow(num,2);
            }

            return A;
        }
    }
}
