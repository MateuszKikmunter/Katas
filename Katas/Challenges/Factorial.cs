namespace Katas.Challenges
{
    public static class Factorial
    {
        public static int FactorialNormal(int num)
        {
            var start = 1;
            for (var i = 1; i <= num; i++)
            {
                start *= i;
            }

            return start;
        }

        public static int FactorialRecursive(int num)
        {
            if (num == 0 || num == 1)
            {
                return 1;
            }

            return num * (FactorialRecursive(num - 1));
        }
    }
}
