using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Code.Arrays
{
    public class Prob1313
    {
        public int[] DecompressRLElist(int[] nums)
        {

            //split up array into pairs
            var pairs = ChunkArrayIntoPairs(nums);

            //all result arrays are then concatenated and returned as one final array 
            //foreach (var pair in pairs)
            //{
            //    var results = CreateResultList(pair);
            //    foreach (var r in results)
            //    {
            //        buffer.Add(r);
            //    }

            //}

            return pairs.SelectMany(CreateResultList).ToArray();
        }

        //first value is the pair assigned to 'frequency'
        //second value in the pair is assigned to 'value'
        //the result of each pair array will generate its own new list
        private static IEnumerable<RleDto> ChunkArrayIntoPairs(IReadOnlyList<int> sourceArray)
        {

            var buffer = new List<RleDto>();

            for (var i = 0; i < sourceArray.Count; i += 2)
            {
                buffer.Add(new RleDto
                {
                    Frequency = sourceArray[i],
                    Value = sourceArray[i + 1]
                });
            }
            return buffer;

        }

        private static List<int> CreateResultList(RleDto pair)
        {
            var decompressedData = new List<int>();

            for (var i = 0; i < pair.Frequency; i++)
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
