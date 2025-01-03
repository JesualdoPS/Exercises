using BasicAlgorithm.BasicAlgorithmClass;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BasicAlgorithm.BasicAlgorithmTests
{
    [TestClass]
    public class AlgorithmTests
    {
        private readonly AlgorithmClass _exercise;

        public AlgorithmTests()
        {
            _exercise = new AlgorithmClass();
        }

        [TestMethod]
        [DataRow(1, 2, 3)]
        [DataRow(3, 2, 5)]
        [DataRow(2, 2, 12)]
        public void ShouldSumIntegersFromArrayOrTripleIfItsEqual(int n1, int n2, int expectedResult)
        {
            //Act
            int result = _exercise.SumOfNumbersInArrayOrTripleIfEqual(new[] { n1, n2 });

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(53, 51, 6)]
        [DataRow(30, 72, 42)]
        [DataRow(26, 26, 0)]
        public void ShouldReturnAbsoluteDifferenceWithTripleForGreater(int input, int subtractor, int expectedResult)
        {
            //Act
            int result = _exercise.AbsoluteDiferenceOrTriple(input, subtractor);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(30, 0, true)]
        [DataRow(25, 5, true)]
        [DataRow(20, 30, true)]
        [DataRow(20, 25, false)]
        public void ShouldCheckIfIts30OrSum30(double n1, double n2, bool expectedResult)
        {
            //Act
            bool result = _exercise.Is30OrSum30(new[] { n1, n2 });

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(103, true)]
        [DataRow(90, true)]
        [DataRow(89, false)]
        [DataRow(205, true)]
        public void ShouldCheckIfItsWithin10Of100Or200(int input, bool expectedResult)
        {
            //Act
            bool result = _exercise.IsWithin10Of100Or200(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow("if else")]
        [DataRow("else")]
        public void ShouldAddIfAtTheBeggining(string input)
        {
            //Act
            string result = _exercise.AddIf(input);

            //Assert
            result.Should().Be("if else");
        }

        [TestMethod]
        [DataRow(1, "Pthon")]
        [DataRow(0, "ython")]
        [DataRow(4, "Pythn")]
        public void ShouldRemoveCharacterAtPosition(int position, string expectedResult)
        {
            //Arrange
            string input = "Python";

            //Act
            string result = _exercise.RemoveAtPosition(input, position);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow("abcd", "dbca")]
        [DataRow("a", "a")]
        [DataRow("xy", "yx")]
        public void ShouldExchangeFirstAndLastCharacter(string input, string expectedResult)
        {
            //Act
            string result = _exercise.ExchangeFirstAndLast(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow("C Sharp", "C C C C")]
        [DataRow("JS", "JSJSJSJS")]
        [DataRow("a", "a")]
        public void ShouldGenerateFourCopiesOfFirstCharacter(string input, string expectedResult)
        {
            //Act
            string result = _exercise.FourCoppiesOfFirstCharacter(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow("Red", "dRedd")]
        [DataRow("Green", "nGreenn")]
        [DataRow("1", "111")]
        public void ShouldAddLastCharacterAtFrontAndBack(string input, string expectedResult)
        {
            //Act
            string result = _exercise.LastCharAtFrontAndBack(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(3, true)]
        [DataRow(14, true)]
        [DataRow(12, true)]
        [DataRow(37, false)]
        public void ShouldBeMultipleOf3Or7(double input, bool expectedResult)
        {
            //Act
            bool result = _exercise.IsMultipleOf3Or7(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow("Python", "PytPythonPyt")]
        [DataRow("JS", "JSJSJS")]
        [DataRow("Code", "CodCodeCod")]
        public void ShouldAddFirstThreeCharactersAtFrontAndBack(string input, string expectedResult)
        {
            //Act
            string result = _exercise.AddFirstThreeCharAtFrontAndBack(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow("C# Sharp", true)]
        [DataRow("C#", true)]
        [DataRow("C++", false)]
        public void ShouldCheckIfItStartsWithCSharp(string input, bool expectedResult)
        {
            //Act
            bool result = _exercise.StartsWithCSharp(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(120, -1, true)]
        [DataRow(-1, 120, true)]
        [DataRow(2, 120, false)]
        public void ShouldOneTemperatureBeNegativeAndTheOtherMoreThan100(int n1, int n2, bool expectedResult)
        {
            //Act
            bool result = _exercise.CheckTemperatureLessThan0AndMoreThan100(new[] { n1, n2 });

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(100, 199, true)]
        [DataRow(250, 300, false)]
        [DataRow(105, 210, true)]
        public void ShouldCheckIfOneIntIsBetween100And200(int n1, int n2, bool expectedResult)
        {
            //Act
            bool result = _exercise.IsBetween100And200(new[] { n1, n2 });

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(11, 20, 12, true)]
        [DataRow(30, 30, 17, true)]
        [DataRow(25, 35, 50, true)]
        [DataRow(15, 12, 8, false)]
        public void ShouldCheckIfItsInRange20To50(int n1, int n2, int n3, bool expectedResult)
        {
            //Act
            bool result = _exercise.IsInRange20To50(new[] { n1, n2, n3 });

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow("Python", "Phon")]
        [DataRow("ytade", "ytade")]
        [DataRow("jsues", "jsues")]
        public void ShouldRemoveYTAtIndex1(string input, string expectedResult)
        {
            //Act
            string result = _exercise.RemoveYTAtIndex1(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(1, 2, 3, 3)]
        [DataRow(1, 3, 2, 3)]
        [DataRow(1, 1, 1, 1)]
        [DataRow(1, 2, 2, 2)]
        public void ShouldFindLargetsInt(int n1, int n2, int n3, int expectedResult)
        {
            //Act
            int result = _exercise.LargestInt(new[] { n1, n2, n3 });

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(78, 95, 95)]
        [DataRow(95, 95, 0)]
        [DataRow(99, 70, 99)]
        public void ShouldShowClosestTo100(int n1, int n2, int expectedResult)
        {
            //Act
            int result = _exercise.IsClosestTo100(new[] { n1, n2 });

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(78, 95, false)]
        [DataRow(25, 35, false)]
        [DataRow(40, 50, true)]
        [DataRow(55, 60, true)]
        public void ShouldCheckIfBothIntsAreBetween40And50Or50And60(int n1, int n2, bool expectedResult)
        {
            //Act
            bool result = _exercise.IsBetween40_50Or50_60(new[] { n1, n2 });

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(78, 95, 0)]
        [DataRow(20, 30, 30)]
        [DataRow(21, 25, 25)]
        [DataRow(28, 28, 28)]
        public void ShouldFindLargestBetween20_30(int n1, int n2, int expectedResult)
        {
            //Act
            int result = _exercise.IsLargestBetween20_30(new[] { n1, n2 });

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow("frizz", true)]
        [DataRow("zane", false)]
        [DataRow("Zazz", true)]
        [DataRow("false", false)]
        [DataRow("zzzz", true)]
        [DataRow("ZZZZ", true)]
        public void ShouldHaveBetween2Or4Zs(string input, bool expectedResult)
        {
            //Act
            bool result = _exercise.HasBetween2Or4Zs(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(123, 456, false)]
        [DataRow(12, 512, true)]
        [DataRow(7, 87, true)]
        [DataRow(12, 45, false)]
        public void ShouldHaveSameLastDigit(int n1, int n2, bool expectedResult)
        {
            //Act
            bool result = _exercise.HasSameLastDigit(new[] { n1, n2 });

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow("Python", "PytHON")]
        [DataRow("JavaScript", "JavaScrIPT")]
        [DataRow("js", "JS")]
        [DataRow("PHP", "PHP")]
        public void ShouldUpperCaseLastThreeCharacters(string input, string expectedResult)
        {
            //Act
            string result = _exercise.UpperCaseLastThree(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(2, "JSJS")]
        [DataRow(3, "JSJSJS")]
        [DataRow(1, "JS")]
        public void ShouldCopyTheStringByNTimes(int repeat, string expectedResult)
        {
            //Arrange
            string input = "JS";

            //Act
            string result = _exercise.CopyStringByNTimes(input, repeat);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow("Python", 2, "PytPyt")]
        [DataRow("Python", 3, "PytPytPyt")]
        [DataRow("JS", 3, "JSJSJS")]
        public void ShouldCreateNCopiesOfFirstThreeCharacters(string text, int repeats, string expectedResult)
        {
            //Act
            string result = _exercise.CopiesOfFirstThreeCharacters(text, repeats);

            //Arrange
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow("bbaaccaag", 2)]
        [DataRow("jjkiaaasew", 2)]
        [DataRow("JSaaakoiaa", 3)]
        public void ShouldCountHowManyAAOfSelectedString(string input, int expectedResult)
        {
            //Act
            int result = _exercise.StringPartCounter(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow("caabb", true)]
        [DataRow("babaaba", false)]
        [DataRow("aaaaa", true)]
        public void ShouldCheckIfFirstAIsFollowedByAnotherA(string input, bool expectedResult)
        {
            //Act
            bool result = _exercise.HasAnAAfterFirstA(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow("Python", "Pto")]
        [DataRow("PHP", "PP")]
        [DataRow("JS", "J")]
        public void ShouldReturnAStringWithEveryOtherCharacter(string input, string expectedResult)
        {
            //Act
            string result = _exercise.EveryOtherCharacter(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow("abcd", "aababcabcd")]
        [DataRow("abc", "aababc")]
        [DataRow("a", "a")]
        public void ShouldReturnACumulativeSubstring(string input, string expectedResult)
        {
            //Act
            string result = _exercise.CumulativeSubstring(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow("abcdsab", 1)]
        [DataRow("abcdabab", 2)]
        [DataRow("abcabdabab", 3)]
        [DataRow("abcabd", 0)]
        public void ShouldCountHowManyOccurencesOfSubstring(string input, int expectedResult)
        {
            //Act
            int result = _exercise.RepeatOfTwoFirstCharacters(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(1, 2, 9, 3, 3, true)]
        [DataRow(1, 2, 2, 3, 2, true)]
        [DataRow(1, 2, 2, 3, 9, false)]
        public void ShouldCheckIfElementIsPresentInArray(int n1, int n2, int n3, int n4, int input, bool expectedResult)
        {
            //Act
            bool result = _exercise.HasTheElement(new[] { n1, n2, n3, n4 }, input);

            //Assert
            result.Should().Be(expectedResult);
        }

        /// <summary>
        /// #############################################################################
        /// TO DO: Ask for refactoring the following test with DataRow
        /// Since the arrays doesn't have the same size, how could I implement it?
        /// Obs.: Tried using params int[] values, but without success
        /// </summary>

        [TestMethod]
        public void ShouldCheckFirstFourElements()
        {
            //Arrange
            int[] array = { 1, 2, 9, 3 };
            int[] array2 = { 1, 2, 3, 4, 5, 6 };
            int[] array3 = { 1, 2, 2, 3 };

            int check = 3;
            int check2 = 6;
            int check3 = 9;

            //Act
            bool result = _exercise.IsInTheFirstFour(array, check);
            bool result2 = _exercise.IsInTheFirstFour(array2, check2);
            bool result3 = _exercise.IsInTheFirstFour(array3, check3);

            //Assert
            result.Should().BeTrue();
            result2.Should().BeFalse();
            result3.Should().BeFalse();
        }

        /// <summary>
        /// #############################################################################
        /// </summary>

        [TestMethod]
        [DataRow(1, 1, 2, 3, 1, true)]
        [DataRow(1, 1, 2, 4, 1, false)]
        [DataRow(1, 2, 1, 2, 3, true)]
        public void ShouldCheckIfHasTheSequence123(int n1, int n2, int n3, int n4, int n5, bool expectedResult)
        {
            //Act
            bool result = _exercise.HasSequence123(new[] { n1, n2, n3, n4, n5 });

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow("abcdefgh", "abijsklm", 1)]
        [DataRow("abcde", "osuefrcd", 1)]
        [DataRow("pqrstuvwx", "pqkdiewx", 2)]
        public void ShouldCountMatchingSubstringsInStrings(string str1, string str2, int expectedResult)
        {
            //Assert
            int result = _exercise.SubstringMatchingCount(new[] { str1, str2 });

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow("xxHxix", 'x', "xHix")]
        [DataRow("abxdddca", 'a', "abxdddca")]
        [DataRow("xabjbhtrb", 'b', "xajhtrb")]
        public void ShouldRemoveCharacterExceptFirstAndLast(string input, char remove, string expectedResult)
        {
            //Act
            string result = _exercise.RemoveCharExceptFirstAndLast(input, remove);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow("Python", "Pyon")]
        [DataRow("JavaScript", "JaScpt")]
        [DataRow("HTML", "HT")]
        public void ShouldCreateAStringBasedOnIndex(string input, string expectedResult)
        {
            //Arrange
            int[] index = { 0, 1, 4, 5, 8, 9 };

            //Act
            string result = _exercise.StringCreatorByIndex(input, index);

            //Assert
            result.Should().Be(expectedResult);
        }

        /// <summary>
        /// #############################################################################
        /// </summary>
        [TestMethod]
        public void ShouldCount5NextToEachOther()
        {
            //Arrange
            int[] input = { 5, 5, 2 };
            int[] input2 = { 5, 5, 2, 5, 5 };
            int[] input3 = { 5, 6, 2, 9 };

            //Act
            int result = _exercise.Count5NextToEachOther(input);
            int result2 = _exercise.Count5NextToEachOther(input2);
            int result3 = _exercise.Count5NextToEachOther(input3);

            //Assert
            result.Should().Be(1);
            result2.Should().Be(2);
            result3.Should().Be(1);
        }

        [TestMethod]
        public void ShouldCheckTripleInArray()
        {
            //Arrange
            int[] input = { 1, 1, 2, 2, 1 };
            int[] input2 = { 1, 1, 2, 1, 2, 3 };
            int[] input3 = { 1, 1, 1, 2, 2, 2, 1 };

            //Act
            bool result = _exercise.HasTripleValue(input);
            bool result2 = _exercise.HasTripleValue(input2);
            bool result3 = _exercise.HasTripleValue(input3);

            //Assert
            result.Should().BeFalse();
            result2.Should().BeFalse();
            result3.Should().BeTrue();
        }

        /// <summary>
        /// #############################################################################
        /// </summary>

        [TestMethod]
        [DataRow(12, 17, 29)]
        [DataRow(2, 17, 30)]
        [DataRow(22, 17, 39)]
        [DataRow(20, 0, 30)]
        public void ShouldSumOrReturn30(int n1, int n2, int expectedResult)
        {
            //Act
            int result = _exercise.SumOrReturn30(new[] { n1, n2 });

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(5, 4, true)]
        [DataRow(4, 3, false)]
        [DataRow(1, 4, true)]
        [DataRow(15, 10, true)]
        public void ShouldFind5OrSumOrDifference5(int n1, int n2, bool expectedResult)
        {
            //Act
            bool result = _exercise.HasA5Value(new[] { n1, n2 });

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(17, true)]
        [DataRow(18, true)]
        [DataRow(35, true)]
        [DataRow(53, false)]
        public void ShouldCheckIfItsAMultipleOf17Or1More(int input, bool expectedResult)
        {
            //Act
            bool result = _exercise.IsMultipleOf17Or1More(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(3, true)]
        [DataRow(7, true)]
        [DataRow(21, false)]
        public void ShouldBeMultipleOf3Or7NotBoth(int input, bool expectedResult)
        {
            //Act
            bool result = _exercise.IsNotMultipleOf3And7(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(3, false)]
        [DataRow(7, false)]
        [DataRow(8, true)]
        [DataRow(21, true)]
        public void ShouldBeWithin2OfMultipleOf10(int input, bool expectedResult)
        {
            //Act
            bool result = _exercise.IsWithin2OfMultipleOf10(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(3, 7, 10)]
        [DataRow(10, 11, 18)]
        [DataRow(10, 20, 18)]
        [DataRow(21, 220, 241)]
        public void ShouldReturn18IfOneValueIsBetween10And20(int n1, int n2, int expectedResult)
        {
            //Act
            int result = _exercise.SumOrReturn18(new[] { n1, n2 });

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(1, 2, 3, true)]
        [DataRow(4, 5, 6, false)]
        [DataRow(-1, 1, 0, true)]
        public void ShouldThirdBeSumOfOtherTwo(int n1, int n2, int n3, bool expectedResult)
        {
            //Act
            bool result = _exercise.IsThirdSumOfOtherTwo(new[] { n1, n2, n3 });

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(1, 2, 3, true)]
        [DataRow(4, 5, 6, true)]
        [DataRow(-1, 1, 0, false)]
        public void ShouldBeNumericOrder(int n1, int n2, int n3, bool expectedResult)
        {
            //Act
            bool result = _exercise.IsAscendingOrder(new[] { n1, n2, n3 });

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(11, 21, 31, true)]
        [DataRow(11, 22, 31, true)]
        [DataRow(11, 22, 33, false)]
        public void ShouldHaveSameDigit(int n1, int n2, int n3, bool expectedResult)
        {
            //Act
            bool result = _exercise.HasTheSameDigit(new[] { n1, n2, n3 });

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(11, 21, 31, true)]
        [DataRow(11, 22, 31, true)]
        [DataRow(10, 20, 15, false)]
        public void ShouldCheckIfOneIntIs20HigherThanAnother(int n1, int n2, int n3, bool expectedResult)
        {
            //Act
            bool result = _exercise.Is20Higher(new[] { n1, n2, n3 });

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(11, 21, 21)]
        [DataRow(11, 20, 20)]
        [DataRow(10, 10, 0)]
        [DataRow(15, 29, 15)]
        public void ShouldFindTheLargestOrIfHasSameRemainderOrReturnZero(int n1, int n2, int expectedResult)
        {
            //Act
            int result = _exercise.LargestIntOrSameRemainderOrZero(new[] { n1, n2 });

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(4, 5, 9)]
        [DataRow(7, 4, 7)]
        [DataRow(10, 10, 20)]
        public void ShouldHaveSameSumLength(int n1, int n2, int expectedResult)
        {
            //Act
            int result = _exercise.HasSameLengthOnSum(new[] { n1, n2 });

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(4, 5, 7, 16)]
        [DataRow(7, 4, 12, 23)]
        [DataRow(10, 10, 12, 12)]
        [DataRow(12, 12, 18, 18)]
        public void ShouldSumThreeIntOrReturnThirdIfTwoAreEqual(int n1, int n2, int n3, int expectedResult)
        {
            //Act
            int result = _exercise.SumOrReturnThird(new[] { n1, n2, n3 });

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(4, 5, 7, 16)]
        [DataRow(7, 4, 12, 23)]
        [DataRow(10, 13, 12, 10)]
        [DataRow(13, 12, 18, 0)]
        public void ShouldIgnore13AndRightToIt(int n1, int n2, int n3, int expectedResult)
        {
            //Act
            int result = _exercise.SumIgnoring13(new[] { n1, n2, n3 });

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(4, 5, 7, 16)]
        [DataRow(7, 4, 12, 11)]
        [DataRow(10, 13, 12, 13)]
        [DataRow(14, 15, 16, 0)]
        public void ShouldSumNumbersBeneath10AndAbove20Except13And17(int n1, int n2, int n3, int expectedResult)
        {
            //Act
            int result = _exercise.SumIgnoringBetween10And13(new[] { n1, n2, n3 });

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(8, 9, 9)]
        [DataRow(11, 16, 16)]
        [DataRow(14, 17, 17)]
        [DataRow(21, 37, 0)]
        public void ShouldReturnTheNearestNumberTo17WithoutCrossing(int n1, int n2, int expectedResult)
        {
            //Act
            int result = _exercise.IsNear17AndLesser(new[] { n1, n2 });

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(4, 5, 6, true)]
        [DataRow(7, 12, 13, false)]
        [DataRow(-1, 0, 1, true)]
        public void ShouldHaveSameDifference(int n1, int n2, int n3, bool expectedResult)
        {
            //Act
            bool result = _exercise.HasSameDiference(new[] { n1, n2, n3 });

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow("Hi", "Hello", "HiHelloHelloHi")]
        [DataRow("whats", "app", "whatsappappwhats")]
        public void ShouldFormatToS1S2S2S1(string str1, string str2, string expectedResult)
        {
            //Act
            string result = _exercise.FormatS1S2S2S1(new[] { str1, str2 });

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow("[[]]", "Hello", "[[Hello]]")]
        [DataRow("(())", "Hi", "((Hi))")]
        public void ShouldInsertStringInsideAnother(string str1, string str2, string expectedResult)
        {
            //Act
            string result = _exercise.InsertString(new[] { str1, str2 });

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow("Hello", "lololo")]
        [DataRow("Hi", "HiHiHi")]
        public void ShouldReturnThreeCopiesOfLastTwoCharacters(string input, string expectedResult)
        {
            //Act
            string result = _exercise.CopyOfThreeLastCharacters(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow("Hello", "He")]
        [DataRow("Hi", "Hi")]
        [DataRow("H", "H")]
        [DataRow(" ", " ")]
        public void ShouldReturnFirstTwoCharactersOrFullString(string input, string expectedResult)
        {
            //Act
            string result = _exercise.FirstTwoChars(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow("Hello", "He")]
        [DataRow("Hi", "H")]
        public void ShouldReturnFirstHalfOfEvenLengthString(string input, string expectedResult)
        {
            //Act
            string result = _exercise.FirstHalfOfEvenLengthString(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow("Hello", "ell")]
        [DataRow("Hi", " ")]
        [DataRow("Python", "ytho")]
        public void ShouldRemoveFirstAndLastCharacters(string input, string expectedResult)
        {
            //Act
            string result = _exercise.RemoveFirstAndLastCharacter(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow("Hello", "Hi", "HelloHiHello")]
        [DataRow("JS", "Python", "PythonJSPython")]
        public void ShouldOrderByLongShortLongString(string str1, string str2, string expectedResult)
        {
            //Act
            string result = _exercise.LongShortLongString(new[] { str1, str2 });

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow("Hello", "Hi", "elloi")]
        [DataRow("JS", "Python", "Sython")]
        public void ShouldCombineStringsAfterRemovingFirstCharacter(string str1, string str2, string expectedResult)
        {
            //Act
            string result = _exercise.CombineStringsWithoutFirstChar(new[] { str1, str2 });

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow("Hello", "lloHe")]
        [DataRow("JS", "SJ")]
        public void ShouldMoveFirstTwoCharsToEnd(string input, string expectedResult)
        {
            //Act
            string result = _exercise.MoveFirstTwoCharsToEnd(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow("Hello", "loHel")]
        [DataRow("JS", "JS")]
        public void ShouldMoveLastTwoCharsToStart(string input, string expectedResult)
        {
            //Act
            string result = _exercise.MoveLastTwoCharsToStart(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow("Hello", "el")]
        [DataRow("JS", "JS")]
        public void ShouldRemoveTwoMiddleCharactersOfEvenLengthString(string input, string expectedResult)
        {
            //Act
            string result = _exercise.TwoMiddleChars(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow("Hello", false)]
        [DataRow("Python", true)]
        [DataRow("on", true)]
        [DataRow("o", false)]
        public void ShouldCheckIfEndsWitOn(string input, bool expectedResult)
        {
            //Act
            bool result = _exercise.EndsWithOn(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow("Hello", 1, "Ho")]
        [DataRow("Python", 2, "Pyon")]
        [DataRow("on", 1, "on")]
        [DataRow("o", 1, "oo")]
        public void ShouldReturnNFirstAndLastChars(string input, int n, string expectedResult)
        {
            //Act
            string result = _exercise.FirstAndLastNChars(input, n);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow("Hello", 1, "el")]
        [DataRow("Python", 2, "th")]
        [DataRow("on", 1, "on")]
        public void ShouldReturnTwoCharactersStartingAtIndex(string input, int index, string expectedResult)
        {
            //Act
            string result = _exercise.ReturnStringWithStartingIndex(input, index);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow("Hello", "ell")]
        [DataRow("Python", "tho")]
        [DataRow("abc", "abc")]
        public void ShouldReturnThreeCharsFromMiddleString(string input, string expectedResult)
        {
            //Act
            string result = _exercise.ThreeCharsFromMiddleString(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow("Hello", "He")]
        [DataRow("Python", "Py")]
        [DataRow("a", "a#")]
        [DataRow("", "##")]
        public void ShouldReturnFirstTwoCharactersOrReplaceTheMissing(string input, string expectedResult)
        {
            //Act
            string result = _exercise.FirstTwoCharsOrMissing(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow("Hello", "Hi", "Hi")]
        [DataRow("Python", "PHP", "PP")]
        [DataRow("JS", "JS", "JS")]
        [DataRow("Csharp", "", "C#")]
        [DataRow("", "IA", "#A")]
        public void ShouldReturnFirstAndLastCharOfTwoStrings(string str1, string str2, string expectedResult)
        {
            //Act
            string result = _exercise.FirstAndLastCharOfTwoStrings(new[] { str1, str2 });

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow("abc", "cat", "abcat")]
        [DataRow("python", "php", "pythonphp")]
        [DataRow("php", "php", "phphp")]
        public void ShouldConcatenateStringsRemovingLastCharIfDuplicated(string str1, string str2, string expectedResult)
        {
            //Act
            string result = _exercise.ConcatStringRemovingLastDuplicate(str1, str2);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow("Hello", "Helol")]
        [DataRow("Python", "Pythno")]
        [DataRow("PHP", "PPH")]
        [DataRow("JS", "SJ")]
        [DataRow("C", "C")]
        public void ShouldSwapLastTwoChars(string input, string expectedResult)
        {
            //Act
            string result = _exercise.SwapLastTwoChars(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow("abc", "abc")]
        [DataRow("abcdef", "abc")]
        [DataRow("C", "")]
        [DataRow("xyz", "xyz")]
        [DataRow("abc", "abc")]
        [DataRow("ABC", "abc")]
        public void ShouldReturnIfBegginsWithABCOrXYZ(string input, string expectedResult)
        {
            //Act
            string result = _exercise.BeginsWith(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow("abab", true)]
        [DataRow("abcdef", false)]
        [DataRow("xyzsderxy", true)]
        public void ShouldCheckIfFirstTwoAndLastTwoAreEqual(string input, bool expectedResult)
        {
            //Act
            bool result = _exercise.IsBeginEqualsLast(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow("abc", "abcd", "abcbcd")]
        [DataRow("Python", "Python", "PythonPython")]
        [DataRow("JS", "Python", "JSon")]
        [DataRow("Python", "JS", "PyJS")]
        public void ShouldJoinTwoStringsAfterReducingLength(string str1, string str2, string expectedResult)
        {
            //Act
            string result = _exercise.EqualizeAndCombine(str1, str2);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow("abcab", "cab")]
        [DataRow("Python", "Python")]
        public void ShouldRemoveFirstTwoIfItsEqualToLastTwo(string input, string expectedResult)
        {
            //Act
            string result = _exercise.RemoveFirstTwo(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow("abcab", "cab")]
        [DataRow("Python", "Python")]
        [DataRow("press", "pess")]
        [DataRow("jython", "ython")]
        public void ShouldRemoveFirstTwoCharactersIfItsNotPOrY(string input, string expectedResult)
        {
            //Act
            string result = _exercise.RemoveFirstTwoIfItsNotPOrY(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow("abcab", "bcab")]
        [DataRow("python", "python")]
        [DataRow("abcda", "bcd")]
        [DataRow("jython", "jython")]
        public void ShouldRemoveAFromBegginingAndFromTheEnd(string input, string expectedResult)
        {
            //Act
            string result = _exercise.ARemover(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow("abcab", "bcab")]
        [DataRow("python", "python")]
        [DataRow("aacda", "cda")]
        [DataRow("calculator", "clculator")]
        public void ShouldRemoveTheAFromFirstTwoChars(string input, string expectedResult)
        {
            //Act
            string result = _exercise.RemoveAFromFirstTwo(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(10, 20, 40, 50, true)]
        [DataRow(5, 20, 40, 10, true)]
        [DataRow(10, 20, 40, 10, true)]
        [DataRow(12, 24, 35, 55, false)]
        public void ShouldCheckIfFirstOrLastIs10(int n1, int n2, int n3, int n4, bool expectedResult)
        {
            //Act
            bool result = _exercise.Has10OnStartOrEnd(new[] { n1, n2, n3, n4 });

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(10, 20, 40, 50, false)]
        [DataRow(10, 20, 40, 10, true)]
        [DataRow(12, 24, 35, 55, false)]
        public void ShouldCheckIfFirstAndLastAreEqual(int n1, int n2, int n3, int n4, bool expectedResult)
        {
            //Act
            bool result = _exercise.Is10FirstOrLast(new[] { n1, n2, n3, n4 });

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(10, 20, 40, 50, 10, 20, 40, 50, true)]
        [DataRow(10, 20, 40, 50, 10, 20, 40, 5, true)]
        [DataRow(10, 20, 40, 50, 1, 20, 40, 50, true)]
        [DataRow(10, 20, 40, 50, 11, 25, 41, 55, false)]
        public void ShouldCheckIfFirstOfLastAreEqual(int n1, int n2, int n3, int n4, int n5, int n6, int n7, int n8, bool expectedResult)
        {
            //Act
            bool result = _exercise.IsFirstOrLastEqual(new[] { n1, n2, n3, n4 }, new[] { n5, n6, n7, n8 });

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(10, 20, 30, 40, 50, 150)]
        [DataRow(10, 20, -30, -40, 50, 10)]
        public void ShouldSumAllVallues(int n1, int n2, int n3, int n4, int n5, int expectedResult)
        {
            //Act
            int result = _exercise.SumOfNumbersInArray(new[] { n1, n2, n3, n4, n5 });

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(10, 20, -30, -40, 20, -30, -40, 10)]
        public void ShouldRotateToLeft(int n1, int n2, int n3, int n4, int n5, int n6, int n7, int n8)
        {
            //Act
            int[] result = _exercise.RotateLeft(new[] { n1, n2, n3, n4 });

            //Assert
            result.Should().Equal(new[] { n5, n6, n7, n8 });
        }

        [TestMethod]
        [DataRow(10, 20, -30, -40, 50, 50, -40, -30, 20, 10)]
        public void ShouldReverseAnArray(int n1, int n2, int n3, int n4, int n5, int n6, int n7, int n8, int n9, int n10)
        {
            //Act
            int[] result = _exercise.ReverseArray(new[] { n1, n2, n3, n4, n5 });

            //Assert
            result.Should().Equal(new[] { n6, n7, n8, n9, n10 });
        }

        [TestMethod]
        [DataRow(10, 20, -30, -40, 20)]
        public void ShouldReplaceAllElementsInArrayByItsMax(int n1, int n2, int n3, int n4, int n5)
        {
            //Act
            int[] result = _exercise.ReplaceAllForMax(new[] { n1, n2, n3, n4 });

            //Assert
            result.Should().Equal(new[] { n5, n5, n5, n5 });
        }

        [TestMethod]
        [DataRow(10, 20, -30, -40, 30, 10, 20, 30, 40, 30)]
        public void ShouldReturnTheMiddleElementsOfTwoArrays(int n1, int n2, int n3, int n4, int n5, int n6, int n7, int n8, int n9, int n10)
        {
            //Act
            int[] result = _exercise.MiddleElements(new[] { n1, n2, n3, n4, n5 }, new[] { n6, n7, n8, n9, n10 });

            //Assert
            result.Should().Equal(new[] { n3, n8 });
        }

        [TestMethod]
        [DataRow(10, 20, -30, -40, 30)]
        public void ShouldReturnFirstAndLastElementOfArray(int n1, int n2, int n3, int n4, int n5)
        {
            //Act
            int[] result = _exercise.FirstAndLastElement(new[] { n1, n2, n3, n4, n5 });

            //Assert
            result.Should().Equal(new[] { n1, n5 });
        }

        [TestMethod]
        [DataRow(12, 20, true)]
        [DataRow(14, 15, true)]
        [DataRow(11, 21, false)]
        public void ShouldCheckIfHas15Or20OnArray(int n1, int n2, bool expectedResult)
        {
            //Act
            bool result = _exercise.Has15Or20(new[] { n1, n2 });

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(10, 20, -30, -40, 30)]
        public void ShouldCheckIfHasNot15Or20OnArray(int n1, int n2, int n3, int n4, int n5)
        {
            //Act
            int[] result = _exercise.FirstIntAndZeroToDoubleSizedArray(new[] { n1, n2, n3, n4, n5 });

            //Assert
            result.Should().Equal(new[] { 10, 0, 0, 0, 0, 0, 0, 0, 0, 0 });
        }

        [TestMethod]
        [DataRow(12, 20, false)]
        [DataRow(20, 20, true)]
        [DataRow(10, 10, true)]
        [DataRow(10, 17, false)]
        public void ShouldHaveBothValuesEqual10Or20(int n1, int n2, bool expectedResult)
        {
            //Act
            bool result = _exercise.AreEqual10Or20(new[] { n1, n2 });

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(1, 5, 7)]
        public void ShouldSet1If7After5(int n1, int n2, int n3)
        {
            //Act
            int[] result = _exercise.If7After5Set1(new[] { n1, n2, n3 });

            //Assert
            result.Should().Equal(new[] { n1, n2, n1 });
        }

        [TestMethod]
        [DataRow(10, 20, -30, 10, 20, 30)]
        public void ShouldCheckWhichArrayIsLarger(int n1, int n2, int n3, int n4, int n5, int n6)
        {
            //Act
            int[] result = _exercise.IsLarger(new[] { n1, n2, n3 }, new[] { n4, n5, n6 });

            //Assert
            result.Should().Equal(new[] { n4, n5, n6 });
        }

        [TestMethod]
        [DataRow(1, 5, 7, 9, 11, 13)]
        public void ShouldReturnTwoMiddleElementsOfEvenArray(int n1, int n2, int n3, int n4, int n5, int n6)
        {
            //Act
            int[] result = _exercise.TwoMiddleElements(new[] { n1, n2, n3, n4, n5, n6 });

            //Assert
            result.Should().Equal(new[] { n3, n4 });
        }

        [TestMethod]
        [DataRow(10, 20, 30, 40, 50, 60)]
        public void ShouldMergeTwoArrays(int n1, int n2, int n3, int n4, int n5, int n6)
        {
            //Act
            int[] result = _exercise.MergeArrays(new[] { n1, n2, n3 }, new[] { n4, n5, n6 });

            //Assert
            result.Should().Equal(new[] { n1, n2, n3, n4, n5, n6 });
        }

        [TestMethod]
        [DataRow(1, 5, 7, 9, 11, 13)]
        public void ShouldSwapFirstAndLastElements(int n1, int n2, int n3, int n4, int n5, int n6)
        {
            //Act
            int[] result = _exercise.FirstAndLastSwap((new[] { n1, n2, n3, n4, n5, n6 }));

            //Assert
            result.Should().Equal(new[] { n6, n2, n3, n4, n5, n1 });
        }

        [TestMethod]
        [DataRow(1, 5, 7, 9, 11, 13)]
        public void ShouldReturnMiddleElementsWithLength3(int n1, int n2, int n3, int n4, int n5, int n6)
        {
            //Act
            int[] result = _exercise.ThreeMiddleElements(new[] { n1, n2, n3, n4, n5, n6 });

            //Assert
            result.Should().Equal(new[] { n3, n4, n5 });
        }

        /// <summary>
        /// #############################################################################
        /// </summary>

        [TestMethod]
        public void ShouldReturnLargestBetweenFirstLastAndMiddleElements()
        {
            //Arrange
            int[] input = { 1 };
            int[] input2 = { 1, 2, 9 };
            int[] input3 = { 1, 2, 9, 3, 3 };
            int[] input4 = { 1, 2, 3, 4, 5, 6, 7 };
            int[] input5 = { 1, 2, 2, 3, 7, 8, 9, 10, 6, 5, 4 };

            //Act
            int result = _exercise.LargestElementFromFirstMiddleAndLast(input);
            int result2 = _exercise.LargestElementFromFirstMiddleAndLast(input2);
            int result3 = _exercise.LargestElementFromFirstMiddleAndLast(input3);
            int result4 = _exercise.LargestElementFromFirstMiddleAndLast(input4);
            int result5 = _exercise.LargestElementFromFirstMiddleAndLast(input5);

            //Assert
            result.Should().Be(1);
            result2.Should().Be(9);
            result3.Should().Be(9);
            result4.Should().Be(7);
            result5.Should().Be(8);
        }

        /// <summary>
        /// #############################################################################
        /// </summary>

        [TestMethod]
        [DataRow(1, 5, 7, 9, 11, 13)]
        public void ShouldReturnFirstTwoElementsOrFullArray(int n1, int n2, int n3, int n4, int n5, int n6)
        {
            //Act
            int[] result = _exercise.FirstTwoElements(new[] { n1, n2, n3, n4, n5, n6 });

            //Assert
            result.Should().Equal(new[] { n1, n2 });
        }

        [TestMethod]
        [DataRow(1, 5, 7, 9, 10, 12, 2)]
        [DataRow(2, 6, 8, 10, 12, 14, 6)]
        public void ShouldCountHowManyEvenElements(int n1, int n2, int n3, int n4, int n5, int n6, int expectedResult)
        {
            //Act
            int result = _exercise.HowManyEvenElements(new[] { n1, n2, n3, n4, n5, n6 });

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(1, 5, 7, 9, 10, 12, 11)]
        public void ShouldReturnTheDiferenceBetweenFirstAndLastElement(int n1, int n2, int n3, int n4, int n5, int n6, int expectedResult)
        {
            //Act
            int result = _exercise.DiferenceBetweenLargestAndSmallest(new[] { n1, n2, n3, n4, n5, n6 });

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(1, 5, 7, 9, 10, 17, 32)]
        public void ShouldSumArrayExcluding17(int n1, int n2, int n3, int n4, int n5, int n6, int expectedResult)
        {
            //Act
            int result = _exercise.SumArrayExcluding17(new[] { n1, n2, n3, n4, n5, n6 });

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(5, 6, 1, 5, 6, 9, 10, 17, 37)]
        [DataRow(1, 5, 6, 9, 10, 17, 5, 6, 37)]
        public void ShouldSumExceptWhen5IsFollowedBy6(int n1, int n2, int n3, int n4, int n5, int n6, int n7, int n8, int expectedResult)
        {
            //Act
            int result = _exercise.SumExcluding5FollowedBy6(new[] { n1, n2, n3, n4, n5, n6, n7, n8 });

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(1, 5, 6, 9, 10, 17, false)]
        [DataRow(1, 5, 5, 9, 10, 17, true)]
        public void ShouldCheckIfThereAre5Duped(int n1, int n2, int n3, int n4, int n5, int n6, bool expectedResult)
        {
            //Act
            bool result = _exercise.Is5FollowedBy5(new[] { n1, n2, n3, n4, n5, n6 });

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(1, 5, 6, 9, 10, 17, true)]
        [DataRow(1, 4, 7, 9, 10, 17, true)]
        [DataRow(1, 1, 2, 9, 10, 17, false)]
        public void ShouldCheckIfHas5Or7(int n1, int n2, int n3, int n4, int n5, int n6, bool expectedResult)
        {
            //Act
            bool result = _exercise.Has5Or7(new[] { n1, n2, n3, n4, n5, n6 });

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(1, 5, 6, 9, 10, 17, false)]
        [DataRow(1, 5, 5, 5, 10, 17, true)]
        [DataRow(1, 1, 5, 5, 5, 5, false)]
        public void ShouldCheckIfTheSumOf5sInArrayIs15(int n1, int n2, int n3, int n4, int n5, int n6, bool expectedResult)
        {
            //Act
            bool result = _exercise.IsSumEqual15(new[] { n1, n2, n3, n4, n5, n6 });

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(1, 5, 6, 9, 3, 3, true)]
        [DataRow(1, 5, 5, 5, 10, 17, false)]
        [DataRow(1, 3, 3, 5, 5, 5, false)]
        public void ShouldCheckIf3Outnumbers5(int n1, int n2, int n3, int n4, int n5, int n6, bool expectedResult)
        {
            //Act
            bool result = _exercise.HasMore3Than5(new[] { n1, n2, n3, n4, n5, n6 });

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(5, 5, 5, 5, 5, true)]
        [DataRow(3, 3, 3, 3, 3, true)]
        [DataRow(3, 3, 3, 5, 5, true)]
        [DataRow(1, 6, 8, 10, 5, false)]
        public void ShouldCheckIfHasOnly3Or5(int n1, int n2, int n3, int n4, int n5, bool expectedResult)
        {
            //Act
            bool result = _exercise.IsOnly3Or5(new[] { n1, n2, n3, n4, n5 });

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(5, 5, 5, 5, 5, true)]
        [DataRow(3, 3, 3, 3, 3, true)]
        [DataRow(3, 3, 3, 5, 5, false)]
        [DataRow(1, 6, 8, 10, 5, true)]
        public void ShouldCheckIfHas3Or5ButNotBoth(int n1, int n2, int n3, int n4, int n5, bool expectedResult)
        {
            //Act
            bool result = _exercise.Has3Or5NotBoth(new[] { n1, n2, n3, n4, n5 });

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(5, 5, 5, 5, 5, true)]
        [DataRow(1, 2, 3, 4, 5, false)]
        [DataRow(3, 3, 3, 5, 5, true)]
        [DataRow(1, 5, 5, 7, 8, true)]
        public void ShouldCheckIfHasADouble3Or5(int n1, int n2, int n3, int n4, int n5, bool expectedResult)
        {
            //Act
            bool result = _exercise.HasDouble3Or5(new[] { n1, n2, n3, n4, n5 });

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(3, 5, 1, 3, 7, true)]
        [DataRow(1, 2, 3, 4, 5, false)]
        [DataRow(3, 3, 3, 5, 5, true)]
        [DataRow(2, 5, 5, 7, 8, false)]
        public void ShouldCheckIfHas3Before5(int n1, int n2, int n3, int n4, int n5, bool expectedResult)
        {
            //Act
            bool result = _exercise.Has3BBefore5(new[] { n1, n2, n3, n4, n5 });

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(3, 5, 1, 3, 7, true)]
        [DataRow(1, 2, 3, 4, 5, false)]
        [DataRow(2, 4, 6, 8, 10, true)]
        public void ShouldCheckIfHasDoubleEvenOrDoubleOdd(int n1, int n2, int n3, int n4, int n5, bool expectedResult)
        {
            //Act
            bool result = _exercise.HasDoubleEvenOrDoubleOdd(new[] { n1, n2, n3, n4, n5 });

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(3, 5, 1, 5, 3, 5, 7, 5, 1, 5, true)]
        [DataRow(3, 5, 5, 5, 5, 5, 5, 6, 2, 1, false)]
        [DataRow(3, 5, 2, 5, 4, 5, 7, 5, 8, 5, true)]
        [DataRow(3, 5, 5, 5, 5, 5, 5, 5, 5, 5, false)]
        public void ShouldHave5FivesAndNoneAdjacentToAnother(int n1, int n2, int n3, int n4, int n5, int n6, int n7, int n8, int n9, int n10, bool expectedResult)
        {
            //Act
            bool result = _exercise.Has5FivesNoneNextToEachOther(new[] { n1, n2, n3, n4, n5, n6, n7, n8, n9, n10 });

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(3, 5, 5, 3, 7, true)]
        [DataRow(5, 5, 4, 5, 1, false)]
        [DataRow(3, 5, 5, 5, 5, true)]
        [DataRow(2, 4, 5, 5, 6, true)]
        public void ShouldCheckIfAll5IsNextToAnother(int n1, int n2, int n3, int n4, int n5, bool expectedResult)
        {
            //Act
            bool result = _exercise.Is5NextToAnother(new[] { n1, n2, n3, n4, n5 });

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(3, 7, 5, 5, 3, 7, 2, true)]
        [DataRow(3, 7, 5, 5, 3, 7, 3, false)]
        [DataRow(3, 7, 5, 3, 7, 5, 3, true)]
        public void ShouldCheckIfTheStartAndLastElementsAreEqual(int n1, int n2, int n3, int n4, int n5, int n6, int count, bool expectedResult)
        {
            //Act
            bool result = _exercise.StartAndEndEqualByNumber(new[] { n1, n2, n3, n4, n5, n6 }, count);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(1, 2, 3, 5, 3, 7, true)]
        [DataRow(3, 7, 5, 5, 3, 7, false)]
        [DataRow(3, 7, 5, 5, 6, 7, true)]
        public void ShouldCheckForThreeIncreasingAdjacent(int n1, int n2, int n3, int n4, int n5, int n6, bool expectedResult)
        {
            //Act
            bool result = _exercise.HasThreeIncreasingAdjacent(new[] { n1, n2, n3, n4, n5, n6 });

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(1, 2, 3, 5, 7)]
        public void ShouldReturnElementsBeforeThe5(int n1, int n2, int n3, int n4, int n5)
        {
            //Act
            int[] result = _exercise.ElementsBefore5(new[] { n1, n2, n3, n4, n5 });

            //Assert
            result.Should().Equal(new[] { n1, n2, n3 });
        }

        [TestMethod]
        [DataRow(1, 2, 5, 3, 7, 9, 11)]
        public void ShouldReturnElementsAfterThe5(int n1, int n2, int n3, int n4, int n5, int n6, int n7)
        {
            //Act
            int[] result = _exercise.ElementsAfter5(new[] { n1, n2, n3, n4, n5, n6, n7 });

            //Assert
            result.Should().Equal(new[] { n4, n5, n6, n7 });
        }

        [TestMethod]
        [DataRow(1, 2, 0, 3, 5, 7, 0, 9, 11)]
        public void ShouldShiftZerosToLeftInArray(int n1, int n2, int n3, int n4, int n5, int n6, int n7, int n8, int n9)
        {
            //Act
            int[] result = _exercise.ZerosToLeft(new[] { n1, n2, n3, n4, n5, n6, n7, n8, n9 });

            //Assert
            result.Should().Equal(new[] { n3, n7, n1, n2, n4, n5, n6, n8, n9 });
        }

        [TestMethod]
        [DataRow(1, 2, 5, 3, 5, 7, 5, 9, 11)]
        public void ShouldReplace5With0AndShiftZerosRight(int n1, int n2, int n3, int n4, int n5, int n6, int n7, int n8, int n9)
        {
            //Act
            int[] result = _exercise.Swap5ToZerosAndShiftToRight(new[] { n1, n2, n3, n4, n5, n6, n7, n8, n9 });

            //Assert
            result.Should().Equal(new[] { n1, n2, n4, n6, n8, n9, 0, 0, 0 });
        }

        [TestMethod]
        [DataRow(1, 2, 3, 4, 5, 6, 7, 8, 9)]
        public void ShouldShiftEvenNumbersBeforeOddNumbers(int n1, int n2, int n3, int n4, int n5, int n6, int n7, int n8, int n9)
        {
            //Act
            int[] result = _exercise.EvenNumbersBeforOdd(new[] { n1, n2, n3, n4, n5, n6, n7, n8, n9 });

            //Assert
            result.Should().Equal(n2, n4, n6, n8, n1, n3, n5, n7, n9);
        }

        [TestMethod]
        [DataRow(5, 5, 1, 5, 5, false)]
        [DataRow(1, 2, 3, 4, 5, true)]
        [DataRow(3, 3, 5, 5, 5, true)]
        [DataRow(1, 5, 5, 7, 8, true)]
        public void ShouldCheckIfEachElementIsLargerOrEqualPrevious(int n1, int n2, int n3, int n4, int n5, bool expectedResult)
        {
            //Act
            bool result = _exercise.IsAllLargerThanBefore(new[] { n1, n2, n3, n4, n5 });

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(5, 5, 1, 15, 15, true)]
        [DataRow(15, 2, 3, 4, 15, false)]
        [DataRow(3, 3, 15, 15, 5, true)]
        [DataRow(1, 5, 15, 7, 8, false)]
        public void ShouldChecForTwo15sNextToEachOther(int n1, int n2, int n3, int n4, int n5, bool expectedResult)
        {
            //Act
            bool result = _exercise.Has15NextToAnother(new[] { n1, n2, n3, n4, n5 });

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(1, 2, 3, 4, 6, 8, 18)]
        [DataRow(15, 2, 3, 4, 15, 11, 30)]
        public void ShouldReturnLargestAverageBetweenArrayHalves(int n1, int n2, int n3, int n4, int n5, int n6, int expectedResult)
        {
            //Act
            int result = _exercise.LargestAverageBetweenHalves(new[] { n1, n2, n3, n4, n5, n6 });

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow("a", "b", "bb", "c", "ccc", 1, 3)]
        public void ShouldCountStringsMatchingLength(string str1, string str2, string str3, string str4, string str5, int lengthCount, int expectedResult)
        {
            //Act
            int result = _exercise.StringLengthMatchingCount(new[] { str1, str2, str3, str4, str5 }, lengthCount);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow("a", "b", "bb", "c", "ccc", 3)]
        public void ShouldReturnFirstNStringsFromStringArray(string str1, string str2, string str3, string str4, string str5, int elementCount)
        {
            //Act
            string[] result = _exercise.FirstNStrings(new[] { str1, str2, str3, str4, str5 }, elementCount);

            //Assert
            result.Should().Equal(new[] { str1, str2, str3 });
        }

        [TestMethod]
        [DataRow("a", "aaa", "b", "bbb", "c", "ccc", 3)]
        public void ShouldReturnStringsMatchingGivenLength(string str1, string str2, string str3, string str4, string str5, string str6, int lengthCount)
        {
            //Act
            string[] result = _exercise.MatchesGivenLegth(new[] { str1, str2, str3, str4, str5, str6 }, lengthCount);

            //Assert
            result.Should().Equal(new[] { str2, str4, str6 });
        }

        [TestMethod]
        [DataRow(123, 2, true)]
        [DataRow(133, 4, false)]
        [DataRow(176, 5, false)]
        public void ShouldCheckIfContainsGivenValue(int input, int value, bool expectedResult)
        {
            //Act
            bool result = _exercise.HasGivenValue(input, value);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(1, 2, 3, 5, 7, 9, 10, 3)]
        public void ShouldReturnArrayOfOddNumbersWithGivenLength(int n1, int n2, int n3, int n4, int n5, int n6, int n7, int length)
        {
            //Act
            int[] result = _exercise.ArrayOfOddNumbers(new[] { n1, n2, n3, n4, n5, n6, n7 }, length);

            //Assert
            result.Should().Equal(new[] { n1, n3, n4 });
        }

        [TestMethod]
        [DataRow(1, 2, 3, 4, 3, 6, 9, 12, 3)]
        [DataRow(1, 2, 3, 4, 5, 10, 15, 20, 5)]
        public void ShouldMultiplyAllIntegersInArrayByGivenValue(int n1, int n2, int n3, int n4, int n5, int n6, int n7, int n8, int multiplier)
        {
            //Act
            int[] result = _exercise.ArrayMultiplier(new[] { n1, n2, n3, n4 }, multiplier);

            //Assert
            result.Should().Equal(new[] { n5, n6, n7, n8 });
        }

        [TestMethod]
        [DataRow(1, 2, 3, 4, 1, 8, 27, 64)]
        public void ShouldReturnTheCubeOfEachElement(int n1, int n2, int n3, int n4, int n5, int n6, int n7, int n8)
        {
            //Act
            int[] result = _exercise.CubeOfArray(new[] { n1, n2, n3, n4 });

            //Assert
            result.Should().Equal(new[] { n5, n6, n7, n8 });
        }

        [TestMethod]
        [DataRow("1", "2", "3", "4", "#1#", "#2#", "#3#", "#4#")]
        public void ShouldAddHashtagBeforeAndAfterTheString(string str1, string str2, string str3, string str4, string str5, string str6, string str7, string str8)
        {
            //Act
            string[] result = _exercise.AddHashtag(new[] { str1, str2, str3, str4 });

            //Assert
            result.Should().Equal(new[] { str5, str6, str7, str8 });
        }

        [TestMethod]
        [DataRow("1", "2", "3", "4", "1111", "2222", "3333", "4444", 4)]
        [DataRow("1", "2", "3", "4", "11111", "22222", "33333", "44444", 5)]
        public void ShouldRepeatStringByGivenValue(string str1, string str2, string str3, string str4, string str5, string str6, string str7, string str8, int repeats)
        {
            //Act
            string[] result = _exercise.StringRepeat(new[] { str1, str2, str3, str4 }, repeats);

            //Assert
            result.Should().Equal(new[] { str5, str6, str7, str8 });
        }

        [TestMethod]
        [DataRow(1, 2, 3, 4, 15, 20, 25, 30, 2, 5)]
        [DataRow(1, 3, 5, 9, 70, 90, 110, 150, 6, 10)]
        public void ShouldReturnValuePlusGivenValueAndMultipliedByAnother(int n1, int n2, int n3, int n4, int n5, int n6, int n7, int n8, int plus, int multiplier)
        {
            //Act
            int[] result = _exercise.AddAndMultiply(new[] { n1, n2, n3, n4 }, plus, multiplier);

            //Assert
            result.Should().Equal(new[] { n5, n6, n7, n8 });
        }

        [TestMethod]
        [DataRow(10, 22, 35, 41, 0, 2, 5, 1)]
        public void ShouldReturnTheRightmostValue(int n1, int n2, int n3, int n4, int n5, int n6, int n7, int n8)
        {
            //Act
            int[] result = _exercise.RightmostValue(new[] { n1, n2, n3, n4 });

            //Assert
            result.Should().Equal(new[] { n5, n6, n7, n8 });
        }

        [TestMethod]
        [DataRow("Abc", "cdef", "js", "php", "ABC", "CDEF", "JS", "PHP")]
        public void ShouldConvertWholeArrayToUppercase(string str1, string str2, string str3, string str4, string str5, string str6, string str7, string str8)
        {
            //Act
            string[] result = _exercise.AllToUpper(new[] { str1, str2, str3, str4 });

            //Assert
            result.Should().Equal(new[] { str5, str6, str7, str8 });
        }

        [TestMethod]
        [DataRow("abc", "cdaef", "js", "php", "bc", "cdef", "js", "php")]
        public void ShouldRemoveAFromEachString(string str1, string str2, string str3, string str4, string str5, string str6, string str7, string str8)
        {
            //Act
            string[] result = _exercise.RemoveTheA(new[] { str1, str2, str3, str4 });

            //Assert
            result.Should().Equal(new[] { str5, str6, str7, str8 });
        }

        [TestMethod]
        [DataRow(0, -2, 1, 2, 3, 5, 4, 7, 8, 4)]
        public void ShouldRemoveIntegersLessThanValue(int n1, int n2, int n3, int n4, int n5, int n6, int n7, int n8, int n9, int givenValue)
        {
            //Act
            int[] result = _exercise.RemoveValueLessThanGiven(new[] { n1, n2, n3, n4, n5, n6, n7, n8, n9 }, givenValue);

            //Assert
            result.Should().Equal(new[] { n6, n8, n9 });
        }

        [TestMethod]
        [DataRow(10, 22, 35, 47, 53, 67)]
        public void ShouldRemoveIntegersEndingIn7(int n1, int n2, int n3, int n4, int n5, int n6)
        {
            //Act
            int[] result = _exercise.RemoveEndingWith7(new[] { n1, n2, n3, n4, n5, n6 });

            //Assert
            result.Should().Equal(new[] { n1, n2, n3, n5 });
        }
    }
}