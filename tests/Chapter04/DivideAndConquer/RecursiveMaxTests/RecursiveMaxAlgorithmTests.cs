using RecursiveMax;

namespace RecursiveMaxTests;

public class RecursiveMaxAlgorithmTests
{
    [Fact]
    public void MaxShouldReturnCorrectMaximumNumber()
    {
        //Arrange
        var inputNumbers = new List<int> { 3, 1, 10, 7, 4, 9 };
        var expectedMaxNumber = 10;

        //Act
        var result = RecursiveMaxAlgorithm.Max(inputNumbers);

        //Assert
        Assert.Equal(expectedMaxNumber, result);
    }
}
