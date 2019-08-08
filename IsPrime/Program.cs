using System;

namespace IsPrime
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPrimeFaster(0));
            Console.WriteLine(IsPrimeFaster(1));
            Console.WriteLine(IsPrimeFaster(2));
            Console.WriteLine(IsPrimeFaster(3));
            Console.WriteLine(IsPrimeFaster(4));
            Console.WriteLine(IsPrimeFaster(5));
            Console.WriteLine(IsPrimeFaster(6));
            Console.WriteLine(IsPrimeFaster(7));
            Console.WriteLine(IsPrimeFaster(8));
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
        public static bool IsPrimeFaster(int n)
        {
            if (n < 2) return false;
            if (n < 4) return true;
            if (n % 2 == 0 || n % 3 == 0) return false;
            for (int i = 3; i < n; i += 2)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
    }
}
