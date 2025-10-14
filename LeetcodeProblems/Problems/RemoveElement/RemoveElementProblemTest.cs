namespace LeetCodeTest.Problems;

public class RemoveElementProblemTest
{
    [Theory]
    [InlineData(new int[] { 3, 2, 2, 3 }, 3, 2)]
    [InlineData(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, 5)]
    public void Solve_ShouldReturnCorrectLength(int[] nums, int val, int expectedLength)
    {
        var result = RemoveElementProblem.Solve(nums, val);
        Assert.Equal(expectedLength, result);
    }
}