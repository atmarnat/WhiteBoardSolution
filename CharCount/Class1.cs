using System;

namespace CharCount
{
    public class CharCounts
    {
        public static int CharacterCount(string str, char c)
        {
            int count = 0;

            foreach (char x in str)
            {
                if (x == c) count++;
            }

            return count;
        }
    }
}
