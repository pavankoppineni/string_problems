using System;
using System.Collections.Generic;
using System.Text;

namespace StringProblems.ReverseWordsInString
{
    /// <summary>
    /// https://www.geeksforgeeks.org/reverse-words-in-a-given-string/
    /// </summary>
    public class ReverseWordsInStringV1
    {
        public string ReverseWords(string str)
        {
            var charArray = str.ToCharArray();
            var startIndex = 0;
            var endIndex = 0;
            for (var i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] == ' ')
                {
                    Reverse(charArray, startIndex, endIndex);
                    startIndex = i + 1;
                    endIndex = i + 1;
                }
                else
                {
                    endIndex = i;
                }

                if (i == charArray.Length - 1)
                {
                    Reverse(charArray, startIndex, endIndex);
                }
            }
            Array.Reverse(charArray);
            return new string(charArray);
        }

        private void Reverse(char[] charArray, int startIndex, int endIndex)
        {
            while (startIndex < endIndex)
            {
                var temp = charArray[startIndex];
                charArray[startIndex] = charArray[endIndex];
                charArray[endIndex] = temp;
                startIndex++;
                endIndex--;
            }
        }
    }
}
