using FluentAssertions;
using FluentAssertions.Execution;
using HsNsH.Custom.Challenges.Geometry;

namespace HsNsH.HackerRank.Challenges.LoadTests.Geometry;

public class PointInsideTriangleTests
{
    [Theory]
    [InlineData(0, 0, 20, 0, 10, 30, 10, 15, true)] //inside
    [InlineData(0, 0, 20, 0, 10, 30, 30, 15, false)] //outside
    [InlineData(0, 0, 20, 20, 40, 0, 10, 10, true)] //on-line side
    private void All_Tests(int x1, int y1, int x2,
        int y2, int x3, int y3,
        int x, int y, bool expected)
    {
        // Arrange

        // Act
        var result = Result.PointInsideTriangle(x1, y1, x2, y2, x3, y3, x, y);
        result.Should().Be(result);

        // Assert
        Execute.Assertion.ForCondition(result.Equals(expected))
            .FailWith($"expected:{expected}, result: {result}");
    }
}