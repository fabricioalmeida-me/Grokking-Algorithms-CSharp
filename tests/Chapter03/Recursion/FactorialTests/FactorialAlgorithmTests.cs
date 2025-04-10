using Factorial;

namespace FactorialTests;

public class FactorialAlgorithmTests
{
    [Fact]
    public void ShouldReturnCorrectResult()
    {
        //Arrange
        var inputFact = 5;
        var expectedFact = 120;

        //Act
        var result = FactorialAlgorithm.Fact(inputFact);

        //assert
        Assert.Equal(expectedFact, result);
    }
}
