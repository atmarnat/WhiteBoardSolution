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

            return -1;
        }
    }
}
