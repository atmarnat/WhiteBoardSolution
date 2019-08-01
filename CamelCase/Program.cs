using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Globalization;
namespace CamelCase
{
    public static class Program
    {
        static string ToCamelCase(string s)
        {
            int x = 0;
            if (s.Length == 0) return "";
            string ss = "";
                   ss += s[0];
            string result = "";
            while (s[x] == ' '|| Regex.IsMatch(ss, "[0-9]"))
            {
                if (Regex.IsMatch(ss, "[0-9]")) result += s[x];
                ss = "";
                x++;
                ss += s[x];
                if (x == s.Length - 1)
                {
                    return result;
                }
            }
            for (int i = x; i < s.Length; i++)
            {
                string t = "";
                while (s[i] == ' ' && i < s.Length - 1)
                {
                    if (s[i+1] != ' '&& i < s.Length -2)
                    {
                        i++;
                        t += s[i];
                        if (Regex.IsMatch(t, "[a-zA-Z0-9]"))
                        {
                            result += t.ToUpper();
                        }
                        i++;
                    }
                    else i++;
                    t = "";
                }
                if (i == s.Length - 1 && s[i - 1] == ' ')
                {
                    t += s[i];
                    if (Regex.IsMatch(t, "[a-zA-Z0-9]")) result += t.ToUpper();
                    i++;
                }
                else if (i == s.Length - 1 && s[i - 1] != ' ')
                {
                    t += s[i];
                    if (Regex.IsMatch(t, "[a-zA-Z0-9]")) result += t.ToLower();
                    t = "";
                }
                else {
                    t += s[i];
                    if (Regex.IsMatch(t, "[a-zA-Z0-9]")) result += t.ToLower();
                    t = "";
                }
            }
            if (result.Length == 0) return "";
            string tem = "";
            string result2 ="";
            tem += result[0];
            int e = 0;
            while (!Regex.IsMatch(tem, "[a-zA-Z]"))
            {
                result2 += result[e];
                tem = "";
                e++;
                tem += result[e];
            }
            if (Regex.IsMatch(tem, "[a-zA-Z]"))
            {
                result2 += tem.ToLower();
                e++;
            }
            while (e < result.Length)
            {
                result2 += result[e];
                e++;
            }
            return result2;
        }
        public static string toCamelCase(string str) //cleaned up ToCamelCase
        {
            string result = "";
            str = str.ToLower();

            if (str.Length == 0) return "";
            for (int i = 0; i < str.Length; i++)
            {
                string temp = "";
                temp += str[i];
                if (Regex.IsMatch(temp, "[a-zA-Z0-9]"))
                {
                    if (i != 0 && str[i - 1] == ' ')
                    {
                        result += temp.ToUpper();
                    }
                    else result += temp;
                }
                else result += "";
            }
            if (result != string.Empty && char.IsUpper(result[0]))
            {
                result = char.ToLower(result[0]) + result.Substring(1);
            }

            return result;

        }
        static void Main(string[] args)
        {
            /*
            Console.WriteLine(ToCamelCase("  we  Like   To       party  h"));
            Console.WriteLine(ToCamelCase("star wars is great "));
            Console.WriteLine(ToCamelCase("a wonderful life "));
            Console.WriteLine(ToCamelCase(" A PARTY IS WE"));
            Console.WriteLine(ToCamelCase(" -Aer  - aserjf"));
            Console.WriteLine(ToCamelCase("== = =  === ======== = ="));
            Console.WriteLine(ToCamelCase("                           "));
            Console.WriteLine(ToCamelCase("4 a42a rk359;^   )"));
            Console.WriteLine(ToCamelCase("1234567890"));
            Console.WriteLine(ToCamelCase("!!!!!!A!!!!!"));
            Console.WriteLine(ToCamelCase(" \\ o"));
            Console.WriteLine(ToCamelCase(""));
            */

            Console.WriteLine(toCamelCase("  we  Like   To       party  h"));
            Console.WriteLine(toCamelCase("star wars is great "));
            Console.WriteLine(toCamelCase("a wonderful life "));
            Console.WriteLine(toCamelCase(" AEr  - aserjf"));
            Console.WriteLine(toCamelCase("== = =  === ======== = ="));
            Console.WriteLine(toCamelCase("                           "));
            Console.WriteLine(toCamelCase("            ;^   )"));
            Console.WriteLine(toCamelCase("4 a42a rk359;^   )"));
            Console.WriteLine(toCamelCase("1234567890"));
            Console.WriteLine(toCamelCase("!!!!!!A!!!!!"));
            Console.WriteLine(toCamelCase(" \\ o"));
        }
    }
}
