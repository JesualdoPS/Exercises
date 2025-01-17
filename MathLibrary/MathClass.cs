using System.Globalization;

namespace MathLibrary
{
    public class MathClass
    {
        public object Absolute(int? inputInt = null, double? inputDouble = null, long? inputLong = null)
        {
            if (inputDouble != null) return Convert.ToDouble(Math.Abs(Convert.ToDouble(inputDouble)));
            if (inputLong != null) return Convert.ToInt64(Math.Abs(Convert.ToInt64(inputLong)));

            return (Convert.ToInt32(Math.Abs(Convert.ToInt32(inputInt))));
        }

        public string ThreeMeanTipes(double[] input)
        {
            double trueMean = Math.Round(input.Average(), 2);
            double awayFromZero = Math.Round(input.Average(), 2, MidpointRounding.AwayFromZero);
            double roundToNearest = Math.Round(input.Average(), 2, MidpointRounding.ToEven);
            return $"True mean: {trueMean}/ Away from zero: {awayFromZero}/ Rounding to nearest: {roundToNearest}";
        }

        public string MilesPerSide(string cityName, double squareMiles)
        {
            return $"{cityName} has {Math.Sqrt(squareMiles).ToString("F2")} miles per side";
        }

        public string FracturedNumber(double input)
        {
            return $"Whole number: {Math.Truncate(input)}\nFractorial part: {(input - Math.Truncate(input)).ToString("F4")}";
        }

        public string ResultAndRemainder(double input, double divisor)
        {
            return $"Result: {Math.Truncate(input / divisor)}\nRemainder: {input % divisor}";
        }

        public long MultiplyHugeInts(int n1, int n2)
        {
            return Math.BigMul(n1, n2);
        }

        public int ReverseNumber(int input)
        {
            int inverso = 0;
            while (input != 0)
            {
                inverso = inverso * 10 + input % 10;
                input /= 10;
            }
            return inverso;
        }

        public int StringToInt(string input)
        {
            string inputWithoutLetters = new string(input.TakeWhile(c => !char.IsLetter(c)).ToArray());

            return (inputWithoutLetters != string.Empty) ? int.Parse(inputWithoutLetters) : 0;
        }

        public bool IsPalindrome(int input)
        {
            int count = input.ToString().Length / 2;

            for (int i = 0; i <= count; i++)
            {
                if (input.ToString()[i] != input.ToString()[^(i + 1)]) return false;
            }
            return true;
        }

        public string NextAndPreviousIntValue(double input)
        {
            return $"Next integer value: {Math.Ceiling(input)}\nPrevious integer value: {Math.Floor(input)}";
        }

        public int LargestSumPositiveNegative(int[] input)
        {
            int positiveSum = input.Where(x => x > 0).Sum();
            int negativeSum = input.Where(x => x < 0).Sum();

            return (positiveSum > Math.Abs(negativeSum)) ? positiveSum : negativeSum;
        }

        public double PiByNPlaces(int decimalPlaces)
        {
            return Convert.ToDouble(Math.PI.ToString($"F{decimalPlaces}"));
        }

        public double Tetrahedral(double input)
        {
            return input * (input + 1) * (input + 2) / 6;
        }

        public string AscendingAndDescending(int input)
        {
            char[] chars = input.ToString().ToCharArray();
            string ascending = new string(chars.OrderBy(x => x).ToArray());
            string descending = new string(chars.OrderByDescending(x => x).ToArray());

            return $"Ascending: {ascending}\nDescending: {descending}";
        }

        public string OddishOrEvenish(int input)
        {
            string str = input.ToString();

            int result = 0;

            for (int i = 0; i < str.Length; i++)
            {
                result += int.Parse(str[i].ToString());
            }
            return result % 2 == 0 ? "Evenish" : "Oddish";
        }

        public int BinaryReverseInt(int input)
        {
            string binary = Convert.ToString(input, 2);

            double result = 0;

            for (int i = 0; i < binary.Length; i++)
            {
                result += Math.Pow(2, i) * (binary[i] == '1' ? 1 : 0);
            }

            return Convert.ToInt32(result);
        }

        public int ClosestPalindrome(int input)
        {
            if (IsPalindrome(input)) return input;

            for (int i = 0; i < input; i++)
            {
                if (IsPalindrome(input + i)) return input + i;
                if (IsPalindrome(input - i)) return input - i;
            }
            return 0;
        }

        public bool IsUban(int input)
        {
            char[] inputChars = input.ToString().ToArray();

            if (inputChars.Any(x => x == '4'))
            {
                return false;
            }
            else if (inputChars.Length >= 3 && inputChars[^3] != '0')
            {
                return false;
            }
            else if (inputChars.Length >= 4 && inputChars[^4] != '0')
            {
                return false;
            }
            else if (inputChars.Length >= 6 && inputChars[^6] != '0')
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}