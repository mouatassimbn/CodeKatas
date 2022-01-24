using System;

namespace ANeedleInTheHaystack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /**
         * Problem:
         *  Can you find the needle in the haystack?
         *  Write a function findNeedle() that takes an array full of junk but containing one "needle"
         *  After your function finds the needle it should return a message (as a string) that says:
         *  "found the needle at position " plus the index it found the needle
         */
        public static string FindNeedle(object[] haystack)
        {
            // Logic:
            // Step 1: Loop through the object list
            // Step 2: Compare object values with needle
            // Step 3: if true break from loop if not continue
            // Step 4: retrun result
            if (haystack != null)
            {
                object comparator = (object)"needle";
                for (int index = 0; index < haystack.Length; index++)
                {
                    if (haystack[index] == comparator)
                    {
                        return $"found the needle at position {index}";
                    }
                }

            }

            return "needle not found";
        }
    }
}
