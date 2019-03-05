using System;
using System.Linq;

namespace Katas.Challenges
{
    public static class LongestNumberRepetition
    {
        public static Tuple<char?, int> LongestRepetition(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return new Tuple<char?, int>(null, 0);
            }

            var result = input.Select((c, index) => input.Substring(index).TakeWhile(e => e == c))
                .OrderByDescending(e => e.Count())
                .First();

            return new Tuple<char?, int>(result.First(), result.Count());
        }
    }
}
