using FluentAssertions;
using FluentAssertions.Execution;
using HsNsH.Custom.Challenges.Strings;

namespace HsNsH.HackerRank.Challenges.LoadTests.Strings;

public class FindAllAnagramsTests
{
    [Fact]
    private void All_Tests()
    {
        // Arrange
        string[] arr = { "geeksquiz", "geeksforgeeks", "abcd", "forgeeksgeeks", "zuiqkeegs" };
        int expected = 2;

        // Act
        var result = Result.FindAllAnagrams(arr, arr.Length);
        result.Should().NotBeNull();

        // Assert
        Execute.Assertion.ForCondition(result.Length.Equals(expected))
            .FailWith($"expected:{expected}, result: {result.Length}");
    }
}