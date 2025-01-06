using FluentAssertions;
using ForLoopLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ForLoopTests
{
    [TestClass]
    public class ForLoopTestClass
    {
        private readonly ForLoopClass _exercises;

        public ForLoopTestClass()
        {
            _exercises = new ForLoopClass();
        }

        [TestMethod]
        [DataRow(10)]
        public void ShouldReturnNaturalNumbersUntilInput(int input)
        {
            //Act
            int[] result = _exercises.IntCounter(input);

            //Assert
            result.Should().Equal(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
        }

        [TestMethod]
        [DataRow(10, 55)]
        public void ShouldReturnTheSumOfTheNumbersOfArray(int input, int expectedResult)
        {
            //Act
            int result = _exercises.ArraySum(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow()]
        public void Should()
        {

        }
    }
}