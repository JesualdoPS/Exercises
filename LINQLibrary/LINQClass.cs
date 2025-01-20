namespace LINQLibrary
{
    public class LINQClass
    {
        public static int[] EvenValues(int[] input, int quantity)
        {
            return input.Where(x => x % 2 == 0).Take(quantity).ToArray();
        }

        public static int[] ConditionedValues(int[] input, Func<int, bool> condition)
        {
            return input.Where(x => condition(x)).ToArray();
        }

        public static int[] AllToSquare(int[] input)
        {
            return input.Select(x => (int)Math.Pow(x, 2)).ToArray();
        }

        public static int Frequency(int[] input, int value)
        {
            return input.Where(x => x == value).Count();
        }

        public static int FrequencyOfLetter(string input, char value)
        {
            return input.Where(x => x == value).Count();
        }
    }
}
