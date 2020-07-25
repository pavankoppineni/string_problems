using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringProblems.MicrosoftExcelColumnNumbers;
using System;
using System.Collections.Generic;
using System.Text;

namespace StringProblems.Tests.MicrosoftExcelColumnNumbers
{
    [TestClass]
    public class MicrosoftExcelColumnNumbersV1Tests
    {
        [DataTestMethod]
        [DataRow("a", 1)]
        [DataRow("aa", 27)]
        [DataRow("ba", 53)]
        public void Given_String_When_ConvertToNumber_Then_ReturnsNumberEquivalentNumberAssociatedToString(string column, int expectedResult)
        {
            //Given
            var problem = new MicrosoftExcelColumnNumbersV1();

            //When
            var actualResult = problem.ConvertToNumber(column);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
