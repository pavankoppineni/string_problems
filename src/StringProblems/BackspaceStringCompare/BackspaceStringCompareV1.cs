using System;
using System.Collections.Generic;
using System.Text;

namespace StringProblems.BackspaceStringCompare
{
    /// <summary>
    /// https://leetcode.com/problems/backspace-string-compare/
    /// </summary>
    public class BackspaceStringCompareV1
    {
        public bool Comapre(string s1, string s2)
        {
            var s1Array = s1.ToCharArray();
            var s2Array = s2.ToCharArray();

            var s1Length = ConvertToCharArray(s1Array);
            var s2Length = ConvertToCharArray(s2Array);

            if (s1Length == s2Length)
            {
                var index = 0;
                while(index < s1Length)
                {
                    if (s1Array[index] != s2Array[index])
                    {
                        return false;
                    }
                    index++;
                }
            }
            else
            {
                return false;
            }
            return true;
        }

        private int ConvertToCharArray(char[] charArray)
        {
            var currentPointer = 0;
            for (var i = 0; i < charArray.Length; i++)
            {
                // Case 1 : Character is #
                if (charArray[i] == '#')
                {
                    if (currentPointer > 0)
                    {
                        currentPointer = currentPointer - 1;
                    }
                }
                // Case 2 : Character is not #
                else
                {
                    if(currentPointer == i)
                    {
                        currentPointer += 1;
                        continue;
                    }
                    else
                    {
                        charArray[currentPointer] = charArray[i];
                        currentPointer += 1;
                    }
                }
            }

            return currentPointer;
        }
    }
}
