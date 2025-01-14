using System.Drawing;
using System.Xml.Linq;
using System.Xml.XPath;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackLibrary;

namespace StackTests
{
    [TestClass]
    public class StackTestClass
    {
        private readonly Stack _exercises;

        public StackTestClass()
        {
            _exercises = new Stack(5);
        }

        [TestMethod]
        public void ShouldReturnTrueIfStackIsEmpty()
        {
            //Act
            bool result = _exercises.IsEmpty();

            result.Should().BeTrue();
        }

        [TestMethod]
        [DataRow(new int[] { 10, 20, 30, 40, 50 })]
        public void ShouldReturnTrueIfStackIsFull(int[] input)
        {
            //Arrange
            foreach (int item in input)
            {
                _exercises.Push(item);
            }

            //Act
            bool result = _exercises.IsFull();

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        [DataRow(new int[] { 10, 20, 30, 40, 50 }, 5)]
        public void ShouldReturnTheNumberOfElementsInStack(int[] stack, int expectedResult)
        {
            //Arrange
            foreach (var item in stack)
            {
                _exercises.Push(item);
            }

            //Act
            int result = Stack.Size(_exercises);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(new int[] { 10, 20, 30, 40, 50 }, 20)]
        public void ShouldReturnAndRemoveTopElement(int[] input, int expectedResult)
        {
            //Arrange
            foreach (int item in input)
            {
                _exercises.Push(item);
            }

            //Act
            _exercises.Pop();
            _exercises.Pop();
            _exercises.Pop();

            //Assert
            _exercises.Peek().Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(new int[] { 10, 20, 30, 40, 50 }, new int[] { 50, 40, 30, 20, 10 })]
        public void ShouldSortAllItemsInStackInDescendingOrder(int[] input, int[] expectedResult)
        {
            //Arrange
            foreach (int item in input)
            {
                _exercises.Push(item);
            }

            //Act
            Stack.SortByDescending(_exercises);

            //Assert
            int[] actualResult = new int[_exercises.items.Length];
            for (int i = 0; i < _exercises.items.Length; i++)
            {
                actualResult[i] = _exercises.Pop();
            }
            actualResult.Should().Equal(expectedResult);
        }

        [TestMethod]
        [DataRow(new int[] { 1, 3, 5, 7, 9 })]
        public void ShouldReturnAllValuesOnStack(int[] input)
        {
            //Arrange
            foreach (var item in input)
            {
                _exercises.Push(item);
            }

            //Act
            int[] result = Stack.Display(_exercises);

            //Assert
            result.Should().Equal(input);
        }

        [TestMethod]
        [DataRow(new int[] { 50, 10, 20, 30, 40 }, new int[] { 10, 20, 30, 40, 50 })]
        public void ShouldSortAllItemsInStackInAscendingOrder(int[] input, int[] expectedResult)
        {
            //Arrange
            foreach (int item in input)
            {
                _exercises.Push(item);
            }

            //Act
            Stack.SortByAscending(_exercises);

            //Assert
            int[] actualResult = new int[_exercises.items.Length];
            for (int i = 0; i < _exercises.items.Length; i++)
            {
                actualResult[i] = _exercises.Pop();
            }
            actualResult.Should().Equal(expectedResult);
        }

        [TestMethod]
        [DataRow(new int[] { 50, 10, 20, 30, 40 }, new int[] { 40, 30, 20, 10, 50 })]
        public void ShouldReverseAllElementsInStack(int[] stack, int[] expectedResult)
        {
            //Arrange
            foreach (int item in stack)
            {
                _exercises.Push(item);
            }

            //Act
            Stack result = Stack.Reverse(_exercises);

            //Assert
            int[] actualResult = new int[result.items.Length];
            for (int i = 0; i < result.items.Length; i++)
            {
                actualResult[i] = result.Pop();
            }
            actualResult.Should().Equal(expectedResult);
        }

        [TestMethod]
        [DataRow(new int[] { 50, 60, 70, 100, 45 }, 100)]
        [DataRow(new int[] { 1, 3, 5, 7, 9 }, 9)]
        public void ShouldReturnMaxValueFromStack(int[] stack, int expectedResult)
        {
            //Arrange
            foreach (int item in stack)
            {
                _exercises.Push(item);
            }

            //Act
            int result = _exercises.Max(_exercises);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(new int[] { 50, 60, 70, 100, 45 }, 45)]
        [DataRow(new int[] { 50, 20, 70, 100, 45 }, 20)]
        public void ShouldReturnMinValueFromStack(int[] stack, int expectedResult)
        {
            //Arrange
            foreach (int item in stack)
            {
                _exercises.Push(item);
            }

            //Act
            int result = _exercises.Min(_exercises);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(new int[] { 50, 60, 70, 100, 45 })]
        public void ShouldRemoveAllElementsFromStack(int[] stack)
        {
            //Arrange
            foreach (int item in stack)
            {
                _exercises.Push(item);
            }

            //Act
            Stack.RemoveAll(_exercises);

            //Assert
            _exercises.IsEmpty().Should().BeTrue();
        }

        [TestMethod]
        [DataRow(new int[] { 50, 60, 70, 100, 45 }, 70, new int[] { 50, 60, 100, 45 })]
        [DataRow(new int[] { 50, 60, 70, 100, 45 }, 100, new int[] { 50, 60, 70, 45 })]
        public void ShouldRemoveASpecificElementFromStack(int[] stack, int remove, int[] expectedResult)
        {
            //Arrange
            foreach (int item in stack)
            {
                _exercises.Push(item);
            }

            //Act
            Stack.Remove(_exercises, remove);
            int[] result = Stack.Display(_exercises);

            //Assert
            result.Should().Equal(expectedResult);
        }

        [TestMethod]
        [DataRow(new int[] { 50, 60, 70, 100, 45 }, 5)]
        public void ShouldCountHowManyElementsTheStackHas(int[] stack, int expectedResult)
        {
            //Arrange
            foreach (int item in stack)
            {
                _exercises.Push(item);
            }

            //Act
            int result = Stack.Count(_exercises);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(new int[] { 50, 60, 50, 100, 45 }, 50, 2)]
        [DataRow(new int[] { 50, 50, 50, 50, 50 }, 50, 5)]
        [DataRow(new int[] { 50, 60, 50, 100, 45 }, 90, 0)]
        public void ShouldCountHowManyElementsMatchesTheInput(int[] stack, int input, int expectedResult)
        {
            //Arrange
            foreach (int item in stack)
            {
                _exercises.Push(item);
            }

            //Act
            int result = Stack.CountSpecific(_exercises, input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(new int[] { 50, 60, 50, 100, 45 }, 50, true)]
        [DataRow(new int[] { 51, 3, 5, 7, 9 }, 7, true)]
        [DataRow(new int[] { 50, 60, 50, 100, 45 }, 90, false)]
        public void ShouldCheckIfStackContainsAnElement(int[] stack, int element, bool expectedResult)
        {
            //Arrange
            foreach (int item in stack)
            {
                _exercises.Push(item);
            }

            //Act
            bool result = Stack.Contains(_exercises, element);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(new int[] { 50, 60, 50, 100, 45 }, new int[] { 50, 60, 100, 45 })]
        public void ShouldRemoveDuplicates(int[] stack, int[] expectedResult)
        {
            //Arrange
            foreach (int item in stack)
            {
                _exercises.Push(item);
            }

            //Act
            Stack result = Stack.RemoveDuplicates(_exercises);

            //Assert
            int[] actualResult = new int[result.items.Length];
            for (int i = 0; i < result.items.Length; i++)
            {
                actualResult[i] = result.Pop();
            }
            actualResult.Should().Equal(expectedResult);
        }

        [TestMethod]
        [DataRow(new int[] { 50, 60, 50, 100, 45 }, new int[] { 50, 45 })]
        public void ShouldReturnTopAndBottomElementsFromStack(int[] stack, int[] expectedResult)
        {
            //Arrange
            foreach (int item in stack)
            {
                _exercises.Push(item);
            }

            //Act
            int[] result = Stack.FirstAndLast(_exercises);

            //
            result.Should().Equal(expectedResult);
        }

        [TestMethod]
        [DataRow(new int[] { 50, 60, 50, 100, 45 }, new int[] { 45, 100, 50, 60, 50 })]
        public void ShouldRotateStack(int[] stack, int[] expectedResult)
        {
            //Arrange
            foreach (int item in stack)
            {
                _exercises.Push(item);
            }

            //Act
            Stack.Rotate(_exercises);

            //Assert
            int[] actualResult = new int[_exercises.items.Length];
            for (int i = 0; i < _exercises.items.Length; i++)
            {
                actualResult[i] = _exercises.Pop();
            }
            actualResult.Should().Equal(expectedResult);
        }

        [TestMethod]
        [DataRow(new int[] { 50, 60, 50, 100, 45 }, new int[] { 60, 50, 50, 100, 45 })]
        public void ShouldSwapTopTwoElementsOfStack(int[] stack, int[] expectedResult)
        {
            //Arrange
            foreach (int item in stack)
            {
                _exercises.Push(item);
            }

            //Act
            Stack.SwapTwoFirsts(_exercises);

            //Assert
            int[] actualResult = new int[_exercises.items.Length];
            for (int i = 0; i < _exercises.items.Length; i++)
            {
                actualResult[i] = _exercises.Pop();
            }
            actualResult.Should().Equal(expectedResult);
        }

        [TestMethod]
        [DataRow(new int[] { 50, 60, 50, 100, 45 }, 3, 50)]
        public void ShouldReturnTheNthElementFromStack(int[] stack, int index, int expectedResult)
        {
            //Arrange
            foreach (int item in stack)
            {
                _exercises.Push(item);
            }

            //Act
            int result = Stack.ReturnByIndex(_exercises, index);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(new int[] { 40, 50, 60, 70, 80 }, new int[] { 90, 100, 110, 120, 130 }, new int[] { 40, 50, 60, 70, 80, 90, 100, 110, 120, 130 })]
        public void ShouldMergeTwoStacksInOne(int[] arrayOne, int[] arrayTwo, int[] expectedResult)
        {
            //Arrange
            var stackOne = new Stack(arrayOne.Length);
            var stackTwo = new Stack(arrayTwo.Length);
            foreach (var item in arrayOne)
            {
                stackOne.Push(item);
            }
            foreach (var item in arrayTwo)
            {
                stackTwo.Push(item);
            }

            //Act
            Stack result = Stack.Merge(stackOne, stackTwo);

            //Assert
            int[] actualResult = new int[result.items.Length];
            for (int i = 0; i < result.items.Length; i++)
            {
                actualResult[i] = result.Pop();
            }
            actualResult.Reverse().Should().Equal(expectedResult);
        }

        [TestMethod]
        [DataRow(new int[] { 40, 60, 70 }, new int[] { 40, 50, 60, 70, 80 }, true)]
        [DataRow(new int[] { 40, 60, 90 }, new int[] { 40, 50, 60, 70, 80 }, false)]
        public void ShouldCheckIfFirstStackIsSubsetOfSecondStack(int[] stackOne, int[] stackTwo, bool expectedResult)
        {
            //Arrange
            var stackCheck = new Stack(stackOne.Length);
            foreach (var item in stackOne)
            {
                stackCheck.Push(item);
            }
            foreach (var item in stackTwo)
            {
                _exercises.Push(item);
            }

            //Act
            bool result = Stack.IsSubset(stackCheck, _exercises);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(new int[] { 40, 50, 60, 70, 80 }, new int[] { 40, 50, 60, 70, 80 }, true)]
        [DataRow(new int[] { 40, 50, 60, 50, 80 }, new int[] { 40, 50, 60, 70, 80 }, true)]
        public void ShouldCheckIfTwoStacksAreEqual(int[] stackOne, int[] stackTwo, bool expectedResult)
        {
            //Arrange
            var stackCheck = new Stack(stackOne.Length);
            foreach (var item in stackOne)
            {
                stackCheck.Push(item);
            }
            foreach (var item in stackTwo)
            {
                _exercises.Push(item);
            }

            //Act
            bool result = Stack.IsSubset(stackCheck, _exercises);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(new int[] { 20, 30, 40, 50, 60 }, new int[] { 50, 60, 80, 90, 100 }, new int[] { 50, 60 })]
        [DataRow(new int[] { 20, 30, 40, 50, 60 }, new int[] { 20, 30, 40, 90, 100 }, new int[] { 20, 30, 40 })]
        public void ShouldReturnCommonElementsFromTwoStacks(int[] arrayOne, int[] arrayTwo, int[] expectedResult)
        {
            //Arrange
            var stackOne = new Stack(arrayOne.Length);
            foreach (var item in arrayOne)
            {
                stackOne.Push(item);
            }
            foreach (var item in arrayTwo)
            {
                _exercises.Push(item);
            }

            //Act
            int[] result = Stack.Commom(stackOne, _exercises);

            //Assert
            result.Should().Equal(expectedResult);
        }

        [TestMethod]
        [DataRow(new int[] { 20, 30, 40, 50, 60 }, new int[] { 50, 60, 80, 90, 100 }, new int[] { 20, 30, 40 })]
        [DataRow(new int[] { 20, 30, 40, 50, 60 }, new int[] { 20, 30, 40, 90, 100 }, new int[] { 50, 60 })]
        public void ShouldReturnValuesFromFirstStackThatAreNotPresentOnSecondStack(int[] arrayOne, int[] arrayTwo, int[] expectedResult)
        {
            //Arrange
            var stackOne = new Stack(arrayOne.Length);
            foreach (var item in arrayOne)
            {
                stackOne.Push(item);
            }
            foreach (var item in arrayTwo)
            {
                _exercises.Push(item);
            }

            //Act
            int[] result = Stack.ElementsOnlyFirst(stackOne, _exercises);

            //Assert
            result.Should().Equal(expectedResult);
        }

        [TestMethod]
        [DataRow(new int[] { 20, 30, 40, 50, 60 }, new int[] { 50, 60, 80, 90, 100 }, new int[] { 20, 30, 40, 50, 60, 80, 90, 100 })]
        [DataRow(new int[] { 20, 30, 40, 50, 60 }, new int[] { 20, 30, 40, 90, 100 }, new int[] { 20, 30, 40, 50, 60, 90, 100 })]
        public void ShouldReturnNewStackWithoutDuplicates(int[] arrayOne, int[] arrayTwo, int[] expectedResult)
        {
            //Arrange
            var stackOne = new Stack(arrayOne.Length);
            foreach (var item in arrayOne)
            {
                stackOne.Push(item);
            }
            foreach (var item in arrayTwo)
            {
                _exercises.Push(item);
            }

            //Act
            Stack result = Stack.MergeWithoutDupes(stackOne, _exercises);

            //Assert
            int[] actualResult = new int[result.items.Length];
            for (int i = 0; i < result.items.Length; i++)
            {
                actualResult[i] = result.Pop();
            }
            actualResult.Reverse().Should().Equal(expectedResult);
        }

        [TestMethod]
        [DataRow(new int[] { 20, 30, 40, 50, 60 }, new int[] { 50, 60, 80, 90, 100 }, new int[] { 20, 30, 40, 50, 60, 80, 90, 100 })]
        [DataRow(new int[] { 20, 30, 40, 50, 60 }, new int[] { 20, 30, 40, 90, 100 }, new int[] { 20, 30, 40, 50, 60, 90, 100 })]
        public void ShouldReturnNewStackWithElementsOnlyInOneStackButNotBoth(int[] arrayOne, int[] arrayTwo, int[] expectedResult)
        {
            //Arrange
            var stackOne = new Stack(arrayOne.Length);
            foreach (var item in arrayOne)
            {
                stackOne.Push(item);
            }
            foreach (var item in arrayTwo)
            {
                _exercises.Push(item);
            }

            //Act
            Stack stack = Stack.MergeUnion(stackOne, _exercises);

            //Assert
            int[] result = new int[stack.items.Length];
            for (int i = 0; i < stack.items.Length; i++)
            {
                result[i] = stack.Pop();
            }
            result.Reverse().Should().Equal(expectedResult);
        }

        [TestMethod]
        [DataRow(new int[] { 20, 30, 40, 50, 60 }, 3, new int[] { 20, 30, 40 })]
        public void ShouldReturnANewStackWithNValuesOfTheFirstOne(int[] stack, int values, int[] expectedResult)
        {
            //Arrange
            foreach (var item in stack)
            {
                _exercises.Push(item);
            }

            //Act
            Stack stackResult = Stack.SubStack(_exercises, values);

            //Assert
            int[] result = new int[stackResult.items.Length];
            for (int i = 0; i < stackResult.items.Length; i++)
            {
                result[i] = stackResult.Pop();
            }
            result.Reverse().Should().Equal(expectedResult);
        }

        public static IEnumerable<object[]> SatisfyCondition
        {
            get
            {
                return new[]
                {
                    new object[]
                    {
                        new int[] { 2, 4, 6, 8, 10 },
                        (Func<int, bool>)(x => x % 2 == 0),
                        true
                    },
                    new object[]
                    {
                        new int[] { 2, 3, 5, 7, 9 },
                        (Func<int, bool>)(x => x % 2 != 0),
                        false
                    }
                };
            }
        }

        [TestMethod]
        [DynamicData(nameof(SatisfyCondition))]
        public void ShouldCheckIfAllValuesSatisfyACondition(int[] stack, Func<int, bool> condition, bool expectedResult)
        {
            //Arrange
            foreach (var item in stack)
            {
                _exercises.Push(item);
            }

            //Act
            bool result = Stack.IsAllSatisfied(_exercises, condition);

            //Assert
            result.Should().Be(expectedResult);
        }

        public static IEnumerable<object[]> OneSatisfyCondition
        {
            get
            {
                return new[]
                {
                    new object[]
                    {
                        new int[] { 2, 5, 7, 9, 11 },
                        (Func<int, bool>)(x => x % 2 == 0),
                        true
                    },
                    new object[]
                    {
                        new int[] { 2, 4, 6, 8, 10 },
                        (Func<int, bool>)(x => x % 2 != 0),
                        false
                    }
                };
            }
        }

        [TestMethod]
        [DynamicData(nameof(OneSatisfyCondition))]
        public void ShouldCheckIfAtLeastOneValueSatisfyACondition(int[] stack, Func<int, bool> condition, bool expectedResult)
        {
            //Arrange
            foreach (var item in stack)
            {
                _exercises.Push(item);
            }

            //Act
            bool result = Stack.IsOneSatisfied(_exercises, condition);

            //Assert
            result.Should().Be(expectedResult);
        }

        public static IEnumerable<object[]> StackSatisfyingCondition
        {
            get
            {
                return new[]
                {
                    new object[]
                    {
                        new int[] { 2, 5, 8, 9, 12 },
                        (Func<int, bool>)(x => x % 2 == 0),
                        new int[] { 2, 8, 12 }
                    },
                    new object[]
                    {
                        new int[] { 3, 4, 7, 8, 10 },
                        (Func<int, bool>)(x => x % 2 != 0),
                        new int[] { 3, 7 }
                    }
                };
            }
        }

        [TestMethod]
        [DynamicData(nameof(StackSatisfyingCondition))]
        public void ShouldReturnANewStackOnlyBySatisfyingConditionValues(int[] stack, Func<int, bool> condition, int[] expectedResult)
        {
            //Arrange
            foreach (var item in stack)
            {
                _exercises.Push(item);
            }

            //Act
            Stack stackResult = Stack.ConditionaryStack(_exercises, condition);

            //Assert
            int[] result = new int[stackResult.items.Length];
            for(int i = 0; i < stackResult.items.Length; i++)
            {
                result[i] = stackResult.Pop();
            }
            result.Reverse().Should().Equal(expectedResult);
        }
    }
}