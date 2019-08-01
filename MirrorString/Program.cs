using System;
using System.Linq;

namespace MirrorString
{
    class Program
    {
        public static string Mirror(string foward) => new string(foward.Reverse().ToArray());
        public static string ReverseString(string foward)
        {
            string reverse = "";
            if (foward == null) return null;
            for (int i = foward.Length - 1; i >= 0; i--) reverse += foward[i];
            return reverse;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseString("Hello World!"));
            Console.WriteLine(ReverseString(null));
            Console.WriteLine(ReverseString("TestIng gnItset"));
        }
    }
}
