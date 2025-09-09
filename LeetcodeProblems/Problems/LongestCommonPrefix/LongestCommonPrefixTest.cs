namespace LeetCodeTest.Problems;

public class LongestCommonPrefixTest
{
    [Theory]
    [InlineData(new string[] { "flower", "flow", "flight" }, "fl")]
    [InlineData(new string[] { "dog", "cat", "horse" }, "")]
    [InlineData(new string[] { "car", "carrot", "carry" }, "car")]
    public void Solve_ShouldReturnLongestCommonPrefix(string[] strs, string expectedPrefix)
    {
        var result = LongestCommonPrefixProblem.Solve(strs);
        Assert.Equal(expectedPrefix, result);
    }
}