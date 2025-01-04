using System.Reflection.Metadata.Ecma335;
using UnitsNet;

namespace ConditionalLibrary
{
    public class ConditionalStatementClass
    {
        public const double PI = 3.14;

        private static readonly Dictionary<int, string> digitName = new()
        {
            {0, "Zero"}, {1, "One"}, {2,"Two"}, {3,"Three"}, {4, "Four"},
            {5, "Five"}, {6, "Six"}, {7, "Seven" }, {8, "Eigth"}, {9, "Nine"}
        };

        private static readonly Dictionary<int, string> monthName = new()
        {
            {1, "January"}, {2, "February"}, {3, "March"}, {4, "April"},
            {5, "May"}, {6, "June"}, {7, "July"}, {8, "August"},
            {9, "September"}, {10, "October"}, {11, "November"}, {12, "December"}
        };

        public bool AreEqual(int n1, int n2)
        {
            return n1 == n2;
        }

        public string EvenOrOdd(int input)
        {
            return input % 2 == 0 ? "Even" : "Odd";
        }

        public string PositiveOrNegative(int input)
        {
            return input > 0 ? "Positive" : "Negative";
        }

        public bool IsALeapYear(int input)
        {
            return input % 4 == 0 && (input % 100 != 0 || input % 400 == 0);
        }

        public string IsAbleToVote(int input)
        {
            return input >= 16 ? "Congratulations! You can vote" : "You're still too young";
        }

        public int MoreOrLessThanZero(int input)
        {
            if (input == 0) return 0;

            return input > 0 ? 1 : -1;
        }

        public string PersonHeigth(int heigthInCentimeters)
        {
            return heigthInCentimeters switch
            {
                < 150 => "The person is Dwarf",
                < 165 => "Average height",
                < 195 => "The person is tall",
                _ => "Abnormal height"
            };
        }

        public int Largest(int[] ints)
        {
            return ints.Max();
        }

        public string Quadrant(int x, int y)
        {
            if (x > 0 && y > 0) { return "First quadrant"; }
            else if (x > 0 && y < 0) { return "Second quadrant"; }
            else if (x < 0 && y < 0) { return "Third quadrant"; }
            else { return "Fourth quadrant"; }
        }

        public string AdmissionCheck(int math, int chem, int phy)
        {
            if (math + chem + phy >= 180) return "Eligible for admission";

            return math + phy >= 140 ? "Eligible for admission" : "Not eligible";
        }

        public string RootOfEquation(int a, int b, int c)
        {
            double delta = Math.Pow(b, 2) - 4 * a * c;

            if (delta < 0) throw new Exception("Root are imaginary: no solution");

            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            return $"X can be {x1} or {x2}";
        }

        public string CalculateTheTotalPercentageAndDivision(int roll, string name, int physics, int chemistry, int compApplication)
        {
            double totalMarks = physics + chemistry + compApplication;

            double percentage = totalMarks / 3;
            string division = "";

            division = percentage >= 80 ? "First"
                : percentage >= 60 ? "Second"
                : percentage >= 40 ? "Pass"
                : "Fail";

            return $"Roll No: {roll}" +
                $"\nName: {name}" +
                $"\nMarks in Physics: {physics}" +
                $"\nMarks in Chemistry: {chemistry}" +
                $"\nMarks in Computer Application: {compApplication}" +
                $"\nTotal Marks: {totalMarks}" +
                $"\nPercentage: {percentage}" +
                $"\nDivision: {division}";
        }

        public string WeatherMessage(double temperature)
        {
            return temperature >= 40 ? "It's very hot"
                : temperature >= 30 ? "It's hot"
                : temperature >= 20 ? "Normal temperature"
                : temperature >= 10 ? "Cold weather"
                : temperature >= 0 ? "Very cold weather"
                : "Freezing weather";
        }

        public string TriangleType(int side1, int side2, int side3)
        {
            if (side1 == side2 && side2 == side3) return "Equilateral";

            return new[] { side1, side2, side3 }.Distinct().Count() == 2 ? "Isoceles" : "Scalene";
        }

        public string IsTriangle(int angleA, int angleB, int angleC)
        {
            return angleA + angleB + angleC == 180 ? "The triangle is valid" : "The triangle is not valid";
        }

        public string IsVowelOrConsoant(char input)
        {
            string vowel = "AEIOUaeiou";

            return vowel.Contains(input) ? "Is vowel" : "Is consoant";
        }

        public string CalculateProfit(int costPrice, int sellPrice)
        {
            int result = sellPrice - costPrice;
            return result >= 0 ? $"Profit of {result}" : $"Loss of {result}";
        }

        public string ElectricityBill(int id, string name, int unitsConsumed)
        {
            double chargePerUnit = unitsConsumed switch
            {
                <= 200 => 1.2,
                <= 400 => 1.5,
                <= 600 => 1.8,
                _ => 2.0
            };

            double amountCharges = unitsConsumed * chargePerUnit;
            double surchageAmount = amountCharges > 400 ? amountCharges * 0.15 : 0;

            return $"Id: {id}" +
                $"\nName: {name}" +
                $"\nUnits consumed: {unitsConsumed}" +
                $"\nAmount charges: {amountCharges}" +
                $"\nSurcharge amount: {surchageAmount}" +
                $"\nNet amoun to be paid: {amountCharges + surchageAmount}";
        }

        public string GradeDescription(char grade)
        {
            return grade switch
            {
                'E' => "Excelent",
                'V' => "Very good",
                'G' => "Good",
                'A' => "Average",
                'F' => "Fail",
                _ => throw new ArgumentException("Invalid grade")
            };
        }

        public string DayName(int dayNumber)
        {
            return dayNumber switch
            {
                1 => "Sunday",
                2 => "Monday",
                3 => "Tuesday",
                4 => "Wednesday",
                5 => "Thursday",
                6 => "Friday",
                7 => "Saturday",
                _ => throw new ArgumentException("Invalid day number")
            };
        }

        public string DigitName(int digit)
        {
            if (digit.ToString().Length > 1) return "Invalid digit";

            return digitName[digit];
        }

        public string MonthName(int monthNumber)
        {
            if (monthNumber > 12) return "Not a valid month";

            return monthName[monthNumber];
        }

        public string DaysInSpecificMonth(int month)
        {
            if (month > 12) return "Not a valid month";

            return $"{monthName[month]} has {DateTime.DaysInMonth(2025, month)} days";
        }

        public Area AreaOfShapes(string input)
        {
            string[] parts = input.Split(',');

            return parts[0] switch
            {
                "Circle" => Area.FromSquareCentimeters(PI * Math.Pow(Convert.ToInt32(parts[1]), 2)),
                "Rectangle" => Area.FromSquareCentimeters(Convert.ToInt32(parts[1]) * Convert.ToInt32(parts[2])),
                "Triangle" => Area.FromSquareCentimeters(0.5 * Convert.ToInt32(parts[1]) * Convert.ToInt32(parts[2])),
                _ => throw new ArgumentException("Its not a valid shape")
            };
        }

        public double Calculator(int option, double n1, double n2)
        {           
            return option switch
            {
                1 => n1 + n2,
                2 => n1 - n2,
                3 => n1 * n2,
                4 => n1 / n2,
                5 => Math.Pow(n1, n2),
                _ => 0
            };
        }
    }
}
