using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecursiveSum
{
    public class RecursiveSumAlgorithm
    {
        public static int Sum(List<int> list)
        {
            if (list == null || list.Count == 0)
                return 0;

            return list[0] + Sum(list.Skip(1).ToList());
        }
    }
}