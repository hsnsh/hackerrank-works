using FluentAssertions;
using FluentAssertions.Execution;

namespace Algorithms.Strings;

public class AnagramTests
{
    [Theory]
    [InlineData("aaabbb", 3)]
    [InlineData("ab", 1)]
    [InlineData("abc", -1)]
    [InlineData("mnop", 2)]
    [InlineData("xyyx", 0)]
    [InlineData("xaxbbbxx", 1)]
    private void All_Tests(string input, int expected)
    {
        // Arrange

        // Act
        var result = Result.Anagram(input);
        result.Should().NotBe(int.MinValue);

        // Assert
        Execute.Assertion.ForCondition(result.Equals(expected))
            .FailWith($"input: {input}, expected:{expected}, result: {result}");
    }
}