using FluentAssertions;
using FluentAssertions.Execution;

namespace InterviewKit.Warmup;

public class CountingValleysTests
{
    [Theory]
    [InlineData("UDDDUDUU", 1)]
    public void All_Tests(string input, int expected)
    {
        // Arrange

        // Act
        var result = Result.CountingValleys(input.Length, input);

        // Assert
        result.Should().NotBe(int.MinValue);

        Execute.Assertion.ForCondition(result.Equals(expected))
            .FailWith($"input: {input}, expected:{expected}, result: {result}");
    }
}