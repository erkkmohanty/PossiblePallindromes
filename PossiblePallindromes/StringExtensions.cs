using System;
using System.Collections.Generic;
using System.Text;

namespace PossiblePallindromes
{
    public static class StringExtensions
    {
        public static string Reverse(this String input)
        {
            string reverseString = String.Empty;
            while (reverseString.Length != input.Length)
            {
                reverseString = input[reverseString.Length] + reverseString;
            }
            return reverseString;
        }
    }
}
