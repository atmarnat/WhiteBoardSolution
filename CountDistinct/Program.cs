using System;
using System.Collections.Generic;

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
            Console.WriteLine(CountDistinct2(arr));
            Console.WriteLine(CountDistinct2(arrr));
            Console.WriteLine(CountDistinct2(arrrr));
            Console.WriteLine(CountDistinct2(array));
        }

        public static int CountDistinctElements(int[] arr)
        {
            if (arr.Length == 0) return 0;
            Array.Sort(arr);
            int count = 1 ;
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] != arr[i + 1]) count++;
            }
            return count;
        }
        public static int CountDistinct2(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                bool same = true;
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] == arr[j]) same = false;
                }
                if (same) count++;
            }
            return count;
        }
    }
}
