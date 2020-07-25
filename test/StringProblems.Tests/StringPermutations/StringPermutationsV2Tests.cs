using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringProblems.StringPermutations;
using System;
using System.Collections.Generic;
using System.Text;

namespace StringProblems.Tests.StringPermutations
{
    [TestClass]
    public class StringPermutationsV2Tests
    {
        [TestMethod]
        public void Given_String_When_GeneratePermutations_Then_ShouldReturnPermutations()
        {
            //Given
            var str = "abc";
            var stringPermutations = new StringPermutationsV2();
            var expectedPermuations = new HashSet<string>();
            expectedPermuations.Add("abc");
            expectedPermuations.Add("acb");

            //When
            var actualPermuations = stringPermutations.GeneratePermutations(str);

            //Then
            Assert.Inconclusive();
        }
    }
}
