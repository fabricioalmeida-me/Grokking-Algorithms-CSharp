var book = new Dictionary<string, decimal>();
book.Add("Apple", 0.67m);
book.Add("Milk", 1.50m);
book.Add("Abacate", 1.49m);

foreach (var item in book)
{
  Console.WriteLine("{0}: {1}", item.Key, item.Value);
}
