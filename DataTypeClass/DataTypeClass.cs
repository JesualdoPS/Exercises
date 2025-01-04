using UnitsNet;

namespace DataTypeLibrary
{
    public class DataTypeClass
    {
        public int UserId = 1250;
        public string Password = "QuotationFactory123";
        public const double PI = 3.14;
        public string AccessMethod(int userId, string password, int tryCount = 0)
        {
            const int maxTries = 3;

            if (tryCount >= maxTries) return "Login rejected: Try again later";

            if (userId == UserId && password == Password) return "Access Granted";

            return AccessMethod(userId, password, tryCount + 1);
        }

        public double Calculate(double n1, double n2, string operatorSymbol)
        {
            switch (operatorSymbol)
            {
                case "+":
                    return n1 + n2;
                case "-":
                    return n1 - n2;
                case "*":
                    return n1 * n2;
                case "/":
                    return n1 / n2;
            }

            throw new FormatException("Wrong value or operator symbol");
        }

        public string ReverseString(string str1, string str2, string str3)
        {
            return string.Join(" ", str3, str2, str1);
        }

        public string TriangleCreator(int input, int width)
        {
            var result = "";

            for (int i = width; i >= 0; i--)
            {
                result += string.Concat(Enumerable.Repeat(input, i)
                    .ToArray()).Trim() + Environment.NewLine;
            }
            return result.Trim();
        }

        public Length PerimeterCircle(double radius)
        {
            return Length.FromMeters(2 * PI * radius);
        }

        public Area AreaCircle(int radius)
        {
            return Area.FromSquareMeters(Math.Pow(radius, 2) * PI);
        }

        public double CalculateX(double input)
        {
            return Math.Pow(input, 2) + (input * 2) + 1;
        }

        public Speed[] MaxSpeed(Length meters, TimeSpan hour, TimeSpan minutes, TimeSpan seconds)
        {
            TimeSpan totalSeconds = hour.Add(minutes).Add(seconds);

            var result = new Speed[3];

            result[0] = Speed.FromMetersPerSecond(meters.Value / totalSeconds.TotalSeconds);
            result[1] = Speed.FromKilometersPerHour(meters.Value / 1000 / totalSeconds.TotalHours);
            result[2] = Speed.FromMilesPerHour(meters.Value / 1609.34 / totalSeconds.TotalHours);

            return result;
        }

        public Area SphereSurface(double radius)
        {
            return Area.FromSquareMeters(4 * PI * Math.Pow(radius, 2));
        }

        public Volume SphereVolume(double radius)
        {
            return Volume.FromCubicMeters(1.33 * PI * Math.Pow(radius, 3));
        }

        public string GetTypeInformation(char input)
        {
            if (char.IsDigit(input))
                return "It's a digit";
            else if (char.IsLower(input) && "aeiou".Contains(input.ToString()))
                return "It's a lower case vowel";
            else if (char.IsUpper(input) && "AEIOU".Contains(input.ToString()))
                return "It's an upper case vowel";
            else
                return "It's a symbol";
        }

        public bool IsSameType(int n1, int n2)
        {
            return n1 % 2 == n2 % 2;
        }

        public int GetBinary(int n1)
        {
            return int.Parse(Convert.ToString(n1, 2));
        }
    }
}

