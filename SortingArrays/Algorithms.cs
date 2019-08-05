using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    class Arrays
    { 
        int[] arr;
        public Arrays(int length = 10, int range = 10)
        {
            arr = RandIntArray(length, range);
        }
        public int[] GetArray() { return arr; }
        //Generates a random array of a defined size with defined random integers
        public int[] RandIntArray(int n, int rand)
        {
            Random r = new Random();
            int[] ar = new int[n];

            for (int i = 0; i < ar.Length; i++)
            {
                ar[i] = r.Next(0, rand);
            }
            return ar;
        }
        public int[] BubbleSort()
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
