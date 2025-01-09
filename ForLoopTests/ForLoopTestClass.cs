using System.ComponentModel;
using System.Security.Permissions;
using FluentAssertions;
using ForLoopLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        [DataRow(10, new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })]
        [DataRow(8, new[] { 1, 2, 3, 4, 5, 6, 7, 8 })]
        public void ShouldReturnNaturalNumbersUntilInput(int input, int[] expectedResult)
        {
            //Act
            int[] result = _exercises.IntCounter(input);

            //Assert
            result.Should().Equal(expectedResult);
        }

        [TestMethod]
        [DataRow(10, 55)]
        [DataRow(5, 15)]
        [DataRow(7, 28)]
        public void ShouldReturnTheSumOfTheNumbersOfArray(int input, int expectedResult)
        {
            //Act
            int result = _exercises.ArraySum(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(2, 2, 10, 110, 11)]
        [DataRow(3, 3, 20, 630, 31.5)]
        public void Should(int start, int step, int length, int sum, double average)
        {
            //Act
            string result = _exercises.AverageAndSum(start, step, length);

            //Assert
            result.Should().Be($"The sum is {sum} and the average is {average}");
        }

        [TestMethod]
        [DataRow(5, new[] { 1.0, 8.0, 27.0, 64.0, 125.0 })]
        [DataRow(7, new[] { 1.0, 8.0, 27.0, 64.0, 125.0, 216.0, 343.0 })]
        public void ShouldReturnTheCubeOfAllNaturalNumbersUpToInput(int input, double[] expectedResult)
        {
            //Act
            double[] result = _exercises.CubeOfNaturalNumbers(input);

            //Assert
            result.Should().Equal(expectedResult);
        }

        [TestMethod]
        [DataRow(15, 10, new[] { 15, 30, 45, 60, 75, 90, 105, 120, 135, 150 })]
        [DataRow(8, 10, new[] { 8, 16, 24, 32, 40, 48, 56, 64, 72, 80 })]
        public void ShouldMultiplicateInputThroughOneToN(int input, int limit, int[] expectedResult)
        {
            //Act
            int[] result = _exercises.ArrayMultiplicatorSequence(input, limit);

            //Assert
            result.Should().Equal(expectedResult);
        }

        [TestMethod]
        [DataRow(2)]
        public void ShouldCreateAMultiplicationTable(int input)
        {
            //Act
            string[][] result = _exercises.MultiplicationTables(input);

            //Assert
            result.Should().BeEquivalentTo(Enumerable.Range(1, input)
                .Select(i => Enumerable.Range(1, 10)
                .Select(j => $"{i} x {j} = {i * j}").ToArray()));
        }

        [TestMethod]
        [DataRow(5, new[] { 1, 3, 5, 7, 9 }, 25)]
        [DataRow(10, new[] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 }, 100)]
        public void ShouldReturnNOddNumbersAndTheirSum(int input, int[] oddNumbers, int sum)
        {
            //Act
            string result = _exercises.OddNumbersAndSum(input);

            //Assert
            result.Should().Be($"The odd list is [{string.Join(",", oddNumbers)}] and their sum is {sum}");
        }

        [TestMethod]
        [DataRow(3)]
        [DataRow(4)]
        [DataRow(5)]
        public void ShouldReturnAnAsteriscTriangle(int input)
        {
            //Act
            string result = _exercises.AsteriscTriangle(input);

            //Assert
            result.Should().Be(string.Join("\n", Enumerable.Range(1, input)
                .Select(i => new string('*', i))));
        }

        [TestMethod]
        [DataRow(4)]
        [DataRow(6)]
        public void ShouldCreateATriangleWithASequence(int input)
        {
            //Act
            string result = _exercises.TriangleWithSequence(input);

            //Assert
            result.Should().Be(string.Join("\n", Enumerable.Range(1, input)
                .Select(i => string.Concat(Enumerable.Range(1, i)))));
        }

        [TestMethod]
        [DataRow(4)]
        [DataRow(5)]
        public void ShouldCreateATriangleWithRepetitions(int input)
        {
            //Act
            string result = _exercises.TriangleWithRepetitions(input);

            //Assert
            result.Should().Be(string.Join("\n", Enumerable.Range(1, input)
                .Select(i => string.Concat(Enumerable.Repeat(i.ToString(), i)))));
        }

        [TestMethod]
        [DataRow(4)]
        public void ShouldCreateATriangleWithTheNumberIncreasedBy1(int input)
        {
            //Act
            string result = _exercises.TriangleWithIncreasingNumber(input);

            //Assert
            result.Should().Be($"1\n2 3\n4 5 6\n7 8 9 10");
        }

        [TestMethod]
        [DataRow(4)]
        public void ShouldCreateAPiramidMadeOfNumbers(int input)
        {
            //Act
            string result = _exercises.PiramidOfNumbers(input);

            //Assert
            result.Should().Be("   1   \n  2 3  \n 4 5 6 \n7 8 9 10");
        }

        [TestMethod]
        [DataRow(4)]
        public void ShouldCreateAnAsteriscPiramid(int rows)
        {
            //Act
            string result = _exercises.PiramidOfAsteriscs(rows);

            //Assert
            result.Should().Be("   *   \n  * *  \n * * * \n* * * *");
        }

        [TestMethod]
        [DataRow(5, 120)]
        [DataRow(8, 40320)]
        public void ShouldReturnTheFactorialNumber(int input, int expectedResult)
        {
            //Act
            int result = _exercises.FactorialNumber(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(5, "The first 5 natural numbers are [2,4,6,8,10] and their sum is 30")]
        [DataRow(8, "The first 8 natural numbers are [2,4,6,8,10,12,14,16] and their sum is 72")]
        public void ShouldReturnNTermsOfNaturalNumbersAndTheirSum(int input, string expectedResult)
        {
            //Act
            string result = _exercises.EvenNaturalNumbersAndSum(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(4)]
        public void ShouldCreateAPiramidMadeOfRepetitiveNumbers(int rows)
        {
            //Act
            string result = _exercises.PiramidOfRepetitiveNumbers(rows);

            //Assert
            result.Should().Be("   1   \n  2 2  \n 3 3 3 \n4 4 4 4");
        }

        [TestMethod]
        [DataRow(5, 2.283)]
        public void ShouldCalculateHarmonicSeries(double input, double expectedResult)
        {
            //Act
            double result = _exercises.CalculateHarmonicSeries(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(3)]
        public void ShouldCreateAPiramidOfAsteriscWithNoSpaces(int rows)
        {
            //Act
            string result = _exercises.PiramidOfOddAsteriscs(rows);

            //Assert
            result.Should().Be("   *   \n  ***  \n ***** ");
        }

        [TestMethod]
        [DataRow(9, 5, 111105)]
        [DataRow(2, 6, 246912)]
        public void ShouldDisplayTheSumOfNRepetitiveNumbers(double input, double repetitions, double expectedResult)
        {
            //Act
            double result = _exercises.SumOfRepetitions(input, repetitions);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(5)]
        public void ShouldDisplayFloydsTriangle(int rows)
        {
            //Act
            string result = _exercises.FloydsTriangle(rows);

            //Assert
            result.Should().Be("1\n01\n101\n0101\n10101");
        }

        [TestMethod]
        [DataRow(3, 5, 16.375)]
        [DataRow(8, 12, 2647.317)]
        public void ShouldCalculateASerieWithFactorialDenominator(double input, double terms, double expectedResult)
        {
            //Act
            double result = _exercises.FactorialDenominator(input, terms);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(2, 5, 410)]
        [DataRow(3, 6, -159432)]
        public void ShouldCalculateAnIrregularSeries(double input, double terms, double expectedResult)
        {
            //Act
            double result = _exercises.IrregularSeriesSum(input, terms);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(5, "The first 5 natural squares are [1,4,9,16,25] and their sum is 55")]
        [DataRow(10, "The first 10 natural squares are [1,4,9,16,25,36,49,64,81,100] and their sum is 385")]
        public void ShouldReturnTheSumOfNaturalSquares(int input, string expectedResult)
        {
            //Act
            string result = _exercises.NaturalSquareSum(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(5, 12345)]
        [DataRow(7, 1234567)]
        public void ShouldReturnOfNOnes(int input, double expectedResult)
        {
            //Act
            double result = _exercises.CalculateNOnes(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(56, false)]
        [DataRow(28, true)]
        public void ShouldCheckIfItsAPerfectNumber(double input, bool expectedResult)
        {
            //Act
            bool result = _exercises.IsPerfect(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(1, 50, new int[] { 6, 28 })]
        public void ShouldFindThePerfectNumberInARow(int start, int end, int[] expectedResult)
        {
            //Act
            List<int> result = _exercises.PerfectNumbersList(start, end);

            //Assert
            result.Should().Equal(expectedResult);
        }

        [TestMethod]
        [DataRow(153, true)]
        [DataRow(245, false)]
        [DataRow(2, false)]
        public void ShouldCheckIfItsAnArmstrongNumber(double input, bool expectedResult)
        {
            //Act
            bool result = _exercises.IsArmstrong(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(1, 1000, new int[] { 1, 153, 370, 371, 407 })]
        public void ShouldFindTheArmstrongNumberInARow(int start, int end, int[] expectedResult)
        {
            //Act
            List<int> result = _exercises.ArmstrongList(start, end);

            //Assert
            result.Should().Equal(expectedResult);
        }

        [TestMethod]
        [DataRow(9)]
        public void ShouldReturnAnAsteriscDiamond(int midRow)
        {
            //Act
            string result = _exercises.AsteriscDiamond(midRow);

            //Assert
            result.Should().Be($"    *    \n   ***   \n  *****  \n ******* \n*********" +
                $"\n ******* \n  *****  \n   ***   \n    *    ");
        }

        [TestMethod]
        [DataRow(13, true)]
        [DataRow(12, false)]
        public void ShouldCheckIfItsPrime(int input, bool expectedResult)
        {
            //Act
            bool result = _exercises.IsPrime(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(5)]
        public void ShouldRetunrPascalsTriangle(int rows)
        {
            //Act
            string result = _exercises.PascalsTriangle(rows);

            //Assert
            result.Should().Be("    1 \n   1 1 \n  1 2 1 \n 1 3 3 1 \n1 4 6 4 1 ");
        }

        [TestMethod]
        [DataRow(1, 50, new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47 })]
        public void ShouldReturnAllPrimeNumbersWithinRange(int start, int end, int[] expectedResult)
        {
            //Act
            List<int> result = _exercises.PrimeList(start, end);

            //Assert
            result.Should().Equal(expectedResult);
        }

        [TestMethod]
        [DataRow(10, new[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 })]
        public void ShouldReturnNNumbersOfFibonacciSeries(int values, int[] expectedResult)
        {
            //Act
            int[] result = _exercises.FibonacciSeries(values);

            //Assert
            result.Should().Equal(expectedResult);
        }

        [TestMethod]
        [DataRow(4)]
        public void ShouldCreateAPiramidIncreasingAndDecreasingNumbers(int rows)
        {
            //Act
            string result = _exercises.PiramidOfAccordionEffect(rows);

            //Assert
            result.Should().Be("   1\n  1 2 1\n 1 2 3 2 1\n1 2 3 4 3 2 1");
        }

        [TestMethod]
        [DataRow(12345, 54321)]
        public void ShouldReturnTheReverseNumber(int input, int expectedResult)
        {
            //Act
            int result = _exercises.ReverseNumber(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(121, true)]
        [DataRow(341, false)]
        [DataRow(1001, true)]
        public void ShouldCheckIfIsAPalindrome(int input, bool expectedResult)
        {
            //Act
            bool result = _exercises.IsPalindrome(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(9, 100, 200, 1683)]
        public void ShouldReturnTheSumOfAllNumbersDivisibleByNBetweenStartAndEnd(int divisor, int start, int end, int expectedResult)
        {
            //Act
            int result = _exercises.SumOfDivisors(divisor, start, end);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(4)]
        public void ShouldCreateAPiramidWithAccordionEffectWithLetters(int rows)
        {
            //Act
            string result = _exercises.PiramidOfAccordionEffectLetters(rows);

            //Assert
            result.Should().Be($"   A\n  A B A\n A B C B A\nA B C D C B A");
        }

        [TestMethod]
        [DataRow(25, 11001)]
        public void ShouldReturnBinaryWithoutUsingArray(int input, int expectedResult)
        {
            //Act
            int result = _exercises.BinaryOfValue(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(1010101, 85)]
        [DataRow(10101011, 171)]
        public void ShouldReturnDecimalNumber(int binary, int expectedResult)
        {
            //Act
            int result = _exercises.DecimalOfABinary(binary);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(24, 28, 4)]
        [DataRow(36, 54, 18)]
        public void ShouldReturnHighestCommonFactor(double n1, double n2, double expectedResult)
        {
            //Act
            double result = _exercises.HighestCommonFactor(n1, n2);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(15, 20, 60)]
        public void ShouldReturnLowestCommonFactor(double n1, double n2, double expectedResult)
        {
            //Act
            double result = _exercises.LowestCommonFactor(n1, n2);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(15, false)]
        [DataRow(145, true)]
        public void ShouldCheckIfItsAStrongNumber(int input, bool expectedResult)
        {
            //Act
            bool result = _exercises.IsStrong(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(1, 200, new int[] { 1, 2, 145 })]
        public void ShouldReturnAListOfStrongNumbers(int start, int end, int[] expectedResult)
        {
            //Act
            List<int> result = _exercises.StrongList(start, end);

            //Assert
            result.Should().Equal(expectedResult);
        }

        [TestMethod]
        [DataRow(1, 10, 4, 190)]
        public void ShouldReturnTheSumOfArithmeticProgress(int start, int length, int step, int expectedResult)
        {
            //Act
            int result = _exercises.ArithmeticProgressSum(start, length, step);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(78, 116)]
        [DataRow(116, 164)]
        [DataRow(171, 253)]
        public void ShouldReturnTheOctalEquivalent(int input, int expectedResult)
        {
            //Act
            int result = _exercises.OctalNumber(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(745, 485)]
        [DataRow(1234, 668)]
        [DataRow(12345, 5349)]
        public void ShouldTurnOctalToDecimal(int octal, int expectedResult)
        {
            //Act
            int result = _exercises.DecimalOfOctal(octal);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(1, 5, 2, 63)]
        public void ShouldReturnTheSumOfGeometricSeries(double first, int length, int ratio, double expectedResult)
        {
            //Act
            double result = _exercises.SumOfGeometricSeries(first, length, ratio);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(101, 5)]
        [DataRow(1101, 15)]
        [DataRow(10101011, 253)]
        public void ShouldConvertBinaryToOctal(int binary, int expectedResult)
        {
            //Act
            int result = _exercises.OctalOfBinary(binary);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(5, 101)]
        [DataRow(15, 1101)]
        [DataRow(253, 10101011)]
        public void ShouldConvertOctalToBinary(int octal, int expectedResult)
        {
            //Act
            int result = _exercises.BinaryOfOctal(octal);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(79, "4F")]
        [DataRow(255, "FF")]
        [DataRow(1234, "4D2")]
        public void ShouldConvertDecimalToHexadecimal(int input, string expectedResult)
        {
            //Act
            string result = _exercises.HexadecimalOfDecimal(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow("Welcome", "emocleW")]
        public void ShouldReturnStringInReverse(string input, string expectedResult)
        {
            //Act
            string result = _exercises.StringReverse(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void ShouldCreateAnAOfAsteriscs()
        {
            //Act
            string result = _exercises.AOfAsteriscs();

            //Assert
            result.Should().Be(" ***\n\n*   *\n\n*   *\n\n*****\n\n*   *\n\n*   *\n\n*   *\n\n*   *");
        }
    }
}