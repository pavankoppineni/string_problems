using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringProblems.StringPermutations;
using System;
using System.Collections.Generic;
using System.Text;

namespace StringProblems.Tests.StringPermutations
{
    [TestClass]
    public class StringPermutationsV3Tests
    {
        [TestMethod]
        public void Given_String_When_GeneratePermutations_Then_ShoulReturnPermutationsOfString()
        {
            //Given
            var str = "abc";
            var problem = new StringPermutationsV3();
            var expectedPermutations = new HashSet<string>
            {
                "abc", "acb",
                "bac", "bca",
                "cba", "cab"
            };

            //When
            var actualPermutations = problem.GeneratePermutations(str);

            //Then
            Assert.AreEqual(expectedPermutations.Count, actualPermutations.Count);
            foreach(var item in actualPermutations)
            {
                Assert.AreEqual(true, expectedPermutations.Contains(item));
            }
        }
    }
}
