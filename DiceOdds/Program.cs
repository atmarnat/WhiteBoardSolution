using System;

namespace DiceOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            float total = 0;
            for (int i = 0; i < 13; i++)
            {
                Console.WriteLine(DiceProb(i));
                total += DiceProb(i);
            }
            Console.WriteLine(total);
        }

        public static float DiceProb(int roll)
        {
            /*   1  2  3  4  5  6
              1  2  3  4  5  6  7
              2  3  4  5  6  7  8
              3  4  5  6  7  8  9   
              4  5  6  7  8  9 10    
              5  6  7  8  9 10 11    
              6  7  8  9 10 11 12     
            */
            float t = 36f;
            switch(roll)
            {
                case 2:
                    return 1 / t;
                case 3:
                    return 2 / t;
                case 4:
                    return 3 / t;
                case 5:
                    return 4 / t;
                case 6:
                    return 5 / t;
                case 7:
                    return 6 / t;
                case 8:
                    return 5 / t;
                case 9:
                    return 4 / t;
                case 10:
                    return 3 / t;
                case 11:
                    return 2 / t;
                case 12:
                    return 1 / t;
                default:
                    Console.WriteLine("Not a correct value");
                    return 0;

            }
        }
    }
}
