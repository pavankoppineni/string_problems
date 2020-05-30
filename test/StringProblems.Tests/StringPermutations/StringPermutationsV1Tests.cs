using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringProblems.StringPermutations;
using System;
using System.Collections.Generic;
using System.Text;

namespace StringProblems.Tests.StringPermutations
{
    [TestClass]
    public class StringPermutationsV1Tests
    {
        [TestMethod]
        public void GivenString_Generate_ReturnsPermutationsOfString()
        {
            //Arrange
            var str = "abc";
            var stringPermutations = new StringPermutationsV1();
            var expectedPermutations = new HashSet<string>();
            expectedPermutations.Add("abc");
            expectedPermutations.Add("acb");
            expectedPermutations.Add("bac");
            expectedPermutations.Add("bca");
            expectedPermutations.Add("cab");
            expectedPermutations.Add("cba");

            //Act
            var actualPermutations = stringPermutations.Permutations(str);

            //Assert
            expectedPermutations.ExceptWith(actualPermutations);
            Assert.AreEqual(0, expectedPermutations.Count);
        }
    }
}
