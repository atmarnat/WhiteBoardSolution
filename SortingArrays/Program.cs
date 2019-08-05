using System;

namespace SortingArrays
{
    class Program
    {
        public static int[] RandIntArray(int n, int rand)
        {
            Random r = new Random();
            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(0, rand);
                Console.Write($"{arr[i]} ");
            }
            return arr;
        }
        public static int[] BubbleSort(int[] arr)
        {
            int temp;

            for (int i = 0; i < arr.Length -1; i++)
            {
                for (int j = 0; j < arr.Length-1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            return arr;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arr = RandIntArray(10, 10);
            Console.WriteLine("");
            BubbleSort(arr);
            foreach (int i in arr)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
