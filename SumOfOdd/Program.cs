using System;

namespace SumOfOdd
{
    public class Program
    {
        public static int sumOfOdd(int x)
        {
            int sum = 0;
            for (int i = 1; i <= x; i += 2)
            {
                 sum += i;
            }
            return sum;
            //Console.WriteLine($"The sum for {x} is {sum}");
        }
        public static int SumOdds(int n, int m)
        {
            int sum = n;
            if (n < m)
            {
                n += 2;
                return sum += SumOdds(n, m);
            }

            return sum;
        }
        static void Main(string[] args)
        {
            sumOfOdd(-1);
            sumOfOdd(0);
            sumOfOdd(1);
            sumOfOdd(2);
            sumOfOdd(3);
            sumOfOdd(5);
            sumOfOdd(7);
            sumOfOdd(9);
            sumOfOdd(11);
            Console.WriteLine(SumOdds(1, 4));
        }
    }
}
