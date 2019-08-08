using System;

namespace IsPrime
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPrime(0));
            Console.WriteLine(IsPrime(1));
            Console.WriteLine(IsPrime(2));
            Console.WriteLine(IsPrime(3));
            Console.WriteLine(IsPrime(4));
            Console.WriteLine(IsPrime(5));
            Console.WriteLine(IsPrime(6));
            Console.WriteLine(IsPrime(7));
            Console.WriteLine(IsPrime(8));
        }
        public static bool IsPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
    }
}
