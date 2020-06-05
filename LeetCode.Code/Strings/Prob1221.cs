using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Code.Strings
{
    public class Prob1221
    {
        //Balanced strings are those who have equal quantity of 'L' and 'R' characters.

        //Given a balanced string s split it in the maximum amount of balanced strings.

        //Return the maximum amount of splitted balanced strings.
        public int BalancedStringSplit(string unbalancedInput)
        {
            //Loop from left to right maintaining a balance variable when it gets an L increase it by one 
            //otherwise decrease it by one.
            var answer = 0;
            var balance = 0;
            foreach (var s in unbalancedInput)
            {
                if (s.Equals('L'))
                {
                    balance++;
                }
                else
                {
                    balance--;
                }

                if (balance == 0)
                {
                    answer++;
                }
            }

            return answer;
            //Whenever the balance variable reaches zero then we increase the answer by one.
        }
    }
}
