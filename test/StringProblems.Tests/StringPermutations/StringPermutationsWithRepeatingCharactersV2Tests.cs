using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringProblems.StringPermutations;
using System;
using System.Collections.Generic;
using System.Text;

namespace StringProblems.Tests.StringPermutations
{
    [TestClass]
    public class StringPermutationsWithRepeatingCharactersV2Tests
    {
        [TestMethod]
        public void Given_String_When_GeneratePermutations_Then_ShouldReturnListOfPermuationsForAString()
        {
            //Given
            var str = "aab";
            var problem = new StringPermutationsWithRepeatingCharactersV2();
            var expectedPermutations = new HashSet<string>
            {
                "aab",
                "baa",
                "aba"
            };

            //When
            var actualPermutations = problem.GeneratePermutations(str);

            //Then
            Assert.AreEqual(expectedPermutations.Count, actualPermutations.Count);
            foreach (var item in actualPermutations)
            {
                Assert.IsTrue(expectedPermutations.Contains(item));
            }
        }
    }
}
