using FluentAssertions;
using FluentAssertions.Execution;

namespace InterviewKit.GreedyAlgorithms;

public class MaxMinTestsTests
{
    [Theory]
    [InlineData(5, "4504 1520 5857 4094 4157 3902 822 6643 2422 7288 8245 9948 2822 1784 7802 3142 9739 5629 5413 7232", 1335)]
    [InlineData(3, "100 200 300 350 400 401 402", 2)]
    public void All_Tests(int k, string input, int expected)
    {
        // Arrange
        var list = input.TrimEnd().Split(' ').Select(arTemp => Convert.ToInt32(arTemp)).ToList();

        // Act
        var result = Result.MaxMin(k, list);

        // Assert
        result.Should().NotBe(int.MinValue);

        Execute.Assertion.ForCondition(result.Equals(expected))
            .FailWith($"input: {input}, expected:{expected}, result: {result}");
    }
}