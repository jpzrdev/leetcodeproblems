namespace LeetCodeTest.Problems;

public class ValidParenthesesProblemTests
{
    [Theory]
    [InlineData("()", true)]
    [InlineData("()[]{}", true)]
    [InlineData("()]{[", false)]
    [InlineData("({)}", false)]
    [InlineData("([()])", true)]
    [InlineData("(((", false)]

    public void Solve_ShouldReturnCorrectResult(string s, bool expectedResult)
    {
        var result = ValidParenthesesProblem.Solve(s);
        Assert.Equal(expectedResult, result);
    }
}