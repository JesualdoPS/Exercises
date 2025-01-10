using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using ArrayLibrary;
using System.Reflection;
using System.Runtime.InteropServices.ObjectiveC;
using System.Xml.XPath;
using System.Net.NetworkInformation;

namespace ArrayTests
{
    [TestClass]
    public class ArrayTestClass
    {
        private readonly ArrayClass _exercises;

        public ArrayTestClass()
        {
            _exercises = new ArrayClass();
        }

        [TestMethod]
        [DataRow(1, 9, "1,2,3,4,5,6,7,8,9,10")]
        public void ShouldPrintElementsInArray(int start, int end, string expectedResult)
        {
            //Act
            string result = _exercises.PrintArray(start, end);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(new int[] { 2, 5, 7 }, "7 5 2")]
        [DataRow(new int[] { 3, 5, 7, 5, 1, 4, 6 }, "6 4 1 5 7 5 3")]
        public void ShouldReturnReverseArray(int[] values, string expectedResult)
        {
            //Act
            string result = _exercises.ReverseArray(values);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(new int[] { 0, 5, 8 }, 13)]
        [DataRow(new int[] { 4, 5, 4, 1, 8, 4, 6 }, 32)]
        public void ShouldSumAllElementsInArray(int[] values, int expectedResult)
        {
            //Act
            int result = _exercises.SumOfArray(values);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(new int[] { 15, 10, 12 }, new int[] { 15, 10, 12 })]
        public void ShouldCopyArray(int[] values, int[] expectedResult)
        {
            //Act
            int[] result = _exercises.CopyArray(values);

            //Assert
            result.Should().Equal(expectedResult);
        }

        [TestMethod]
        [DataRow(new int[] { 5, 1, 1 }, 1)]
        [DataRow(new int[] { 5, 5, 4, 6, 2, 8, 2, 6 }, 3)]
        public void ShouldReturnHowManyDuplicated(int[] input, int expectedResult)
        {
            //Act
            int result = _exercises.Duplicated(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(new int[] { 1, 5, 1 }, new int[] { 5 })]
        [DataRow(new int[] { 3, 3, 9, 8, 2, 1, 1 }, new int[] { 9, 8, 2 })]
        [DataRow(new int[] { 1, 5, 5, 8, 4, 9, 4, 8 }, new int[] { 1, 9 })]
        public void ShouldReturnUniqueElements(int[] values, int[] expectedResult)
        {
            //Act
            int[] result = _exercises.UniqueElements(values);

            //Assert
            result.Should().Equal(expectedResult);
        }

        [TestMethod]
        [DataRow(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 }, new int[] { 1, 1, 2, 2, 3, 3 })]
        [DataRow(new int[] { 1, 2, 6 }, new int[] { 4, 5, 3 }, new int[] { 1, 2, 3, 4, 5, 6 })]
        public void ShouldMergeArraysInOrder(int[] array1, int[] array2, int[] expectedResult)
        {
            //Act
            int[] result = _exercises.MergeArrays(array1, array2);

            //Assert
            result.Should().Equal(expectedResult);
        }

        [TestMethod]
        [DataRow(new int[] { 25, 12, 43 }, "25 occurs 1 times, 12 occurs 1 times, 43 occurs 1 times")]
        [DataRow(new int[] { 25, 12, 43, 25 }, "25 occurs 2 times, 12 occurs 1 times, 43 occurs 1 times")]
        [DataRow(new int[] { 25, 12, 43, 67 }, "25 occurs 1 times, 12 occurs 1 times, 43 occurs 1 times, 67 occurs 1 times")]
        [DataRow(new int[] { 25, 12, 12 }, "25 occurs 1 times, 12 occurs 2 times")]
        public void ShouldCountFrequencyOfValuesOnArray(int[] array, string expectedResult)
        {
            //Act
            string result = _exercises.ValueCounter(array);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(new int[] { 45, 25, 21 }, "Max element is 45 and Min element is 21")]
        public void ShouldReturnMaxAndMinOfArray(int[] array, string expectedResult)
        {
            //Act
            string result = _exercises.MaxAndMin(array);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(new int[] { 25, 47, 42, 56, 32 }, new int[] { 25, 47 }, new int[] { 42, 56, 32 })]
        public void ShouldReturnOddAndEvenElementsSeparately(int[] input, int[] odd, int[] even)
        {
            //Act
            (int[] Even, int[] Odd) result = _exercises.OddAndEvenSeparately(input);

            //Assert
            result.Even.Should().Equal(even);
            result.Odd.Should().Equal(odd);
        }

        [TestMethod]
        [DataRow(new int[] { 2, 7, 4, 5, 9 }, new int[] { 2, 4, 5, 7, 9 })]
        public void ShouldOrderByAscending(int[] input, int[] expectedResult)
        {
            //Act
            int[] result = _exercises.OrderArray(input);

            //Assert
            result.Should().Equal(expectedResult);
        }

        [TestMethod]
        [DataRow(new int[] { 2, 7, 4, 5, 9 }, new int[] { 9, 7, 5, 4, 2 })]
        public void ShouldOrderByDescending(int[] input, int[] expectedResult)
        {
            //Act
            int[] result = _exercises.DisorderArray(input);

            //Assert
            result.Should().Equal(expectedResult);
        }

        [TestMethod]
        [DataRow(8, new int[] { 5, 7, 9 }, new int[] { 5, 7, 8, 9 })]
        public void ShouldAddValueAndReturnOrdered(int insert, int[] input, int[] expectedResult)
        {
            //Act
            int[] result = _exercises.AddAndOrder(insert, input);

            //Assert
            result.Should().Equal(expectedResult);
        }

        [TestMethod]
        [DataRow(5, 2, new int[] { 1, 8, 7, 10 }, new int[] { 1, 5, 8, 7, 10 })]
        public void ShouldInsertValueToArrayOnIndex(int value, int position, int[] array, int[] expectedResult)
        {
            //Act
            int[] result = _exercises.InsertToIndex(value, position, array);

            //Assert
            result.Should().Equal(expectedResult);
        }

        [TestMethod]
        [DataRow(new int[] { 1, 2, 3, 4, 5 }, 2, new int[] { 1, 2, 4, 5 })]
        public void ShouldRemoveValueByIndex(int[] input, int index, int[] expectedResult)
        {
            //Act
            int[] result = _exercises.RemoveByIndex(input, index);

            //Assert
            result.Should().Equal(expectedResult);
        }

        [TestMethod]
        [DataRow(new int[] { 2, 9, 1, 4, 6 }, 6)]
        public void ShouldReturnTheSecondLargestNumber(int[] input, int expectedResult)
        {
            //Act
            int result = _exercises.SecondLargest(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(new int[] { 0, 9, 4, 6, 5 }, 4)]
        public void ShouldReturnTheSecondSmallestNumber(int[] input, int expectedResult)
        {
            //Act
            int result = _exercises.SecondSmallest(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 }, "1 2 3\n4 5 6\n7 8 9")]
        public void ShouldReturnAMatrix(int[] array0, int[] array1, int[] array2, string expectedResult)
        {
            //Act
            string result = _exercises.MatrixToString(new[] { array0, array1, array2 });

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(new int[] { 1, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, new int[] { 6, 8 }, new int[] { 10, 12 })]
        public void ShouldSumTwoMatrices(int[] array0, int[] array1, int[] array2, int[] array3, int[] expectedResult1, int[] expectedResult2)
        {
            //Arrange
            int[,] expectedResult = { { expectedResult1[0], expectedResult1[1] }, { expectedResult2[0], expectedResult2[1] } };

            //Act
            int[,] matrix1 = { { array0[0], array0[1] }, { array1[0], array1[1] } };
            int[,] matrix2 = { { array2[0], array2[1] }, { array3[0], array3[1] } };
            int[,] result = _exercises.MatrixSum(matrix1, matrix2);

            //Assert
            result.Should().BeEquivalentTo(expectedResult);
        }

        [TestMethod]
        [DataRow(new int[] { 5, 6 }, new int[] { 7, 8 }, new int[] { 1, 2 }, new int[] { 3, 4 }, new int[] { 4, 4 }, new int[] { 4, 4 })]
        public void ShouldSubtractTwoMatrices(int[] array0, int[] array1, int[] array2, int[] array3, int[] expectedResult1, int[] expectedResult2)
        {
            //Arrange
            int[,] expectedResult = { { expectedResult1[0], expectedResult1[1] }, { expectedResult2[0], expectedResult2[1] } };
            int[,] matrix1 = { { array0[0], array0[1] }, { array1[0], array1[1] } };
            int[,] matrix2 = { { array2[0], array2[1] }, { array3[0], array3[1] } };

            //Act
            int[,] result = _exercises.MatrixSubtract(matrix1, matrix2);

            //Assert
            result.Should().BeEquivalentTo(expectedResult);
        }

        [TestMethod]
        [DataRow(new int[] { 1, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, new int[] { 5, 12 }, new int[] { 21, 32 })]
        public void ShouldMultiplyTwoMatrices(int[] array0, int[] array1, int[] array2, int[] array3, int[] expectedResult1, int[] expectedResult2)
        {
            //Arrange
            int[,] expectedResult = { { expectedResult1[0], expectedResult1[1] }, { expectedResult2[0], expectedResult2[1] } };
            int[,] matrix1 = { { array0[0], array0[1] }, { array1[0], array1[1] } };
            int[,] matrix2 = { { array2[0], array2[1] }, { array3[0], array3[1] } };

            //Act
            int[,] result = _exercises.MatrixMultiply(matrix1, matrix2);

            //Assert
            result.Should().BeEquivalentTo(expectedResult);
        }

        [TestMethod]
        [DataRow(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 })]
        public void ShouldTransposeArrays(int[] array0, int[] array1, int[] array2)
        {
            // Arrange
            int[,] matrix = { { array0[0], array0[1], array0[2] }, { array1[0], array1[1], array1[2] }, { array2[0], array2[1], array2[2] } };
            int[,] expectedResult = { { array0[0], array1[0], array2[0] }, { array0[1], array1[1], array2[1] }, { array0[2], array1[2], array2[2] } };

            // Act
            int[,] result = _exercises.TransposeMatrix(matrix);

            // Assert
            result.Should().BeEquivalentTo(expectedResult);
        }

        [TestMethod]
        [DataRow(new int[] { 1, 2 }, new int[] { 3, 4 }, 5)]
        public void ShouldReturnTheSumOfDiagonalMatrix(int[] array0, int[] array1, int expectedResult)
        {
            //Arrange
            int[,] matrix = { { array0[0], array0[1] }, { array1[0], array1[1] } };

            //Act
            int result = _exercises.DiagonalSum(matrix);

            //Assert
            result.Should().Be(expectedResult);
        }

        public static IEnumerable<object[]> LeftDiagonalData
        {
            get
            {
                return new[]
                {
                    new object[]
                    {
                        new int[,]{{1,2,3},{4,5,6},{7,8,9}},
                        15,
                    },
                    new object[]
                    {
                        new int[,]{{1,5,9},{7,5,3},{4,5,6}},
                        18
                    }
                };
            }
        }
        [TestMethod]
        [DynamicData(nameof(LeftDiagonalData))]
        public void ShouldSumLeftDiagonal(int[,] matrix, int expectedResult)
        {
            //Act
            int result = _exercises.LeftDiagonalSum(matrix);

            //Assert
            result.Should().Be(expectedResult);
        }

        public static IEnumerable<object[]> SumRowAndColumnsData
        {
            get
            {
                return new[]
                {
                    new object[]
                    {
                        new int[,]{{5,6},{7,8}},
                        "The sum of rows are [11, 15], and the sum of columns are [12, 14]"
                    },
                    new object[]
                    {
                        new int[,]{{1,2,3},{4,5,6},{7,8,9}},
                        "The sum of rows are [6, 15, 24], and the sum of columns are [12, 15, 18]"
                    }
                };
            }
        }
        [TestMethod]
        [DynamicData(nameof(SumRowAndColumnsData))]
        public void ShouldSumRowsAndColumns(int[,] matrix, string expectedResult)
        {
            //Act
            string result = _exercises.SumRowsAndColumns(matrix);

            //Assert
            result.Should().Be(expectedResult);
        }

        public static IEnumerable<object[]> LowerTriangularData
        {
            get
            {
                return new[]
                {
                    new object[]
                    {
                        new int[,]{{1,2,3},{4,5,6},{7,8,9}},
                        new int[,]{{1,2,3},{0,5,6},{0,0,9}}
                    }
                };
            }
        }
        [TestMethod]
        [DynamicData(nameof(LowerTriangularData))]
        public void ShouldChangeLowerTriangleValuesToZero(int[,] matrix, int[,] expectedResult)
        {
            //Act
            int[,] result = _exercises.LowerTriangleToZero(matrix);

            //Assert
            result.Should().BeEquivalentTo(expectedResult);
        }

        public static IEnumerable<object[]> UpperTriangularData
        {
            get
            {
                return new[]
                {
                    new object[]
                    {
                        new int[,]{{1,2,3},{4,5,6},{7,8,9}},
                        new int[,]{{1,0,0},{4,5,0},{7,8,9}}
                    }
                };
            }
        }
        [TestMethod]
        [DynamicData(nameof(UpperTriangularData))]
        public void ShouldChangeUpperTriangleValuesToZero(int[,] matrix, int[,] expectedResult)
        {
            //Act
            int[,] result = _exercises.UpperTriangleToZero(matrix);

            //Assert
            result.Should().BeEquivalentTo(expectedResult);
        }

        public static IEnumerable<object[]> DeterminantOfMatrix
        {
            get
            {
                return new[]
                {
                    new object[]
                    {
                        new int[,]{{1,0,-1},{0,0,1},{-1,-1,0}},
                        1
                    }
                };
            }
        }
        [TestMethod]
        [DynamicData(nameof(DeterminantOfMatrix))]
        public void ShouldReturnTheDeterminantOfAMatrix(int[,] matrix, int expectedResult)
        {
            //Act
            int result = _exercises.Determinant(matrix);

            //Assert
            result.Should().Be(expectedResult);
        }

        public static IEnumerable<object[]> IsSparseMatrixData
        {
            get
            {
                return new[]
                {
                    new object[]
                    {
                        new int[,]{{0,0},{1,0}},
                        true
                    },
                    new object[]
                    {
                        new int[,]{{1,2,0},{1,0,3}},
                        false
                    }
                };
            }
        }
        [TestMethod]
        [DynamicData(nameof(IsSparseMatrixData))]
        public void ShouldCheckIfItsASparseMatrix(int[,] matrix, bool expectedResult)
        {
            //Act
            bool result = _exercises.IsSparseMatrix(matrix);

            //Assert
            result.Should().Be(expectedResult);
        }

        public static IEnumerable<object[]> IsMatrixEqual
        {
            get
            {
                return new[]
                {
                    new object[]
                    {
                        new int[,]{{1,2},{3,4}},
                        new int[,]{{1,2},{3,4}},
                        true
                    },
                    new object[]
                    {
                        new int[,]{{1,2},{3,4}},
                        new int[,]{{1,3},{5,4}},
                        false
                    }
                };
            }
        }
        [TestMethod]
        [DynamicData(nameof(IsMatrixEqual))]
        public void ShouldCheckIfMatricesAreEqual(int[,] matrix1, int[,] matrix2, bool expectedResult)
        {
            //Act
            bool result = _exercises.IsMatrixEqual(matrix1, matrix2);

            //Assert
            result.Should().Be(expectedResult);
        }

        public static IEnumerable<object[]> IsIdentityMatrix
        {
            get
            {
                return new[]
                {
                    new object[]
                    {
                        new int[,]{{1,0},{0,1}},
                        true
                    },
                    new object[]
                    {
                        new int[,]{{1,0},{1,1}},
                        false
                    },
                    new object[]
                    {
                        new int[,]{{1,0,0},{0,1,2}},
                        false
                    },
                    new object[]
                    {
                        new int[,]{{1,0,0},{0,1,0},{0,0,1}},
                        true
                    }
                };
            }
        }
        [TestMethod]
        [DynamicData(nameof(IsIdentityMatrix))]
        public void ShouldCheckIfItsAnIdentityMatrix(int[,] matrix, bool expectedResult)
        {
            //Act
            bool result = _exercises.IsIdentityMatrix(matrix);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, new int[] { 1, 3, 5, 7, 9 })]
        public void ShouldReturnOnlyOddValues(int[] input, int[] expectedResult)
        {
            //Act
            int[] result = _exercises.OddValues(input);

            //Assert
            result.Should().Equal(expectedResult);
        }

        public static IEnumerable<object[]> ArrayWithouRepeatedElementsData
        {
            get
            {
                return new[]
                {
                    new object[]
                    {
                        new object[] {25, "Anna", false, 25, new DateTime(2021, 04, 15, 12, 10, 51), 112.22, "Anna", false },
                        new object[] {25, "Anna", false, new DateTime(2021, 04, 15, 12, 10, 51), 112.22 },
                    }
                };
            }
        }
        [TestMethod]
        [DynamicData(nameof(ArrayWithouRepeatedElementsData))]
        public void ShouldReturnArrayWithoutRepeatedElements(object[] input, object[] expectedResult)
        {
            //Act
            object[] result = _exercises.ArrayWithoutRepeatedElements(input);

            //Assert
            result.Should().Equal(expectedResult);
        }

        [TestMethod]
        [DataRow(new int[] { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 }, 10, 20, 0)]
        [DataRow(new int[] { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 }, 10, 20, 10)]
        [DataRow(new int[] { 10, 11, 12, 13, 14, 16, 17, 18, 19, 20 }, 10, 20, 15)]
        [DataRow(new int[] { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 }, 10, 20, 20)]
        public void ShouldReturnMissingValue(int[] input, int start, int end, int expectedResult)
        {
            //Act
            int result = _exercises.MissingValue(input, start, end);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(new int[] { -10, -11, -12, -13, -14, 15, 16, 17, 18, 19, 20, }, -27)]
        [DataRow(new int[] { -1, -2, -4, 0, 3, 4, 5, 9 }, -6)]
        public void ShouldSumTheTwoLowestNumbersOfArray(int[] input, int expectedResult)
        {
            //Act
            int result = _exercises.SumOfTwoLowest(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(new int[] { -10, -11, -12, -13, -14, 15, 16, 17, 18, 19, 20 }, false)]
        [DataRow(new int[] { -1, -2, -3, 0, 1, 2, 3, 4 }, false)]
        [DataRow(new int[] { -3, -2, -1, 0, 1, 2, 3, 4 }, true)]
        public void ShouldCheckIfTheElementsOfArrayAreConsecutive(int[] input, bool expectedResult)
        {
            //Act
            bool result = _exercises.IsConsecutive(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(new int[] { 7, 5, 8, 9, 11, 23, 18 }, 1)]
        [DataRow(new int[] { 200, 300, 250, 151, 162 }, 11)]
        public void ShouldReturnTheSmallestGapBetweenElements(int[] input, int expectedResult)
        {
            //Act
            int result = _exercises.SmallestGap(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(new int[] { 7, 5, 85, 9, 11, 23, 18 }, "1", true)]
        [DataRow(new int[] { 7, 5, 85, 9, 11, 23, 18 }, "2", true)]
        [DataRow(new int[] { 7, 5, 85, 9, 11, 23, 18 }, "4", false)]
        public void ShouldCheckIfTheNumberIsPresent(int[] input, string check, bool expectedResult)
        {
            //Act
            bool result = _exercises.IsPresent(input, check);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(new int[] { 7, 5, 85, 9, 11, 23, 18 }, 46)]
        [DataRow(new int[] { 200, 300, 250, 151, 162 }, 151)]
        public void ShouldSumAllPrimeNumbersInArray(int[] input, int expectedResult)
        {
            //Act
            int result = _exercises.SumOfPrime(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(new int[] { 1, 2, 3, 5, 6, 7 }, 4)]
        [DataRow(new int[] { -1, -2, 0, 1, 3, 4, 5, 6 }, 2)]
        [DataRow(new int[] { -1, -2, 0, 1, 2, 3, 4, 5, 6 }, 0)]
        public void ShouldReturnSmallestMissingPositiveNumber(int[] input, int expectedResult)
        {
            //Act
            int result = _exercises.SmallestMissingPositive(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(new int[] { 10, 18, 39, 75, 100 }, 180, new int[] { 10, 18 })]
        [DataRow(new int[] { 10, 18, 39, 75, 100 }, 200, new int[] { })]
        [DataRow(new int[] { 10, 18, 39, 75, 100 }, 702, new int[] { 18, 39 })]
        public void ShouldReturnTheValuesWhoseProductsAreEqualsToGivenNumber(int[] input, int multiplied, int[] expectedResult)
        {
            //Act
            int[] result = _exercises.Multipliers(input, multiplied);

            //Assert
            result.Should().Equal(expectedResult);
        }
    }
}