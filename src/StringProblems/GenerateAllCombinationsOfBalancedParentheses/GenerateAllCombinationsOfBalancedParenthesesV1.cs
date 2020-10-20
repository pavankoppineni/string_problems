using System;
using System.Collections.Generic;
using System.Text;

namespace StringProblems.PrintAllCombinationsOfBalancedParentheses
{
    /// <summary>
    /// https://www.geeksforgeeks.org/print-all-combinations-of-balanced-parentheses/
    /// </summary>
    public class GenerateAllCombinationsOfBalancedParenthesesV1
    {
        private IList<string> combinations;

        public IList<string> GenerateAllCombinations(int n)
        {
            combinations = new List<string>();
            return combinations;
        }

        private void GenerateAllCombinations(char[] str, int position, int n, int openCount, int closeCount)
        {
            if (closeCount == n)
            {
                combinations.Add(new string(str));
                return;
            }

            if(openCount > closeCount)
            {
                str[position] = '}';
                GenerateAllCombinations(str, position + 1, n, openCount, closeCount + 1);
            }

            if (openCount < n)
            {
                str[position] = '{';
                GenerateAllCombinations(str, position + 1, n, openCount + 1, closeCount);
            }
        }
    }
}
