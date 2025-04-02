using System;
using Xunit;
using BinarySearch;

namespace BinarySearchTests;

public class BinarySearchAlgorithmTests
{
    [Fact]
    public void Search_FindsExistingNumber_ReturnsCorrectIndex()
    {
        // Arrange
        var myList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
        var number = 13;

        // Act
        var result = BinarySearchAlgorithm.Search(myList, number);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(12, result);
    }

    [Fact]
    public void Search_NumberNotInList_ReturnsNull()
    {
        //Arrange
        var myList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var number = 13;

        //Act
        var result = BinarySearchAlgorithm.Search(myList, number);

        //Assert
        Assert.Null(result);
    }
}
