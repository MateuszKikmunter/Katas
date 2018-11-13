using System.Linq;

namespace Katas.Challenges
{
    public static class FirstNonRepeatingCharater
    {
        /// <summary>
        /// Write a function named firstNonRepeatingLetter† that takes a string input, and returns the first character that is not repeated anywhere in the string.
        /// 
        /// For example, if given the input 'stress', the function should return 't', since the letter t only occurs once in the string, and occurs first in the string.
        /// 
        /// As an added challenge, upper- and lowercase letters are considered the same character, but the function should return the correct case for the initial letter. For example, the input 'sTreSS' should return 'T'.
        /// 
        /// If a string contains all repeating characters, it should return the empty string ("").
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string GetFirstNonRepeating(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return string.Empty;
            }

            return input
                       .GroupBy(c => c.ToString().ToLower())
                       .FirstOrDefault(grp => grp.Count() == 1)
                       ?.First().ToString() ?? string.Empty;
        }
    }
}