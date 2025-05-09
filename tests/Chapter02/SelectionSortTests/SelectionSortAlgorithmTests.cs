﻿using Xunit;
using SelectionSort;

namespace SelectionSortTests;

public class SelectionSortAlgorithmTests
{
    [Fact]
    public void ShouldReturnSortedList()
    {
        //Arrange
        var inputList = new List<int> { 10, 5, 3, 6, 2 };
        var expectedList = new List<int> { 2, 3, 5, 6, 10 };
        //Act
        var result = SelectionSortAlgorithm.SortList(inputList);

        //Assert
        Assert.Equal(expectedList, result);
    }
}
