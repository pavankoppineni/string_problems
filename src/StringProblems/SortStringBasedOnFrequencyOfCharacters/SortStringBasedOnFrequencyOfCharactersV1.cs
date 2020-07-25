using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace StringProblems.SortStringBasedOnFrequencyOfCharacters
{
    /// <summary>
    /// Problem : Sort characters in string based on frequency of characters.
    /// 
    /// Example 1 : 
    /// Input : abbc
    /// Output : bbac
    /// 
    /// Example 2 : 
    /// Input : abc
    /// Output : abc
    /// </summary>
    public class SortStringBasedOnFrequencyOfCharactersV1
    {
        public string Sort(string str)
        {
            var lookUp = new Dictionary<char, int>();
            foreach (var item in str)
            {
                if (lookUp.ContainsKey(item))
                {
                    lookUp[item]++;
                }
                else
                {
                    lookUp.Add(item, 1);
                }
            }

            var lookUpArray = lookUp.ToArray();
            Array.Sort(lookUpArray, KeyValueComparer.Default);
            var stringBuilder = new StringBuilder();
            foreach (var lookUpItem in lookUpArray)
            {
                for (var i = 0; i < lookUpItem.Value; i++)
                {
                    stringBuilder.Append(lookUpItem.Key);
                }
            }
            return stringBuilder.ToString();
        }

        public class KeyValueComparer : IComparer<KeyValuePair<char, int>>
        {
            public int Compare(KeyValuePair<char, int> x, KeyValuePair<char, int> y)
            {
                if (x.Value == y.Value)
                {
                    return 0;
                }
                else if (x.Value > y.Value)
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
            }

            public static KeyValueComparer Default { get; } = new KeyValueComparer();
        }
    }
}
