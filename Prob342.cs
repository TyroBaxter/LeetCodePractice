using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Prob342
    {
        public bool IsPowerOfFour(int num)
        {
            //Given an integer(signed 32 bits), write a function to check whether it is a power of 4.
                        
            var baseNum = Math.Pow(num, (1.0 / 4.0));
            var baseNumDifference = Math.Ceiling(baseNum) - Math.Floor(baseNum);
            if (num == 0)
            {
                return false;
            }
            else if (baseNumDifference == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
                       
        }
    }
}
