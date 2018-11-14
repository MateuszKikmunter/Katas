using System.Linq;

namespace Katas.Challenges
{
    public static class SumOfDigits
    {
        /// <summary>
        /// A digital root is the recursive sum of all the digits in a number. 
        /// Given n, take the sum of the digits of n. If that value has two digits, continue reducing in this way until a single-digit number is produced. 
        /// This is only applicable to the natural numbers.
        /// Here's how it works:
        /// digital_root(16)
        /// => 1 + 6
        /// => 7
        /// 
        /// digital_root(942)
        /// => 9 + 4 + 2
        /// => 15 ...
        /// => 1 + 5
        /// => 6
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int DigitalRoot(long n)
        {
            while (n >= 10)
            {
                n = n.ToString().Select(c => int.Parse(c.ToString())).Sum();
            }
            return (int)n;
        }
    }
}
