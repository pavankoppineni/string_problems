using System;
using System.Collections.Generic;
using System.Text;

namespace StringProblems.MicrosoftExcelColumnNumbers
{
    /// <summary>
    /// 
    /// </summary>
    public class MicrosoftExcelColumnNumbersV1
    {
        public double ConvertToNumber(string column)
        {
            var charArray = column.ToCharArray();
            Array.Reverse(charArray);
            return Convert(charArray, 0, 0);
        }

        private double Convert(char[] charArray, int position, double result)
        {
            if (position == charArray.Length)
            {
                return result;
            }

            var indexNumber = charArray[position] - 'a' + 1;
            result += Math.Pow(26, position) * indexNumber;
            Console.WriteLine($"{charArray[position]}");
            result = Convert(charArray, position + 1, result);
            return result;
        }
    }
}
