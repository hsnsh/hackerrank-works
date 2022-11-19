using FluentAssertions;
using FluentAssertions.Execution;

namespace Algorithms.Strings;

public class CamelCaseTests
{
    [Theory]
    [InlineData("saveChangesInTheEditor", 5)]
    private void All_Tests(string input, int expected)
    {
        // Arrange

        // Act
        var result = Result.CamelCase(input);

        // Assert
        Execute.Assertion.ForCondition(result.Equals(expected))
            .FailWith($"input: {input}, expected:{expected}, result: {result}");
    }
}