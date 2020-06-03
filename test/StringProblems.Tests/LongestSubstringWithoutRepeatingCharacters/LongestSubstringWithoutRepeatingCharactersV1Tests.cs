using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringProblems.LongestSubstringWithoutRepeatingCharacters;

namespace StringProblems.Tests.LongestSubstringWithoutRepeatingCharacters
{
    [TestClass]
    public class LongestSubstringWithoutRepeatingCharactersV1Tests
    {
        [TestMethod]
        [DataRow("aba", 2)]
        public void GivenString_Find_ReturnsLengthOfLongestSubstringWithoutRepeatingCharacters(string str, int expectedLength)
        {
            //Given
            var solution = new LongestSubstringWithoutRepeatingCharactersV1();

            //When
            var actualLength = solution.Find(str);

            //Then
            Assert.AreEqual(expectedLength, actualLength);
        }
    }
}
