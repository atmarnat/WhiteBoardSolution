using System;

namespace CapitalLetters
{
    public class Program
    {
        public static int CountCapitals(string sentence)
        {
            int solution = 0;

            string alphabet = "QWERTYUIOPASDFGHJKLZXCVBNM";
            for (int i = 0; i < sentence.Length; i++)
            {
                for (int k = 0; k < alphabet.Length; k++)
                {
                    if (sentence[i] == alphabet[k]) solution++;
                }
            }

            return solution;
        }
        public static int CountCapitalsBetter(string sentence)
        {
            int count=0;
            for (int i = 0; i < sentence.Length; i++)
            {
                if (char.IsUpper(sentence[i]))
                {
                    count++;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CountCapitals("Star Wars"));
            Console.WriteLine(CountCapitalsBetter("Star Wars"));

        }
    }
}
