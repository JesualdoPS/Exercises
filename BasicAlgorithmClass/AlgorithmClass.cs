using System.Diagnostics.Tracing;
using System.Text.RegularExpressions;
using System.Xml;

namespace BasicAlgorithm.BasicAlgorithmClass
{
    public class AlgorithmClass
    {
        public int SumOfNumbersInArrayOrTrupleIfEqual(int[] input)
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
            return input.StartsWith("if") ? input : $"if {input}";
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

        public bool Is20Higher(int[] array)
        {
            return array.Max() - array.Min() >= 20;
        }

        public int LargestIntOrSameRemainderOrZero(int[] input)
        {
            if (input[0].Equals(input[1])) return 0;
            return (input[0] % 7).Equals(input[1] % 7) ? input.Min() : input.Max();
        }

        public int HasSameLengthOnSum(int[] input)
        {
            int result = input.Sum();

            return result.ToString().Length == input[0].ToString().Length
                ? result
                : input[0];
        }

        public int SumOrReturnThird(int[] input)
        {
            return input[0].Equals(input[1]) ? input[2] : input.Sum();
        }

        public int SumIgnoring13(int[] input)
        {
            int result = 0;
            foreach (var item in input)
            {
                if (item == 13) break;
                result += item;
            }
            return result;
        }

        public int SumIgnoringBetween10And13(int[] input)
        {
            return input.Where(x => x < 10 || x > 20 || x == 13 || x == 17).Sum();
        }

        public int IsNear17AndLesser(int[] input)
        {
            return input.All(x => x > 17) ? 0 : input.MinBy(x => Math.Abs(17 - x));
        }

        public bool HasSameDiference(int[] input)
        {
            return (input[2] - input[1]).Equals(input[1] - input[0]);
        }

        public string FormatS1S2S2S1(string[] array)
        {
            var s1 = array[0];
            var s2 = array[1];

            return string.Concat(s1, s2, s2, s1);
        }

        public string InsertString(string[] input)
        {
            int middle = input[0].Length / 2;

            return $"{input[0].Substring(0, middle)}{input[1]}{input[0].Substring(middle)}";
        }

        public string CopyOfThreeLastCharacters(string input)
        {
            return (input.Length <= 3)
                ? string.Concat(Enumerable.Repeat(input, 3))
                : string.Concat(Enumerable.Repeat(input.Substring(input.Length - 2, 2), 3));
        }

        public string FirstTwoChars(string input)
        {
            return (input.Length <= 2) ? input : input.Substring(0, 2);
        }

        public string FirstHalfOfEvenLengthString(string input)
        {
            return input.Substring(0, Math.Abs(input.Length / 2));
        }

        public string RemoveFirstAndLastCharacter(string input)
        {
            return (input.Length <= 2) ? " " : input.Substring(1, input.Length - 2);
        }

        public string LongShortLongString(string[] input)
        {
            string longer = input.MaxBy(x => x.Length);
            string shorter = input.MinBy(x => x.Length);

            return $"{longer}{shorter}{longer}";
        }

        public string CombineStringsWithoutFirstChar(string[] input)
        {
            string newString1 = input[0].Substring(1);
            string newString2 = input[1].Substring(1);
            return $"{newString1}{newString2}";
        }

        public string MoveFirstTwoCharsToEnd(string input)
        {
            if (input.Length <= 2) return new string(input.Reverse().ToArray());

            return input.Substring(2) + input.Substring(0, 2);
        }

        public string MoveLastTwoCharsToStart(string input)
        {
            if (input.Length <= 2) return input;

            return input.Substring(input.Length - 2, 2) + input.Substring(0, input.Length - 2);
        }

        public string TwoMiddleChars(string input)
        {
            if (input.Length <= 2) return input;

            int middle = input.Length % 2 == 0 ? input.Length / 2 : (input.Length - 1) / 2;

            return input.Substring(middle - 1, 2);
        }

        public bool EndsWithOn(string input)
        {
            return input.Length < 2 ? false : input.Substring(input.Length - 2) == "on";
        }

        public string FirstAndLastNChars(string input, int n)
        {
            if (input.Length < 2) return $"{input}{input}";

            return string.Concat(input.Substring(0, n) + input.Substring(input.Length - n));
        }

        public string ReturnStringWithStartingIndex(string input, int index)
        {
            if (input.Length <= 2) return input;

            return input.Substring(index, 2);
        }

        public string ThreeCharsFromMiddleString(string input)
        {
            if (input.Length <= 3) return input;

            int startingIndex = Math.Abs(input.Length / 2);

            return input.Substring(startingIndex - 1, 3);
        }

        public string FirstTwoCharsOrMissing(string input)
        {
            if (input.Length >= 2) return input.Substring(0, 2);

            return input.Length == 0 ? "##" : input + "#";
        }

        public string FirstAndLastCharOfTwoStrings(string[] strings)
        {
            return string.Concat(strings[0].Length == 0 ? "#" : strings[0].Substring(0, 1),
                strings[1].Length == 0 ? "#" : strings[1].Substring(strings[1].Length - 1, 1));
        }

        public string ConcatStringRemovingLastDuplicate(string str1, string str2)
        {
            return (str1.Last() == str2.First())
                ? string.Concat(str1.Substring(0), str2.Substring(1))
                : str1 + str2;
        }

        public string SwapLastTwoChars(string input)
        {
            if (input.Length < 2) return input;

            char[] chars = input.ToCharArray();
            (chars[^2], chars[^1]) = (chars[^1], chars[^2]);

            return new string(chars);
        }

        public string BeginsWith(string input)
        {
            string lower = input.ToLower();
            if (!lower.StartsWith("abc") && !lower.StartsWith("xyz")) return string.Empty;

            return lower.StartsWith("abc") ? "abc" : "xyz";
        }

        public bool IsBeginEqualsLast(string input)
        {
            return input.Substring(0, 2) == input.Substring(input.Length - 2);
        }

        public string EqualizeAndCombine(string str1, string str2)
        {
            int minLength = Math.Min(str1.Length, str2.Length);
            return str1.Substring(0, minLength) + str2.Substring(str2.Length - minLength);
        }

        public string RemoveFirstTwo(string input)
        {
            if (input.Substring(0, 2) != input.Substring(input.Length - 2)) return input;

            return input.Substring(2);
        }

        public string RemoveFirstTwoIfItsNotPOrY(string input)
        {
            if (input[1] != 'y') input = input.Remove(1, 1);
            if (char.ToLower(input[0]) != 'p') input = input.Remove(0, 1);

            return input;
        }

        public string ARemover(string input)
        {
            if (!input.StartsWith("a") && !input.EndsWith("a")) return input;

            if (char.ToLower(input[0]) == 'a') input = input.Remove(0, 1);

            if (input[^1] == 'a') input = input.Remove(input.Length - 1, 1);

            return input;
        }

        public string RemoveAFromFirstTwo(string input)
        {
            if (input.ToLower().StartsWith("aa")) return input.Substring(2);

            if (input[1] == 'a') input = input.Remove(1, 1);
            if (char.ToLower(input[0]) == 'a') input = input.Remove(0, 1);

            return input;
        }

        public bool Has10OnStartOrEnd(int[] input)
        {
            return input[0] == 10 || input[^1] == 10;
        }

        public bool Is10FirstOrLast(int[] input)
        {
            return input[0] == input[^1];
        }

        public bool IsFirstOrLastEqual(int[] input, int[] input2)
        {
            return input[0] == input2[0] || input[^1] == input2[^1];
        }

        public int SumOfNumbersInArray(int[] input)
        {
            return input.Sum();
        }

        public int[] RotateLeft(int[] input)
        {
            return input.Skip(1).Concat(new[] { input[0] }).ToArray();
        }

        public int[] ReverseArray(int[] input)
        {
            return input.Reverse().ToArray();
        }

        public int[] ReplaceAllForMax(int[] input)
        {
            int maxValue = input.Max();

            return Enumerable.Repeat(maxValue, input.Length).ToArray();
        }

        public int[] MiddleElements(int[] input, int[] input2)
        {
            return new int[] { input[2], input2[2] };
        }

        public int[] FirstAndLastElement(int[] input)
        {
            return new int[] { input[0], input[^1] };
        }

        public bool Has15Or20(int[] input)
        {
            return input.Contains(15) || input.Contains(20);
        }

        public int[] FirstIntAndZeroToDoubleSizedArray(int[] input)
        {
            int[] result = new int[input.Length * 2];
            result[0] = input[0];

            return result;
        }

        public bool AreEqual10Or20(int[] input)
        {
            return input.All(x => x == 10) || input.All(x => x == 20);
        }

        public int[] If7After5Set1(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 7 && input[i - 1] == 5) input[i] = 1;
            }

            return input;
        }

        public int[] IsLarger(int[] input, int[] input2)
        {
            return input.Sum() > input2.Sum() ? input : input2;
        }

        public int[] TwoMiddleElements(int[] input)
        {
            return input.Skip((input.Length / 2) - 1).Take(2).ToArray();
        }

        public int[] MergeArrays(int[] input, int[] input2)
        {
            return input.Concat(input2).ToArray();
        }

        public int[] FirstAndLastSwap(int[] input)
        {
            (input[0], input[^1]) = (input[^1], input[0]);
            return input;
        }

        public int[] ThreeMiddleElements(int[] input)
        {
            return input.Skip((input.Length / 2) - 1).Take(3).ToArray();
        }

        public int LargestElementFromFirstMiddleAndLast(int[] input)
        {
            if (input.Length == 1) return input[0];

            int middleIndex = input.Length % 2 == 0 ? input.Length / 2 - 1 : input.Length / 2;

            return new[] { input[0], input[^1], input[middleIndex] }.Max();
        }

        public int[] FirstTwoElements(int[] input)
        {
            return new int[] { input[0], input[1] };
        }

        public int HowManyEvenElements(int[] input)
        {
            return input.Where(x => x % 2 == 0).Count();
        }

        public int DiferenceBetweenLargestAndSmallest(int[] input)
        {
            return input.Max() - input.Min();
        }

        public int SumArrayExcluding17(int[] input)
        {
            return input.Where(x => x != 17).Sum();
        }

        /// <summary>
        /// #############################################################################
        /// </summary>

        public int SumExcluding5FollowedBy6(int[] input)
        {
            return input.Select((x, i) => new { Value = x, Index = i })
                .Where(t => !(t.Value == 5 && t.Index < input.Length - 1 && input[t.Index + 1] == 6))
                .Where(t => t.Value != 6 || input.Take(t.Index).Any(x => x == 5) == false)
                .Select(t => t.Value)
                .ToArray()
                .Sum();
        }

        /// <summary>
        /// #############################################################################
        /// </summary>

        public bool Is5FollowedBy5(int[] input)
        {
            return input.Zip(input.Skip(1), (a, b) => a == 5 && b == 5).Any(x => x);
        }

        public bool Has5Or7(int[] ints)
        {
            return ints.Any(x => x == 5 || x == 7);
        }

        public bool IsSumEqual15(int[] ints)
        {
            return ints.Count(x => x == 5) == 3;
        }

        public bool HasMore3Than5(int[] ints)
        {
            return ints.Count(x => x == 3) > ints.Count(x => x == 5);
        }

        public bool IsOnly3Or5(int[] ints)
        {
            return ints.All(x => x == 3 || x == 5);
        }

        public bool Has3Or5NotBoth(int[] ints)
        {
            return ints.Any(x => x == 3) ^ ints.Any(x => x == 5);
        }

        public bool HasDouble3Or5(int[] ints)
        {
            return ints.Zip(ints.Skip(1), (a, b) => a == 3 && b == 3).Any(x => x)
                || ints.Zip(ints.Skip(1), (a, b) => a == 5 && b == 5).Any(x => x);
        }

        public bool Has3BBefore5(int[] ints)
        {
            return ints.Zip(ints.Skip(1), (a, b) => a == 3 && b == 5).Any(x => x);
        }

        public bool HasDoubleEvenOrDoubleOdd(int[] ints)
        {
            return ints.Zip(ints.Skip(1), (a, b) =>
                (a % 2 == 0 && b % 2 == 0) ||
                (a % 2 != 0 && b % 2 != 0))
                .Any(x => x);
        }

        public bool Has5FivesNoneNextToEachOther(int[] ints)
        {
            return ints.Count(x => x == 5) == 5
                && ints.Zip(ints.Skip(1), (a, b) => a == 5 && b != 5).Any(x => x);
        }

        /// <summary>
        /// #############################################################################
        /// </summary>

        public bool Is5NextToAnother(int[] ints)
        {
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] == 5)
                {
                    if (i == 0 && ints[i + 1] != 5 ||
                        i == ints.Length - 1 && ints[i - 1] != 5 ||
                        (i > 0 && i < ints.Length - 1 && ints[i - 1] != 5 && ints[i + 1] != 5))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// #############################################################################
        /// </summary>

        public bool StartAndEndEqualByNumber(int[] ints, int count)
        {
            int[] start = ints.Take(count).ToArray();
            int[] end = ints.TakeLast(count).ToArray();
            return start.SequenceEqual(end);
        }

        public bool HasThreeIncreasingAdjacent(int[] ints)
        {
            return ints.Where((x, i) => i < ints.Length - 2 && x + 1 == ints[i + 1] && x + 2 == ints[i + 2]).Any();
        }

        public int[] ElementsBefore5(int[] ints)
        {
            if (!ints.Contains(5)) return ints;

            return ints.TakeWhile(x => x != 5).ToArray();
        }

        public int[] ElementsAfter5(int[] ints)
        {
            if (!ints.Contains(5)) return ints;

            int index = Array.IndexOf(ints, 5);

            return ints.Skip(index + 1).ToArray();
        }

        public int[] ZerosToLeft(int[] ints)
        {
            if (!ints.Contains(0)) return ints;

            return ints.Where(x => x == 0).Concat(ints.Where(x => x != 0)).ToArray();
        }

        public int[] Swap5ToZerosAndShiftToRight(int[] ints)
        {
            if (!ints.Contains(5)) return ints;

            ints = ints.Select(x => x == 5 ? 0 : x).ToArray();

            return ints.Where(x => x != 0).Concat(ints.Where(x => x == 0)).ToArray();
        }

        public int[] EvenNumbersBeforOdd(int[] ints)
        {
            return ints.Where(x => x % 2 == 0).Concat(ints.Where(x => x % 2 != 0)).ToArray();
        }

        public bool IsAllLargerThanBefore(int[] ints)
        {
            return ints.Zip(ints.Skip(1), (a, b) => a < b || a == b).All(x => x);
        }

        public bool Has15NextToAnother(int[] ints)
        {
            return ints.Zip(ints.Skip(1), (a, b) => a == 15 && b == 15).Any(x => x);
        }

        public int LargestAverageBetweenHalves(int[] ints)
        {
            int middle = ints.Length / 2;
            return Math.Max(ints.Take(middle).Sum(), ints.TakeLast(middle).Sum());
        }

        public int StringLengthMatchingCount(string[] strings, int lengthCount)
        {
            return strings.Where(x => x.Length == lengthCount).Count();
        }

        public string[] FirstNStrings(string[] strings, int elementCount)
        {
            return strings.Take(elementCount).ToArray();
        }

        public string[] MatchesGivenLegth(string[] strings, int lengthCount)
        {
            return strings.Where(x => x.Length == lengthCount).ToArray();
        }

        public bool HasGivenValue(int input, int value)
        {
            return input.ToString().Contains(value.ToString());
        }

        public int[] ArrayOfOddNumbers(int[] ints, int length)
        {
            return ints.Where(x => x % 2 != 0).Take(length).ToArray();
        }

        public int[] ArrayMultiplier(int[] ints, int multiplier)
        {
            return ints.Select(x => x * multiplier).ToArray();
        }

        public int[] CubeOfArray(int[] ints)
        {
            return ints.Select(x => (int)Math.Pow(x, 3)).ToArray();
        }

        public string[] AddHashtag(string[] strings)
        {
            return strings.Select(x => "#" + x + "#").ToArray();
        }

        public string[] StringRepeat(string[] strings, int repeats)
        {
            return strings.Select(x => string.Concat(Enumerable.Repeat(x, repeats))).ToArray();
        }

        public int[] AddAndMultiply(int[] ints, int plus, int multiplier)
        {
            return ints.Select(x => (x + plus) * multiplier).ToArray();
        }

        public int[] RightmostValue(int[] ints)
        {
            return ints.Select(x => x % 10).ToArray();
        }

        public string[] AllToUpper(string[] strings)
        {
            return strings.Select(x => x.ToUpper()).ToArray();
        }

        public string[] RemoveTheA(string[] strings)
        {
            return strings.Select(x => x.Replace("a", "")).ToArray();
        }

        public int[] RemoveValueLessThanGiven(int[] ints, int givenValue)
        {
            return ints.Where(x => x > givenValue).ToArray();
        }

        public int[] RemoveEndingWith7(int[] ints)
        {
            return ints.Where(x => x.ToString().Last() != '7').ToArray();
        }
    }
}