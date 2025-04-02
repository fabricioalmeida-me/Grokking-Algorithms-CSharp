namespace BinarySearch;

public class Program
{
  public static void Main(string[] args)
  {
    var number = 6;
    var myList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    var index = BinarySearchAlgorithm.Search(myList, number);
    if (index.HasValue)
    {
      Console.WriteLine($"The number {number} was found at index {index}.");
    }
    else
    {
      Console.WriteLine("The number was not found in the list.");
    }
  }
}