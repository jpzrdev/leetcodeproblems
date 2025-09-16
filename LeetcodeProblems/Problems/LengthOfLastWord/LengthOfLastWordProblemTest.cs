namespace LeetCodeTest.Problems;

public class LengthOfLastWordProblemTests
{
    [Theory]
    [InlineData("Hello World", 5)]
    [InlineData("   fly me   to   the moon  ", 4)]
    [InlineData("luffy is still joyboy", 6)]
    public void Solve_ShouldReturnCorrectLengthOfLastWord(string s, int expectedResult)
    {
        var result = LengthOfLastWordProblem.Solve(s);
        Assert.Equal(expectedResult, result);
    }
}