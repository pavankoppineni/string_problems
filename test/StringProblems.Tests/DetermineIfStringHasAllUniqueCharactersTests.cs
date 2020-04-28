using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace StringProblems.Tests
{
    [TestClass]
    public class DetermineIfStringHasAllUniqueCharactersTests
    {
        [DataTestMethod]
        [DataRow("abc", true)]
        [DataRow("aabc", false)]
        [DataRow("xyzx", false)]
        public void GivenText_Check_ReturnsBoolean(string text, bool expectedResult)
        {
            //Arrange
            var problem = new DetermineIfStringHasAllUniqueCharacters();

            //Act
            var result = problem.Check(text);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
