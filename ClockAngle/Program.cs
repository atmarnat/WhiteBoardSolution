using System;

namespace ClockAngle
{
    public class Program
    {
        public static int Angle(int min, int hrs)
        {
            while (hrs >= 12) hrs -= 12;
            while (min >= 60) min -= 60;
            min = 360 / 60 * min;
            hrs = 360 / 12 * hrs;

            int result = Math.Abs(min - hrs);
            if (result > 180)
            {
                return result - 180;
            }
            return result;
        }    
            
        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.Write("Minutes: ");
                string a = Console.ReadLine();
                Console.Write("Hours: ");
                string b = Console.ReadLine();
                int m = int.Parse(a);
                int h = int.Parse(b);
                Console.Write("Angle Between: ");
                Console.WriteLine(Angle(m, h));

            }
        }
    }
}
