using System;

namespace ReverseInt
{
    public class Program
    {
        public static int ReverseInt(int number)
        {
            int result = 0;
            bool isNeg = false;
            if (number < 0)
            {
                isNeg = true;
                number *= -1;
            }
            while (number > 0)
            {
                result *= 10;
                result += number % 10;
                number /= 10;
            }

            if (isNeg) return result * -1;
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Reverse the digits in an integer");
            Console.WriteLine(ReverseInt(-123));
        }
    }
}
