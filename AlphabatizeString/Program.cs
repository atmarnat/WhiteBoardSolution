﻿using System;

namespace AlphabatizeString
{
    class Program
    {
        static string Alphabatize(string str)
        {
            string fin = "";
            char[] letters = str.ToCharArray();
            
            for (int i = 0; i < letters.Length-1; i++)
            {
                for (int j = 0; j < letters.Length-1; j++)
                {
                    if (letters[j] > letters[j+1])
                    {
                        char temp = letters[j+1];
                        letters[j+1] = letters[j];
                        letters[j] = temp;
                        Console.WriteLine(temp);
                    }
                }
            }
            foreach (var c in letters)
            {
                fin += c;
            }
            return fin;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Alphabatize("helloworld"));
        }
    }
}
