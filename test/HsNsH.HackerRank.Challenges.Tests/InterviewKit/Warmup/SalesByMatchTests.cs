using FluentAssertions;
using FluentAssertions.Execution;

namespace InterviewKit.Warmup;

public class SalesByMatchTests
{
    [Theory]
    [InlineData("1 2 1 2 1 3 2", 2)]
    [InlineData("10 20 20 10 10 30 50 10 20", 3)]
    public void All_Tests(string input, int expected)
    {
        // Arrange
        var list = input.TrimEnd().Split(' ').Select(arTemp => Convert.ToInt32(arTemp)).ToList();

        // Act
        var result = Result.SockMerchant(list.Count, list);

        // Assert
        result.Should().NotBe(int.MinValue);

        Execute.Assertion.ForCondition(result.Equals(expected))
            .FailWith($"input: {input}, expected:{expected}, result: {result}");
    }
}