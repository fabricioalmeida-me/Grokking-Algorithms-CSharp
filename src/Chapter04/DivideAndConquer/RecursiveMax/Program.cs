using RecursiveMax;

var myList = new List<int> { 5, 27, 3, 7, 1, 9 };
var maxNumber = RecursiveMaxAlgorithm.Max(myList);

Console.WriteLine("The maximum number is {0}", maxNumber);
