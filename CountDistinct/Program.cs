using System;

namespace CountDistinct
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5};
            int[] arrr = new int[] { 1, 1, 2, 3, 4};
            int[] arrrr = new int[] { 1, 1, 1, 1, 1};
            int[] array = new int[0];
            Console.WriteLine(CountDistinctElements(array));
        }

        public static int CountDistinctElements(int[] arr)
        {
            if (arr.Length == 0) return 0;
            Array.Sort(arr);
            int count = 1 ;
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] != arr[i + 1])
                {
                    count++;
                }
            }
            return count;
        }
    }
}
