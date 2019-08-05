using System;
using SortingAlgorithms;

namespace SortingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sorting array of random integers");
            int[] arr = Arrays.RandIntArray(10, 10);
            Console.WriteLine("");
            Arrays.BubbleSort(arr);
            foreach (int i in arr)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
