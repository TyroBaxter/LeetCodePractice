﻿using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Code.Arrays
{
    public class Prob884
    {
        //        We are given two sentences A and B.  
       // (A sentence is a string of space separated words.Each word consists only of lowercase letters.)

        //A word is uncommon if it appears exactly once in one of the sentences,
        //and does not appear in the other sentence.

        //Return a list of all uncommon words.

        //You may return the list in any order.


        public string[] UncommonFromSentences(string A, string B)
        {
            var combinedInput = A +" "+ B;

            var words = combinedInput.Split(" ");
            var countsByWord = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (countsByWord.ContainsKey(word))
                {
                    var temp = countsByWord[word];
                    temp++;
                    countsByWord[word] = temp;
                }
                else
                {
                    countsByWord.Add(word, 1);
                }
                
            }

            //foreach (var word in countsByWord)
            //{
            //    if (word.Value == 1)
            //    {
            //        uniqueWords.Add(word.Key);
            //    }
                  
            //}
            var finalUniqueWords = (from word in countsByWord where word.Value == 1 select word.Key).ToArray();
            return finalUniqueWords;
        }

        public string[] UncommonFromSentencesUsingLinq(string A, string B)
        {
            return Enumerable.Empty<string>()
                .Concat(A.Split(' '))
                .Concat(B.Split(' '))
                .GroupBy(x => x)
                .Where(x => x.Count() == 1)
                .Select(x => x.Key)
                .ToArray();
        }
    }
}
