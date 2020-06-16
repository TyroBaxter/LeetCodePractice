using System;
using System.Collections.Generic;
using System.Text;


namespace LeetCode.Code.Arrays
{
    public class Prob832
    {
        //Given a binary matrix A, we want to flip the image horizontally, 
        //then invert it, and return the resulting image.

        //To flip an image horizontally means that each row of the image is reversed.
        //For example, flipping[1, 1, 0] horizontally results in [0, 1, 1].

        //To invert an image means that each 0 is replaced by 1, and each 1 is replaced by 0.
        //For example, inverting[0, 1, 1] results in [1, 0, 0].

        public int[][] FlipAndInvertImage(int[][] A)
        {

            //Get the data into a better format 
            var betterData = new List<List<int>>();
            
            for (int i = 0; i < A.Length; i++)
            {
                int[] innerDataFromInput = A[i];
                var chunkedData = new List<int>(innerDataFromInput);
             
                betterData.Add(chunkedData);
            }

            //reverse the data 
            ReverseTheData(betterData);
            //flip the 0s and 1s
            FlipAllTheDigits(betterData);
            //turn it back into a jagged array and return it
            var flipItAndInvertIt = new int[A.Length][];
            //for (int i = 0; i < betterData.Count; i++)
            //{
            //    List<int> innerDataFromBetterData = betterData[i];
            //    var chunkedData = new int[innerDataFromBetterData.Count];
            //    foreach (var item in innerDataFromBetterData)
            //    {
            //        chunkedData.SetValue(item, )
            //    }
            //}
            for (int i = 0; i < betterData.Count; i++)
            {
                List<int> innerDataFromBetterData = betterData[i];
                flipItAndInvertIt[i] = innerDataFromBetterData.ToArray();

            }
            return flipItAndInvertIt;
        }

        private void ReverseTheData(List<List<int>> data)
        {
            data.ForEach(x => x.Reverse());
        }

        private void FlipAllTheDigits(List<List<int>> input)
        {
            input.ForEach(x => FlipSomeOfTheDigits(x));
        }

        private void FlipSomeOfTheDigits(List<int> input)
        {
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] == 1)
                {
                    input[i] = 0;
                }
                else
                {
                    input[i] = 1;
                }
            }
        }
    }
}
