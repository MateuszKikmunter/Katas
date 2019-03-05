using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Katas.Challenges
{
    public static class RainFall
    {
        public static double Variance(string town, string strng)
        {
            if (strng.Split($"{town}:").Length == 1)
            {
                return -1;
            }

            var mean = Mean(town, strng);
            var data = GetTownData(town, strng);

            return data.Select(num => Math.Pow(num - mean, 2)).Sum() / data.Count();
        }

        public static double Mean(string town, string strng)
        {
            if (strng.Split($"{town}:").Length == 1)
            {
                return -1;
            }

            var data = GetTownData(town, strng);
            return data.Sum() / data.Count();
        }

        private static IEnumerable<double> GetTownData(string town, string data)
        {
            var townsWithData = data.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            var reg = new Regex(@"-?\d+(?:\.\d+)?");
            var str = townsWithData.FirstOrDefault(s => s.Contains(town));

            return reg.Matches(str).Select(m => double.Parse(m.Value));
        }
    }
}
