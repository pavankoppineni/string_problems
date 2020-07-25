using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringProblems.SortStringBasedOnFrequencyOfCharacters;
using System;
using System.Collections.Generic;
using System.Text;

namespace StringProblems.Tests.SortStringBasedOnFrequencyOfCharacters
{
    [TestClass]
    public class SortStringBasedOnFrequencyOfCharactersV1Tests
    {
        [TestMethod]
        public void String_Sort_ReturnsSortedStringBasedOnFrequencyOfCharacters()   
        {
            //Arrange
            var str = "abbcccd";
            var expectedString = "cccbbad";
            var solution = new SortStringBasedOnFrequencyOfCharactersV1();

            //Act
            var sortedString = solution.Sort(str);

            //Assert
            Assert.AreEqual(expectedString, sortedString);
        }
    }
}
