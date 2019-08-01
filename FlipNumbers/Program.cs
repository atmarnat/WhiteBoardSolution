using System;

namespace FlipNumbers
{
    class Program
    {
        static void FlipInt(int a, int b)
        {
            Console.WriteLine($"old : {a}, {b}");
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"new : {a}, {b}");
        }
        static void Main(string[] args)
        {
            FlipInt(1, 1);
            FlipInt(0, 5);
            FlipInt(-3, 2);
            FlipInt(2, -4);
            FlipInt(-2, -11);
        }
    }
}
