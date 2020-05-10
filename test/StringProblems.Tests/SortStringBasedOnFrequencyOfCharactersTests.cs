using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace StringProblems.Tests
{
    [TestClass]
    public class SortStringBasedOnFrequencyOfCharactersTests
    {
        [TestMethod]
        public void String_Sort_ReturnsSortedStringBasedOnFrequencyOfCharacters()
        {
            //Arrange
            var str = "abbcccd";
            var expectedString = "cccbbad";
            var solution = new SortStringBasedOnFrequencyOfCharacters();

            //Act
            var sortedString = solution.Sort(str);

            //Assert
            Assert.AreEqual(expectedString, sortedString);
        }
    }
}
