using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using DataTypeLibrary;
using UnitsNet;
using System.Configuration;

namespace DataTypeTests
{
    [TestClass]
    public class DataTypeClassTests
    {
        public readonly DataTypeClass _exercise;

        public DataTypeClassTests()
        {
            _exercise = new DataTypeClass();
        }

        [TestMethod]
        [DataRow("b", "a", "t", "t a b")]
        public void ShouldReturnStringWithLettersInReverse(string str1, string str2, string str3, string expectedResult)
        {
            //Act
            string result = _exercise.ReverseString(str1, str2, str3);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(6, 6)]
        public void ShouldCreateATriangle(int input, int width)
        {
            //Act
            string result = _exercise.TriangleCreator(input, width);

            //Assert
            result.Should().Be("666666\r\n66666\r\n6666\r\n666\r\n66\r\n6");
        }

        [TestMethod]
        [DataRow(1250, "QuotationFactory123", "Access Granted")]
        public void ShouldGrantAccess(int tryId, string password, string expectedResult)
        {
            //Act
            string result = _exercise.AccessMethod(tryId, password);

            //Assert
            result.Should().Be("Access Granted");
        }

        [TestMethod]
        [DataRow(1240, "Factory123", "Login rejected: Try again later")]
        public void ShouldRejectLoginAfter3Tries(int tryId, string wrongPassword, string expectedResult)
        {
            // Act            
            string result = _exercise.AccessMethod(tryId, wrongPassword);

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(20, 12, "-", 8)]
        [DataRow(20, 12, "+", 32)]
        [DataRow(20, 2, "*", 40)]
        [DataRow(20, 10, "/", 2)]
        public void ShouldCalculateResult(double n1, double n2, string operatorSymbol, double expectedResult)
        {
            //Act
            double result = _exercise.Calculate(n1, n2, operatorSymbol);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(20, 12, ":", 8)]
        public void ShouldThrowCalculateException(double n1, double n2, string operatorSymbol, double expectedResult)
        {
            //Act
            Action action = () => _exercise.Calculate(n1, n2, operatorSymbol);

            //Assert
            action.Should().Throw<FormatException>();
        }

        [TestMethod]
        [DataRow(12, 75.36)]
        [DataRow(25, 157)]
        public void ShouldCalculatePerimeterOfACircle(double radius, double expectedResult)
        {
            //Act
            Length result = _exercise.PerimeterCircle(radius);

            //Assert
            result.Should().BeEquivalentTo(Length.FromMeters(expectedResult));
        }

        [TestMethod]
        [DataRow(12, 452.16)]
        public void ShouldCalculateAreaOfACircle(int radius, double expectedResult)
        {
            //Act
            Area result = _exercise.AreaCircle(radius);

            //Assert
            result.Should().Be(Area.FromSquareMeters(expectedResult));
        }

        [TestMethod]
        [DataRow(-5, 16)]
        [DataRow(5, 36)]
        public void ShouldReturnTheValueOfX(double input, double expectedResult)
        {
            //Act
            double result = _exercise.CalculateX(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void ShouldCalculateSpeed()
        {
            //Arrange
            var meters = Length.FromMeters(50000);
            TimeSpan hour = TimeSpan.FromHours(1);
            TimeSpan minutes = TimeSpan.FromMinutes(35);
            TimeSpan seconds = TimeSpan.FromSeconds(56);

            //Act
            Speed[] result = _exercise.MaxSpeed(meters, hour, minutes, seconds);

            //Assert
            Math.Round(result[0].Value, 2).Should().Be(8.69);
            result[0].Unit.ToString().Should().Be("MeterPerSecond");
            Math.Round(result[1].Value, 2).Should().Be(31.27);
            result[1].Unit.ToString().Should().Be("KilometerPerHour");
            Math.Round(result[2].Value, 2).Should().Be(19.43);
            result[2].Unit.ToString().Should().Be("MilePerHour");
        }

        [TestMethod]
        [DataRow(2, 50.26)]
        public void ShouldCalculateSurfaceOfASphere(double radius, double expectedResult)
        {
            //Act
            Area result = _exercise.SphereSurface(radius);

            //Assert
            Math.Round(result.Value, 2).Should().Be(50.24);
            result.Unit.ToString().Should().Be("SquareMeter");
        }

        [TestMethod]
        [DataRow(2, 33.49)]
        public void ShouldCalculateVolumeOfASphere(double radius, double expectedResult)
        {
            //Act
            Volume result = _exercise.SphereVolume(radius);

            //Assert
            Math.Round(result.Value, 2).Should().Be(33.41);
            result.Unit.ToString().Should().Be("CubicMeter");
        }

        [TestMethod]
        [DataRow('a', "It's a lower case vowel")]
        [DataRow('E', "It's an upper case vowel")]
        [DataRow('2', "It's a digit")]
        [DataRow(':', "It's a symbol")]
        public void ShouldCheckTheTypeOfInput(char input, string expectedResult)
        {
            //Act
            string result = _exercise.GetTypeInformation(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(20, 14, true)]
        [DataRow(25, 37, true)]
        [DataRow(52, 11, false)]
        public void ShouldBothBeEvenOrOdd(int n1, int n2, bool expectedResult)
        {
            //Act
            bool result = _exercise.IsSameType(n1, n2);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(25, 11001)]
        public void ShouldReturnTheEquivalentBinaryNumber(int n1, int expectedResult)
        {
            //Act
            int result = _exercise.GetBinary(n1);

            //Assert
            result.Should().Be(expectedResult);
        }
    }
}