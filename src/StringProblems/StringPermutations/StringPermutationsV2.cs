﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StringProblems.StringPermutations
{
    /// <summary>
    /// https://www.geeksforgeeks.org/write-a-c-program-to-print-all-permutations-of-a-given-string/
    /// </summary>
    public class StringPermutationsV2
    {
        public IList<string> GeneratePermutations(string str)
        {
            var permutations = new List<string>();
            GeneratePermutations(str, 0, permutations);
            return permutations;
        }

        private void GeneratePermutations(string str, int position, IList<string> permutations)
        {
            if (position == str.Length)
            {
                permutations.Add(str);
                return;
            }

            for (var i = position; i < str.Length; i++)
            {
                str = Swap(str, i, position);
                GeneratePermutations(str, position + 1, permutations);
                str = Swap(str, i, position);
            }
        }

        private string Swap(string str, int i, int j)
        {
            var charArray = str.ToCharArray();
            var tempChar = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = tempChar;
            return new string(charArray);
        }
    }
}
