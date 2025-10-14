namespace LeetCodeTest.Problems;


public class FindIndexOfFirstOccurrenceInAStringProblemTest
{
    [Theory]
    [InlineData("sadbutsad", "sad", 0)]
    [InlineData("leetcode", "leeto", -1)]
    [InlineData("thinkingoutloud", "out", 8)]
    public void Solve_ShouldReturnCorrectIndex(string haystack, string needle, int expectedIndex)
    {
        var result = FindIndexOfFirstOccurrenceInAStringProblem.Solve(haystack, needle);
        Assert.Equal(expectedIndex, result);
    }
}

