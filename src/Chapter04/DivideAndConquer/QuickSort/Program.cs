using QuickSort;

var myList = new List<int> { 7, 10, 5, 3, 6, 2 };

var sortedList = QuickSortAlgorithm.SortList(myList);
Console.WriteLine(string.Join(", ", sortedList));