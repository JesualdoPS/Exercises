namespace ForLoopLibrary
{
    public class ForLoopClass
    {
        public int[] IntCounter(int input)
        {
            int[] result = new int[input];

            for (int i = 0; i < input; i++)
            {
                result[i] = i + 1;
            }
            return result;
        }

        public int ArraySum(int input)
        {
            int result = 0;

            for (int i = 1; i <= input; i++)
            {
                result += i;
            }

            return result;
        }
    }
}
