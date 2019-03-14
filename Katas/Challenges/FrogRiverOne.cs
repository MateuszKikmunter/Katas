using System.Collections.Generic;
using System.Linq;

namespace Katas.Challenges
{
    public static class FrogRiverOne
    {
        public static int Frog(int X, int[] A)
        {
            var storage = new Dictionary<int, bool>();
            for (var i = 0; i < A.Length; i++)
            {
                if (!storage.ContainsKey(A[i]))
                {
                    storage[i] = true;
                }

                if (storage.Count() == X)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
