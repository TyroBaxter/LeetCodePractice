using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Code
{
    public class Prob1281
    {
        public int SubtractProductAndSum(int n)
        {
            //Input: n = 234
            //Output: 15
            //Explanation:
            //Product of digits = 2 * 3 * 4 = 24
            //Sum of digits = 2 + 3 + 4 = 9
            //Result = 24 - 9 = 15
            var individualNumbers = new List<int>();
            if (n % 10 > 0 )
            {
                individualNumbers.Add(n % 10);
            }

            var numProduct = 0;
            //var productOfNumbers = individualNumbers.
            foreach (var num in individualNumbers)
            {

            }
            var summationOfNumbers = individualNumbers.Sum();

            return productOfNumbers - summationOfNumbers;
        }
    }
}
