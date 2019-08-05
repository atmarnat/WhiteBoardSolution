using System;
using SortingAlgorithms;

namespace SortingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sorting array of random integers");
            Arrays arr = new Arrays(10, 5);
            foreach (int i in arr.GetArray())
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("");
            arr.BubbleSort();
            foreach (int i in arr.GetArray())
            {
                Console.Write($"{i} ");
            }
        }
    }
}
