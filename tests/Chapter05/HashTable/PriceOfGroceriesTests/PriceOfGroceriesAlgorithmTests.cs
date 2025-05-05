namespace PriceOfGroceriesTests;

public class PriceOfGroceriesAlgorithmTests
{
    [Fact]
    public void Should_Contain_Expected_Items()
    {
        //Arrange
        var book = new Dictionary<string, decimal>();
        book.Add("Apple", 0.67m);
        book.Add("Milk", 1.50m);
        book.Add("Abacate", 1.49m);

        //Assert
        Assert.Equal(3, book.Count);
        Assert.Equal(0.67m, book["Apple"]);
        Assert.Equal(1.50m, book["Milk"]);
        Assert.Equal(1.49m, book["Abacate"]);
        Assert.False(book.ContainsKey("Banana"));
    }
}
