using System;

namespace CharArraySort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(SortStr("Hello World!"));
            Console.WriteLine(SortStr("Howdy hardly Has Henry"));
        }

        public static string SortStr(string input)
        {
            string answer = "";

            for (int j = 0; j < 26; j++)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    char compare = (char)('a' + j);
                    char uCompare = (char)('A' + j);
                    if (input[i] == compare || input[i] == uCompare)
                    {
                        answer += input[i];
                    }
                }
            }

            return answer;
        }
    }
}
