using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace StringProblems
{
    /// <summary>
    /// Find the longest substring with k unique characters in a given string
    /// https://www.geeksforgeeks.org/find-the-longest-substring-with-k-unique-characters-in-a-given-string/
    /// </summary>
    public class LongestSubstringWithKDistinctCharacters
    {
        public (int startIndex, int length) Find(string text, int k)
        {
            var currentIndex = 0;
            var currentLength = 0;
            var maxLength = 0;
            var maxLengthIndex = 0;
            var charDictionary = new Dictionary<char, int>();
            for (var i = 0; i < text.Length; i++)
            {
                if (charDictionary.ContainsKey(text[i]))
                {
                    charDictionary[text[i]] = i;
                    currentLength++;
                }
                else
                {
                    if (charDictionary.Keys.Count == k)
                    {
                        KeyValuePair<char, int> leastIndex = charDictionary.First();
                        foreach (var item in charDictionary)
                        {
                            if (item.Value < leastIndex.Value)
                            {
                                leastIndex = item;
                            }
                        }
                        charDictionary.Remove(leastIndex.Key);
                        currentIndex = leastIndex.Value + 1;
                        charDictionary.Add(text[i], i);
                        currentLength = i - currentIndex + 1;
                    }
                    else if (charDictionary.Keys.Count < k)
                    {
                        charDictionary.Add(text[i], i);
                        currentLength++;
                    }
                }
                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    maxLengthIndex = currentIndex;
                }
            }
            return (maxLengthIndex, maxLength);
        }
    }
}
