using System;
using System.Collections.Generic;
using System.Text;

namespace StringProblems
{
    /// <summary>
    /// https://www.geeksforgeeks.org/write-a-c-program-to-print-all-permutations-of-a-given-string/
    /// </summary>
    public class PermutationsOfString
    {
        public HashSet<string> GeneratePermutations(string str)
        {
            var items = new HashSet<string>();
            Permutate(str, 0, str.Length - 1, items);
            return items;
        }

        private void Permutate(string str, int low, int high, ISet<string> permutations)
        {
            if (low == high)
            {
                permutations.Add(str);
                return;
            }

            for (var i = low; i <= high; i++)
            {
                str = Swap(str, low, i);
                Permutate(str, low + 1, high, permutations);
                str = Swap(str, low, i);
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
