using System;
using System.Collections.Generic;
using System.Text;

namespace StringProblems.StringPermutations
{
    /// <summary>
    /// https://www.geeksforgeeks.org/write-a-c-program-to-print-all-permutations-of-a-given-string/
    /// </summary>
    public class StringPermutationsV1
    {
        public IList<string> Permutations(string str)
        {
            var permutations = new List<string>();
            GeneratePermutations(str, 0, str.Length - 1, permutations);
            return permutations;
        }

        private void GeneratePermutations(string str, int fixedPosition, int lastIndex, IList<string> permutations)
        {
            if (fixedPosition == lastIndex)
            {
                permutations.Add(str);
                Console.WriteLine(str);
                return;
            }

            for (var i = fixedPosition; i <= lastIndex; i++)
            {
                str = Swap(str, fixedPosition, i);
                GeneratePermutations(str, fixedPosition + 1, lastIndex, permutations);
                str = Swap(str, fixedPosition, i);
            }
        }

        private string Swap(string str, int i, int j)
        {
            var charArray = str.ToCharArray();
            var temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            return new string(charArray);
        }
    }
}
