using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace StringProblems.StringPermutations
{
    /// <summary>
    /// https://www.youtube.com/watch?v=nYFd7VHKyWQ
    /// </summary>
    public class StringPermutationsWithRepeatingCharactersV2
    {
        public IList<string> GeneratePermutations(string str)
        {
            var permutations = new List<string>();
            var charDictionary = new Dictionary<char, int>();
            var result = new char[str.Length];
            foreach (var item in str)
            {
                if (charDictionary.ContainsKey(item))
                {
                    charDictionary[item] += 1;
                }
                else
                {
                    charDictionary.Add(item, 1);
                }
            }
            GeneratePermutations(permutations, charDictionary, result, 0);
            return permutations;
        }

        private void GeneratePermutations(IList<string> permutations, IDictionary<char, int> charDictionary, char[] result, int level)
        {
            if (result.Length == level)
            {
                permutations.Add(new string(result));
                return;
            }

            foreach (var key in charDictionary.Keys.ToArray())
            {
                if (charDictionary[key] == 0)
                {
                    continue;
                }
                result[level] = key;
                charDictionary[key] -= 1;
                GeneratePermutations(permutations, charDictionary, result, level + 1);
                charDictionary[key] += 1;
            }
        }
    }
}
