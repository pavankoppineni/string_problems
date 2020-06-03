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
    public class LongestSubstringWithoutRepeatingCharactersV1
    {
        public int Find(string text)
        {
            var charDictionary = new Dictionary<char, int>
            {
                { text[0], 0 }
            };
            var currentLength = 1;
            var maxLength = 1;

            for (var i = 1; i < text.Length; i++)
            {
                if (charDictionary.ContainsKey(text[i]))
                {
                    var subStringIndex = i - currentLength;
                    var previousIndex = charDictionary[text[i]];
                    if (subStringIndex <= previousIndex)
                    {
                        currentLength = i - previousIndex;
                    }
                    else
                    {
                        currentLength++;
                    }
                    charDictionary[text[i]] = i;
                }
                else
                {
                    charDictionary.Add(text[i], i);
                    currentLength++;
                }
                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                }
            }
            return maxLength;
        }
    }
}
