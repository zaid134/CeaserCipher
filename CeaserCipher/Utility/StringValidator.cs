using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CaesarCipher.Utility
{
    public static class StringValidator
    {
        /// <summary>
        /// checks if input string only contains lower case alphabetical characters
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        public static bool ContainsOnlyLowerCaseAlphabeticalCharacters(this string inputString)
        { 
            var regexItem = new Regex("^[a-z]*$");
            return regexItem.IsMatch(inputString); 
        }
    }
}
