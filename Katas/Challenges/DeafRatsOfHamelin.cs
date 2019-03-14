namespace Katas.Challenges
{
    public static class DeafRatsOfHamelin
    {

        public static int CountDeafRats(string town)
        {
            var rats = town.Replace("0", "O").Replace(" ", "").Trim().Split('P');
            return CountRunningRats(rats[0], "left") + CountRunningRats(rats[1], "right");
        }

        private static int CountRunningRats(string town, string runningRatsDirection)
        {
            var counter = 0;
            if (string.IsNullOrEmpty(town))
            {
                return counter;
            }

            var rat = runningRatsDirection == "left" ? "O~" : "~O";
            for (var i = 0; i < town.Length; i += 2)
            {
                if (town.Substring(i, 2) == rat)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
