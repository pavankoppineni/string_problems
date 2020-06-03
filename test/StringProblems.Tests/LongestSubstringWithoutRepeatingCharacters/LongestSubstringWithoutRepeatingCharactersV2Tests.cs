using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringProblems.LongestSubstringWithoutRepeatingCharacters;
using System;
using System.Collections.Generic;
using System.Text;

namespace StringProblems.Tests.LongestSubstringWithoutRepeatingCharacters
{
    [TestClass]
    public class LongestSubstringWithoutRepeatingCharactersV2Tests
    {
        [TestMethod]
        [DataRow("abcdabxyza", 7)]
        public void GivenString_Find_ReturnsLongestSubstringWithoutRepeatingCharacters(string str, int expectedSubstringLength)
        {
            //Given
            var solution = new LongestSubstringWithoutRepeatingCharactersV2();

            //When
            var actualSubstring = solution.Find(str);

            //Then
            Assert.AreEqual(expectedSubstringLength, actualSubstring.Length);
        }
    }
}
