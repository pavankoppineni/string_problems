using System;
using System.Collections.Generic;
using System.Text;

namespace StringProblems
{
    /// <summary>
    /// Given two strings str1, str2.
    /// Find out if str2 is rotation of str1.
    /// Example : 
    /// str1 = "waterbottle"
    /// str2 = "erbottlewat"
    /// 
    /// str2 is rotation of str1
    /// </summary>
    public class CheckToSeeStringOneIsRotationOfAnotherStringTwo
    {
        public bool Find(string str1, string str2)
        {
            var str = str1 + str1;
            return str.Contains(str2);
        }
    }
}
