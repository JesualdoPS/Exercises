namespace RecursionLibrary
{
    public class RecursionClass
    {
        public static int[] GetRecursiveNumbers(int limit)
        {
            if (limit <= 0) return Array.Empty<int>();
            int[] sequence = new int[limit];
            GetRecursiveNumbers(limit, sequence, 0);
            return sequence;
        }

        private static void GetRecursiveNumbers(int limit, int[] sequence, int actual)
        {
            sequence[actual] = actual + 1;
            if (actual < limit - 1)
            {
                GetRecursiveNumbers(limit, sequence, actual + 1);
            }
        }

        public static int[] GetDecreasingSequence(int start)
        {
            int[] sequence = new int[start];
            GetDecreasingSequence(start, sequence, 0);
            return sequence;
        }

        private static void GetDecreasingSequence(int start, int[] sequence, int index)
        {
            sequence[index] = start;
            if (index < sequence.Length - 1)
            {
                GetDecreasingSequence(start - 1, sequence, index + 1);
            }
        }

        public static int SumNaturalNumbers(int limit)
        {
            return SumNaturalNumbers(limit, 1);
        }

        private static int SumNaturalNumbers(int limit, int actual)
        {
            if (actual > limit) return 0;
            return actual + SumNaturalNumbers(limit, actual + 1);
        }

        public static string DigitsToString(int input)
        {
            return DigitsToString(input, 0);
        }

        private static string DigitsToString(int input, int index)
        {
            if (index > input.ToString().Length - 1) return "";
            char actual = input.ToString()[index];
            return new string(actual + " " + DigitsToString(input, index + 1)).TrimEnd();
        }

        public static int DigitCount(int input)
        {
            return DigitCount(input, 0);
        }

        private static int DigitCount(int input, int result)
        {
            if (input == 0) return result;

            return DigitCount(input / 10, ++result);
        }

        public static int[] EvenOrOddSequence(int limit)
        {
            int[] sequence = new int[(limit + 1) / 2];
            int start = (limit % 2 == 0) ? 2 : 1;
            EvenOrOddSequence(start, sequence, 0);
            return sequence;
        }

        private static void EvenOrOddSequence(int start, int[] sequence, int index)
        {
            sequence[index] = start + index * 2;
            if (index < sequence.Length - 1)
            {
                EvenOrOddSequence(start, sequence, index + 1);
            }
        }

        public static bool IsPrime(int input)
        {
            return IsPrime(input, 2);
        }

        private static bool IsPrime(int input, int actual)
        {
            if (actual > Math.Sqrt(input)) return true;

            if (input % actual == 0) return false;

            return IsPrime(input, actual + 1);
        }

        public static bool IsPalindrome(string input)
        {
            return IsPalindrome(input, 1);
        }

        private static bool IsPalindrome(string input, int index)
        {
            int middle = input.Length % 2 == 0 ? input.Length / 2 : (input.Length - 1) / 2;

            if (index > middle) return true;

            if (input.Substring(index - 1, 1) != input[^index].ToString()) return false;

            return IsPalindrome(input, index + 1);
        }

        public static int Factorial(int input)
        {
            return Factorial(input, 1);
        }

        private static int Factorial(int input, int result)
        {
            if (input <= 0) return result;

            result *= input;

            return Factorial(input - 1, result);
        }

        public static int[] FibonacciSequence(int values)
        {
            int[] sequence = new int[values];
            FibonacciSequence(0, 1, sequence, 0);
            return sequence;
        }

        private static void FibonacciSequence(int a, int b, int[] sequence, int index)
        {
            sequence[index] = a;
            if (index < sequence.Length - 1)
            {
                FibonacciSequence(b, a + b, sequence, index + 1);
            }
        }

        public static int[] Permutation(int[] array)
        {
            int[] sequence = new int[Factorial(array.Length)];
            int index = 0;
            Permutation(array, sequence, 0, array.Length - 1, ref index);
            return sequence;
        }

        private static void Permutation(int[] array, int[] sequence, int a, int b, ref int index)
        {
            if (a == b)
            {
                int value = 0;
                for (int i = 0; i <= b; i++)
                {
                    value = value * 10 + array[i];
                }
                sequence[index++] = value;
            }
            else
            {
                for (int i = a; i <= b; i++)
                {
                    Swap(ref array[a], ref array[i]);
                    Permutation(array, sequence, a + 1, b, ref index);
                    Swap(ref array[a], ref array[i]);
                }
            }
        }

        private static void Swap(ref int a, ref int b) => (a, b) = (b, a);

        public static string GCDandLCM(int n1, int n2)
        {
            int gcd = GCD(n1, n2);
            int lcm = n1 * n2 / gcd;
            return $"GCD: {gcd}\nLCM: {lcm}";
        }

        private static int GCD(int n1, int n2)
        {
            if (n2 == 0) return n1;
            return GCD(n2, n1 % n2);
        }

        public static string ToBinary(int input)
        {
            return ToBinary(input, "");
        }

        private static string ToBinary(int input, string result)
        {
            if (input <= 0) return result;

            result = (input % 2).ToString() + result;

            return ToBinary(input / 2, result);
        }

        public static string ReverseString(string input)
        {
            return ReverseString(input, "");
        }

        private static string ReverseString(string input, string result)
        {
            if (input.Length < 1) return result;
            result += input.Last();
            return ReverseString(input.Substring(0, input.Length - 1), result);
        }

        public static int Power(int input, int power)
        {
            return Power(input, power, 1);
        }

        private static int Power(int input, int power, int result)
        {
            if (power == 0) return result;

            result *= input;

            return Power(input, power - 1, result);
        }
    }
}
