

using System.Linq;
using System.Text;
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
    }
}
