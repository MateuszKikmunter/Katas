using System;

namespace Katas.Challenges
{
    public static class PrintTree
    {
        public static void Print(int level)
        {
            var index = level;
            for (var i = 0; i < level; i++)
            {
                for (var j = index; j > 0; j--)
                {
                    Console.Write(" ");
                }

                for (var k = i; k >= 0; k--)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
                index--;
            }
        }

        public static void PrintReversed(int level)
        {
            var index = level;
            for (var i = 0; i < level; i++)
            {
                for (var k = i; k > 0; k--)
                {
                    Console.Write("|");
                }

                for (var j = index; j > 0; j--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
                index--;
            }
        }
    }
}
