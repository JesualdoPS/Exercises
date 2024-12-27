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
            int result = _exercise.SumOfNumbersInArray(new[] { n1, n2 });

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(53, 6)]
        [DataRow(30, 21)]
        [DataRow(51, 0)]
        public void ShouldReturnAbsoluteDifferenceWithTripleForGreater(int input, int expectedResult)
        {
            //Act
            int result = _exercise.AbsoluteDiferenceOrTriple(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(30, 0, true)]
        [DataRow(25, 5, true)]
        [DataRow(20, 30, true)]
        [DataRow(20, 25, false)]
        public void ShouldCheckIfIts30OrSum30(int n1, int n2, bool expectedResult)
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
        public void ShouldBeMultipleOf3Or7(int input, bool expectedResult)
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
        public void ShouldTemperatureBeLessThan0AndMoreThan100(int n1, int n2, bool expectedResult)
        {
            //Act
            bool result = _exercise.CheckTemperatureLessThan0AndMoreThan100(new[] { n1, n2 });

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(100, 199, true)]
        [DataRow(250, 300, false)]
        [DataRow(105, 190, true)]
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
        public void ShouldCheckIfBothIntsAreBetween40And50And60(int n1, int n2, bool expectedResult)
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
        public void ShouldHave2Or4Zs(string input, bool expectedResult)
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
            string result = _exercise.CopyOfThreeCharacters(text, repeats);
            string result2 = _exercise.CopyOfThreeCharacters(text, repeats);
            string result3 = _exercise.CopyOfThreeCharacters(text, repeats);

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
    }
}