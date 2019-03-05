using System;
using System.Linq;
using System.Text;

namespace Katas.Challenges
{
    public class CaesarCipherRotation13
    {
        public static string Rot13(string message)
        {
            var aplhabet = Enumerable.Range('a', 26).Select(n => (char)n).ToArray();
            var sb = new StringBuilder();
            foreach (var current in message)
            {
                if (!char.IsLetter(current))
                {
                    sb.Append(current);
                }
                else
                {
                    var isUpper = char.IsUpper(current);
                    var index = Array.IndexOf(aplhabet, isUpper ? char.ToLower(current) : current);
                    var match = index >= aplhabet.Length / 2 ? index - (aplhabet.Length / 2) : index + 13;
                    Console.WriteLine(match);
                    sb.Append(isUpper ? char.ToUpper(aplhabet[match]) : aplhabet[match]);
                }
            }
            return sb.ToString();
        }
    }
}
