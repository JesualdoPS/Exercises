using ConditionalLibrary;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitsNet;

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
            result.Should().Be("Roll No: 784" +
                "\nName: James" +
                "\nMarks in Physics: 70" +
                "\nMarks in Chemistry: 80" +
                "\nMarks in Computer Application: 90" +
                "\nTotal Marks: 240" +
                "\nPercentage: 80" +
                "\nDivision: First");
        }

        [TestMethod]
        [DataRow(784, "James", 70, 60, 80)]
        public void ShouldCalculateTheTotalPercentageAndDivisionMustBeSecond(int roll, string name, int physics, int chemistry, int compApplication)
        {
            //Act
            string result = _exercises.CalculateTheTotalPercentageAndDivision(roll, name, physics, chemistry, compApplication);

            //Assert
            result.Should().Be("Roll No: 784" +
                "\nName: James" +
                "\nMarks in Physics: 70" +
                "\nMarks in Chemistry: 60" +
                "\nMarks in Computer Application: 80" +
                "\nTotal Marks: 210" +
                "\nPercentage: 70" +
                "\nDivision: Second");
        }

        [TestMethod]
        [DataRow(784, "James", 50, 55, 60)]
        public void ShouldCalculateTheTotalPercentageAndDivisionMustBeThird(int roll, string name, int physics, int chemistry, int compApplication)
        {
            //Act
            string result = _exercises.CalculateTheTotalPercentageAndDivision(roll, name, physics, chemistry, compApplication);

            //Assert
            result.Should().Be("Roll No: 784" +
                "\nName: James" +
                "\nMarks in Physics: 50" +
                "\nMarks in Chemistry: 55" +
                "\nMarks in Computer Application: 60" +
                "\nTotal Marks: 165" +
                "\nPercentage: 55" +
                "\nDivision: Pass");
        }

        [TestMethod]
        [DataRow(784, "James", 40, 30, 35)]
        public void ShouldCalculateTheTotalPercentageAndDivisionMustBeFail(int roll, string name, int physics, int chemistry, int compApplication)
        {
            //Act
            string result = _exercises.CalculateTheTotalPercentageAndDivision(roll, name, physics, chemistry, compApplication);

            //Assert
            result.Should().Be("Roll No: 784" +
                "\nName: James" +
                "\nMarks in Physics: 40" +
                "\nMarks in Chemistry: 30" +
                "\nMarks in Computer Application: 35" +
                "\nTotal Marks: 105" +
                "\nPercentage: 35" +
                "\nDivision: Fail");
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

        [TestMethod]
        [DataRow(50, 50, 110, "Isoceles")]
        [DataRow(50, 60, 120, "Scalene")]
        [DataRow(60, 60, 60, "Equilateral")]
        public void ShouldReturnTheTriangleType(int side1, int side2, int side3, string expectedResult)
        {
            //Act
            string result = _exercises.TriangleType(side1, side2, side3);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(45, 55, 65, "The triangle is not valid")]
        [DataRow(90, 45, 45, "The triangle is valid")]
        public void ShouldCheckIfIsATriangle(int angleA, int angleB, int angleC, string expectedResult)
        {
            //Act
            string result = _exercises.IsTriangle(angleA, angleB, angleC);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow('k', "Is consoant")]
        [DataRow('a', "Is vowel")]
        public void ShouldCheckIfItsAVowelOrConsoant(char input, string expectedResult)
        {
            //Act
            string result = _exercises.IsVowelOrConsoant(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(500, 700, "Profit of 200")]
        [DataRow(500, 300, "Loss of -200")]
        public void ShouldReturnProfitOrLoss(int costPrice, int sellPrice, string expectedResult)
        {
            //Act
            string result = _exercises.CalculateProfit(costPrice, sellPrice);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(1001, "James", 190, 228, 0, 228)]
        [DataRow(1002, "Mark", 260, 390, 0, 390)]
        [DataRow(1003, "Cesar", 510, 918, 137.7, 1055.7)]
        [DataRow(1004, "Billy", 800, 1600, 240, 1840)]
        public void ShouldReturnElectricityBill(int Id, string name, int unitsConsumed, double amountCharge, double surcharge, double valuePaid)
        {
            //Act
            string result = _exercises.ElectricityBill(Id, name, unitsConsumed);

            //Assert
            result.Should().Be($"Id: {Id}" +
                $"\nName: {name}" +
                $"\nUnits consumed: {unitsConsumed}" +
                $"\nAmount charges: {amountCharge}" +
                $"\nSurcharge amount: {surcharge}" +
                $"\nNet amoun to be paid: {valuePaid}");
        }

        [TestMethod]
        [DataRow('E', "Excelent")]
        [DataRow('V', "Very good")]
        [DataRow('G', "Good")]
        [DataRow('A', "Average")]
        [DataRow('F', "Fail")]
        public void ShouldReturnGradeDescription(char grade, string expectedResult)
        {
            //Act
            string result = _exercises.GradeDescription(grade);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void ShouldReturnExceptionOnGradeDescription()
        {
            //Arrange
            char grade = 'C';

            //Act
            Action action = () => _exercises.GradeDescription(grade);

            //Assert
            action.Should().Throw<ArgumentException>("Invalid grade");
        }

        [TestMethod]
        [DataRow(1, "Sunday")]
        [DataRow(2, "Monday")]
        [DataRow(3, "Tuesday")]
        [DataRow(4, "Wednesday")]
        [DataRow(5, "Thursday")]
        [DataRow(6, "Friday")]
        [DataRow(7, "Saturday")]
        public void ShouldReturnDayName(int dayNumber, string expectedResult)
        {
            //Act
            string result = _exercises.DayName(dayNumber);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void ShouldReturnDayNameArgumentException()
        {
            //Arrange
            int dayNumber = 8;

            //Act
            Action action = () => _exercises.DayName(dayNumber);

            //Assert
            action.Should().Throw<ArgumentException>("Invalid day number");
        }

        [TestMethod]
        [DataRow(1, "One")]
        [DataRow(4, "Four")]
        [DataRow(7, "Seven")]
        [DataRow(11, "Invalid digit")]
        public void ShouldReturnDigitName(int digit, string expectedResult)
        {
            //Act
            string result = _exercises.DigitName(digit);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(4, "April")]
        [DataRow(8, "August")]
        [DataRow(12, "December")]
        [DataRow(15, "Not a valid month")]
        public void ShouldReturnMonthName(int monthNumber, string expectedResult)
        {
            //Act
            string result = _exercises.MonthName(monthNumber);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(7, "July has 31 days")]
        public void Should(int month, string expectedResult)
        {
            //Act
            string result = _exercises.DaysInSpecificMonth(month);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow("Circle, 5", 78.5)]
        [DataRow("Rectangle, 5, 5", 25)]
        [DataRow("Triangle, 10, 5", 25)]
        public void ShouldCalculateAreaBasedOnMenu(string input, double expectedResult)
        {
            //Act
            Area result = _exercises.AreaOfShapes(input);

            //Assert
            result.Should().Be(Area.FromSquareCentimeters(expectedResult));
        }

        [TestMethod]
        public void ShouldThrowExceptionWhenCalculatingAreaBasedOnMenu()
        {
            //Arrange
            string input = "Sphere,5";

            //Act
            Action action = () => _exercises.AreaOfShapes(input);

            //Assert
            action.Should().Throw<ArgumentException>("Its not a valid shape");
        }

        [TestMethod]
        [DataRow(1, 10, 2, 12)]
        [DataRow(2, 10, 2, 8)]
        [DataRow(3, 10, 2, 20)]
        [DataRow(4, 10, 2, 5)]
        [DataRow(5, 10, 2, 100)]
        [DataRow(6, 10, 10, 0)]
        public void ShouldCalculateBasedOnMenu(int option, double n1, double n2, double expectedResult)
        {
            //Act
            double result = _exercises.Calculator(option, n1, n2);

            //Assert
            result.Should().Be(expectedResult);
        }
    }
}