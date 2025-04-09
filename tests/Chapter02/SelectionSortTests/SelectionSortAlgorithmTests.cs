using Xunit;
using SelectionSort;

namespace SelectionSortTests;

public class SelectionSortAlgorithmTests
{
    [Fact]
    public void ShouldReturnSortedArray()
    {
        //Arrange
        var inputArray = new List<int> { 10, 5, 3, 6, 2 };
        var expectedArray = new List<int> { 2, 3, 5, 6, 10 };
        //Act
        var result = SelectionSortAlgorithm.SortList(inputArray);

        //Assert
        Assert.Equal(expectedArray, result);
    }
}
