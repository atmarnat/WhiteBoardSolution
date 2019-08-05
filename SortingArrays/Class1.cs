using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    class Arrays
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
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        arr[j] += arr[j + 1];
                        arr[j + 1] = arr[j] - arr[j + 1];
                        arr[j] -= arr[j + 1];
                    }
                }
            }
            return arr;
        }
    }
}
