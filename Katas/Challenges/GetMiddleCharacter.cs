namespace Katas.Challenges
{
    /// <summary>
    /// You are going to be given a word. 
    /// Your job is to return the middle character of the word. If the word's length is odd, return the middle character. If the word's length is even, return the middle 2 characters.
    /// Examples:
    /// Kata.getMiddle("test") should return "es"
    /// 
    /// Kata.getMiddle("testing") should return "t"
    /// 
    /// Kata.getMiddle("middle") should return "dd"
    /// 
    /// Kata.getMiddle("A") should return "A"
    /// </summary>
    public static class GetMiddleCharacter
    {
        public static string GetMiddle(string s)
        {
            var sLength = s.Length;
            var startIndex = sLength / 2;
            return sLength % 2 == 0 ? s.Substring(startIndex - 1, 2) : s.Substring(startIndex, 1);
        }
    }
}
