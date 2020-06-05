using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Code
{
    public class Prob1295
    {
        //Given an array nums of integers, return how many of them contain an even number of digits.
        public int FindNumbers(int[] nums)
        {
            var counter = 0;

            foreach (var num in nums)
            {
                if (countDigitsRecursion(num) % 2 == 0)
                {
                    counter++;
                }

            }

            return counter;
        }

        public static int countDigitsLongform(int n)
        {
            var counter = 0;
            while (n > 0)
            {
                n = n / 10;
                counter++;
            }
            return counter;
        }
        public static int countDigitsRecursion(int n)
        {
            if (n == 0)
                return 0;
            return 1 + countDigitsRecursion(n / 10);
        }
    }
}
