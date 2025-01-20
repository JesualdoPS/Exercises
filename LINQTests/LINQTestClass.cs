using System.Xml.XPath;
using FluentAssertions;
using LINQLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LINQTests
{
    [TestClass]
    public class LINQTestClass
    {
        [TestMethod]
        [DataRow(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 6, new int[] { 0, 2, 4, 6, 8, 10 })]
        public void ShouldReturnEvenValues(int[] input, int quantity, int[] expectedResult)
        {
            //Act
            int[] result = LINQClass.EvenValues(input, quantity);

            //Assert
            result.Should().Equal(expectedResult);
        }

        public static IEnumerable<object[]> PositiveLessThan12
        {
            get
            {
                return new[]
                {
                    new object[]
                    {
                        new int[] { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 },
                        (Func<int, bool>)(x => x > 0 && x < 12),
                        new int[] { 1, 3, 6, 9, 10 }
                    }
                };
            }
        }

        [TestMethod]
        [DynamicData(nameof(PositiveLessThan12))]
        public void ShouldReturnPositiveValuesLessThan12InArray(int[] input, Func<int, bool> condition, int[] expectedResult)
        {
            //Act
            int[] result = LINQClass.ConditionedValues(input, condition);

            //Assert
            result.Should().Equal(expectedResult);
        }

        [TestMethod]
        [DataRow(new int[] { 9, 8, 6, 5 }, new int[] { 81, 64, 36, 25 })]
        public void ShouldReturnAllValuesToTheSquare(int[] input, int[] expectedResult)
        {
            //Act
            int[] result = LINQClass.AllToSquare(input);

            //Assert
            result.Should().Equal(expectedResult);
        }

        [TestMethod]
        [DataRow(new int[] { 1, 3, 12, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14, 12, 19, 3, 6, 12 }, 12, 4)]
        public void ShouldCheckFrequencyOfAValue(int[] input, int value, int expectedResult)
        {
            //Act
            int result = LINQClass.Frequency(input, value);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow("apple", 'a', 1)]
        [DataRow("apple", 'p', 2)]
        public void ShouldCheckFrequencyOfAValue(string input, char value, int expectedResult)
        {
            //Act
            int result = LINQClass.FrequencyOfLetter(input, value);

            //Assert
            result.Should().Be(expectedResult);
        }
    }
}