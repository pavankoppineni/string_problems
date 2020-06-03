using System;
using System.Collections.Generic;
using System.Text;

namespace StringProblems.LongestSubstringWithoutRepeatingCharacters
{
    /// <summary>
    /// Problem is taken from GeeksForGeeks:
    /// Length of the longest substring without repeating characters
    /// https://www.geeksforgeeks.org/length-of-the-longest-substring-without-repeating-characters/
    /// </summary>
    public class LongestSubstringWithoutRepeatingCharactersV2
    {
        public string Find(string str)
        {
            var dict = new Dictionary<char, int>()
            {
                { str[0], 0 }
            };
            var startIndex = 0;
            var length = 1;
            var currentStartIndex = 0;
            var currentLength = 1;
            for (var i = 1; i < str.Length; i++)
            {
                if (dict.ContainsKey(str[i]))
                {
                    var previousIndex = dict[str[i]];
                    currentStartIndex = previousIndex + 1;
                    currentLength = i - currentStartIndex + 1;
                    dict[str[i]] = i;
                }
                else
                {
                    dict[str[i]] = i;
                    currentLength++;
                }

                if (currentLength > length)
                {
                    length = currentLength;
                    startIndex = currentStartIndex;
                }
            }

            return str.Substring(startIndex, length);
        }
    }
}
