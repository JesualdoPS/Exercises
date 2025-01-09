

using System.Linq;
using System.Reflection;
using System.Security;
using System.Text;
using System.Xml.XPath;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ForLoopLibrary
{
    public class ForLoopClass
    {
        public int[] IntCounter(int input)
        {
            int[] result = new int[input];

            for (int i = 0; i < input; i++)
            {
                result[i] = i + 1;
            }
            return result;
        }

        public int ArraySum(int input)
        {
            int result = 0;

            for (int i = 1; i <= input; i++)
            {
                result += i;
            }
            return result;
        }

        public string AverageAndSum(int start, int step, int length)
        {
            int sum = 0;
            for (int i = 0; i < length; i++)
            {
                int value = start + i * step;
                sum += value;
            }
            double average = (double)sum / length;

            return $"The sum is {sum} and the average is {average}";
        }

        public double[] CubeOfNaturalNumbers(int input)
        {
            var result = new double[input];

            for (int i = 1; i <= input; i++)
            {
                result[i - 1] = Math.Pow(i, 3);
            }

            return result;
        }

        public int[] ArrayMultiplicatorSequence(int input, int limit)
        {
            var result = new int[limit];

            for (int i = 1; i <= limit; i++)
            {
                result[i - 1] = i * input;
            }
            return result;
        }

        public string[][] MultiplicationTables(int input)
        {
            string[][] table = new string[input][];

            for (int i = 1; i <= input; i++)
            {
                table[i - 1] = new string[10];

                for (int j = 1; j <= 10; j++)
                {
                    table[i - 1][j - 1] = $"{i} x {j} = {i * j}";
                }
            }

            return table;
        }

        public string OddNumbersAndSum(int input)
        {
            var result = new int[input];
            int num = 1;
            for (int j = 0; j < input; j++)
            {
                while (num % 2 == 0)
                {
                    num++;
                }
                result[j] = num;
                num++;
            }
            return $"The odd list is [{string.Join(",", result)}] and their sum is {result.Sum()}";
        }

        public string AsteriscTriangle(int input)
        {
            var result = new string[input];

            for (int i = 1; i <= input; i++)
            {
                result[i - 1] = string.Concat(Enumerable.Repeat("*", i));
            }
            return string.Join("\n", result);
        }

        public string TriangleWithSequence(int input)
        {
            string result = "";

            for (int i = 1; i <= input; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    result += j.ToString();
                }
                result += "\n";
            }
            return result.Trim();
        }

        public string TriangleWithRepetitions(int input)
        {
            string result = "";
            for (int i = 1; i <= input; i++)
            {
                result += string.Concat(Enumerable.Repeat(i.ToString(), i));
                result += "\n";
            }
            return result.Trim();
        }

        public string TriangleWithIncreasingNumber(int input)
        {
            StringBuilder result = new StringBuilder();

            int num = 1;
            for (int i = 1; i <= input; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    result.Append(num).Append(" ");
                    num++;
                }
                result.Length--;
                result.Append("\n");
            }
            return result.ToString().Trim();
        }

        public string PiramidOfNumbers(int input)
        {
            string result = "";
            int spaces = input - 1;
            int num = 1;

            for (int i = 1; i <= input; i++)
            {
                result += string.Concat(Enumerable.Repeat(" ", spaces));

                for (int j = 0; j < i; j++)
                {
                    result += num + " ";
                    num++;
                }

                result += string.Concat(Enumerable.Repeat(" ", spaces));
                result = result.Substring(0, result.Length - 1);
                spaces--;
                result += "\n";
            }
            result = result.Substring(0, result.Length - 1);

            return result;
        }

        public string PiramidOfAsteriscs(int rows)
        {
            string result = "";
            int spaces = rows - 1;

            for (int i = 1; i <= rows; i++)
            {
                result += string.Concat(Enumerable.Repeat(" ", spaces));
                for (int j = 0; j < i; j++)
                {
                    result += "* ";
                }
                result += string.Concat(Enumerable.Repeat(" ", spaces));
                result = result.Substring(0, result.Length - 1);
                spaces--;
                result += "\n";
            }
            result = result.Substring(0, result.Length - 1);

            return result;
        }

        public int FactorialNumber(int input)
        {
            int result = 1;

            for (int i = 1; i <= input; i++)
            {
                result *= i;
            }

            return result;
        }

        public string EvenNaturalNumbersAndSum(int input)
        {
            var result = new int[input];
            int num = 2;

            for (int i = 0; i < input; i++)
            {
                result[i] = num;
                num += 2;
            }
            return $"The first {input} natural numbers are [{string.Join(",", result)}] and their sum is {result.Sum()}";
        }

        public string PiramidOfRepetitiveNumbers(int rows)
        {
            string result = "";
            int spaces = rows - 1;
            int num = 1;

            for (int i = 1; i <= rows; i++)
            {
                result += string.Concat(Enumerable.Repeat(" ", spaces));

                for (int j = 0; j < i; j++)
                {
                    result += num + " ";
                }
                num++;
                result += string.Concat(Enumerable.Repeat(" ", spaces));
                result = result.Substring(0, result.Length - 1);
                spaces--;
                result += "\n";
            }
            result = result.Substring(0, result.Length - 1);

            return result;
        }

        public double CalculateHarmonicSeries(double input)
        {
            double result = 0;

            for (double i = 1; i <= input; i++)
            {
                result += 1 / i;
            }

            return Math.Round(result, 3);
        }

        public string PiramidOfOddAsteriscs(int rows)
        {
            string result = "";
            int spaces = rows;
            int asteriscs = 1;

            for (int i = 1; i <= rows; i++)
            {
                result += string.Concat(Enumerable.Repeat(" ", spaces));
                for (int j = 1; j <= asteriscs; j++)
                {
                    result += "*";
                }
                asteriscs += 2;
                result += string.Concat(Enumerable.Repeat(" ", spaces));
                spaces--;
                result += "\n";
            }
            result = result.Substring(0, result.Length - 1);

            return result;
        }

        public double SumOfRepetitions(double input, double repetitions)
        {
            double result = 0;
            double addingNumber = input;
            for (double i = 1; i <= repetitions; i++)
            {
                result += addingNumber;
                addingNumber += input * Math.Pow(10, i);
            }
            return result;
        }

        public string FloydsTriangle(int rows)
        {
            string result = "";
            string binary = 1.ToString();

            for (int i = 1; i <= rows; i++)
            {
                result += binary;
                binary = (binary.First() == '0') ? '1' + binary : '0' + binary;
                result += "\n";
            }

            return result.Trim();
        }

        public double FactorialDenominator(double input, double terms)
        {
            double result = 1;

            for (int i = 1; i < terms; i++)
            {
                result += (Math.Pow(input, i) / FactorialNumber(i));
            }
            return Math.Round(result, 3);
        }

        public double IrregularSeriesSum(double input, double terms)
        {
            double result = input;
            double sign = -1;
            double expoent = 3;

            for (int i = 1; i <= terms - 1; i++)
            {
                result += sign * Math.Pow(input, expoent);
                sign *= -1;
                expoent += 2;
            }

            return Math.Round(result, 3);
        }

        public string NaturalSquareSum(int input)
        {
            var result = new double[input];

            for (int i = 1; i <= input; i++)
            {
                result[i - 1] = Math.Pow(i, 2);
            }
            return $"The first {input} natural squares are [{string.Join(",", result)}] and their sum is {result.Sum()}";
        }

        public double CalculateNOnes(int input)
        {
            double result = 1;
            double adding = 1;

            for (int i = 1; i < input; i++)
            {
                adding += Math.Pow(10, i);
                result += adding;
            }

            return result;
        }

        public bool IsPerfect(double input)
        {
            var results = new List<double>();

            for (int i = 0; i < input; i++)
            {
                if (input % i == 0) results.Add(i);
            }

            return results.Sum() == input;
        }

        public List<int> PerfectNumbersList(int start, int end)
        {
            var results = new List<int>();

            for (int i = start; i <= end; i++)
            {
                if (IsPerfect(i)) results.Add(i);
            }

            return results;
        }

        public bool IsArmstrong(double input)
        {
            string strInput = input.ToString();
            double sum = 0;
            int length = strInput.Length;

            if (length == 1 && input != 1) return false;

            for (int i = 0; i < length; i++)
            {
                int digit = int.Parse(strInput[i].ToString());
                sum += Math.Pow(digit, length);
            }
            return sum == input;
        }

        public List<int> ArmstrongList(int start, int end)
        {
            var results = new List<int>();

            for (int i = start; i <= end; i++)
            {
                if (IsArmstrong(Convert.ToDouble(i))) results.Add(i);
            }

            return results;
        }

        public string AsteriscDiamond(int midRow)
        {
            string result = "";
            int spaces = (midRow - 1) / 2;
            int asteriscs = 1;

            for (int i = 1; asteriscs <= midRow; i++)
            {
                result += new string(' ', spaces);
                result += new string('*', asteriscs);
                result += new string(' ', spaces);
                result += "\n";
                asteriscs += 2;
                spaces--;
            }
            spaces = 1;
            asteriscs -= 4;
            for (int i = 1; asteriscs >= 1; i++)
            {
                result += new string(' ', spaces);
                result += new string('*', asteriscs);
                result += new string(' ', spaces);
                result += "\n";
                asteriscs -= 2;
                spaces++;
            }

            return result.Substring(0, result.Length - 1);
        }

        public bool IsPrime(int input)
        {
            if (input <= 1) return false;

            int limit = (int)Math.Sqrt(input);

            for (int i = 2; i <= limit; i++)
            {
                if (input % i == 0) return false;
            }

            return true;
        }

        public string PascalsTriangle(int rows)
        {
            int spaces = rows - 1;
            string result = "";

            for (int i = 0; i < rows; i++)
            {
                result += new string(' ', spaces);
                spaces--;

                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || i == 0 || j == i)
                        result += "1 ";
                    else
                        result += $"{FactorialNumber(i) / (FactorialNumber(j) * FactorialNumber(i - j))} ";
                }
                result.TrimEnd();
                result += "\n";
            }

            return result.Substring(0, result.Length - 1);
        }

        public List<int> PrimeList(int start, int end)
        {
            var result = new List<int>();

            for (int i = start; i <= end; i++)
            {
                if (IsPrime(i)) result.Add(i);
            }

            return result;
        }

        public int[] FibonacciSeries(int values)
        {
            var result = new int[values];

            result[0] = 0;

            int resultTemp = 1;

            for (int i = 1; i <= values - 1; i++)
            {
                result[i] = resultTemp;

                resultTemp = result[i] + result[i - 1];
            }
            return result;
        }

        public string PiramidOfAccordionEffect(int rows)
        {
            string result = "";
            int spaces = rows - 1;
            int num = 1;

            for (int i = 1; i <= rows; i++)
            {
                result += new string(' ', spaces);
                result += string.Join(" ", Enumerable.Range(1, i).Concat(Enumerable.Range(1, i - 1).Reverse())).ToString();
                result += "\n";
                spaces--;
            }

            return result.Substring(0, result.Length - 1);
        }

        public int ReverseNumber(int input)
        {
            string inputString = input.ToString();
            string result = "";

            for (int i = 1; i <= inputString.Length; i++)
            {
                result += inputString[^i];
            }

            return int.Parse(result);
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

        public int SumOfDivisors(int divisor, int start, int end)
        {
            int sum = 0;

            for (int i = start; i <= end; i++)
            {
                if (i % divisor == 0) sum += i;
            }
            return sum;
        }

        public string PiramidOfAccordionEffectLetters(int rows)
        {
            var result = new StringBuilder();
            int spaces = rows - 1;

            for (int i = 1; i <= rows; i++)
            {
                result.Append(' ', spaces);
                var line = Enumerable.Range('A', i).Concat(Enumerable.Range('A', i - 1).Reverse());
                result.Append(string.Join(" ", line.Select(c => (char)c)));
                result.Append("\n");
                spaces--;
            }
            return result.ToString().TrimEnd('\n');
        }

        public int BinaryOfValue(int input)
        {
            string binary = "";
            int original = input;

            for (; input > 0; input /= 2)
            {
                binary = input % 2 + binary;
            }

            return Convert.ToInt32(binary);
        }

        public int DecimalOfABinary(int binary)
        {
            int decimalValue = 0;
            string strBinary = binary.ToString();
            int power = strBinary.Length - 1;

            for (int i = 0; i < strBinary.Length; i++)
            {
                if (strBinary[i] == '1')
                {
                    decimalValue += (int)Math.Pow(2, power);
                }
                power--;
            }
            return decimalValue;
        }

        public double HighestCommonFactor(double n1, double n2)
        {
            double result = 0;

            for (int i = 1; i < n1; i++)
            {
                double divisor1 = n1 / i;
                double divisor2 = n2 / i;
                if (divisor1 % 1 == 0 && divisor2 % 1 == 0) result = i;
            }
            return result;
        }

        public double LowestCommonFactor(double n1, double n2)
        {
            double hcf = HighestCommonFactor(n1, n2);
            return n1 * n2 / hcf;
        }

        public bool IsStrong(int input)
        {
            int sum = 0;
            string strInput = input.ToString();

            for (int i = 0; i < strInput.Length; i++)
            {
                int num = int.Parse(strInput[i].ToString());
                sum += FactorialNumber(num);
            }
            return sum == input;
        }

        public List<int> StrongList(int start, int end)
        {
            var result = new List<int>();

            for (int i = start; i <= end; i++)
            {
                if (IsStrong(i)) result.Add(i);
            }
            return result;
        }

        public int ArithmeticProgressSum(int start, int length, int step)
        {
            int sum = 0;

            for (int i = start; length > 0; i += step)
            {
                sum += i;
                length--;
            }
            return sum;
        }

        public int OctalNumber(int input)
        {
            string result = "";
            int module = input;

            for (; module > 0; module /= 8)
            {
                result = (module % 8).ToString() + result;
            }
            return Convert.ToInt32(result);
        }

        public int DecimalOfOctal(int octal)
        {
            int result = 0;
            string strOctal = octal.ToString();
            int power = strOctal.Length - 1;

            for (int i = 0; i < strOctal.Length; i++)
            {
                int digit = int.Parse(strOctal[i].ToString());
                result += Convert.ToInt32(digit * (Math.Pow(8, power)));
                power--;
            }

            return result;
        }

        public double SumOfGeometricSeries(double first, int length, int ratio)
        {
            double result = 0;
            double term = first;

            for (int i = 0; i <= length; i++)
            {
                result += term;
                term *= ratio;
            }
            return result;
        }

        public int OctalOfBinary(int binary)
        {
            string strBinary = binary.ToString();
            string result = "";
            int maxGroupLength = 3;

            for (int i = strBinary.Length - 1; i >= 0; i -= maxGroupLength)
            {
                int groupLength = Math.Min(maxGroupLength, i + 1);
                string group = strBinary.Substring(i - groupLength + 1, groupLength);
                group = group.PadLeft(maxGroupLength, '0');
                result = OctalNumber(Convert.ToInt32(group, 2)).ToString() + result;
            }

            return Convert.ToInt32(result);
        }

        public int BinaryOfOctal(int octal)
        {
            int decimalValue = 0;
            string strOctal = octal.ToString();
            int power = strOctal.Length - 1;

            for (int i = 0; i < strOctal.Length; i++)
            {
                int digit = int.Parse(strOctal[i].ToString());
                decimalValue += Convert.ToInt32(digit * (Math.Pow(8, power)));
                power--;
            }

            string binary = "";
            int original = decimalValue;

            for (; decimalValue > 0; decimalValue /= 2)
            {
                binary = decimalValue % 2 + binary;
            }

            return Convert.ToInt32(binary);
        }

        public string HexadecimalOfDecimal(int input)
        {
            string hexadecimal = "";
            string hexDigits = "0123456789ABCDEF";

            for (; input > 0; input /= 16)
            {
                hexadecimal = hexDigits[input % 16] + hexadecimal;
            }
            return hexadecimal;
        }

        public string StringReverse(string input)
        {
            string result = "";
            int count = input.Length;

            for (int i = 1; i <= input.Length; i++)
            {
                result += input[^i];
            }
            return result;
        }

        public string AOfAsteriscs()
        {
            string result = "";
            result += " ***\n\n";

            for (int i = 1; i <= 2; i++)
            {
                result += "*   *\n\n";
            }

            result += "*****\n\n";

            for (int j = 1; j <= 4; j++)
            {
                result += "*   *\n\n";
            }
            return result.TrimEnd();
        }
    }
}
