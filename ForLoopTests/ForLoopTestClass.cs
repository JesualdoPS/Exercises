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
    }
}