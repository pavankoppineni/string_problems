using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringProblems.ReverseWordsInString;
using System;
using System.Collections.Generic;
using System.Text;

namespace StringProblems.Tests.ReverseWordsInString
{
    [TestClass]
    public class ReverseWordsInStringV1Tests
    {
        [DataTestMethod]
        [DataRow("geeks quiz practice code", "code practice quiz geeks")]
        public void Given_StringWithWords_When_ReverseWords_Then_ShouldReverseWordsInString(string str, string expectedResult)
        {
            //Given
            var problem = new ReverseWordsInStringV1();

            //When
            var actualResult = problem.ReverseWords(str);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
