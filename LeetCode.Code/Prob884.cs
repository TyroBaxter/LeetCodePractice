using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Code
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

            var uniqueWords = new List<string>();
            foreach (var word in countsByWord)
            {
                if (word.Value == 1)
                {
                    uniqueWords.Add(word.Key);
                }
                  
            }
            var finalUniqueWords = uniqueWords.ToArray();
            return finalUniqueWords;
        }
    }
}
