using System;
using System.Collections.Generic;

namespace VowelCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine($"abracadabra has {GetVowelCount("abracadabra")} vowels");
            Console.WriteLine($"abracadabra has {GetVowelCount("")} vowels");
            Console.WriteLine($"null has {GetVowelCount(null)} vowels");
        }

        /**
         * Problem: 
         *  Return the number (count) of vowels in the given string.
         *  We will consider a, e, i, o, u as vowels for this Kata (but not y).
         *  The input string will only consist of lower case letters and/or spaces.
         */
        public static int GetVowelCount(string str)
        {
            // Logic
            // Step 2: Loop through string
            // Step 3: Check if current characters is a vowel
            // Step 4: If true, increase vowel count. If not continue.

            int vowelCount = 0;

            if (str != null)
            {
                foreach (char character in str)
                {
                    switch (character)
                    {
                        case 'a':
                        case 'e':
                        case 'i':
                        case 'o':
                        case 'u':
                            vowelCount++;
                            break;
                        default:
                            continue;
                    }
                }
            }

            return vowelCount;
        }
    }
}
