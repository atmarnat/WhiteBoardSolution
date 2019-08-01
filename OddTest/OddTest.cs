using System;

namespace OddTest
{
    class OddTest
    {
        static bool oddTest(int n) => ((n % 2) == 1);
        static void testOddTest()
        {
            int num = 8;
            Console.WriteLine($"{num} is an odd number: {oddTest(num)}");
            num = 5;
            Console.WriteLine($"{num} is an odd number: {oddTest(num)}");
            num = 0;
            Console.WriteLine($"{num} is an odd number: {oddTest(num)}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\n\tOddTest Main.");
            testOddTest();

        }
    }
}
