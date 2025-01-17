using FluentAssertions;
using MathLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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

        [TestMethod]
        [DataRow(52.7365, "Whole number: 52\nFractorial part: 0,7365")]
        [DataRow(-52.736, "Whole number: -52\nFractorial part: -0,7360")]
        [DataRow(92.7317, "Whole number: 92\nFractorial part: 0,7317")]
        [DataRow(-42.7636, "Whole number: -42\nFractorial part: -0,7636")]
        public void ShouldReturnTheWholeNumberAndFractorialPart(double input, string expectedResult)
        {
            //Act
            string result = _exercises.FracturedNumber(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(2147483647, 4000, "Result: 536870\nRemainder: 3647")]
        public void ShouldReturnResultAndRemainderOfADivision(double input, double divisor, string expectedResult)
        {
            //Act
            string result = _exercises.ResultAndRemainder(input, divisor);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(int.MaxValue, int.MaxValue, 4611686014132420609)]
        public void ShouldCalculateFullProductOfGiantIntegers(int n1, int n2, long expectedResult)
        {
            //Act
            long result = _exercises.MultiplyHugeInts(n1, n2);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(123456, 654321)]
        [DataRow(-7654, -4567)]
        [DataRow(100, 1)]
        public void ShouldReverseNumbersOfAnInteger(int input, int expectedResult)
        {
            //Act
            int result = _exercises.ReverseNumber(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow("123456", 123456)]
        [DataRow("+3456", 3456)]
        [DataRow("-123456", -123456)]
        [DataRow("a1234", 0)]
        [DataRow("123a456", 123)]
        public void ShouldTurnStringToInteger(string input, int expectedResult)
        {
            //Act
            int result = _exercises.StringToInt(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(123456, false)]
        [DataRow(16461, true)]
        [DataRow(-121, false)]
        public void ShouldCheckIfItsAPalindrome(int input, bool expectedResult)
        {
            //Act
            bool result = _exercises.IsPalindrome(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(8.03, "Next integer value: 9\nPrevious integer value: 8")]
        [DataRow(-8.1, "Next integer value: -8\nPrevious integer value: -9")]
        public void ShouldReturnTheNextAndPreviousIntValue(double input, string expectedResult)
        {
            //Act
            string result = _exercises.NextAndPreviousIntValue(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(new int[] { -10, -11, -12, -13, -14, 15, 16, 17, 18, 19, 20 }, 105)]
        [DataRow(new int[] { -11, -22, -44, 0, 3, 4, 5, 9 }, -77)]
        public void ShouldReturnLargestSumBetweenPositiveOrNegativeNumbersInArray(int[] input, int expectedResult)
        {
            //Act
            int result = _exercises.LargestSumPositiveNegative(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        /// <summary>
        /// TO DO: Ask how to return a value withou rounding
        /// </summary>

        [TestMethod]
        [DataRow(2, 3.14)]
        [DataRow(4, 3.1416)]
        [DataRow(6, 3.141593)]
        public void ShouldReturnPIByNGivenDecimalPlaces(int decimalPlaces, double expectedResult)
        {
            //Act
            double result = _exercises.PiByNPlaces(decimalPlaces);

            //Assert
            result.Should().Be(expectedResult);
        }

        /// <summary>
        /// TO DO: Ask how to return a value withou rounding
        /// </summary>

        [TestMethod]
        [DataRow(1, 1)]
        [DataRow(2, 4)]
        [DataRow(3, 10)]
        [DataRow(4, 20)]
        [DataRow(5, 35)]
        [DataRow(6, 56)]
        public void ShouldCalculateTheTetrahedralValueFromANumber(double input, double expectedResult)
        {
            //Act
            double result = _exercises.Tetrahedral(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(134543, "Ascending: 133445\nDescending: 544331")]
        [DataRow(4375973, "Ascending: 3345779\nDescending: 9775433")]
        public void ShouldReturnTheAscendingAndDescendingOrder(int input, string expectedResult)
        {
            //Act
            string result = _exercises.AscendingAndDescending(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(120, "Oddish")]
        [DataRow(321, "Evenish")]
        [DataRow(4433, "Evenish")]
        [DataRow(43, "Oddish")]
        [DataRow(373, "Oddish")]
        public void ShouldReturnIfTheNumberIsOddishOrEvenish(int input, string expectedResult)
        {
            //Act
            string result = _exercises.OddishOrEvenish(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(120, 15)]
        [DataRow(321, 261)]
        [DataRow(43, 53)]
        [DataRow(4433, 4433)]
        public void ShouldTurnAIntToABinaryReverseItAndReturnAsAnotherInt(int input, int expectedResult)
        {
            //Act
            int result = _exercises.BinaryReverseInt(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(1234, 1221)]
        [DataRow(9987, 9999)]
        [DataRow(5123, 5115)]
        public void ShouldReturnTheClosesPalindrome(int input, int expectedResult)
        {
            //Act
            int result = _exercises.ClosestPalindrome(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(63, true)]
        [DataRow(100, false)]
        [DataRow(3000, false)]
        [DataRow(100000, false)]
        [DataRow(4000, false)]
        public void ShouldCheckIfItsAnUbanNumber(int input, bool expectedResult)
        {
            //Act
            bool result = _exercises.IsUban(input);

            //Assert
            result.Should().Be(expectedResult);
        }
    }
}