using System;

namespace JulianDay
{
    public class Program
    {
        public static int Julian(int month, int day)
        {
            int result = day;
            int[] arr = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30 };
            for (int i = 0; i < month; i++)
            {
                result += arr[i];
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
