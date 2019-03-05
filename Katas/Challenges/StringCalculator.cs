using System;
using System.Collections.Generic;
using System.Linq;

namespace Katas.Challenges
{
    public static class StringCalculator
    {
        public static string CalculateString(string calcIt)
        {
            var operators = new Dictionary<string, Func<string, double>>
            {
                ["+"] = str => GetNumbersFromString(str, '+').Sum(),
                ["-"] = str => GetNumbersFromString(str, '-').Aggregate((l, r) => l - r),
                ["*"] = str => GetNumbersFromString(str, '*').Aggregate((l, r) => l * r),
                ["/"] = str => GetNumbersFromString(str, '/').Aggregate((l, r) => l / r)
            };

            return Math.Round(operators.First(o => calcIt.Contains(o.Key)).Value(calcIt)).ToString();
        }

        private static IEnumerable<double> GetNumbersFromString(string input, char symbol)
        {
            return input.Split(symbol)
                .Select(str => str.Where(c => char.IsDigit(c) || c == '.'))
                .Select(str => double.Parse(string.Join("", str)));
        }
    }
}