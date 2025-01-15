using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using MathLibrary;
using System.Numerics;

namespace MathTests
{
    [TestClass]
    public class MathTestClass
    {
        private readonly MathClass _exercises;

        public MathTestClass()
        {
            _exercises = new MathClass();
        }

        [TestMethod]
        public void ShouldReturnTheAbsoluteNumber()
        {
            //Arrange
            int inputInt = -3250;

            //Act
            int resultInt = Convert.ToInt32(_exercises.Absolute(inputInt));
            double resultDouble = Convert.ToDouble(_exercises.Absolute(inputDouble: 35.456));
            long resultLong = Convert.ToInt64(_exercises.Absolute(inputLong: -2147483672));

            //Assert
            resultInt.Should().Be(3250);
            resultDouble.Should().Be(35.456);
            resultLong.Should().Be(2147483672);
        }

        [TestMethod]
        [DataRow(new double[] { 10.23, 10.27, 14.34, 11.15, 41.51, 10.65 }, "True mean: 16,36/ Away from zero: 16,36/ Rounding to nearest: 16,36")]
        public void ShouldReturnTrueMeanAwayFromZeroAndNearest(double[] input, string expectedResult)
        {
            //Act
            string result = _exercises.ThreeMeanTipes(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow("New York City", 302.64, "New York City has 17,40 miles per side")]
        public void ShouldReturnTheMilesPerSide(string cityName, double squareMiles, string expectedResult)
        {
            //Act
            string result = _exercises.MilesPerSide(cityName, squareMiles);

            //Assert
            result.Should().Be(expectedResult);
        }
    }
}