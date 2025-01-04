using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using ConditionalLibrary;
using System.Threading;

namespace ConditionalTests
{
    [TestClass]
    public class ConditionalStatementTests
    {
        private readonly ConditionalStatementClass _exercises;

        public ConditionalStatementTests()
        {
            _exercises = new ConditionalStatementClass();
        }

        [TestMethod]
        [DataRow(5, 5, true)]
        [DataRow(5, 6, false)]
        public void ShouldBeEqual(int n1, int n2, bool expectedResult)
        {
            //Act
            bool result = _exercises.AreEqual(n1, n2);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(2, "Even")]
        [DataRow(3, "Odd")]
        public void ShouldCheckIfItsEvenOrOdd(int input, string expectedResult)
        {
            //Act
            string result = _exercises.EvenOrOdd(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(14, "Positive")]
        [DataRow(-15, "Negative")]
        public void ShouldReturnPositiveOrNegative(int input, string expectedResult)
        {
            //Act
            string result = _exercises.PositiveOrNegative(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(2016, true)]
        [DataRow(2017, false)]
        public void ShouldCheckIfItsALeapYear(int input, bool expectedResult)
        {
            //Act
            bool result = _exercises.IsALeapYear(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(21, "Congratulations! You can vote")]
        [DataRow(14, "You're still too young")]
        public void ShouldCheckIfThePersonCanVote(int input, string expectedResult)
        {
            //Act
            string result = _exercises.IsAbleToVote(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(12, 1)]
        [DataRow(-12, -1)]
        [DataRow(0, 0)]
        public void ShouldReturnAValueIfItsMoreOrLessThanZero(int input, int expectedResult)
        {
            //Act
            int result = _exercises.MoreOrLessThanZero(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(149, "The person is Dwarf")]
        [DataRow(160, "Average height")]
        [DataRow(175, "The person is tall")]
        [DataRow(200, "Abnormal height")]
        public void ShouldCheckThePersonHeigth(int heigthInCentimeters, string expectedResult)
        {
            //Act
            string result = _exercises.PersonHeigth(heigthInCentimeters);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(25, 63, 10, 63)]
        [DataRow(78, 63, 10, 78)]
        [DataRow(25, 63, 81, 81)]
        public void ShouldFindTheLargest(int n1, int n2, int n3, int expectedResult)
        {
            //Act
            int result = _exercises.Largest(new[] { n1, n2, n3 });

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(7, 9, "First quadrant")]
        [DataRow(7, -9, "Second quadrant")]
        [DataRow(-7, -9, "Third quadrant")]
        [DataRow(-7, 9, "Fourth quadrant")]
        public void ShouldReturnTheQuadrant(int x, int y, string expectedResult)
        {
            //Act
            string result = _exercises.Quadrant(x, y);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(72, 51, 65, "Eligible for admission")]
        [DataRow(65, 48, 66, "Not eligible")]
        public void ShouldCheckIfTheProfessionalCanBeAdmitted(int math, int chem, int phy, string expectedResult)
        {
            //Act
            string result = _exercises.AdmissionCheck(math, chem, phy);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(1, -7, 12, "X can be 4 or 3")]
        public void ShouldReturnTheRootOfAEquation(int a, int b, int c, string expectedResult)
        {
            //Act
            string result = _exercises.RootOfEquation(a, b, c);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(1, 5, 7)]
        public void ShouldThrowExceptionIfDeltaIsNegative(int a, int b, int c)
        {
            //Act
            Action action = () => _exercises.RootOfEquation(a, b, c);

            //Assert
            action.Should().Throw<Exception>();
        }

        [TestMethod]
        [DataRow(784, "James", 70, 80, 90)]
        public void ShouldCalculateTheTotalPercentageAndDivisionMustBeFirst(int roll, string name, int physics, int chemistry, int compApplication)
        {
            //Act
            string result = _exercises.CalculateTheTotalPercentageAndDivision(roll, name, physics, chemistry, compApplication);

            //Assert
            result.Should().Be("Roll No: 784\r\nName: James" +
                "\r\nMarks in Physics: 70" +
                "\r\nMarks in Chemistry: 80" +
                "\r\nMarks in Computer Application: 90" +
                "\r\nTotal Marks: 240" +
                "\r\nPercentage: 80" +
                "\r\nDivision: First");
        }

        [TestMethod]
        [DataRow(784, "James", 70, 60, 80)]
        public void ShouldCalculateTheTotalPercentageAndDivisionMustBeSecond(int roll, string name, int physics, int chemistry, int compApplication)
        {
            //Act
            string result = _exercises.CalculateTheTotalPercentageAndDivision(roll, name, physics, chemistry, compApplication);

            //Assert
            result.Should().Be("Roll No: 784\r\nName: James" +
                "\r\nMarks in Physics: 70" +
                "\r\nMarks in Chemistry: 60" +
                "\r\nMarks in Computer Application: 80" +
                "\r\nTotal Marks: 210" +
                "\r\nPercentage: 70" +
                "\r\nDivision: Second");
        }

        [TestMethod]
        [DataRow(784, "James", 50, 55, 60)]
        public void ShouldCalculateTheTotalPercentageAndDivisionMustBeThird(int roll, string name, int physics, int chemistry, int compApplication)
        {
            //Act
            string result = _exercises.CalculateTheTotalPercentageAndDivision(roll, name, physics, chemistry, compApplication);

            //Assert
            result.Should().Be("Roll No: 784\r\nName: James" +
                "\r\nMarks in Physics: 50" +
                "\r\nMarks in Chemistry: 55" +
                "\r\nMarks in Computer Application: 60" +
                "\r\nTotal Marks: 165" +
                "\r\nPercentage: 55" +
                "\r\nDivision: Pass");
        }

        [TestMethod]
        [DataRow(784, "James", 40, 30, 35)]
        public void ShouldCalculateTheTotalPercentageAndDivisionMustBeFail(int roll, string name, int physics, int chemistry, int compApplication)
        {
            //Act
            string result = _exercises.CalculateTheTotalPercentageAndDivision(roll, name, physics, chemistry, compApplication);

            //Assert
            result.Should().Be("Roll No: 784\r\nName: James" +
                "\r\nMarks in Physics: 40" +
                "\r\nMarks in Chemistry: 30" +
                "\r\nMarks in Computer Application: 35" +
                "\r\nTotal Marks: 105" +
                "\r\nPercentage: 35" +
                "\r\nDivision: Fail");
        }

        [TestMethod]
        [DataRow(-2, "Freezing weather")]
        [DataRow(2, "Very cold weather")]
        [DataRow(15, "Cold weather")]
        [DataRow(23, "Normal temperature")]
        [DataRow(37, "It's hot")]
        [DataRow(44, "It's very hot")]
        public void ShouldReturnAMessageAccordingWithTheWeather(double temperature, string expectedResult)
        {
            //Act
            string result = _exercises.WeatherMessage(temperature);

            //Assert
            result.Should().Be(expectedResult);
        }
    }
}