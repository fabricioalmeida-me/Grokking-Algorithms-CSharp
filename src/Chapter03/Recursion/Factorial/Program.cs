using Factorial;

public class Program
{
  public static void Main(string[] args)
  {
    var number = 5;
    Console.WriteLine("The factorial of {0} is {1}.", number, FactorialAlgorithm.Fact(number));
  }
}

