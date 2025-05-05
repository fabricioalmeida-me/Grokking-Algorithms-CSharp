using QuickSort;

namespace QuickSortTests;

public class QuickSortAlgorithmTests
{
    [Fact]
    public void ShouldReturnSortedList()
    {
        //Arrange
        var inputList = new List<int> { 10, 5, 3, 6, 2 };
        var expectedList = new List<int> { 2, 3, 5, 6, 10 };
        //Act
        var result = QuickSortAlgorithm.SortList(inputList);

        //Assert
        Assert.Equal(expectedList, result);
    }
}
