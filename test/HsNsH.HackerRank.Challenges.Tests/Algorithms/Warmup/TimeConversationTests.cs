using FluentAssertions;
using FluentAssertions.Execution;

namespace Algorithms.Warmup;

public class TimeConversationTests
{
    [Theory]
    [InlineData("07:05:45PM", "19:05:45")]
    public void All_Tests(string input, string expected)
    {
        // Arrange

        // Act
        var result = Result.TimeConversation(input);

        // Assert
        result.Should().NotBeNullOrEmpty();

        Execute.Assertion.ForCondition(result.Equals(expected))
            .FailWith($"input: {input}, expected:{expected}, result: {result}");
    }
}