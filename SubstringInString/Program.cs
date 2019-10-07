using System;
using System.Text.RegularExpressions;

namespace SubstringInString
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(IndexOfSubstring("mothermothhher", "sodjio"));
            Console.WriteLine(IndexOfSubstring("Mississippi", "is"));
            Console.WriteLine(IndexOfSubstring("4356", "sg 45y"));
        }
        public static int IndexOfSubstring(string str, string subStr)
        {
            Regex rx = new Regex(subStr);

            Match m = rx.Match(str);
            int ret = Convert.ToInt32(m.Index.ToString());

            if(Match.Empty != m)
            {
                return ret;
            }

            return ret;
        }

        static int IoS(string str, string subStr) => (new Regex(subStr)).Match(str) != Match.Empty ? Convert.ToInt32((new Regex(subStr)).Match(str).Index.ToString()) : -1;
    }
}
