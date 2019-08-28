using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace ReadingFromFile
{
    class Program
    {
        static void LineCount(string s)
        {
            var lineCount = File.ReadAllLines(s).Length;
            Console.WriteLine($"The line count is {lineCount}");
        }
        static void BlankLines(string s)
        {
            var lineCount = File.ReadLines(s).Count(line => string.IsNullOrWhiteSpace(line));
            Console.WriteLine($"The blank line count is {lineCount}");
        }
        static void NonBlankLines(string s)
        {
            var lineCount = File.ReadLines(s).Count(line => !string.IsNullOrWhiteSpace(line));
            Console.WriteLine($"The non-blank line count is {lineCount}");
        }
        static void WordCount(string s)
        {
            StreamReader sr = new StreamReader(s);
            int counter = 0;
            string delim = " ";
            string[] fields;
            string line;

            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                line.Trim();
                fields = line.Split(delim.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                counter += fields.Length;
            }
            sr.Close();

            Console.WriteLine("The word count is {0}", counter);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Reading files");
            string s = "C:\\Users\\wwstudent\\Documents\\song.txt";

            LineCount(s);
            BlankLines(s);
            NonBlankLines(s);
            WordCount(s);

        }
    }
}
