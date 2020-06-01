using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Code
{
    public class Prob1313
    {
        public int[] DecompressRLElist(int[] nums)
        {
            //split up array into pairs
            var pairArray = ChunkArrayIntoPairs(nums);

            //first value is the pair assigned to 'frequency'
            //second value in the pair is assigned to 'value'
            //the result of each pair array will generate its own new array
            var result = CreateResultArray(pairArray[0], pairArray[1]);

            //all result arrays are then concatenated and returned as one final array 
            return ConcatenateAllThePairArrays(result);
        }

        private int[] ChunkArrayIntoPairs(int[] sourceArray)
        {
            int[] buffer = null;

            for (int i = 0; i < sourceArray.Length; i += 2)
            {
                buffer = new int[2];
                Array.Copy(sourceArray, i, buffer, 0, 2);
            }

            return buffer;
        }

        private int[] CreateResultArray(int frequency, int value)
        {

        }

        private int[] ConcatenateAllThePairArrays(int[] args)
        {

        }

    }
}
