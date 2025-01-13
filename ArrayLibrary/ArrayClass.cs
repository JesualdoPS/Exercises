namespace ArrayLibrary
{
    public class ArrayClass
    {
        public string PrintArray(int start, int end)
        {
            var array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + start;
            }

            return string.Join(",", array);
        }

        public string ReverseArray(params int[] values)
        {
            var array = values.ToArray();

            return string.Join(" ", array.Reverse().ToArray());
        }

        public int SumOfArray(params int[] values)
        {
            var result = values.ToArray();
            return result.Sum();
        }

        public int[] CopyArray(int[] values)
        {
            int[] result = values.ToArray();

            return values;
        }

        public int Duplicated(params int[] input)
        {
            int result = input.GroupBy(x => x)
                      .Where(g => g.Count() > 1)
                      .Select(g => g.Count() - 1)
                      .Sum();
            return result;
        }

        public int[] UniqueElements(int[] values)
        {
            var result = values.GroupBy(x => x)
                .Where(g => g.Count() == 1)
                .Select(g => g.Key)
                .ToArray();
            return result;
        }

        public int[] MergeArrays(int[] array1, int[] array2)
        {
            int[] result = array1.Concat(array2).OrderBy(x => x).ToArray();
            return result;
        }

        public string ValueCounter(params int[] array)
        {
            int[] values = array.Distinct().ToArray();
            var result = new List<string>();

            foreach (int value in values)
            {
                int count = array.Count(x => x == value);
                result.Add($"{value} occurs {count} times");
            }

            return string.Join(", ", result);
        }

        public string MaxAndMin(int[] array)
        {
            return $"Max element is {array.Max()} and Min element is {array.Min()}";
        }

        public (int[] even, int[] odd) OddAndEvenSeparately(int[] input)
        {
            int[] even = input.Where(x => x % 2 == 0).ToArray();
            int[] odd = input.Where(x => x % 2 != 0).ToArray();

            return (even, odd);
        }

        public int[] OrderArray(int[] input)
        {
            return input.OrderBy(x => x).ToArray();
        }

        public int[] DisorderArray(int[] input)
        {
            return input.OrderByDescending(x => x).ToArray();
        }

        public int[] AddAndOrder(int insert, int[] input)
        {
            var list = input.ToList();
            list.Add(insert);
            return list.OrderBy(x => x).ToArray();
        }

        public int[] InsertToIndex(int value, int position, int[] array)
        {
            return array.Take(position - 1).Concat(new[] { value }).Concat(array.Skip(1).ToArray()).ToArray();
        }

        public int[] RemoveByIndex(int[] input, int index)
        {
            return input.Take(index).Concat(input.Skip(index + 1)).ToArray();
        }

        public int SecondLargest(params int[] input)
        {
            int[] result = input.OrderByDescending(x => x).ToArray();
            return result[1];
        }

        public int SecondSmallest(int[] input)
        {
            int[] result = input.OrderBy(x => x).ToArray();
            return result[1];
        }

        public string MatrixToString(int[][] matrix)
        {
            string result = "";

            foreach (var row in matrix)
            {
                result += string.Join(" ", row) + "\n";
            }
            return result.Trim();
        }

        public int[,] MatrixSum(int[,] ints1, int[,] ints2)
        {
            if (ints1.GetLength(0) != ints2.GetLength(0) || ints1.GetLength(1) != ints2.GetLength(1))
                throw new ArgumentException("Matrices must have same size");

            int[,] result = new int[ints1.GetLength(0), ints1.GetLength(1)];

            for (int line = 0; line < ints1.GetLength(0); line++)
            {
                for (int column = 0; column < ints1.GetLength(1); column++)
                {
                    result[line, column] = ints1[line, column] + ints2[line, column];
                }
            }
            return result;
        }

        public int[,] MatrixSubtract(int[,] matrix1, int[,] matrix2)
        {
            if (matrix1.GetLength(0) != matrix2.GetLength(0) || matrix1.GetLength(1) != matrix2.GetLength(1))
                throw new ArgumentException("Matrices must have same size");

            int[,] result = new int[matrix1.GetLength(0), matrix1.GetLength(1)];

            for (int line = 0; line < matrix1.GetLength(0); line++)
            {
                for (int column = 0; column < matrix1.GetLength(1); column++)
                {
                    result[line, column] = matrix1[line, column] - matrix2[line, column];
                }
            }
            return result;
        }

        public int[,] MatrixMultiply(int[,] matrix1, int[,] matrix2)
        {
            if (matrix1.GetLength(0) != matrix2.GetLength(0) || matrix1.GetLength(1) != matrix2.GetLength(1))
                throw new ArgumentException("Matrices must have same size");

            int[,] result = new int[matrix1.GetLength(0), matrix1.GetLength(1)];

            for (int line = 0; line < matrix1.GetLength(0); line++)
            {
                for (int column = 0; column < matrix1.GetLength(1); column++)
                {
                    result[line, column] = matrix1[line, column] * matrix2[line, column];
                }
            }
            return result;
        }

        public int[,] TransposeMatrix(int[,] ints)
        {
            int[,] result = new int[ints.GetLength(0), ints.GetLength(1)];

            for (int line = 0; line < ints.GetLength(0); line++)
            {
                for (int column = 0; column < ints.GetLength(1); column++)
                {
                    if (line == column) result[line, column] = ints[line, column];

                    result[line, column] = ints[column, line];
                }
            }
            return result;
        }

        public int DiagonalSum(int[,] ints)
        {
            int result = 0;

            for (int line = 0; line < ints.GetLength(0); line++)
            {
                for (int column = 0; column < ints.GetLength(1); column++)
                {
                    if (line == column)
                    {
                        result += ints[line, column];
                    }
                }
            }
            return result;
        }

        public int LeftDiagonalSum(int[,] matrix)
        {
            int result = 0;
            int column = matrix.GetLength(1) - 1;

            for (int line = 0; line <= matrix.GetLength(0) - 1; line++)
            {
                result += matrix[line, column];
                column--;
            }
            return result;
        }

        public string SumRowsAndColumns(int[,] matrix)
        {
            int[] sumOfRows = new int[matrix.GetLength(0)];
            int[] sumOfColumns = new int[matrix.GetLength(1)];

            for (int line = 0; line < matrix.GetLength(0); line++)
            {
                for (int columns = 0; columns < matrix.GetLength(1); columns++)
                {
                    sumOfRows[line] += matrix[line, columns];
                    sumOfColumns[columns] += matrix[line, columns];
                }
            }
            return $"The sum of rows are [{string.Join(", ", sumOfRows)}]" +
                $", and the sum of columns are [{string.Join(", ", sumOfColumns)}]";
        }

        public int[,] LowerTriangleToZero(int[,] matrix)
        {
            int[,] result = new int[matrix.GetLength(0), matrix.GetLength(1)];

            for (int line = 0; line < matrix.GetLength(0); line++)
            {
                for (int columns = 0; columns < matrix.GetLength(1); columns++)
                {
                    result[line, columns] = (line > columns) ? 0 : matrix[line, columns];
                }
            }
            return result;
        }

        public int[,] UpperTriangleToZero(int[,] matrix)
        {
            int[,] result = new int[matrix.GetLength(0), matrix.GetLength(1)];

            for (int line = 0; line < matrix.GetLength(0); line++)
            {
                for (int columns = 0; columns < matrix.GetLength(1); columns++)
                {
                    result[line, columns] = (line >= columns) ? matrix[line, columns] : 0;
                }
            }
            return result;
        }

        public int Determinant(int[,] matrix)
        {
            if (matrix.GetLength(0) != 3 || matrix.GetLength(1) != 3)
            {
                throw new ArgumentException("Matrix must be 3x3");
            }

            int a = matrix[0, 0];
            int b = matrix[0, 1];
            int c = matrix[0, 2];
            int d = matrix[1, 0];
            int e = matrix[1, 1];
            int f = matrix[1, 2];
            int g = matrix[2, 0];
            int h = matrix[2, 1];
            int i = matrix[2, 2];

            int result = a * (e * i - f * h) -
                               b * (d * i - f * g) +
                               c * (d * h - e * g);

            return result;
        }

        public bool IsSparseMatrix(int[,] matrix)
        {
            int zeros = 0;

            for (int line = 0; line < matrix.GetLength(0); line++)
            {
                for (int columns = 0; columns < matrix.GetLength(1); columns++)
                {
                    if (matrix[line, columns] == 0) zeros++;
                }
            }

            return zeros > matrix.Length / 2;
        }

        public bool IsMatrixEqual(int[,] matrix1, int[,] matrix2)
        {
            if (matrix1.GetLength(0) != matrix2.GetLength(0) || matrix1.GetLength(1) != matrix2.GetLength(1)) return false;
            for (int line = 0; line < matrix1.GetLength(0); line++)
            {
                for (int columns = 0; columns < matrix1.GetLength(1); columns++)
                {
                    if (matrix1[line, columns] != matrix2[line, columns]) return false;
                }
            }
            return true;
        }

        public bool IsIdentityMatrix(int[,] matrix)
        {
            if (matrix.GetLength(0) != matrix.GetLength(1)) return false;

            for (int line = 0; line < matrix.GetLength(0); line++)
            {
                for (int columns = 0; columns < matrix.GetLength(1); columns++)
                {
                    if (line == columns && matrix[line, columns] != 1) return false;
                    if (line != columns && matrix[line, columns] == 1) return false;
                }
            }
            return true;
        }

        public int[] OddValues(int[] input)
        {
            return input.Where(x => x % 2 != 0).ToArray();
        }

        public object[] ArrayWithoutRepeatedElements(object[] input)
        {
            return input.Union(input).ToArray();
        }

        public int MissingValue(int[] input, int start, int end)
        {
            if (input.Length == (end - start + 1)) return 0;
            int count = start;

            for (int i = 0; i < end - start; i++)
            {
                if (input[i] != count) return count;
                count++;
            }
            return end;
        }

        public int SumOfTwoLowest(int[] input)
        {
            int[] result = input.OrderBy(x => x).ToArray();

            return result.Take(2).Sum();
        }

        public bool IsConsecutive(int[] input)
        {
            return input.Zip(input.Skip(1), (a, b) => a + 1 == b).All(x => x);
        }

        public int SmallestGap(int[] input)
        {
            int result = input.Max() - input.Min();

            for (int i = 0; i < input.Length - 1; i++)
            {
                result = Math.Abs(input[i] - input[i + 1]) > result ? result : Math.Abs(input[i] - input[i + 1]);
            }
            return result;
        }

        public bool IsPresent(int[] input, string check)
        {
            return input.Any(x => x.ToString().Contains(check));
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

        public int SumOfPrime(int[] input)
        {
            int result = 0;
            foreach (int item in input)
            {
                if (IsPrime(item)) result += item;
            }
            return result;
        }

        public int SmallestMissingPositive(int[] input)
        {
            int[] positive = input.Where(x => x >= 0).OrderBy(x => x).ToArray();
            int count = positive[0];

            for (int index = 0; index < positive.Length; index++)
            {
                if (positive[index] != count) return count;
                count++;
            }
            return 0;
        }

        public int[] Multipliers(int[] input, int multiplied)
        {
            int[] result = new int[2];
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 1; j < input.Length - 1; j++)
                {
                    if (input[i] * input[j] == multiplied) return new int[] { input[i], input[j] };
                }
            }
            return new int[] { };
        }
    }
}
