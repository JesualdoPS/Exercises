using System.Diagnostics.Tracing;
using System.Text.RegularExpressions;

namespace BasicAlgorithm.BasicAlgorithmClass
{
    public class AlgorithmClass
    {
        public int SumOfNumbersInArray(int[] input)
        {
            int result = (input[0] == input[1]) ? input.Sum() * 3 : input.Take(2).Sum();
            return result;
        }

        public int AbsoluteDiferenceOrTriple(int input)
        {
            return (input > 51) ? Math.Abs(input - 51) * 3 : Math.Abs(input - 51);
        }

        public bool Is30OrSum30(int[] input)
        {
            return input.Contains(30) || input[0] + input[1] == 30;
        }

        public bool IsWithin10Of100Or200(int input)
        {
            return (input >= 90 && input <= 110) || (input >= 190 && input <= 210);
        }

        public string AddIf(string input)
        {
            return (input.StartsWith("if") ? input : $"if {input}");
        }

        public string RemoveAtPosition(string input, int position)
        {
            string result = input.Remove(position, 1);

            return result;
        }

        public string ExchangeFirstAndLast(string input)
        {
            if (input.Length <= 1) { return input; }

            char[] charList = input.ToCharArray();
            char temp = charList[0];
            charList[0] = charList[^1];
            charList[^1] = temp;
            var result = new string(charList);

            return result;
        }

        public string FourCoppiesOfFirstCharacter(string input)
        {
            if (input.Length < 2) { return input; }

            string firstCharacter = input.Substring(0, 2);
            var result = string.Concat(Enumerable.Repeat(firstCharacter, 4));

            return result.Trim();
        }

        public string LastCharAtFrontAndBack(string input)
        {
            char firstChar = input[^1];

            var result = string.Concat(firstChar, input, firstChar);
            return result;
        }

        public bool IsMultipleOf3Or7(int input)
        {
            var result = input % 3 == 0 || input % 7 == 0 ? true : false;

            return result;
        }

        public string AddFirstThreeCharAtFrontAndBack(string input)
        {
            if (input.Length <= 2) { return string.Concat(Enumerable.Repeat(input, 3)); };

            string firstThree = input.Substring(0, 3);
            return string.Concat(firstThree, input, firstThree);

        }

        public bool StartsWithCSharp(string input)
        {
            return input.StartsWith("C#");
        }

        public bool CheckTemperatureLessThan0AndMoreThan100(int[] input)
        {
            return (input[0] > 100 || input[1] > 100) && (input[0] < 0 ^ input[1] < 0);
        }

        public bool IsBetween100And200(int[] input)
        {
            return input.Any(i => i >= 100 && i <= 200);
        }

        public bool IsInRange20To50(int[] input)
        {
            return input.Any(i => i >= 20 && i <= 50);
        }

        public string RemoveYTAtIndex1(string input)
        {
            return input.Substring(1, 2).Equals("yt") ? input.Remove(1, 2) : input;
        }

        public int LargestInt(int[] input)
        {
            return input.Max();
        }

        public int IsClosestTo100(int[] input)
        {
            if (input[0] == input[1]) { return 0; }
            return 100 - input[0] < 100 - input[1] ? input[0] : input[1];
        }

        public bool IsBetween40_50Or50_60(int[] input)
        {
            var intervalo1 = input.All(i => i >= 40 && i <= 50);
            var intervalo2 = input.All(i => i >= 50 && i <= 60);
            return intervalo1 || intervalo2;
        }

        public int IsLargestBetween20_30(int[] input)
        {
            return input.Any(i => i < 20 || i > 30) ? 0 : input.Max();
        }

        public bool HasBetween2Or4Zs(string input)
        {
            int count = 0;
            char[] chars = input.ToCharArray();

            foreach (char item in chars)
            {
                if (item == 'Z' || item == 'z') { count++; }
            }

            return count >= 2 && count <= 4 ? true : false;
        }

        public bool HasSameLastDigit(int[] input)
        {
            return input[0].ToString().Last() == input[1].ToString().Last();
        }

        public string UpperCaseLastThree(string input)
        {
            if (input.Length <= 3) { return input.ToUpper(); }

            return Regex.Replace(input, ".{3}$", match => match.Value.ToUpper());
        }

        public string CopyStringByNTimes(string input, int repeat)
        {
            if (repeat == 1) { return input; }

            return string.Concat(Enumerable.Repeat(input, repeat));
        }

        public string CopyOfThreeCharacters(string text, int repeats)
        {
            if (text.Length < 3) { return string.Concat(Enumerable.Repeat(text, repeats)); }
            string brokenString = text.Substring(0, 3);

            string result = string.Concat(Enumerable.Repeat(brokenString, repeats));
            return result;
        }

        public int StringPartCounter(string input)
        {
            int count = 0;

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input.Substring(i, 2) == "aa") { count++; }
            }

            return count;
        }

        public bool HasAnAAfterFirstA(string input)
        {
            int index = input.IndexOf('a');

            return (input[index + 1] == 'a') ? true : false;
        }

        public string EveryOtherCharacter(string input)
        {
            string result = "";

            for (int i = 0; i < input.Length; i += 2)
            {
                result += input[i];
            }

            return result;
        }

        public string CumulativeSubstring(string input)
        {
            if (input.Length <= 1) { return input; }

            string result = string.Concat(Enumerable.Range(1, input.Length).Select(i => input.Substring(0, i)));

            return result;
        }

        public int RepeatOfTwoFirstCharacters(string input)
        {
            if (input[1] != input[^1]) { return 0; }

            string subString = input.Substring(0, 2);

            int count = -1;

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input.Substring(i, 2).Equals(subString)) { count++; }
            }

            return count;
        }

        public bool HasTheElement(int[] array, int input)
        {
            return array.Contains(input);
        }

        public bool IsInTheFirstFour(int[] array, int check)
        {
            for (int i = 0; i < 4; i++)
            {
                if (array[i] == check) { return true; }
            }
            return false;
        }

        public bool HasSequence123(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == 1 && array[i + 1] == 2 && array[i + 2] == 3) { return true; }
            }
            return false;
        }

        public int SubstringMatchingCount(string[] array)
        {
            return Enumerable.Range(0, array[0].Length - 1)
                             .Count(i => array[1].Contains(array[0].Substring(i, 2)));
        }

        public string RemoveCharExceptFirstAndLast(string input, char remove)
        {
            return input.First()
                + input.Substring(1, input.Length - 2)
                .Replace(remove.ToString(), "")
                + input.Last();
        }

        public string StringCreatorByIndex(string input, int[] index)
        {
            return new string(index.Where(idx => idx < input.Length).Select(idx => input[idx]).ToArray());
        }

        public int Count5NextToEachOther(int[] input)
        {
            return Enumerable.Range(0, input.Length - 1)
                .Count(i => input[i] == 5 && (input[i + 1] == 5 || input[i + 1] == 6));
        }

        public bool HasTripleValue(int[] input)
        {
            return Enumerable.Range(0, input.Length - 1)
                .Any(i => input[i] == input[i + 1] && input[i] == input[i + 2]);
        }

        public int SumOrReturn30(int[] array)
        {
            return array.Sum() >= 10 && array.Sum() <= 20 ? 30 : array.Sum();
        }

        public bool HasA5Value(int[] input)
        {
            return input.Contains(5)
                || input.Sum() == 5
                || Math.Abs(input[0] - input[1]) == 5;
        }

        public bool IsMultipleOf17Or1More(int input)
        {
            return input % 17 == 0 || (input - 1) % 17 == 0;
        }

        public bool IsNotMultipleOf3And7(int input)
        {
            return input % 3 == 0 ^ input % 7 == 0;
        }

        public bool IsWithin2OfMultipleOf10(int input)
        {
            return input % 10 <= 2 || input % 10 >= 8;
        }

        public int SumOrReturn18(int[] input)
        {
            return input.Any(x => x >= 10 && x <= 20) ? 18 : input.Sum();
        }

        public bool IsThirdSumOfOtherTwo(int[] array)
        {
            return array[0] + array[1] == array[2]
                || array[1] + array[2] == array[0]
                || array[0] + array[2] == array[1];
        }

        public bool IsAscendingOrder(int[] array)
        {
            return array[2] > array[1] && array[1] > array[0];
        }

        public bool HasTheSameDigit(int[] input)
        {
            return input.Any(x => input.Any(y => x != y && x.ToString().Intersect(y.ToString()).Any()));
        }
    }
}
