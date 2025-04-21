using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecursiveMax
{
    public class RecursiveMaxAlgorithm
    {
        public static int Max(List<int> list, int index = 0)
        {
            if (list == null || list.Count == 0)
                throw new ArgumentException(nameof(list));

            if (index < 0 || index >= list.Count)
                throw new ArgumentOutOfRangeException(nameof(list));

            if (index == list.Count - 1)
                return list[index];

            var subMax = Max(list, index + 1);
            return list[index] > subMax ? list[index] : subMax;
        }
    }
}