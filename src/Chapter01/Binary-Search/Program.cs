public class Program
{
  public static void Main(string[] args)
  {
    var number = 6;
    var myList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    var index = BinarySearch(myList, number);
    if (index.HasValue)
    {
      Console.WriteLine($"The number {number} was found at index {index}.");
    }
    else
    {
      Console.WriteLine("The number was not found in the list.");
    }
  }

  private static int? BinarySearch(IList<int> list, int item)
  {
    var low = 0;
    var high = list.Count() - 1;

    while (low <= high)
    {
      var mid = (low + high) / 2;
      var guess = list[mid];
      if (guess == item) return mid;
      if (guess > item)
      {
        high = mid - 1;
      }
      else
      {
        low = mid + 1;
      }
    }

    return null;
  }
}