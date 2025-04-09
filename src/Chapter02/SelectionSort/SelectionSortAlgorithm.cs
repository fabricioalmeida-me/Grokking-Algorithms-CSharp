using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SelectionSort
{
    public class SelectionSortAlgorithm
    {
        public static int[] SortList(List<int> list)
        {
            var workingList = new List<int>(list);
            var sorterArray = new int[workingList.Count];

            for (int i = 0; i < sorterArray.Length; i++)
            {
                int smallestIndex = FindSmallestIndex(workingList);
                sorterArray[i] = workingList[smallestIndex];
                workingList.RemoveAt(smallestIndex);
            }

            return sorterArray;
        }

        private static int FindSmallestIndex(List<int> list)
        {
            int smallest = list[0];
            int smallestIndex = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < smallest)
                {
                    smallest = list[i];
                    smallestIndex = i;
                }
            }

            return smallestIndex;
        }
    }
}