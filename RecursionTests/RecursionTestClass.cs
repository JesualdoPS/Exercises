using System.Dynamic;
using System.Security.Cryptography.X509Certificates;
using FluentAssertions;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecursionLibrary;

namespace RecursionTests
{
    [TestClass]
    public class RecursionTestClass
    {
        private readonly RecursionClass _exercises;

        public RecursionTestClass()
        {
            _exercises = new RecursionClass();
        }

        [TestMethod]
        [DataRow(1, new int[] { 1 })]
        [DataRow(5, new int[] { 1, 2, 3, 4, 5 })]
        [DataRow(10, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })]
        [DataRow(-1, new int[] { })]
        public void ShouldReturnAllValuesUntilInputUsingRecursion(int limit, int[] expectedResult)
        {
            // Act
            int[] result = RecursionClass.GetRecursiveNumbers(limit);

            // Assert
            result.Should().Equal(expectedResult);
        }

        [TestMethod]
        [DataRow(10, new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 })]
        [DataRow(5, new int[] { 5, 4, 3, 2, 1 })]
        public void ShouldReturnAllValuesFromInputDecreasingUntilOneUsingRecursion(int start, int[] expectedResult)
        {
            //Act
            int[] result = RecursionClass.GetDecreasingSequence(start);

            //Assert
            result.Should().Equal(expectedResult);
        }

        [TestMethod]
        [DataRow(10, 55)]
        public void ShouldReturnTheSumOfNNatualNumbersUsingRecursion(int limit, int expectedResult)
        {
            //Act
            int result = RecursionClass.SumNaturalNumbers(limit);

            //Assert
            result.Should().Be(result);
        }

        [TestMethod]
        [DataRow(1234, "1 2 3 4")]
        [DataRow(54321, "5 4 3 2 1")]
        public void ShouldDisplayTheIndividualDigitsOfAValue(int input, string expectedResult)
        {
            //Act
            string result = RecursionClass.DigitsToString(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(1234, 4)]
        [DataRow(54321, 5)]
        public void ShouldCountHowManyDigitsUsingRecursion(int input, int expectedResult)
        {
            //Act
            int result = RecursionClass.DigitCount(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(20, new int[] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 })]
        [DataRow(10, new int[] { 2, 4, 6, 8, 10 })]
        [DataRow(25, new int[] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25 })]
        public void ShouldReturnAllEvenNumbersUntilLimit(int limit, int[] expectedResult)
        {
            //Act
            int[] result = RecursionClass.EvenOrOddSequence(limit);

            //Assert
            result.Should().Equal(expectedResult);
        }

        [TestMethod]
        [DataRow(37, true)]
        [DataRow(25, false)]
        public void ShouldCheckIfNumberIsPrimeOrNot(int input, bool expectedResult)
        {
            //Act
            bool result = RecursionClass.IsPrime(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow("RADAR", true)]
        [DataRow("VISUAL", false)]
        [DataRow("STONE", false)]
        [DataRow("NOON", true)]
        public void ShouldCheckIfIsAPalindrome(string input, bool expectedResult)
        {
            //Act
            bool result = RecursionClass.IsPalindrome(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(5, 120)]
        [DataRow(10, 3628800)]
        public void ShouldCalculateFactorialUsingRecursion(int input, int expectedResult)
        {
            //Act
            int result = RecursionClass.Factorial(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(10, new int[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 })]
        public void ShouldReturnNValuesFromFibonacciSequence(int values, int[] expectedResult)
        {
            //Act
            int[] result = RecursionClass.FibonacciSequence(values);

            //Assert
            result.Should().Equal(expectedResult);
        }

        [TestMethod]
        [DataRow(new int[] { 1, 2, 3 }, new int[] { 123, 132, 213, 231, 321, 312 })]
        [DataRow(new int[] { 2, 3 }, new int[] { 23, 32 })]
        public void ShouldReturnAllPermutationsOfValuesInArray(int[] array, int[] expectedResult)
        {
            //Act
            int[] result = RecursionClass.Permutation(array);

            //Assert
            result.Should().Equal(expectedResult);
        }

        [TestMethod]
        [DataRow(10, 15, "GCD: 5\nLCM: 30")]
        public void ShouldReturnGCDAndLCM(int n1, int n2, string expectedResult)
        {
            //Act
            string result = RecursionClass.GCDandLCM(n1, n2);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(66, "1000010")]
        [DataRow(85, "1010101")]
        public void ShouldConvertADecimalToBinary(int input, string expectedResult)
        {
            //Act
            string result = RecursionClass.ToBinary(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow("w3resource", "ecruoser3w")]
        [DataRow("Jesualdo", "odlauseJ")]
        public void ShouldInvertAStringUsingRecursion(string input, string expectedResult)
        {
            //Act
            string result = RecursionClass.ReverseString(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(5, 3, 125)]
        [DataRow(2, 5, 32)]
        public void ShouldReturnThePowerOfANumberUsingRecursion(int input, int power, int expectedResult)
        {
            //Act
            int result = RecursionClass.Power(input, power);

            //Assert
            result.Should().Be(expectedResult);
        }
    }
}
