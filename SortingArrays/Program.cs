using System;
using SortingAlgorithms;

namespace SortingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sorting array of random integers");
            Arrays arr = new Arrays();
            foreach (int i in arr.GetArray())
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("");
            arr.HeapSort();
            foreach (int i in arr.GetArray())
            {
                Console.Write($"{i} ");
            }
        }
    }
}
