using System.Collections.Generic;
using System.Linq;

namespace Katas.Challenges
{
    /// <summary>
    /// Delete occurrences of an element if it occurs more than n times.
    /// Given a list lst and a number N, create a new list that contains each number of lst at most N times without reordering.
    /// For example if N = 2, and the input is [1,2,3,1,2,1,2,3], you take [1,2,3,1,2], drop the next [1,2] since this would lead to 1 and 2 being in the result 3 times, and then take 3, which leads to [1,2,3,1,2,3].
    /// Kata.DeleteNth (new int[] {20,37,20,21}, 1) // return [20,37,21]
    /// Kata.DeleteNth (new int[] {1,1,3,3,7,2,2,2,2}, 3) // return [1, 1, 3, 3, 7, 2, 2, 2]
    /// </summary>
    public static class NTimesOccurcence
    {
        public static int[] RemoveDuplicates(int[] array, int count)
        {
            var result = new List<int>();
            foreach (var currentNumber in array)
            {
                var originalCount = array.Count(num => currentNumber == num);
                var currentCount = result.Count(num => currentNumber == num);
                if ((originalCount <= count || originalCount >= count) && currentCount != count)
                {
                    result.Add(currentNumber);
                }
            }

            return result.ToArray();
        }
    }
}
