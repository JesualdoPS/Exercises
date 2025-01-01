using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicAlgorithm.BasicAlgorithmClass;
using Xunit.Sdk;
using System.Net;

namespace BasicAlgorithm.BasicAlgorithmTests
{
    [TestClass]
    public class ExceptionTests
    {
        private readonly AlgorithmClass _exercise;

        public ExceptionTests()
        {
            _exercise = new AlgorithmClass();
        }

        [TestMethod]
        [DataRow(double.NaN)]
        public void ShouldThrowExceptionWhenInputIsNotNumber(double n1)
        {
            //Act
            Action action = () => _exercise.IsMultipleOf3Or7(n1);

            //Assert
            action.Should().Throw<ArgumentException>();
        }

        [TestMethod]
        [DataRow(-25)]
        public void ShouldThrowNegativeNumberException(double n1)
        {
            //Act
            Action action = () => _exercise.IsMultipleOf3Or7(n1);

            //Assert
            action.Should().Throw<NegativeNumberException>();
        }

        [TestMethod]
        [DataRow("C://temp/NotExists")]
        public void ShouldThrowAFileDoesNotExistException(string filePath)
        {
            //Act
            Action action = () => _exercise.FileReader(filePath);

            //Assert
            action.Should().Throw<FileNotFoundException>();
        }

        [TestMethod]
        [DataRow(1001, -1)]
        public void ShouldThrowExceptionIfInputIsLessThan0OrGreaterThan1000(double n1, double n2)
        {
            //Act
            Action action = () => _exercise.Is30OrSum30(new[] { n1, n2 });

            //Assert
            action.Should().Throw<NumberOutOfRangeException>();
        }

        [TestMethod]
        public void ShouldThrowExceptionIfArrayIsEmpty()
        {
            //Act
            Action action = () => _exercise.LargestAverageBetweenHalves(Array.Empty<int>());

            //Assert
            action.Should().Throw<EmptyArrayException>();
        }

        [TestMethod]
        [DataRow("ABC")]
        public void ShouldThrowExceptionIfCannotConvertToInt(string input)
        {
            //Act
            Action action = () => _exercise.IntConverter(input);

            //Assert
            action.Should().Throw<FormatException>();
        }

        [TestMethod]
        public void ShouldThrowExceptionIfOutsideTheRangeOfInteger()
        {
            //Act
            Action action = () => _exercise.AbsoluteDiferenceOrTriple(int.MaxValue, int.MinValue);

            //Assert
            action.Should().Throw<OverflowException>();
        }

        [TestMethod]
        [DataRow(20,0)]
        public void Should(double n1, double n2)
        {
            //Act
            Action action = () => _exercise.Divide(n1, n2);

            //Assert
            action.Should().Throw<DivideByZeroException>();
        }

        [TestMethod]
        [DataRow("AB/13/3001")]
        public void ShouldThrowExceptionIfCannotConvertToDateTime(string date)
        {
            //Act
            Action action = () => _exercise.DateTimeConverter(date);

            //Assert
            action.Should().Throw<FormatException>();
        }

        [TestMethod]
        public void ShouldThrowExceptionIfStringIsNull()
        {
            //Act
            Action action = () => _exercise.AllToUpper(new[] { string.Empty });

            //Assert
            action.Should().Throw<NullReferenceException>();
        }

        [TestMethod]
        [DataRow(21)]
        public void ShouldThrowExceptionIfResultIsOutOfIntsRange(int input)
        {
            //Act
            Action action = () => _exercise.CalculateFactorial(input);

            //Assert
            action.Should().Throw<OverflowException>();
        }

        [TestMethod]
        public void ShouldThrowExceptionIfURLIsInaccessible()
        {
            //Act
            Action action = () => _exercise.URLDownloader(string.Empty);

            //Assert
            action.Should().Throw<WebException>();
        }
    }
}