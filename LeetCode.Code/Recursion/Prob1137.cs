using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Code.Recursion
{
    public class Prob1137
    {
        //The tribonacci series is a generalization of the Fibonacci sequence 
        //where each term is the sum of the three preceding terms.

        //The Tribonacci sequence Tn is defined as follows: 

        //T0 = 0, T1 = 1, T2 = 1, and Tn+3 = Tn + Tn+1 + Tn+2 for n >= 0.

        //Given n, return the value of Tn.
        public int Tribonacci(int n)
        {
            //var tribonacciSequenceResult = 0;
            ////base case 
            //if (n == 0)
            //{
            //    return tribonacciSequenceResult;
            //}
            ////recursive case 
            //else
            //{
            //    return n + Tribonacci(n - 1);
            //}

            int[] F = new int[38];
            F[0] = 0;
            F[1] = F[2] = 1;

            var tribonacciSequenceResult = 0;
            //Now write a loop where you set F[n+3] = F[n] + F[n+1] + F[n+2], and return F[n].
            if (n == 0)
            {
                //base case 
                return tribonacciSequenceResult;
            }
            else
            {
                //recursive case 
                return F[n] + F[n + 1] + F[n + 2] + Tribonacci(n - 1);
            }


        }
    }
}
