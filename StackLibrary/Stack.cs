using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace StackLibrary
{
    public class Stack
    {
        public int[] items;
        public int top;

        public Stack(int size)
        {
            items = new int[size];
            top = -1;
        }

        public bool IsEmpty()
        {
            return top == -1;
        }

        public bool IsFull()
        {
            return top == items.Length - 1;
        }

        public void Push(int item)
        {
            if (IsFull()) throw new ArgumentException("Stack is full");

            items[++top] = item;
        }

        public int Pop()
        {
            if (IsEmpty()) throw new ArgumentException("Stack underflow");

            return items[top--];
        }

        public int Peek()
        {
            if (IsEmpty()) throw new ArgumentException("Stack is empty");

            return items[top];
        }

        public static int Size(Stack stack)
        {
            return stack.top + 1;
        }

        public static int[] Display(Stack stack)
        {
            int count = Stack.Size(stack);
            int[] result = new int[count];
            for (int i = 0; i < count; i++)
            {
                result[i] = stack.items[i];
            }
            return result;
        }


        public static void SortByDescending(Stack stack)
        {
            if (stack.IsEmpty()) throw new ArgumentException("Stack is Empty");

            Stack tempStack = new Stack(stack.items.Length);

            while (!stack.IsEmpty())
            {
                int currentItem = stack.Pop();
                while (!tempStack.IsEmpty() && currentItem > tempStack.Peek())
                {
                    stack.Push(tempStack.Pop());
                }
                tempStack.Push(currentItem);
            }
            while (!tempStack.IsEmpty())
            {
                stack.Push(tempStack.Pop());
            }
        }

        public static void SortByAscending(Stack stack)
        {
            if (stack.IsEmpty()) throw new ArgumentException("Stack is empty");

            Stack tempStack = new Stack(stack.items.Length);

            while (!stack.IsEmpty())
            {
                int currentItem = stack.Pop();
                while (!tempStack.IsEmpty() && currentItem < tempStack.Peek())
                {
                    stack.Push(tempStack.Pop());
                }
                tempStack.Push(currentItem);
            }
            while (!tempStack.IsEmpty())
            {
                stack.Push(tempStack.Pop());
            }
        }

        public static Stack Reverse(Stack stack)
        {
            if (stack.IsEmpty()) throw new ArgumentException("Stack is empty");

            Stack temp = new Stack(stack.items.Length);
            int[] array = new int[stack.items.Length];

            int i = 0;
            while (!stack.IsEmpty())
            {
                array[i] = stack.Pop();
                i++;
            }

            for (int j = array.Length - 1; j >= 0; j--)
            {
                temp.Push(array[j]);
            }
            return temp;
        }

        public int Max(Stack stack)
        {
            int[] array = stack.items.ToArray();

            return array.Max();
        }

        public int Min(Stack stack)
        {
            int[] array = stack.items.ToArray();

            return array.Min();
        }

        public static void RemoveAll(Stack stack)
        {
            while (!stack.IsEmpty())
            {
                stack.Pop();
            }
        }

        public static void Remove(Stack stack, int remove)
        {
            Stack temp = new Stack(Size(stack));
            bool found = false;
            while (!stack.IsEmpty())
            {
                int element = stack.Pop();
                if (element != remove || found)
                {
                    temp.Push(element);
                }
                else
                {
                    found = true;
                }
            }
            while (!temp.IsEmpty())
            {
                stack.Push(temp.Pop());
            }
        }

        public static int Count(Stack stack)
        {
            int result = 0;
            foreach (var item in stack.items)
            {
                result++;
            }
            return result;
        }

        public static int CountSpecific(Stack stack, int input)
        {
            int result = 0;
            foreach (var item in stack.items)
            {
                if (item == input) result++;
            }
            return result;
        }

        public static bool Contains(Stack exercises, int element)
        {
            foreach (var item in exercises.items)
            {
                if (item == element) return true;
            }
            return false;
        }

        public static Stack RemoveDuplicates(Stack stack)
        {
            int[] temp = stack.items.ToArray();
            int[] result = temp.Union(temp).ToArray();
            Stack returnable = new Stack(result.Length);
            foreach (var item in result.Reverse())
            {
                returnable.Push(item);
            }
            return returnable;
        }

        public static int[] FirstAndLast(Stack stack)
        {
            int[] result = stack.items.ToArray();

            return new int[] { result[0], result[^1] };
        }

        public static Stack Rotate(Stack stack)
        {
            int[] temp = stack.items.ToArray();
            Stack result = new Stack(temp.Length);
            foreach (var item in temp.Reverse())
            {
                result.Push(item);
            }
            return result;
        }

        public static void SwapTwoFirsts(Stack stack)
        {
            int[] temp = new int[stack.items.Length];
            for (int i = stack.items.Length - 1; i >= 0; i--)
            {
                temp[i] = stack.Pop();
            }

            int aux = temp[0];
            temp[0] = temp[1];
            temp[1] = aux;

            foreach (var item in temp.Reverse())
            {
                stack.Push(item);
            }
        }

        public static int ReturnByIndex(Stack stack, int index)
        {
            int[] result = new int[stack.items.Length];
            for (int i = stack.items.Length - 1; i >= 0; i--)
            {
                result[i] = stack.Pop();
            }
            return result[index - 1];
        }

        public static Stack Merge(Stack stackOne, Stack stackTwo)
        {
            int[] tempOne = new int[stackOne.items.Length];
            for (int i = stackOne.items.Length - 1; i >= 0; i--)
            {
                tempOne[i] = stackOne.Pop();
            }
            int[] tempTwo = new int[stackTwo.items.Length];
            for (int i = stackTwo.items.Length - 1; i >= 0; i--)
            {
                tempTwo[i] = stackTwo.Pop();
            }

            int[] resultArray = tempOne.Concat(tempTwo).ToArray();
            var stackResult = new Stack(tempOne.Length + tempTwo.Length);

            foreach (var item in resultArray)
            {
                stackResult.Push(item);
            }
            return stackResult;
        }

        public static bool IsSubset(Stack stackCheck, Stack stack)
        {
            if (stackCheck.items.Length == stack.items.Length)
            {
                return Stack.IsEqual(stackCheck, stack);
            }

            foreach (var item in stackCheck.items)
            {
                if (!Stack.Contains(stack, item)) return false;
            }
            return true;
        }

        private static bool IsEqual(Stack stackCheck, Stack stack)
        {
            foreach (var item in stackCheck.items)
            {
                if (!Stack.Contains(stack, item)) return false;
            }
            return true;
        }

        public static int[] Commom(Stack stackOne, Stack stackTwo)
        {
            int[] tempOne = stackOne.items.ToArray();
            int[] tempTwo = stackTwo.items.ToArray();
            List<int> result = new List<int>();

            foreach (var item in tempOne)
            {
                if (Stack.Contains(stackTwo, item)) result.Add(item);
            }
            return result.ToArray();
        }

        public static int[] ElementsOnlyFirst(Stack stackOne, Stack stackTwo)
        {
            int[] tempOne = stackOne.items.ToArray();
            int[] tempTwo = stackTwo.items.ToArray();
            List<int> result = new List<int>();

            foreach (var item in tempOne)
            {
                if (!Stack.Contains(stackTwo, item)) result.Add(item);
            }
            return result.ToArray();
        }

        public static Stack MergeWithoutDupes(Stack stackOne, Stack stackTwo)
        {
            var result = new List<int>();

            foreach (var item in stackOne.items)
            {
                if (!result.Contains(item)) result.Add(item);
            }
            foreach (var item in stackTwo.items)
            {
                if (!result.Contains(item)) result.Add(item);
            }

            var stack = new Stack(result.Count());

            foreach (var item in result)
            {
                stack.Push(item);
            }
            return stack;
        }

        public static Stack MergeUnion(Stack stackOne, Stack stackTwo)
        {
            int[] tempOne = stackOne.items.ToArray();
            int[] tempTwo = stackTwo.items.ToArray();

            int[] temp = tempOne.Union(tempTwo).ToArray();
            var stack = new Stack(temp.Length);

            foreach (var item in temp)
            {
                stack.Push(item);
            }
            return stack;
        }

        public static Stack SubStack(Stack stack, int values)
        {
            int[] temp = new int[stack.items.Length];
            for (int i = 0; i < stack.items.Length; i++)
            {
                temp[i] = stack.Pop();
            }

            var result = new Stack(values);

            for (int i = 1; i <= values; i++)
            {
                result.Push(temp[^i]);
            }

            return result;
        }

        public static bool IsAllSatisfied(Stack stack, Func<int, bool> condition)
        {
            foreach (var item in stack.items)
            {
                if (!condition(item)) return false;
            }
            return true;
        }

        public static bool IsOneSatisfied(Stack stack, Func<int, bool> condition)
        {
            foreach (var item in stack.items)
            {
                if (condition(item)) return true;
            }
            return false;
        }

        public static Stack ConditionaryStack(Stack stack, Func<int, bool> condition)
        {
            var temp = new List<int>();

            foreach (var item in stack.items)
            {
                if (condition(item)) temp.Add(item);
            }

            var result = new Stack(temp.Count());
            foreach (var item in temp)
            {
                result.Push(item);
            }
            return result;
        }
    }
}
