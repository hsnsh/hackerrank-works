using FluentAssertions;
using FluentAssertions.Execution;

namespace Algorithms.ConstructiveAlgorithms;

public class FlippingTheMatrixTests
{
    [Fact]
    private void All_Tests()
    {
        // Arrange
        List<List<int>> input = new List<List<int>> { new List<int>() { 112, 42, 83, 119 }, new List<int>() { 56, 125, 56, 49 }, new List<int>() { 15, 78, 101, 43 }, new List<int>() { 62, 98, 114, 108 } };
        var expected = 414;

        // Act
        var result = Result.FlippingMatrix(input);
        result.Should().NotBe(int.MinValue);

        // Assert
        Execute.Assertion.ForCondition(result.Equals(expected))
            .FailWith($"input: {input}, expected:{expected}, result: {result}");
    }
}