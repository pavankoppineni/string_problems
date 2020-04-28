using System;
using System.Collections.Generic;
using System.Text;

namespace StringProblems
{
    public class DetermineIfStringHasAllUniqueCharacters
    {
        public bool Check(string text)
        {
            var result = true;
            var charDictionary = new Dictionary<char, int>();
            foreach (var charItem in text)
            {
                if (charDictionary.ContainsKey(charItem))
                {
                    result = false;
                    break;
                }
                else
                {
                    charDictionary.Add(charItem, 1);
                }
            }
            return result;
        }
    }
}
