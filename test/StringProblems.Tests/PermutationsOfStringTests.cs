using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace StringProblems.Tests
{
    [TestClass]
    public class PermutationsOfStringTests
    {
        [TestMethod]
        public void GivenString_Generate_ReturnsPermutationsOfString()
        {
            //Arrange
            var str = "abc";
            var permutationsOfString = new PermutationsOfString();
            var expectedPermutations = new HashSet<string>();
            expectedPermutations.Add("abc");
            expectedPermutations.Add("acb");
            expectedPermutations.Add("bac");
            expectedPermutations.Add("bca");
            expectedPermutations.Add("cab");
            expectedPermutations.Add("cba");

            //Act
            var actualPermutations = permutationsOfString.GeneratePermutations(str);

            //Assert
            expectedPermutations.ExceptWith(actualPermutations);
            Assert.AreEqual(0, expectedPermutations.Count);
        }
    }
}
