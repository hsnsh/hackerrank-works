using FluentAssertions;
using FluentAssertions.Execution;

namespace Algorithms.Strings;

public class CamelCaseTests
{
    [Theory]
    [InlineData("saveChangesInTheEditorName", 6)]
    private void All_Tests(string input, int expected)
    {
        // Arrange

        // Act
        var result = Result.CamelCase(input);
        result.Should().NotBe(int.MinValue);

        // Assert
        Execute.Assertion.ForCondition(result.Equals(expected))
            .FailWith($"input: {input}, expected:{expected}, result: {result}");
    }
}