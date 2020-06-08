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
            var pairs = ChunkArrayIntoPairs(nums);

            //all result arrays are then concatenated and returned as one final array 
            var buffer = new List<int>();
            foreach (var pair in pairs)
            {
                var results = CreateResultList(pair);
                foreach (var r in results)
                {
                    buffer.Add(r);
                }

            }

            return buffer.ToArray();
        }

        //first value is the pair assigned to 'frequency'
        //second value in the pair is assigned to 'value'
        //the result of each pair array will generate its own new list
        private List<RleDto> ChunkArrayIntoPairs(int[] sourceArray)
        {

            List<RleDto> buffer = new List<RleDto>();

            for (int i = 0; i < sourceArray.Length; i += 2)
            {
                buffer.Add(new RleDto
                {
                    Frequency = sourceArray[i],
                    Value = sourceArray[i + 1]
                });
            }
            return buffer;

        }

        private List<int> CreateResultList(RleDto pair)
        {
            var decompressedData = new List<int>();

            for (int i = 0; i < pair.Frequency; i++)
            {
                decompressedData.Add(pair.Value);
            }

            return decompressedData;

        }

    }

    public class RleDto
    {
        public int Frequency { get; set; }
        public int Value { get; set; }
    }
}
