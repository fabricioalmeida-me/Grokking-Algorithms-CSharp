using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoopSum
{
    public class LoopSumAlgorithm
    {
        public static int Sum(List<int> list)
        {
            var total = 0;
            foreach (var item in list)
            {
                total += item;
            }
            return total;
        }
    }
}