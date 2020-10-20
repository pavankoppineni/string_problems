using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringProblems.BackspaceStringCompare;
using System;
using System.Collections.Generic;
using System.Text;

namespace StringProblems.Tests.BackspaceStringCompare
{
    [TestClass]
    public class BackspaceStringCompareV1Tests
    {
        [TestMethod]
        public void Given_TwoStrings_When_Compare_Then_ShouldReturnTrueIfBothStringsAreTrue()
        {
            // Given
            var s1 = "ab#c";
            var s2 = "ad#c";
            var problem = new BackspaceStringCompareV1();
            var expectedResult = true;

            // When
            var actualResult = problem.Comapre(s1, s2);

            // Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
