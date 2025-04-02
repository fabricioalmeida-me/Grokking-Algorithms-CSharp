public class Program
{
  public static void Main(string[] args)
  {
    var myList = new List<int>{1,2,3,4,5,6,7,8,9,10};
    var number = BinarySearch(myList, 7);
    if (number is not null)
    {
      Console.WriteLine(number);  
    } else 
    {
      Console.WriteLine("Esse numero não existe em nossa lista");
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