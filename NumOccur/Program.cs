using System;

namespace NumOccurrences
{
    public class Program
    {
        public static int NumOccurences(string str, char c)
        {
            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == c)
                {
                    count++;
                }
            }

            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Counting number of occurences");

            Console.WriteLine(NumOccurences("mississippi", 's'));
        }
    }
}
