using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsDecoder
{
    /**
     * Problem:
     *  Create a function that takes a Roman numeral as its argument and returns its value as a numeric decimal integer. You don't need to validate the form of the Roman numeral.
     *  Modern Roman numerals are written by expressing each decimal digit of the number to be encoded separately, starting with the leftmost digit and skipping any 0s.
     *  So 1990 is rendered "MCMXC" (1000 = M, 900 = CM, 90 = XC) and 2008 is rendered "MMVIII" (2000 = MM, 8 = VIII).
     *  The Roman numeral for 1666, "MDCLXVI", uses each letter in descending order.
     *  ---------
     *  |   Symbol  |   Value   |
     *  |-----------|-----------|
     *  |     I     |     1     |
     *  |     V     |     5     |
     *  |     X     |     10    |
     *  |     L     |     50    |
     *  |     C     |     100   |
     *  |     D     |     500   |
     *  |     M     |     1,000 |
     *  |-----------|-----------|
     *  
     */
    internal class RemanDecoder
    {
        public static int Decode(string roman)
        {
            IEnumerable<char> reverse = roman.Reverse();
            Stack<string> expression = new();
            int result = 0;

            foreach (char character in reverse)
            {
                if(ConvertSymbol(character) < ConvertSymbol(character))
                {

                }
            }

            return 0;
        }

        public enum RomanSymbols
        {
            I = 1,
            V = 5,
            X = 10,
            L = 50,
            C = 100,
            D = 500,
            M = 1000
        }

        private static int ConvertSymbol(char symbol)
        {
            switch (symbol)
            {
                case 'I':
                    return (int)RomanSymbols.I;
                case 'V':
                    return (int)RomanSymbols.V;
                case 'X':
                    return (int)RomanSymbols.X;
                case 'L':
                    return (int)RomanSymbols.L;
                case 'C':
                    return (int)RomanSymbols.C;
                case 'D':
                    return (int)RomanSymbols.D;
                case 'M':
                    return (int)RomanSymbols.M;
                default:
                    return 0;
            }
        }
    }
}
