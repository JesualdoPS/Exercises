


using System.Net.Http.Headers;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConditionalLibrary
{
    public class ConditionalStatementClass
    {
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

            return $"Roll No: {roll}\r\nName: {name}" +
                $"\r\nMarks in Physics: {physics}" +
                $"\r\nMarks in Chemistry: {chemistry}" +
                $"\r\nMarks in Computer Application: {compApplication}" +
                $"\r\nTotal Marks: {totalMarks}" +
                $"\r\nPercentage: {percentage}" +
                $"\r\nDivision: {division}";
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
    }
}
