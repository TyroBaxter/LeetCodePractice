using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Code.Arrays
{
    public class Prob905
    {
        //Given an array A of non-negative integers, return an array consisting of all
        //the even elements of A, followed by all the odd elements of A.
        //You may return any answer array that satisfies this condition.
        public int[] SortArrayByParity(int[] A)
        {
           IList<int> odd = new List<int>();
            IList<int> even = new List<int>();

            foreach (var num in A)
            {
                if (num % 2 == 0)
                {
                    even.Add(num);
                }
                else
                {
                    odd.Add(num);
                }
            }
            var temp = even.Concat(odd);
            return temp.ToArray();
        }
    }
}
