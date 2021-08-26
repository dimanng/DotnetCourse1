using System;
using System.Collections.Generic;

namespace TestApp
{
    class Program
    {
        public static class RomanNumerals
        {
            private static readonly Dictionary<char, int> romanDigits =
            new Dictionary<char, int> {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
            };

            public static int Decode(string s)
            {
                int total = 0;
                int prev = 0;
                foreach (char c in s)
                {
                    int curr = romanDigits[c];
                    total += curr < prev ? -curr : curr;
                    prev = curr;
                }
                return total;
            }
        }

        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            Console.WriteLine(RomanNumerals.Decode(s));
            
            Console.ReadKey();
        }
    }
}

