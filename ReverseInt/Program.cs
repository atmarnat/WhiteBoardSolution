using System;

namespace ReverseInt
{
    public class Program
    {
        public static int ReverseInt(int number)
        {
            int result = 0;
            while (number > 0)
            {
                result *= 10;
                result += number % 10;
                number /= 10;
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Reverse the digits in an integer");
        }
    }
}
