using RecursiveSum;

namespace RecursiveSumTests;

public class RecursiveSumAlgorithmTests
{
    [Fact]
    public void Should_ReturnCorrectSum()
    {
        //Arrange
        var inputList = new List<int> { 1, 2, 3, 4, 5 };
        var expectedResult = 15;

        //Act
        var result = RecursiveSumAlgorithm.Sum(inputList);

        //Assert
        Assert.Equal(expectedResult, result);
    }
}
