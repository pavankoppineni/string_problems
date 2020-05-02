using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace StringProblems.Tests
{
    [TestClass]
    public class LongestSubstringWithKDistinctCharactersTests
    {
        public static IEnumerable<object[]> GetDataSet()
        {
            var dataSet = new List<object[]>();

            dataSet.Add(new object[]
            {
                "aabbc", 2, (0, 4)
            });
            dataSet.Add(new object[]
            {
                "abc", 2, (0, 2)
            });
            dataSet.Add(new object[]
            {
                "aabbccccccd", 2, (2, 8)
            });

            return dataSet;
        }

        [DataTestMethod]
        [DynamicData(nameof(GetDataSet), DynamicDataSourceType.Method)]
        public void GivenStringAndNumber_Find_ReturnsSubStringWithNDistinctCharacters(string text, int k, (int startIndex, int length) expectedResult)
        {
            //Arrange
            var problem = new LongestSubstringWithKDistinctCharacters();

            //Act
            var result = problem.Find(text, k);

            //Assert
            Assert.AreEqual(expectedResult.startIndex, result.startIndex);
            Assert.AreEqual(expectedResult.length, result.length);
        }
    }
}
