using System;
using System.Collections;
using System.Collections.Generic;

namespace EX2a_GenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T>,
            var list = new List<object> { 1, "two", 3.00001, true, 0x5 };
            Console.Write("List<T> : ");
            PrintToConsole<object>(list);

            //LinkedList<T>,
            var linkedList = new LinkedList<object>(new object[] { 1, "two", 3.00001, true, 0x5 });
            Console.Write("LinkedList<T> : ");
            PrintToConsole<object>(linkedList);

            //Queue<T>,
            var queue = new Queue<object>(new object[] { 1, "two", 3.00001, true, 0x5 });
            Console.Write("Queue<T> : ");
            PrintToConsole<object>(queue);

            //Stack<T>,
            var stack = new Stack<object>(new object[] { 1, "two", 3.00001, true, 0x5 });
            Console.Write("Queue<T> : ");
            PrintToConsole<object>(stack);

            //Dictionary<TKey, TValue>,
            var dictionary = new Dictionary<int, object>
            {
                {1, 1 },
                {2, "two" },
                {3, 3.00001 },
                {4, true },
                {5, 0x5 },
            };
            Console.Write("Dictionary<int, object> : ");
            PrintToConsole(dictionary);

            //SortedList<TKey, TValue>, and
            var sortedList = new SortedList<string, object>
            {
                {"first", 1 },
                {"second", "two" },
                {"third", 3.00001 },
                {"fourth", true },
                {"fifth", 0x5 },
            };
            Console.Write("SortedList<string, object> : ");
            PrintToConsole(sortedList);

            //HashSet<T>).
            var hashSet = new HashSet<object> { 1, "two", 3.00001, true, 0x5 };
            Console.Write("HashSet<object> : ");
            PrintToConsole(hashSet);
        }

        public static void PrintToConsole<T>(T container)
        {
            Console.WriteLine(container.GetType());
            foreach (object o in (IEnumerable)container)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine();
        }
    }
}
