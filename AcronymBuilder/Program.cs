using System;

namespace AcronymBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AcronymBuilder("Hello World!"));
        }
        public static string AcronymBuilder(string input)
        {
            string acronym = "";
            string[] inputArr = input.Split(' ');
            for (int i = 0; i < inputArr.Length; i++)
            {
                acronym += inputArr[i][0];
            }
            return acronym;
        }
    } 
}
