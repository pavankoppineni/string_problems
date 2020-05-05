using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace StringProblems.Tests
{
    [TestClass]
    public class CheckToSeeStringOneIsRotationOfAnotherStringTwoTests
    {
        [DataTestMethod]
        [DataRow("waterbottle", "bottlewater", true)]
        [DataRow("pavankumar", "kumarpavan", true)]
        [DataRow("hellotim", "timolleh", false)]
        public void GiveTwoStrings_Find_ReturnsTrueIfStringTwoIsRotationOfStringOne(string str1, string str2, bool expectedResult)
        {
            //Arrange
            var problem = new CheckToSeeStringOneIsRotationOfAnotherStringTwo();

            //Act
            var result = problem.Find(str1, str2);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
