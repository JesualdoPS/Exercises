using System.Collections.Generic;
using System.Runtime.InteropServices;
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
        public void ShouldSumIntegersFromArrayOrTripleIfItsEqual()
        {
            //Arrange
            int[] input = { 1, 2 };
            int[] input2 = { 3, 2 };
            int[] input3 = { 2, 2 };

            //Act
            int result = _exercise.SumOfNumbersInArray(input);
            int result2 = _exercise.SumOfNumbersInArray(input2);
            int result3 = _exercise.SumOfNumbersInArray(input3);

            //Assert
            result.Should().Be(3);
            result2.Should().Be(5);
            result3.Should().Be(12);
        }

        [TestMethod]
        public void ShouldReturnAbsoluteDifferenceWithTripleForGreater()
        {
            //Arrange
            int input = 53;
            int input2 = 30;
            int input3 = 51;

            //Act
            int result = _exercise.AbsoluteDiferenceOrTriple(input);
            int result2 = _exercise.AbsoluteDiferenceOrTriple(input2);
            int result3 = _exercise.AbsoluteDiferenceOrTriple(input3);

            //Assert
            result.Should().Be(6);
            result2.Should().Be(21);
            result3.Should().Be(0);
        }

        [TestMethod]
        public void ShouldCheckIfIts30OrSum30()
        {
            //Arrange
            int[] input = { 30, 0 };
            int[] input2 = { 25, 5 };
            int[] input3 = { 20, 30 };
            int[] input4 = { 20, 25 };

            //Act
            bool result = _exercise.Is30OrSum30(input);
            bool result2 = _exercise.Is30OrSum30(input2);
            bool result3 = _exercise.Is30OrSum30(input3);
            bool result4 = _exercise.Is30OrSum30(input4);

            //Assert
            result.Should().BeTrue();
            result2.Should().BeTrue();
            result3.Should().BeTrue();
            result4.Should().BeFalse();
        }

        [TestMethod]
        public void ShouldCheckIfItsWithin10Of100Or200()
        {
            //Arrange
            int input = 103;
            int input2 = 90;
            int input3 = 89;
            int input4 = 205;

            //Act
            bool result = _exercise.IsWithin10Of100Or200(input);
            bool result2 = _exercise.IsWithin10Of100Or200(input2);
            bool result3 = _exercise.IsWithin10Of100Or200(input3);
            bool result4 = _exercise.IsWithin10Of100Or200(input4);

            //Assert
            result.Should().BeTrue();
            result2.Should().BeTrue();
            result3.Should().BeFalse();
            result4.Should().BeTrue();
        }

        [TestMethod]
        public void ShouldAddIfAtTheBeggining()
        {
            //Arrange
            string input = "if else";
            string input2 = "else";

            //Act
            string result = _exercise.AddIf(input);
            string result2 = _exercise.AddIf(input2);

            //Assert
            result.Should().Be("if else");
            result2.Should().Be("if else");
        }

        [TestMethod]
        public void ShouldRemoveCharacterAtPosition()
        {
            //Arrange
            string input = "Python";
            int position = 1;
            int position2 = 0;
            int position3 = 4;

            //Act
            string result = _exercise.RemoveAtPosition(input, position);
            string result2 = _exercise.RemoveAtPosition(input, position2);
            string result3 = _exercise.RemoveAtPosition(input, position3);

            //Assert
            result.Should().Be("Pthon");
            result2.Should().Be("ython");
            result3.Should().Be("Pythn");
        }

        [TestMethod]
        public void ShouldExchangeFirstAndLastCharacter()
        {
            //Arrange
            string input = "abcd";
            string input2 = "a";
            string input3 = "xy";

            //Act
            string result = _exercise.ExchangeFirstAndLast(input);
            string result2 = _exercise.ExchangeFirstAndLast(input2);
            string result3 = _exercise.ExchangeFirstAndLast(input3);

            //Assert
            result.Should().Be("dbca");
            result2.Should().Be("a");
            result3.Should().Be("yx");
        }

        [TestMethod]
        public void ShouldGenerateFourCopiesOfFirstCharacter()
        {
            //Arrange
            string input = "C Sharp";
            string input2 = "JS";
            string input3 = "a";

            //Act
            string result = _exercise.FourCoppiesOfFirstCharacter(input);
            string result2 = _exercise.FourCoppiesOfFirstCharacter(input2);
            string result3 = _exercise.FourCoppiesOfFirstCharacter(input3);

            //Assert
            result.Should().Be("C C C C");
            result2.Should().Be("JSJSJSJS");
            result3.Should().Be("a");
        }

        [TestMethod]
        public void ShouldAddLastCharacterAtFrontAndBack()
        {
            //Arrange
            string input = "Red";
            string input2 = "Green";
            string input3 = "1";

            //Act
            string result = _exercise.LastCharAtFrontAndBack(input);
            string result2 = _exercise.LastCharAtFrontAndBack(input2);
            string result3 = _exercise.LastCharAtFrontAndBack(input3);

            //Assert
            result.Should().Be("dRedd");
            result2.Should().Be("nGreenn");
            result3.Should().Be("111");
        }

        [TestMethod]
        public void ShouldBeMultipleOf3Or7()
        {
            //Arrange
            int input = 3;
            int input2 = 14;
            int input3 = 12;
            int input4 = 37;

            //Act
            bool result = _exercise.IsMultipleOf3Or7(input);
            bool result2 = _exercise.IsMultipleOf3Or7(input2);
            bool result3 = _exercise.IsMultipleOf3Or7(input3);
            bool result4 = _exercise.IsMultipleOf3Or7(input4);

            //Assert
            result.Should().BeTrue();
            result2.Should().BeTrue();
            result3.Should().BeTrue();
            result4.Should().BeFalse();
        }

        [TestMethod]
        public void ShouldAddFirstThreeCharactersAtFrontAndBack()
        {
            //Arrange
            string input = "Python";
            string input2 = "JS";
            string input3 = "Code";

            //Act
            string result = _exercise.AddFirstThreeCharAtFrontAndBack(input);
            string result2 = _exercise.AddFirstThreeCharAtFrontAndBack(input2);
            string result3 = _exercise.AddFirstThreeCharAtFrontAndBack(input3);

            //Assert
            result.Should().Be("PytPythonPyt");
            result2.Should().Be("JSJSJS");
            result3.Should().Be("CodCodeCod");
        }

        [TestMethod]
        public void ShouldCheckIfItStartsWithCSharp()
        {
            //Arrange
            string input = "C# Sharp";
            string input2 = "C#";
            string input3 = "C++";

            //Act
            bool result = _exercise.StartsWithCSharp(input);
            bool result2 = _exercise.StartsWithCSharp(input2);
            bool result3 = _exercise.StartsWithCSharp(input3);

            //Assert
            result.Should().BeTrue();
            result2.Should().BeTrue();
            result3.Should().BeFalse();
        }

        [TestMethod]
        public void ShouldTemperatureBeLessThan0AndMoreThan100()
        {
            //Arrange
            int[] input = { 120, -1 };
            int[] input2 = { -1, 120 };
            int[] input3 = { 2, 120 };

            //Act
            bool result = _exercise.CheckTemperatureLessThan0AndMoreThan100(input);
            bool result2 = _exercise.CheckTemperatureLessThan0AndMoreThan100(input2);
            bool result3 = _exercise.CheckTemperatureLessThan0AndMoreThan100(input3);

            //Assert
            result.Should().BeTrue();
            result2.Should().BeTrue();
            result3.Should().BeFalse();
        }

        [TestMethod]
        public void ShouldCheckIfOneIntIsBetween100And200()
        {
            //Arrange
            int[] input = { 100, 199 };
            int[] input2 = { 250, 300 };
            int[] input3 = { 105, 190 };

            //Act
            bool result = _exercise.IsBetween100And200(input);
            bool result2 = _exercise.IsBetween100And200(input2);
            bool result3 = _exercise.IsBetween100And200(input3);

            //Assert
            result.Should().BeTrue();
            result2.Should().BeFalse();
            result3.Should().BeTrue();
        }

        [TestMethod]
        public void ShouldCheckIfItsInRange20To50()
        {
            //Arrange
            int[] input = { 11, 20, 12 };
            int[] input2 = { 30, 30, 17 };
            int[] input3 = { 25, 35, 50 };
            int[] input4 = { 15, 12, 8 };

            //Act
            bool result = _exercise.IsInRange20To50(input);
            bool result2 = _exercise.IsInRange20To50(input2);
            bool result3 = _exercise.IsInRange20To50(input3);
            bool result4 = _exercise.IsInRange20To50(input4);

            //Assert
            result.Should().BeTrue();
            result2.Should().BeTrue();
            result3.Should().BeTrue();
            result4.Should().BeFalse();
        }

        [TestMethod]
        public void ShouldRemoveYTAtIndex1()
        {
            //Arrange
            string input = "Python";
            string input2 = "ytade";
            string input3 = "jsues";

            //Act
            string result = _exercise.RemoveYTAtIndex1(input);
            string result2 = _exercise.RemoveYTAtIndex1(input2);
            string result3 = _exercise.RemoveYTAtIndex1(input3);

            //Assert
            result.Should().Be("Phon");
            result2.Should().Be("ytade");
            result3.Should().Be("jsues");
        }

        [TestMethod]
        public void ShouldFindLargetsInt()
        {
            //Arrange
            int[] input = { 1, 2, 3 };
            int[] input2 = { 1, 3, 2 };
            int[] input3 = { 1, 1, 1 };
            int[] input4 = { 1, 2, 2 };

            //Act
            int result = _exercise.LargestInt(input);
            int result2 = _exercise.LargestInt(input2);
            int result3 = _exercise.LargestInt(input3);
            int result4 = _exercise.LargestInt(input4);

            //Assert
            result.Should().Be(3);
            result2.Should().Be(3);
            result3.Should().Be(1);
            result4.Should().Be(2);
        }

        [TestMethod]
        public void ShouldShowClosestTo100()
        {
            //Arrange
            int[] input = { 78, 95 };
            int[] input2 = { 95, 95 };
            int[] input3 = { 99, 70 };

            //Act
            int result = _exercise.IsClosestTo100(input);
            int result2 = _exercise.IsClosestTo100(input2);
            int result3 = _exercise.IsClosestTo100(input3);

            //Assert
            result.Should().Be(95);
            result2.Should().Be(0);
            result3.Should().Be(99);
        }

        [TestMethod]
        public void ShouldCheckIfBothIntsAreBetween40And50And60()
        {
            //Arrange
            int[] input = { 78, 95 };
            int[] input2 = { 25, 35 };
            int[] input3 = { 40, 50 };
            int[] input4 = { 55, 60 };

            //Act
            bool result = _exercise.IsBetween40_50Or50_60(input);
            bool result2 = _exercise.IsBetween40_50Or50_60(input2);
            bool result3 = _exercise.IsBetween40_50Or50_60(input3);
            bool result4 = _exercise.IsBetween40_50Or50_60(input4);

            //Assert
            result.Should().BeFalse();
            result2.Should().BeFalse();
            result3.Should().BeTrue();
            result4.Should().BeTrue();
        }

        [TestMethod]
        public void ShouldFindLargestBetween20_30()
        {
            //Arrange
            int[] input = { 78, 95 };
            int[] input2 = { 20, 30 };
            int[] input3 = { 21, 25 };
            int[] input4 = { 28, 28 };

            //Act
            int result = _exercise.IsLargestBetween20_30(input);
            int result2 = _exercise.IsLargestBetween20_30(input2);
            int result3 = _exercise.IsLargestBetween20_30(input3);
            int result4 = _exercise.IsLargestBetween20_30(input4);

            //Assert
            result.Should().Be(0);
            result2.Should().Be(30);
            result3.Should().Be(25);
            result4.Should().Be(28);
        }

        [TestMethod]
        public void ShouldHave2Or4Zs()
        {
            //Arrange
            string input = "frizz";
            string input2 = "zane";
            string input3 = "Zazz";
            string input4 = "false";
            string input5 = "zzzz";
            string input6 = "ZZZZ";

            //Act
            bool result = _exercise.HasBetween2Or4Zs(input);
            bool result2 = _exercise.HasBetween2Or4Zs(input2);
            bool result3 = _exercise.HasBetween2Or4Zs(input3);
            bool result4 = _exercise.HasBetween2Or4Zs(input4);
            bool result5 = _exercise.HasBetween2Or4Zs(input5);
            bool result6 = _exercise.HasBetween2Or4Zs(input6);

            //Assert
            result.Should().BeTrue();
            result2.Should().BeFalse();
            result3.Should().BeTrue();
            result4.Should().BeFalse();
            result5.Should().BeTrue();
            result6.Should().BeTrue();
        }

        [TestMethod]
        public void ShouldHaveSameLastDigit()
        {
            //Arrange
            int[] input = { 123, 456 };
            int[] input2 = { 12, 512 };
            int[] input3 = { 7, 87 };
            int[] input4 = { 12, 45 };

            //Act
            bool result = _exercise.HasSameLastDigit(input);
            bool result2 = _exercise.HasSameLastDigit(input2);
            bool result3 = _exercise.HasSameLastDigit(input3);
            bool result4 = _exercise.HasSameLastDigit(input4);

            //Assert
            result.Should().BeFalse();
            result2.Should().BeTrue();
            result3.Should().BeTrue();
            result4.Should().BeFalse();
        }

        [TestMethod]
        public void ShouldUpperCaseLastThreeCharacters()
        {
            //Arrange
            string input = "Python";
            string input2 = "JavaScript";
            string input3 = "js";
            string input4 = "PHP";

            //Act
            string result = _exercise.UpperCaseLastThree(input);
            string result2 = _exercise.UpperCaseLastThree(input2);
            string result3 = _exercise.UpperCaseLastThree(input3);
            string result4 = _exercise.UpperCaseLastThree(input4);

            //Assert
            result.Should().Be("PytHON");
            result2.Should().Be("JavaScrIPT");
            result3.Should().Be("JS");
            result4.Should().Be("PHP");
        }

        [TestMethod]
        public void ShouldCopyTheStringByNTimes()
        {
            //Arrange
            string input = "JS";
            int repeat = 2;
            int repeat2 = 3;
            int repeat3 = 1;

            //Act
            string result = _exercise.CopyStringByNTimes(input, repeat);
            string result2 = _exercise.CopyStringByNTimes(input, repeat2);
            string result3 = _exercise.CopyStringByNTimes(input, repeat3);

            //Assert
            result.Should().Be("JSJS");
            result2.Should().Be("JSJSJS");
            result3.Should().Be("JS");
        }

        [TestMethod]
        public void ShouldCreateNCopiesOfFirstThreeCharacters()
        {
            //Arrange
            string text = "Python";
            int repeats = 2;
            int repeats2 = 3;
            string text2 = "JS";

            //Act
            string result = _exercise.CopyOfThreeCharacters(text, repeats);
            string result2 = _exercise.CopyOfThreeCharacters(text, repeats2);
            string result3 = _exercise.CopyOfThreeCharacters(text2, repeats2);

            //Arrange
            result.Should().Be("PytPyt");
            result2.Should().Be("PytPytPyt");
            result3.Should().Be("JSJSJS");
        }

        [TestMethod]
        public void ShouldCountHowManyAAOfSelectedString()
        {
            //Arrange
            string input = "bbaaccaag";
            string input2 = "jjkiaaasew";
            string input3 = "JSaaakoiaa";

            //Act
            int result = _exercise.StringPartCounter(input);
            int result2 = _exercise.StringPartCounter(input2);
            int result3 = _exercise.StringPartCounter(input3);

            //Assert
            result.Should().Be(2);
            result2.Should().Be(2);
            result3.Should().Be(3);
        }

        [TestMethod]
        public void ShouldCheckIfFirstAIsFollowedByAnotherA()
        {
            //Arrange
            string input = "caabb";
            string input2 = "babaaba";
            string input3 = "aaaaa";

            //Act
            bool result = _exercise.HasAnAAfterFirstA(input);
            bool result2 = _exercise.HasAnAAfterFirstA(input2);
            bool result3 = _exercise.HasAnAAfterFirstA(input3);

            //Assert
            result.Should().BeTrue();
            result2.Should().BeFalse();
            result3.Should().BeTrue();
        }

        [TestMethod]
        public void ShouldReturnAStringWithEveryOtherCharacter()
        {
            //Arrange
            string input = "Python";
            string input2 = "PHP";
            string input3 = "JS";

            //Act
            string result = _exercise.EveryOtherCharacter(input);
            string result2 = _exercise.EveryOtherCharacter(input2);
            string result3 = _exercise.EveryOtherCharacter(input3);

            //Assert
            result.Should().Be("Pto");
            result2.Should().Be("PP");
            result3.Should().Be("J");
        }

        [TestMethod]
        public void ShouldReturnACumulativeSubstring()
        {
            //Arrange
            string input = "abcd";
            string input2 = "abc";
            string input3 = "a";

            //Act
            string result = _exercise.CumulativeSubstring(input);
            string result2 = _exercise.CumulativeSubstring(input2);
            string result3 = _exercise.CumulativeSubstring(input3);

            //Assert
            result.Should().Be("aababcabcd");
            result2.Should().Be("aababc");
            result3.Should().Be("a");
        }

        [TestMethod]
        public void ShouldCountHowManyOccurencesOfSubstring()
        {
            //Arrange
            string input = "abcdsab";
            string input2 = "abcdabab";
            string input3 = "abcabdabab";
            string input4 = "abcabd";

            //Act
            int result = _exercise.RepeatOfTwoFirstCharacters(input);
            int result2 = _exercise.RepeatOfTwoFirstCharacters(input2);
            int result3 = _exercise.RepeatOfTwoFirstCharacters(input3);
            int result4 = _exercise.RepeatOfTwoFirstCharacters(input4);

            //Assert
            result.Should().Be(1);
            result2.Should().Be(2);
            result3.Should().Be(3);
            result4.Should().Be(0);
        }

        [TestMethod]
        public void ShouldCheckIfElementIsPresentInArray()
        {
            //Arrange
            int[] array = { 1, 2, 9, 3 };
            int[] array2 = { 1, 2, 2, 3 };

            int input = 3;
            int input2 = 2;
            int input3 = 9;

            //Act
            bool result = _exercise.HasTheElement(array, input);
            bool result2 = _exercise.HasTheElement(array2, input2);
            bool result3 = _exercise.HasTheElement(array2, input3);

            //Assert
            result.Should().BeTrue();
            result2.Should().BeTrue();
            result3.Should().BeFalse();
        }

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

        [TestMethod]
        public void ShouldCheckIfHasTheSequence123()
        {
            //Arrange
            int[] array = { 1, 1, 2, 3, 1 };
            int[] array2 = { 1, 1, 2, 4, 1 };
            int[] array3 = { 1, 1, 2, 1, 2, 3 };

            //Act
            bool result = _exercise.HasSequence123(array);
            bool result2 = _exercise.HasSequence123(array2);
            bool result3 = _exercise.HasSequence123(array3);

            //Assert
            result.Should().BeTrue();
            result2.Should().BeFalse();
            result3.Should().BeTrue();
        }

        [TestMethod]
        public void ShouldCountMatchingSubstringsInStrings()
        {
            //Arrange
            string[] array = { "abcdefgh", "abijsklm" };
            string[] array2 = { "abcde", "osuefrcd" };
            string[] array3 = { "pqrstuvwx", "pqkdiewx" };

            //Assert
            int result = _exercise.SubstringMatchingCount(array);
            int result2 = _exercise.SubstringMatchingCount(array2);
            int result3 = _exercise.SubstringMatchingCount(array3);

            //Assert
            result.Should().Be(1);
            result2.Should().Be(1);
            result3.Should().Be(2);
        }

        [TestMethod]
        public void ShouldRemoveCharacterExceptFirstAndLast()
        {
            //Arrange
            string input = "xxHxix";
            char remove = 'x';
            string input2 = "abxdddca";
            char remove2 = 'a';
            string input3 = "xabjbhtrb";
            char remove3 = 'b';

            //Act
            string result = _exercise.RemoveCharExceptFirstAndLast(input, remove);
            string result2 = _exercise.RemoveCharExceptFirstAndLast(input2, remove2);
            string result3 = _exercise.RemoveCharExceptFirstAndLast(input3, remove3);

            //Assert
            result.Should().Be("xHix");
            result2.Should().Be("abxdddca");
            result3.Should().Be("xajhtrb");
        }

        [TestMethod]
        public void ShouldCreateAStringBasedOnIndex()
        {
            //Arrange
            string input = "Python";
            string input2 = "JavaScript";
            string input3 = "HTML";
            int[] index = { 0, 1, 4, 5, 8, 9 };

            //Act
            string result = _exercise.StringCreatorByIndex(input, index);
            string result2 = _exercise.StringCreatorByIndex(input2, index);
            string result3 = _exercise.StringCreatorByIndex(input3, index);

            //Assert
            result.Should().Be("Pyon");
            result2.Should().Be("JaScpt");
            result3.Should().Be("HT");
        }

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

        [TestMethod]
        public void ShouldSumOrReturn30()
        {
            //Arrange
            int[] array = { 12, 17 };
            int[] array2 = { 2, 17 };
            int[] array3 = { 22, 17 };
            int[] array4 = { 20, 0 };

            //Act
            int result = _exercise.SumOrReturn30(array);
            int result2 = _exercise.SumOrReturn30(array2);
            int result3 = _exercise.SumOrReturn30(array3);
            int result4 = _exercise.SumOrReturn30(array4);

            //Assert
            result.Should().Be(29);
            result2.Should().Be(30);
            result3.Should().Be(39);
            result4.Should().Be(30);
        }

        [TestMethod]
        public void ShouldFind5OrSumOrDifference5()
        {
            //Arrange
            int[] input = { 5, 4 };
            int[] input2 = { 4, 3 };
            int[] input3 = { 1, 4 };
            int[] input4 = { 15, 10 };

            //Act
            bool result = _exercise.HasA5Value(input);
            bool result2 = _exercise.HasA5Value(input2);
            bool result3 = _exercise.HasA5Value(input3);
            bool result4 = _exercise.HasA5Value(input4);

            //Assert
            result.Should().BeTrue();
            result2.Should().BeFalse();
            result3.Should().BeTrue();
            result4.Should().BeTrue();
        }

        [TestMethod]
        public void ShouldCheckIfItsAMultipleOf17Or1More()
        {
            //Arrange
            int input = 17;
            int input2 = 18;
            int input3 = 35;
            int input4 = 53;

            //Act
            bool result = _exercise.IsMultipleOf17Or1More(input);
            bool result2 = _exercise.IsMultipleOf17Or1More(input2);
            bool result3 = _exercise.IsMultipleOf17Or1More(input3);
            bool result4 = _exercise.IsMultipleOf17Or1More(input4);

            //Assert
            result.Should().BeTrue();
            result2.Should().BeTrue();
            result3.Should().BeTrue();
            result4.Should().BeFalse();
        }

        [TestMethod]
        public void ShouldBeMultipleOf3Or7NotBoth()
        {
            //Arrange
            int input = 3;
            int input2 = 7;
            int input3 = 21;

            //Act
            bool result = _exercise.IsNotMultipleOf3And7(input);
            bool result2 = _exercise.IsNotMultipleOf3And7(input2);
            bool result3 = _exercise.IsNotMultipleOf3And7(input3);

            //Assert
            result.Should().BeTrue();
            result2.Should().BeTrue();
            result3.Should().BeFalse();
        }

        [TestMethod]
        public void ShouldBeWithin2OfMultipleOf10()
        {
            //Arrange
            int input = 3;
            int input2 = 7;
            int input3 = 8;
            int input4 = 21;

            //Act
            bool result = _exercise.IsWithin2OfMultipleOf10(input);
            bool result2 = _exercise.IsWithin2OfMultipleOf10(input2);
            bool result3 = _exercise.IsWithin2OfMultipleOf10(input3);
            bool result4 = _exercise.IsWithin2OfMultipleOf10(input4);

            //Assert
            result.Should().BeFalse();
            result2.Should().BeFalse();
            result3.Should().BeTrue();
            result4.Should().BeTrue();
        }

        [TestMethod]
        public void ShouldReturn18IfOneValueIsBetween10And20()
        {
            //Arrange
            int[] input = { 3, 7 };
            int[] input2 = { 10, 11 };
            int[] input3 = { 10, 20 };
            int[] input4 = { 21, 220 };

            //Act
            int result = _exercise.SumOrReturn18(input);
            int result2 = _exercise.SumOrReturn18(input2);
            int result3 = _exercise.SumOrReturn18(input3);
            int result4 = _exercise.SumOrReturn18(input4);

            //Assert
            result.Should().Be(10);
            result2.Should().Be(18);
            result3.Should().Be(18);
            result4.Should().Be(241);
        }

        [TestMethod]
        public void ShouldThirdBeSumOfOtherTwo()
        {
            //Arrange
            int[] array = { 1, 2, 3 };
            int[] array2 = { 4, 5, 6 };
            int[] array3 = { -1, 1, 0 };

            //Act
            bool result = _exercise.IsThirdSumOfOtherTwo(array);
            bool result2 = _exercise.IsThirdSumOfOtherTwo(array2);
            bool result3 = _exercise.IsThirdSumOfOtherTwo(array3);

            //Assert
            result.Should().BeTrue();
            result2.Should().BeFalse();
            result3.Should().BeTrue();
        }

        [TestMethod]
        public void ShouldBeNumericOrder()
        {
            //Arrange
            int[] array = { 1, 2, 3 };
            int[] array2 = { 4, 5, 6 };
            int[] array3 = { -1, 1, 0 };

            //Act
            bool result = _exercise.IsAscendingOrder(array);
            bool result2 = _exercise.IsAscendingOrder(array2);
            bool result3 = _exercise.IsAscendingOrder(array3);

            //Assert
            result.Should().BeTrue();
            result2.Should().BeTrue();
            result3.Should().BeFalse();
        }

        [TestMethod]
        public void ShouldHaveSameDigit()
        {
            //Arrange
            int[] input = { 11, 21, 31 };
            int[] input2 = { 11, 22, 31 };
            int[] input3 = { 11, 22, 33 };

            //Act
            bool result = _exercise.HasTheSameDigit(input);
            bool result2 = _exercise.HasTheSameDigit(input2);
            bool result3 = _exercise.HasTheSameDigit(input3);

            //Assert
            result.Should().BeTrue();
            result2.Should().BeTrue();
            result3.Should().BeFalse();
        }
    }
}