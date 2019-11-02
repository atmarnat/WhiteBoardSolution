//Some of the whiteboarding questions asked at Microsoft

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MicrosoftWhiteboardQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            ClockAngle(7, 00);
            int[] arr = FrontZeros(new int[]{ 1, 0, 4, 3, 0, 2, 7, 0});
            foreach (var v in arr)
            {
                Console.Write(v + ", ");
            }
        }

        //Using a hash table, take a string and count up the number of occurances of each character, casing does not matter. If there are no characters, return a zero. Only a-z
        public static Dictionary<char, int> HashCounter(string str)
        {
            /*
             do validation here
             */
            Dictionary<char, int> AlphabetSet= new Dictionary<char, int>();

            //stuff goes here

            return AlphabetSet;
        }

        //Given a string and a char array, split into a list the string based on the characters in the array.
        public static List<string> Splitter(string str, string[] strArr)
        {
            /*
             do validation here
             */
            List<string> ret = new List<string>();

            //stuff goes here

            return ret;
        }

        //Given the hours and minutes on a clock, get the shortest angle between them (in degrees)
        public static void ClockAngle(int hour, int minute)
        {
            while (hour > 11)
            {
                hour -= 12;
            }

            while (minute > 59)
            {
                minute -= 59;
            }


            int angle = Math.Abs((minute * 6) - (hour * 30));

            if (angle > 180)
            {
                angle = 360 - angle;
            }

            Console.WriteLine(angle + " degrees");
        }

        //Given an array of numbers, move all of the 0s to the front, while maintaining order on the rest
        public static int[] FrontZeros(int[] numList)
        {
            /*
             do validation here
             */
            int[] newList = new int[numList.Length];
            int zeroIndex = 0;
            int otherIndex = numList.Length - 1;

            for (int i = numList.Length - 1; i >= 0; i--)
            {
                if (numList[i] == 0)
                {
                    newList[zeroIndex] = 0;
                    zeroIndex++;
                }
                else
                {
                    newList[otherIndex] = numList[i];
                    otherIndex--;
                }
            }
            return newList;
        }
    }
}
