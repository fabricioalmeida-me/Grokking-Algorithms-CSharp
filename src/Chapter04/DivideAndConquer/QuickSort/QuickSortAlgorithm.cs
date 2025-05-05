using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickSort
{
    public static class QuickSortAlgorithm
    {
        public static List<int> SortList(List<int> list)
        {
            if (list.Count < 2)
                return list;

            var pivot = list[0];
            var less = list.Skip(1).Where(i => i <= pivot).ToList();
            var greater = list.Skip(1).Where(i => i > pivot).ToList();

            var result = new List<int>();
            result.AddRange(SortList(less));
            result.Add(pivot);
            result.AddRange(SortList(greater));

            return result;
        }
    }
}