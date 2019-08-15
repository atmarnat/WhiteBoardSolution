using System;
using System.Text.RegularExpressions;

namespace CountLetters
{
    public class Program
    {
        public static int NumLetters(string str)
        {
            int count = 0;
            string s = "";

            Regex r = new Regex("[A-Za-z]");
            Regex rSpace = new Regex("[^ ]");

            for(int i = 0; i < str.Length; i++)
            {
                s += str[i];
                if (rSpace.IsMatch(s))
                {
                    count++;
                }
                s = "";
            }

            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(NumLetters(" "));
            Console.WriteLine(NumLetters("*$*$*"));
            Console.WriteLine(NumLetters("cat"));
            Console.WriteLine(NumLetters("Melinda rocks"));
        }
    }
}
