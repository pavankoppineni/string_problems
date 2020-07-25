using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringProblems.StringPermutations;
using System;
using System.Collections.Generic;
using System.Text;

namespace StringProblems.Tests.StringPermutations
{
    [TestClass]
    public class StringPermutationsWithRepeatingCharactersV1Tests
    {
        [TestMethod]
        public void Given_String_When_GeneratePermutations_Then_ShouldReturnPermutationsOfString()
        {
            //Given
            var str = "aab";
            var stringPermutations = new StringPermutationsWithRepeatingCharactersV1();
            var expectedPermuations = new HashSet<string> 
            {
                "aab",
                "baa",
                "aba"
            };

            //When
            var actualPermutations = stringPermutations.GeneratePermutations(str);

            //Then
            Assert.AreEqual(expectedPermuations.Count, actualPermutations.Count);
            foreach (var actualPermutation in actualPermutations)
            {
                Assert.AreEqual(true, expectedPermuations.Contains(actualPermutation));
            }
        }
    }
}
