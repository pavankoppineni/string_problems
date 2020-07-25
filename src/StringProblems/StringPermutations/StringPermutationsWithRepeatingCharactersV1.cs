using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace StringProblems.StringPermutations
{
    /// <summary>
    /// https://www.youtube.com/watch?v=nYFd7VHKyWQ
    /// </summary>
    public class StringPermutationsWithRepeatingCharactersV1
    {
        public IList<string> GeneratePermutations(string str)
        {
            var permutations = new List<string>();
            var resultArray = new char[str.Length];
            var charDictionary = str
                                   .GroupBy(i => i)
                                   .Select(i => new { i.Key, count = i.Count() })
                                   .ToArray();

            var charArray = new char[charDictionary.Length];
            var countArray = new int[charDictionary.Length];

            for (var i = 0; i < charDictionary.Length; i++)
            {
                charArray[i] = charDictionary[i].Key;
                countArray[i] = charDictionary[i].count;
            }

            GeneratePermutations(charArray, countArray, resultArray, permutations, 0);
            return permutations;
        }

        private void GeneratePermutations(char[] charArray, int[] countArray, char[] resultArray, IList<string> permutations, int level)
        {
            if (level == resultArray.Length)
            {
                permutations.Add(new string(resultArray));
                return;
            }

            for (var i = 0; i < charArray.Length; i++)
            {
                if (countArray[i] == 0)
                {
                    continue;
                }

                resultArray[level] = charArray[i];
                countArray[i] = countArray[i] - 1;
                GeneratePermutations(charArray, countArray, resultArray, permutations, level + 1);
                countArray[i] = countArray[i] + 1;
            }
        }
    }
}
