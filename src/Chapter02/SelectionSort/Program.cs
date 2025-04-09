namespace SelectionSort;

public class Program
{
  public static void Main(string[] args)
  {
    var myList = new List<int> { 5, 3, 6, 2, 10 };

    var sortedList = SelectionSortAlgorithm.SortList(myList);
    Console.WriteLine(string.Join(", ", sortedList));
  }
}